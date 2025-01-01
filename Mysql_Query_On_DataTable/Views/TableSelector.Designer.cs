namespace Mysql_Query_On_DataTable.Views
{
	partial class TableSelector
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
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2CustomGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(10, 9);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(430, 23);
			this.guna2HtmlLabel1.TabIndex = 0;
			this.guna2HtmlLabel1.Text = "Selecione até 6 tabelas (devido a limitação na impressão).";
			// 
			// guna2CustomGradientPanel1
			// 
			this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
			this.guna2CustomGradientPanel1.Controls.Add(this.checkedListBox1);
			this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
			this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
			this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Aquamarine;
			this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Yellow;
			this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
			this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(490, 301);
			this.guna2CustomGradientPanel1.TabIndex = 1;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.Color.DimGray;
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.HorizontalScrollbar = true;
			this.checkedListBox1.Location = new System.Drawing.Point(9, 40);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(469, 214);
			this.checkedListBox1.TabIndex = 1;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// guna2Button1
			// 
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderRadius = 3;
			this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(298, 260);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedDepth = 60;
			this.guna2Button1.Size = new System.Drawing.Size(180, 38);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.Text = "Avançar";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// TableSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 301);
			this.Controls.Add(this.guna2CustomGradientPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TableSelector";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TableSelector";
			this.Load += new System.EventHandler(this.TableSelector_Load);
			this.guna2CustomGradientPanel1.ResumeLayout(false);
			this.guna2CustomGradientPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}