namespace TP2JuanChavez
{
	partial class FrmLogin
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
			this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
			this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::TP2JuanChavez.Properties.Resources.USER_ICON;
			this.pictureBox1.Location = new System.Drawing.Point(270, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 36);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = global::TP2JuanChavez.Properties.Resources.PASS_ICON;
			this.pictureBox2.Location = new System.Drawing.Point(270, 157);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 36);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.AutoRoundedCorners = true;
			this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
			this.btnIniciarSesion.BorderRadius = 21;
			this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnIniciarSesion.FillColor = System.Drawing.Color.Gray;
			this.btnIniciarSesion.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
			this.btnIniciarSesion.Location = new System.Drawing.Point(270, 229);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.Size = new System.Drawing.Size(100, 45);
			this.btnIniciarSesion.TabIndex = 6;
			this.btnIniciarSesion.Text = "Iniciar Sesión";
			this.btnIniciarSesion.UseTransparentBackground = true;
			this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.AutoRoundedCorners = true;
			this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
			this.btnCerrarSesion.BorderRadius = 21;
			this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCerrarSesion.FillColor = System.Drawing.Color.Gray;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
			this.btnCerrarSesion.Location = new System.Drawing.Point(376, 229);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(100, 45);
			this.btnCerrarSesion.TabIndex = 7;
			this.btnCerrarSesion.Text = "Salir";
			this.btnCerrarSesion.UseTransparentBackground = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// txtUser
			// 
			this.txtUser.AutoRoundedCorners = true;
			this.txtUser.BorderRadius = 16;
			this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUser.DefaultText = "";
			this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.FillColor = System.Drawing.Color.Gray;
			this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUser.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtUser.ForeColor = System.Drawing.Color.Black;
			this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUser.Location = new System.Drawing.Point(313, 115);
			this.txtUser.Name = "txtUser";
			this.txtUser.PasswordChar = '\0';
			this.txtUser.PlaceholderForeColor = System.Drawing.Color.White;
			this.txtUser.PlaceholderText = "Usuario";
			this.txtUser.SelectedText = "";
			this.txtUser.Size = new System.Drawing.Size(170, 34);
			this.txtUser.TabIndex = 8;
			// 
			// txtPass
			// 
			this.txtPass.AutoRoundedCorners = true;
			this.txtPass.BorderRadius = 16;
			this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPass.DefaultText = "";
			this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPass.FillColor = System.Drawing.Color.Gray;
			this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPass.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtPass.ForeColor = System.Drawing.Color.Black;
			this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPass.Location = new System.Drawing.Point(313, 159);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.PlaceholderForeColor = System.Drawing.Color.White;
			this.txtPass.PlaceholderText = "Contraseña\r\n\r\n";
			this.txtPass.SelectedText = "";
			this.txtPass.Size = new System.Drawing.Size(170, 34);
			this.txtPass.TabIndex = 9;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.FONDO_LOGIN;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnIniciarSesion);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmLogin";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
		private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
		private Guna.UI2.WinForms.Guna2TextBox txtUser;
		private Guna.UI2.WinForms.Guna2TextBox txtPass;
	}
}