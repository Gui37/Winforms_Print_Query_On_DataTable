using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql_Query_On_DataTable.Views
{
	public partial class ReportViewer_PdfiuViewer : Form
	{
		private PdfViewer pdfViewer;
		public ReportViewer_PdfiuViewer(string filepath)
		{
			InitializeComponent();
			InitializePdfViewer();
			LoadPdf(filepath);
		}

		private void InitializePdfViewer()
		{
			// Initialize the PdfViewer control
			pdfViewer = new PdfViewer
			{
				Dock = DockStyle.Fill
			};
			this.Controls.Add(pdfViewer);

			this.Text = "Pré-visualização do Relatório";
			this.WindowState = FormWindowState.Maximized;
		}

		private void LoadPdf(string filePath)
		{
			//if (File.Exists(filePath))
			//{

			//	pdfViewer.Load(filePath);
			//}
			//else
			//{
			//	MessageBox.Show("O arquivo do relatório não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}
	}
}
