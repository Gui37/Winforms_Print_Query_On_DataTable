using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql_Query_On_DataTable.Views
{
	public partial class ReportViewerCrystal : Form
	{
		ReportDocument report = new ReportDocument();
		public ReportViewerCrystal()
		{
			InitializeComponent();
		}
        public ReportViewerCrystal(ReportDocument report1)
        {
			InitializeComponent();
			report = report1;
			crystalReportViewer1.ReportSource = report1;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
		{
			
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			try
			{
				sfd.FileName = "Impressão";
				sfd.Filter = "PDF Files|*.pdf";
				sfd.FilterIndex = 0;

				if (sfd.ShowDialog() == DialogResult.OK)
				{

					ExportOptions exportOpts = new ExportOptions();
					DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
					PdfFormatOptions pdfFormatOpts = new PdfFormatOptions();

					exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
					exportOpts.ExportFormatOptions = pdfFormatOpts;
					exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;

					diskOpts.DiskFileName = sfd.FileName;
					exportOpts.ExportDestinationOptions = diskOpts;

					report.Export(exportOpts);

					MessageBox.Show("Documento Exportado Com Sucesso", "Works..", MessageBoxButtons.OK, MessageBoxIcon.Information);
					System.Diagnostics.Process.Start(sfd.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
