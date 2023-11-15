namespace TP2JuanChavez.Usuarios
{
	partial class FrmNuevoUsuario
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cmbAcceso = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(430, 110);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(296, 18);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(416, 162);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(310, 18);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelular.Location = new System.Drawing.Point(443, 188);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(283, 18);
			this.txtCelular.TabIndex = 1;
			this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(443, 213);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(283, 18);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(457, 237);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(269, 18);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// cmbAcceso
			// 
			this.cmbAcceso.FormattingEnabled = true;
			this.cmbAcceso.Location = new System.Drawing.Point(430, 135);
			this.cmbAcceso.Name = "cmbAcceso";
			this.cmbAcceso.Size = new System.Drawing.Size(296, 21);
			this.cmbAcceso.TabIndex = 17;
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
			this.btnCrear.Location = new System.Drawing.Point(385, 300);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(150, 45);
			this.btnCrear.TabIndex = 20;
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
			this.btnCancelar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(559, 300);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(167, 45);
			this.btnCancelar.TabIndex = 21;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmNuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.NUEVO_USUARIO;
			this.ClientSize = new System.Drawing.Size(975, 431);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.cmbAcceso);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmNuevoUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNuevoUsuario";
			this.Load += new System.EventHandler(this.FrmNuevoUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.ComboBox cmbAcceso;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnCrear;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}