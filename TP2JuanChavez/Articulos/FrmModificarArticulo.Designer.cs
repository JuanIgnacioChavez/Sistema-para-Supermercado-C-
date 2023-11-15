namespace TP2JuanChavez.Articulos
{
	partial class FrmModificarArticulo
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
			this.cmbArticulos = new System.Windows.Forms.ComboBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.txtEan13 = new System.Windows.Forms.TextBox();
			this.txtDetalle = new System.Windows.Forms.TextBox();
			this.txtPresentacion = new System.Windows.Forms.TextBox();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtProveedor = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbArticulos
			// 
			this.cmbArticulos.FormattingEnabled = true;
			this.cmbArticulos.Location = new System.Drawing.Point(467, 88);
			this.cmbArticulos.Name = "cmbArticulos";
			this.cmbArticulos.Size = new System.Drawing.Size(309, 21);
			this.cmbArticulos.TabIndex = 0;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(682, 113);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 21);
			this.btnSeleccionar.TabIndex = 1;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// txtEan13
			// 
			this.txtEan13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEan13.Location = new System.Drawing.Point(440, 143);
			this.txtEan13.Name = "txtEan13";
			this.txtEan13.Size = new System.Drawing.Size(336, 18);
			this.txtEan13.TabIndex = 2;
			this.txtEan13.TextChanged += new System.EventHandler(this.txtEan13_TextChanged);
			// 
			// txtDetalle
			// 
			this.txtDetalle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetalle.Location = new System.Drawing.Point(455, 166);
			this.txtDetalle.Name = "txtDetalle";
			this.txtDetalle.Size = new System.Drawing.Size(321, 18);
			this.txtDetalle.TabIndex = 3;
			this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
			// 
			// txtPresentacion
			// 
			this.txtPresentacion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPresentacion.Location = new System.Drawing.Point(518, 194);
			this.txtPresentacion.Name = "txtPresentacion";
			this.txtPresentacion.Size = new System.Drawing.Size(258, 18);
			this.txtPresentacion.TabIndex = 4;
			this.txtPresentacion.TextChanged += new System.EventHandler(this.txtPresentacion_TextChanged);
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioCompra.Location = new System.Drawing.Point(532, 218);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(244, 18);
			this.txtPrecioCompra.TabIndex = 5;
			this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioVenta.Location = new System.Drawing.Point(518, 248);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(258, 18);
			this.txtPrecioVenta.TabIndex = 6;
			this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
			// 
			// txtStock
			// 
			this.txtStock.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStock.Location = new System.Drawing.Point(420, 277);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(356, 18);
			this.txtStock.TabIndex = 7;
			this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
			// 
			// txtProveedor
			// 
			this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProveedor.Location = new System.Drawing.Point(477, 302);
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Size = new System.Drawing.Size(299, 18);
			this.txtProveedor.TabIndex = 8;
			this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnAceptar
			// 
			this.btnAceptar.AutoRoundedCorners = true;
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.BorderRadius = 21;
			this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAceptar.FillColor = System.Drawing.Color.Gray;
			this.btnAceptar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.Black;
			this.btnAceptar.Location = new System.Drawing.Point(374, 343);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(150, 45);
			this.btnAceptar.TabIndex = 11;
			this.btnAceptar.Text = "ACEPTAR";
			this.btnAceptar.UseTransparentBackground = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
			this.btnCancelar.FillColor = System.Drawing.Color.Gray;
			this.btnCancelar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(611, 343);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(165, 45);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmModificarArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.MODIFICAR_ARTICULO;
			this.ClientSize = new System.Drawing.Size(975, 431);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtProveedor);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.txtPrecioVenta);
			this.Controls.Add(this.txtPrecioCompra);
			this.Controls.Add(this.txtPresentacion);
			this.Controls.Add(this.txtDetalle);
			this.Controls.Add(this.txtEan13);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.cmbArticulos);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmModificarArticulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmModificarArticulo";
			this.Load += new System.EventHandler(this.FrmModificarArticulo_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbArticulos;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtEan13;
		private System.Windows.Forms.TextBox txtDetalle;
		private System.Windows.Forms.TextBox txtPresentacion;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtProveedor;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnAceptar;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}