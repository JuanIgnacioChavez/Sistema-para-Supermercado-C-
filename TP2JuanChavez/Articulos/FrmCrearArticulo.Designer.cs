namespace TP2JuanChavez.Articulos
{
	partial class FrmCrearArticulo
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
			this.components = new System.ComponentModel.Container();
			this.txtEan13 = new System.Windows.Forms.TextBox();
			this.txtDetalle = new System.Windows.Forms.TextBox();
			this.txtPresentacion = new System.Windows.Forms.TextBox();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtProveedor = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEan13
			// 
			this.txtEan13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEan13.Location = new System.Drawing.Point(436, 114);
			this.txtEan13.Name = "txtEan13";
			this.txtEan13.Size = new System.Drawing.Size(296, 18);
			this.txtEan13.TabIndex = 0;
			this.txtEan13.TextChanged += new System.EventHandler(this.txtEan13_TextChanged);
			// 
			// txtDetalle
			// 
			this.txtDetalle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetalle.Location = new System.Drawing.Point(454, 138);
			this.txtDetalle.Name = "txtDetalle";
			this.txtDetalle.Size = new System.Drawing.Size(278, 18);
			this.txtDetalle.TabIndex = 1;
			this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
			// 
			// txtPresentacion
			// 
			this.txtPresentacion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPresentacion.Location = new System.Drawing.Point(525, 164);
			this.txtPresentacion.Name = "txtPresentacion";
			this.txtPresentacion.Size = new System.Drawing.Size(207, 18);
			this.txtPresentacion.TabIndex = 2;
			this.txtPresentacion.TextChanged += new System.EventHandler(this.txtPresentacion_TextChanged);
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioCompra.Location = new System.Drawing.Point(538, 190);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(194, 18);
			this.txtPrecioCompra.TabIndex = 3;
			this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioVenta.Location = new System.Drawing.Point(525, 218);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(207, 18);
			this.txtPrecioVenta.TabIndex = 4;
			this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
			// 
			// txtStock
			// 
			this.txtStock.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStock.Location = new System.Drawing.Point(427, 247);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(305, 18);
			this.txtStock.TabIndex = 5;
			this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
			// 
			// txtProveedor
			// 
			this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProveedor.Location = new System.Drawing.Point(484, 273);
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Size = new System.Drawing.Size(248, 18);
			this.txtProveedor.TabIndex = 6;
			this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnCrear
			// 
			this.btnCrear.AutoRoundedCorners = true;
			this.btnCrear.BackColor = System.Drawing.Color.Transparent;
			this.btnCrear.BorderRadius = 21;
			this.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCrear.FillColor = System.Drawing.Color.Gray;
			this.btnCrear.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrear.ForeColor = System.Drawing.Color.Black;
			this.btnCrear.Location = new System.Drawing.Point(368, 332);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(150, 45);
			this.btnCrear.TabIndex = 9;
			this.btnCrear.Text = "CREAR";
			this.btnCrear.UseTransparentBackground = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoRoundedCorners = true;
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BorderRadius = 21;
			this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancelar.FillColor = System.Drawing.Color.DimGray;
			this.btnCancelar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(568, 332);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(164, 45);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmCrearArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.NUEVO_ARTICULO;
			this.ClientSize = new System.Drawing.Size(975, 431);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.txtProveedor);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.txtPrecioVenta);
			this.Controls.Add(this.txtPrecioCompra);
			this.Controls.Add(this.txtPresentacion);
			this.Controls.Add(this.txtDetalle);
			this.Controls.Add(this.txtEan13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCrearArticulo";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCrearArticulo";
			this.Load += new System.EventHandler(this.FrmCrearArticulo_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEan13;
		private System.Windows.Forms.TextBox txtDetalle;
		private System.Windows.Forms.TextBox txtPresentacion;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtProveedor;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnCrear;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}