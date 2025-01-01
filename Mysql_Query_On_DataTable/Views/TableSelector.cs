using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Mysql_Query_On_DataTable.Views
{
	public partial class TableSelector : Form
	{
		DataTable table = new DataTable();
		private short contador = 0;
		public List<string> tabelas = new List<string>();
		public TableSelector()
		{
			InitializeComponent();
		}
		public TableSelector(DataTable dataTable)
		{
			InitializeComponent();
			this.table = dataTable;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (contador > 6 || contador == 0)
			{
				MessageBox.Show("Selecione apenas seis colunas");
				return;
			}
			else
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void TableSelector_Load(object sender, EventArgs e)
		{
			foreach (DataColumn col in table.Columns)
			{
				checkedListBox1.Items.Add(col.ColumnName);
			}
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.CurrentValue == CheckState.Unchecked)
			{
				if (contador == 6)
				{
					MessageBox.Show(this,"Só pode selecionar no máximo 6 colunas","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
					checkedListBox1.SetItemChecked(e.Index, false);
				}
				contador++;
				tabelas.Add(checkedListBox1.Items[e.Index].ToString());
			}
			if (e.CurrentValue == CheckState.Checked)
			{
				contador--;
				tabelas.Remove(checkedListBox1.Items[e.Index].ToString());

			}
		}
	}
}
