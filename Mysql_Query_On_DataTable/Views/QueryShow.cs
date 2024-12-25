using Mysql_Query_On_DataTable.Helper;
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
	public partial class QueryShow : Form
	{
		public QueryShow()
		{
			InitializeComponent();
		}
		DbHelper dbHelper = new DbHelper();

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			try
			{
				dgvDados.AutoGenerateColumns = true;
				string query = txt_query.Text;
				if (!string.IsNullOrEmpty(query.Trim()))
				{
					var dt= dbHelper.ExecuteQuery(query);
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
			if (!dbHelper.TestaConexaoOnBoot())
			{
				this.Hide();
				var db = new DbConnection();
				db.Show();
			}
		}
	}
}
