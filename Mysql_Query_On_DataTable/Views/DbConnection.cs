using Mysql_Query_On_DataTable.Helper;
using System;
using System.Windows.Forms;

namespace Mysql_Query_On_DataTable.Views
{
	public partial class DbConnection : Form
	{
		public DbConnection()
		{
			InitializeComponent();
		}

		private void btnTestar_Click(object sender, EventArgs e)
		{
			if (verificarCampos())
			{
			var db = new DbHelper(txt_servidor.Text,txt_nome_db.Text,txt_username.Text,txt_password.Text,txt_numero_porta.Text);
				if (db.TestConnection())
				{
					messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
					messageDialog.Show("Conexão efectuada com Sucesso", "Atenção");
				}
				else
				{
					messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
					messageDialog.Show("Não foi possível conectar a Base de Dados, verifique os dados fornecidos.", "Atenção");

				}
			}
			else
			{
				messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
				messageDialog.Show("Um dos campos está vazio, por favor verifique","Atenção");
			}
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (verificarCampos())
			{
				var db = new DbHelper(txt_servidor.Text, txt_nome_db.Text, txt_username.Text, txt_password.Text, txt_numero_porta.Text);
				if (db.TestConnection())
				{
					if (db.SalvarConfEncripada())
					{

						messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
						messageDialog.Show("Conexão Guardada com Sucesso", "Atenção");
					}
					else
					{
						messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
						messageDialog.Show("Não foi possível guardar os Dados, verifique os dados fornecidos.", "Atenção");
					}
				}
				else
				{
					messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
					messageDialog.Show("Não foi possível conectar a Base de Dados, verifique os dados fornecidos.", "Atenção");

				}
			}
			else
			{
				messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
				messageDialog.Show("Um dos campos está vazio, por favor verifique", "Atenção");
			}
		}
	
		private bool verificarCampos()
		{
			if (string.IsNullOrEmpty(txt_nome_db.Text.Trim()) && string.IsNullOrEmpty(txt_numero_porta.Text.Trim()) && string.IsNullOrEmpty(txt_password.Text.Trim()) && string.IsNullOrEmpty(txt_servidor.Text.Trim()) && string.IsNullOrEmpty(txt_username.Text.Trim()))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
