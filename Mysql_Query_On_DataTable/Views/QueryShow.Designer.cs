namespace Mysql_Query_On_DataTable.Views
{
	partial class QueryShow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnProcessar = new Guna.UI2.WinForms.Guna2Button();
			this.dgvDados = new Guna.UI2.WinForms.Guna2DataGridView();
			this.txt_query = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
			this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnProcessar
			// 
			this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProcessar.Animated = true;
			this.btnProcessar.AutoRoundedCorners = true;
			this.btnProcessar.BorderRadius = 21;
			this.btnProcessar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnProcessar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnProcessar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnProcessar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnProcessar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcessar.ForeColor = System.Drawing.Color.White;
			this.btnProcessar.Location = new System.Drawing.Point(638, 121);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(159, 45);
			this.btnProcessar.TabIndex = 2;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
			// 
			// dgvDados
			// 
			this.dgvDados.AllowUserToOrderColumns = true;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
			this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvDados.ColumnHeadersHeight = 30;
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDados.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
			this.dgvDados.Location = new System.Drawing.Point(3, 3);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvDados.Size = new System.Drawing.Size(794, 277);
			this.dgvDados.TabIndex = 3;
			this.dgvDados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
			this.dgvDados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
			this.dgvDados.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDados.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
			this.dgvDados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
			this.dgvDados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvDados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDados.ThemeStyle.HeaderStyle.Height = 30;
			this.dgvDados.ThemeStyle.ReadOnly = false;
			this.dgvDados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
			this.dgvDados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvDados.ThemeStyle.RowsStyle.Height = 22;
			this.dgvDados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
			this.dgvDados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// txt_query
			// 
			this.txt_query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_query.AutoRoundedCorners = true;
			this.txt_query.BorderRadius = 41;
			this.txt_query.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_query.DefaultText = "";
			this.txt_query.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_query.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_query.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_query.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_query.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_query.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_query.ForeColor = System.Drawing.Color.Black;
			this.txt_query.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_query.Location = new System.Drawing.Point(5, 29);
			this.txt_query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_query.Name = "txt_query";
			this.txt_query.PasswordChar = '\0';
			this.txt_query.PlaceholderText = "Escreva a Query neste Campo";
			this.txt_query.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_query.SelectedText = "";
			this.txt_query.Size = new System.Drawing.Size(792, 85);
			this.txt_query.TabIndex = 1;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(7, 6);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(215, 17);
			this.guna2HtmlLabel1.TabIndex = 4;
			this.guna2HtmlLabel1.TabStop = false;
			this.guna2HtmlLabel1.Text = "Insira a Query que Deseja Mostrar Processar";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimir.Animated = true;
			this.btnImprimir.AutoRoundedCorners = true;
			this.btnImprimir.BorderRadius = 21;
			this.btnImprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnImprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.ForeColor = System.Drawing.Color.White;
			this.btnImprimir.Location = new System.Drawing.Point(638, 283);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(159, 45);
			this.btnImprimir.TabIndex = 4;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.guna2Panel1.Controls.Add(this.btnProcessar);
			this.guna2Panel1.Controls.Add(this.txt_query);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(800, 169);
			this.guna2Panel1.TabIndex = 6;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.AutoRoundedCorners = true;
			this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.guna2Panel2.BorderRadius = 164;
			this.guna2Panel2.Controls.Add(this.guna2CircleProgressBar1);
			this.guna2Panel2.Controls.Add(this.btnImprimir);
			this.guna2Panel2.Controls.Add(this.dgvDados);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 169);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(800, 331);
			this.guna2Panel2.TabIndex = 0;
			// 
			// guna2CircleProgressBar1
			// 
			this.guna2CircleProgressBar1.Animated = true;
			this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleProgressBar1.Location = new System.Drawing.Point(335, 6);
			this.guna2CircleProgressBar1.Minimum = 0;
			this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
			this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Teal;
			this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
			this.guna2CircleProgressBar1.ProgressOffset = 1;
			this.guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
			this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleProgressBar1.ShowText = true;
			this.guna2CircleProgressBar1.Size = new System.Drawing.Size(130, 130);
			this.guna2CircleProgressBar1.TabIndex = 5;
			this.guna2CircleProgressBar1.TabStop = false;
			this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
			this.guna2CircleProgressBar1.Value = 1;
			this.guna2CircleProgressBar1.Visible = false;
			// 
			// messageDialog
			// 
			this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.messageDialog.Caption = null;
			this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
			this.messageDialog.Parent = null;
			this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
			this.messageDialog.Text = null;
			// 
			// QueryShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.MinimumSize = new System.Drawing.Size(816, 539);
			this.Name = "QueryShow";
			this.Text = "QueryShow";
			this.Load += new System.EventHandler(this.QueryShow_Load);
			this.Shown += new System.EventHandler(this.QueryShow_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btnProcessar;
		private Guna.UI2.WinForms.Guna2DataGridView dgvDados;
		private Guna.UI2.WinForms.Guna2TextBox txt_query;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2Button btnImprimir;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
		private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
	}
}