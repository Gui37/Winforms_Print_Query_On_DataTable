using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
using CrystalDecisions.Shared;
using iText.Kernel.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Mysql_Query_On_DataTable.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;

namespace Mysql_Query_On_DataTable.Views
{
	public partial class QueryShow : Form
	{
		public QueryShow()
		{
			InitializeComponent();
			if (!dbHelper.TestaConexaoOnBoot())
			{
				this.Hide();
				var db = new DbConnection();
				db.Show();
			}
		}
		DbHelper dbHelper = new DbHelper();
		DataTable dt = new DataTable();

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			try
			{
	
				string query = txt_query.Text;
				if (!string.IsNullOrEmpty(query.Trim()))
				{
					dt = dbHelper.ExecuteQuery(query);
					if (dt.Rows.Count > 0)
					{
						dgvDados.DataSource = dt;
					}
				}
			}
			catch (Exception)
			{

				messageDialog.Show("Um Erro ocorreu ao processar a query, verifique a mesma.", "Atenção");
			}
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			string tempFilePath = Path.Combine(Path.GetTempPath(), $"Relatorio_{Guid.NewGuid()}.pdf");


			CriarReportCystal(dt);
			
		}

		private void QueryShow_Load(object sender, EventArgs e)
		{
			//if (!dbHelper.TestaConexaoOnBoot())
			//{
			//	this.Hide();
			//	var db = new DbConnection();
			//	db.Show();
			//}
		}

		private void QueryShow_Shown(object sender, EventArgs e)
		{

		}
		public void CriarReport(DataTable dt, string filePath)
		{
			if (dt == null || dt.Columns.Count == 0)
			{
				throw new ArgumentException("A tabela de dados (DataTable) é inválida ou não possui colunas.");
			}

			// Create a new PDF document
			Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);

			try
			{
				// Create a writer to save the PDF
				iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

				// Open the PDF document
				pdfDoc.Open();

				// Add a title to the report
				Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
				Paragraph title = new Paragraph("Relatório Dinâmico", titleFont)
				{
					Alignment = Element.ALIGN_CENTER,
					SpacingAfter = 20f
				};
				pdfDoc.Add(title);

				// Create a table with a column for each DataColumn
				PdfPTable table = new PdfPTable(dt.Columns.Count)
				{
					WidthPercentage = 100,
					SpacingBefore = 10f,
					SpacingAfter = 10f
				};

				// Add table headers
				Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
				foreach (DataColumn column in dt.Columns)
				{
					PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, headerFont))
					{
						HorizontalAlignment = Element.ALIGN_CENTER,
						BackgroundColor = BaseColor.LIGHT_GRAY
					};
					table.AddCell(headerCell);
				}

				// Add table rows
				Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
				foreach (DataRow row in dt.Rows)
				{
					foreach (var cellValue in row.ItemArray)
					{
						PdfPCell cell = new PdfPCell(new Phrase(cellValue?.ToString() ?? string.Empty, cellFont))
						{
							HorizontalAlignment = Element.ALIGN_CENTER
						};
						table.AddCell(cell);
					}
				}

				// Add the table to the document
				pdfDoc.Add(table);

				// Add a footer
				iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);
				iTextSharp.text.Paragraph footer = new Paragraph($"Gerado em: {DateTime.Now}", footerFont)
				{
					Alignment = Element.ALIGN_RIGHT,
					SpacingBefore = 20f
				};
				pdfDoc.Add(footer);
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("Erro ao criar o relatório PDF.", ex);
			}
			finally
			{
				// Close the document
				if (pdfDoc.IsOpen())
				{
					pdfDoc.Close();
				}
			}
		}
		public void CriarReportCystal(DataTable Dados)
		{

			try
			{
				// Create dynamic report
				ReportDocument report = new ReportDocument();
				report.Load(@"Reports\CrystalReport1.rpt");
				short contadorReport = 1;
				foreach (DataColumn item in Dados.Columns)
				{
					if (contadorReport > 6)
					{
					var columnReport = report.ReportDefinition.ReportObjects[$"txtColumn{contadorReport}"] as TextObject;
					columnReport.Text = item.ColumnName + "";
					contadorReport++;
						break;
					}
				}

				short i = 1;
				if (Dados.Columns.Count > 6)
				{
					for (int x = Dados.Columns.Count - 1; x >= 5; x--) // Iterate in reverse to avoid index shifting
					{
						string columnName = Dados.Columns[x].ColumnName;

						Dados.Columns.Remove(columnName); // Remove the column if it's not required

					}
				}
				else if (Dados.Columns.Count < 6)
				{
					for (int x = Dados.Columns.Count - 1; x >= 0; x--) // Iterate in reverse to avoid index shifting
					{
						string columnName = Dados.Columns[x].ColumnName;

						Dados.Columns.Add($"Col{12 * x}", typeof(string)); // Add the missing column as a string type
						foreach (DataRow row in Dados.Rows)
						{
							row[$"Col{12 * x}"] = string.Empty; // Set default value for existing rows
						}
					}
				}
				foreach (DataColumn col in Dados.Columns)
				{
					Dados.Columns[col.ColumnName].ColumnName = $"Column{i}";
					i++;
				}

				report.SetDataSource(Dados);

				// Show report
				ReportViewerCrystal reportForm = new ReportViewerCrystal(report);

				reportForm.ShowDialog();
			}
			catch (Exception ex)
			{

				messageDialog.Show("Erro ao Processar os dados.","Atenção");
			}
		}
	}
}

