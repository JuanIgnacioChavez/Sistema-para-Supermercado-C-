namespace TP2JuanChavez.Proveedores
{
	partial class FrmNuevoProveedor
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtRubro = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(429, 112);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(318, 18);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtCuit
			// 
			this.txtCuit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuit.Location = new System.Drawing.Point(403, 136);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(344, 18);
			this.txtCuit.TabIndex = 3;
			this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(419, 161);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(328, 18);
			this.txtEmail.TabIndex = 4;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// txtRubro
			// 
			this.txtRubro.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRubro.Location = new System.Drawing.Point(419, 187);
			this.txtRubro.Name = "txtRubro";
			this.txtRubro.Size = new System.Drawing.Size(328, 18);
			this.txtRubro.TabIndex = 5;
			this.txtRubro.TextChanged += new System.EventHandler(this.txtRubro_TextChanged);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(475, 211);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(272, 18);
			this.txtDireccion.TabIndex = 6;
			this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelular.Location = new System.Drawing.Point(444, 236);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(303, 18);
			this.txtCelular.TabIndex = 7;
			this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnCrear
			// 
			this.btnCrear.Animated = true;
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
			this.btnCrear.Location = new System.Drawing.Point(403, 293);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(150, 45);
			this.btnCrear.TabIndex = 21;
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
			this.btnCancelar.FillColor = System.Drawing.Color.Gray;
			this.btnCancelar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(592, 293);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(164, 45);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmNuevoProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.NUEVO_PROVEEDOR;
			this.ClientSize = new System.Drawing.Size(991, 470);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtRubro);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtCuit);
			this.Controls.Add(this.txtNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmNuevoProveedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNuevoProveedor";
			this.Load += new System.EventHandler(this.FrmNuevoProveedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCuit;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtRubro;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnCrear;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}