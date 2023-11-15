namespace TP2JuanChavez.Articulos
{
	partial class FrmListarImprimirArticulos
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
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(361, 12);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(491, 40);
			this.guna2HtmlLabel2.TabIndex = 5;
			this.guna2HtmlLabel2.Text = "IMPRIMIR LISTADO ARTICULOS";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(248, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(694, 139);
			this.dataGridView1.TabIndex = 45;
			// 
			// btnAgregar
			// 
			this.btnAgregar.AutoRoundedCorners = true;
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BorderRadius = 20;
			this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAgregar.FillColor = System.Drawing.Color.Gray;
			this.btnAgregar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.Location = new System.Drawing.Point(523, 203);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(160, 43);
			this.btnAgregar.TabIndex = 49;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseTransparentBackground = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(248, 252);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(694, 139);
			this.dataGridView2.TabIndex = 50;
			// 
			// btnImprimir
			// 
			this.btnImprimir.AutoRoundedCorners = true;
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BorderRadius = 21;
			this.btnImprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnImprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnImprimir.FillColor = System.Drawing.Color.Gray;
			this.btnImprimir.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.ForeColor = System.Drawing.Color.Black;
			this.btnImprimir.Location = new System.Drawing.Point(503, 397);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(180, 45);
			this.btnImprimir.TabIndex = 51;
			this.btnImprimir.Text = "IMPRIMIR";
			this.btnImprimir.UseTransparentBackground = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// FrmListarImprimirArticulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.FONDO_IMPRIMIR;
			this.ClientSize = new System.Drawing.Size(991, 470);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.guna2HtmlLabel2);
			this.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmListarImprimirArticulos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmListarImprimirArticulos";
			this.Load += new System.EventHandler(this.FrmListarImprimirArticulos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Guna.UI2.WinForms.Guna2Button btnAgregar;
		private System.Windows.Forms.DataGridView dataGridView2;
		private Guna.UI2.WinForms.Guna2Button btnImprimir;
	}
}