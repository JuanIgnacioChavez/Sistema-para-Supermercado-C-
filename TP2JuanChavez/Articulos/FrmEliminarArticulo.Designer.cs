namespace TP2JuanChavez.Articulos
{
	partial class FrmEliminarArticulo
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
			this.cmbArticulos = new System.Windows.Forms.ComboBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.lblEan13 = new System.Windows.Forms.Label();
			this.lblDetalle = new System.Windows.Forms.Label();
			this.lblPresentacion = new System.Windows.Forms.Label();
			this.lblPrecioCompra = new System.Windows.Forms.Label();
			this.lblPrecioVenta = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblProveedor = new System.Windows.Forms.Label();
			this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// cmbArticulos
			// 
			this.cmbArticulos.FormattingEnabled = true;
			this.cmbArticulos.Location = new System.Drawing.Point(461, 89);
			this.cmbArticulos.Name = "cmbArticulos";
			this.cmbArticulos.Size = new System.Drawing.Size(302, 21);
			this.cmbArticulos.TabIndex = 1;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(669, 114);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 21);
			this.btnSeleccionar.TabIndex = 2;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// lblEan13
			// 
			this.lblEan13.AutoSize = true;
			this.lblEan13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEan13.Location = new System.Drawing.Point(433, 141);
			this.lblEan13.Name = "lblEan13";
			this.lblEan13.Size = new System.Drawing.Size(34, 23);
			this.lblEan13.TabIndex = 3;
			this.lblEan13.Text = "lbl";
			// 
			// lblDetalle
			// 
			this.lblDetalle.AutoSize = true;
			this.lblDetalle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetalle.Location = new System.Drawing.Point(448, 164);
			this.lblDetalle.Name = "lblDetalle";
			this.lblDetalle.Size = new System.Drawing.Size(68, 23);
			this.lblDetalle.TabIndex = 3;
			this.lblDetalle.Text = "label1";
			// 
			// lblPresentacion
			// 
			this.lblPresentacion.AutoSize = true;
			this.lblPresentacion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPresentacion.Location = new System.Drawing.Point(520, 190);
			this.lblPresentacion.Name = "lblPresentacion";
			this.lblPresentacion.Size = new System.Drawing.Size(68, 23);
			this.lblPresentacion.TabIndex = 4;
			this.lblPresentacion.Text = "label1";
			// 
			// lblPrecioCompra
			// 
			this.lblPrecioCompra.AutoSize = true;
			this.lblPrecioCompra.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioCompra.Location = new System.Drawing.Point(532, 216);
			this.lblPrecioCompra.Name = "lblPrecioCompra";
			this.lblPrecioCompra.Size = new System.Drawing.Size(68, 23);
			this.lblPrecioCompra.TabIndex = 5;
			this.lblPrecioCompra.Text = "label1";
			// 
			// lblPrecioVenta
			// 
			this.lblPrecioVenta.AutoSize = true;
			this.lblPrecioVenta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioVenta.Location = new System.Drawing.Point(520, 244);
			this.lblPrecioVenta.Name = "lblPrecioVenta";
			this.lblPrecioVenta.Size = new System.Drawing.Size(68, 23);
			this.lblPrecioVenta.TabIndex = 6;
			this.lblPrecioVenta.Text = "label1";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStock.Location = new System.Drawing.Point(418, 273);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(68, 23);
			this.lblStock.TabIndex = 7;
			this.lblStock.Text = "label1";
			// 
			// lblProveedor
			// 
			this.lblProveedor.AutoSize = true;
			this.lblProveedor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProveedor.Location = new System.Drawing.Point(478, 298);
			this.lblProveedor.Name = "lblProveedor";
			this.lblProveedor.Size = new System.Drawing.Size(68, 23);
			this.lblProveedor.TabIndex = 8;
			this.lblProveedor.Text = "label1";
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
			this.btnAceptar.Location = new System.Drawing.Point(376, 335);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(150, 45);
			this.btnAceptar.TabIndex = 12;
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
			this.btnCancelar.Location = new System.Drawing.Point(594, 335);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(169, 45);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmEliminarArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.ELIMINAR_ARTICULO;
			this.ClientSize = new System.Drawing.Size(991, 470);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblProveedor);
			this.Controls.Add(this.lblStock);
			this.Controls.Add(this.lblPrecioVenta);
			this.Controls.Add(this.lblPrecioCompra);
			this.Controls.Add(this.lblPresentacion);
			this.Controls.Add(this.lblDetalle);
			this.Controls.Add(this.lblEan13);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.cmbArticulos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEliminarArticulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEliminarArticulo";
			this.Load += new System.EventHandler(this.FrmEliminarArticulo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbArticulos;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Label lblEan13;
		private System.Windows.Forms.Label lblDetalle;
		private System.Windows.Forms.Label lblPresentacion;
		private System.Windows.Forms.Label lblPrecioCompra;
		private System.Windows.Forms.Label lblPrecioVenta;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.Label lblProveedor;
		private Guna.UI2.WinForms.Guna2Button btnAceptar;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}