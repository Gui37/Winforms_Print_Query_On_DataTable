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
	public partial class ReportViewer_iTextSharp : Form
	{
		public ReportViewer_iTextSharp(string filepath)
		{
			InitializeComponent();
			LoadReport(filepath);
		}

		private void LoadReport(string filePath)
		{
			if (System.IO.File.Exists(filePath))
			{
				webBrowser1.Navigate(filePath);
			}
			else
			{
				MessageBox.Show("O arquivo do relatório não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
