namespace TP2JuanChavez.Proveedores
{
	partial class FrmModificarProveedor
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
			this.cmbProveedores = new System.Windows.Forms.ComboBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtRubro = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbProveedores
			// 
			this.cmbProveedores.FormattingEnabled = true;
			this.cmbProveedores.Location = new System.Drawing.Point(472, 89);
			this.cmbProveedores.Name = "cmbProveedores";
			this.cmbProveedores.Size = new System.Drawing.Size(318, 21);
			this.cmbProveedores.TabIndex = 1;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(696, 116);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 21);
			this.btnSeleccionar.TabIndex = 2;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(434, 142);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(356, 18);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtCuit
			// 
			this.txtCuit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuit.Location = new System.Drawing.Point(409, 166);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(381, 18);
			this.txtCuit.TabIndex = 4;
			this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(421, 194);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(369, 18);
			this.txtEmail.TabIndex = 5;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// txtRubro
			// 
			this.txtRubro.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRubro.Location = new System.Drawing.Point(421, 220);
			this.txtRubro.Name = "txtRubro";
			this.txtRubro.Size = new System.Drawing.Size(369, 18);
			this.txtRubro.TabIndex = 6;
			this.txtRubro.TextChanged += new System.EventHandler(this.txtRubro_TextChanged);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(472, 244);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(318, 18);
			this.txtDireccion.TabIndex = 7;
			this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelular.Location = new System.Drawing.Point(450, 271);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(340, 18);
			this.txtCelular.TabIndex = 12;
			this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
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
			this.btnAceptar.Location = new System.Drawing.Point(409, 305);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(150, 45);
			this.btnAceptar.TabIndex = 13;
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
			this.btnCancelar.Location = new System.Drawing.Point(624, 305);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(166, 45);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmModificarProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.MODIFICAR_PROVEEDOR1;
			this.ClientSize = new System.Drawing.Size(991, 470);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtRubro);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtCuit);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.cmbProveedores);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmModificarProveedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmModificarProveedor";
			this.Load += new System.EventHandler(this.FrmModificarProveedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbProveedores;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCuit;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtRubro;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnAceptar;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}