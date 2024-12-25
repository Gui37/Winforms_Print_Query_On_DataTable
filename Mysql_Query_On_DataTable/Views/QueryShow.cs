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
				dgvDados.AutoGenerateColumns = true;
				string query = txt_query.Text;
				if (!string.IsNullOrEmpty(query.Trim()))
				{
					dt= dbHelper.ExecuteQuery(query);
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

			
			CriarReport(dt, tempFilePath);
			ReportViewer_iTextSharp reportViewer = new ReportViewer_iTextSharp(tempFilePath);
			reportViewer.Show();
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
			//public void CriarReportCystal()
			//{

			//	// Create dynamic report
			//	ReportDocument report = new ReportDocument();

			//	// Create report schema
			//	Section detailSection = report.ReportDefinition.Sections["Detail"];

			//	int xPosition = 0;
			//	int yPosition = 0;
			//	const int FIELD_WIDTH = 2000; // Measured in twips (1 twip = 1/1440 inch)
			//	const int FIELD_HEIGHT = 400;
			//	const int FIELD_SPACING = 200;

			//	foreach (DataColumn col in dt.Columns)
			//	{
			//		// Create a TextObject dynamically
			//		TextObject textObject = new TextObject
			//		{
			//			Name = $"txt{col.ColumnName}",
			//			Text = col.ColumnName,
			//			Top = yPosition,
			//			Left = xPosition,
			//			Width = FIELD_WIDTH,
			//			Height = FIELD_HEIGHT
			//		};

			//		// Add the TextObject to the detail section
			//		detailSection.ReportObjects.Add(textObject);

			//		xPosition += FIELD_WIDTH + FIELD_SPACING;
			//	}

			//	report.SetDataSource(dt);

			//	// Show report
			//	ReportViewerCrystal reportForm = new ReportViewerCrystal(report);

			//	reportForm.ShowDialog();
			//}
		}
}

