namespace TP2JuanChavez.Usuarios
{
	partial class FrmEliminarUsuario
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
			this.cmbUsuarios = new System.Windows.Forms.ComboBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblAcceso = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// cmbUsuarios
			// 
			this.cmbUsuarios.FormattingEnabled = true;
			this.cmbUsuarios.Location = new System.Drawing.Point(450, 89);
			this.cmbUsuarios.Name = "cmbUsuarios";
			this.cmbUsuarios.Size = new System.Drawing.Size(304, 21);
			this.cmbUsuarios.TabIndex = 2;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(660, 115);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 21);
			this.btnSeleccionar.TabIndex = 3;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(433, 140);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(34, 23);
			this.lblNombre.TabIndex = 5;
			this.lblNombre.Text = "lbl";
			// 
			// lblAcceso
			// 
			this.lblAcceso.AutoSize = true;
			this.lblAcceso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcceso.Location = new System.Drawing.Point(433, 163);
			this.lblAcceso.Name = "lblAcceso";
			this.lblAcceso.Size = new System.Drawing.Size(34, 23);
			this.lblAcceso.TabIndex = 6;
			this.lblAcceso.Text = "lbl";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(418, 190);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(34, 23);
			this.lblEmail.TabIndex = 7;
			this.lblEmail.Text = "lbl";
			// 
			// lblCelular
			// 
			this.lblCelular.AutoSize = true;
			this.lblCelular.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelular.Location = new System.Drawing.Point(446, 217);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(34, 23);
			this.lblCelular.TabIndex = 8;
			this.lblCelular.Text = "lbl";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(446, 245);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(34, 23);
			this.lblUsuario.TabIndex = 9;
			this.lblUsuario.Text = "lbl";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(458, 272);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(34, 23);
			this.lblPassword.TabIndex = 10;
			this.lblPassword.Text = "lbl";
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
			this.btnAceptar.Location = new System.Drawing.Point(373, 312);
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
			this.btnCancelar.Location = new System.Drawing.Point(588, 312);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(166, 45);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseTransparentBackground = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmEliminarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.ELIMINAR_USUARIO;
			this.ClientSize = new System.Drawing.Size(971, 470);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblCelular);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblAcceso);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.cmbUsuarios);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEliminarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEliminarUsuario";
			this.Load += new System.EventHandler(this.FrmEliminarUsuario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbUsuarios;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblAcceso;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblPassword;
		private Guna.UI2.WinForms.Guna2Button btnAceptar;
		private Guna.UI2.WinForms.Guna2Button btnCancelar;
	}
}