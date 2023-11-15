namespace TP2JuanChavez
{
	partial class FrmInicioAdmin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnArticulos = new Guna.UI2.WinForms.Guna2Button();
			this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
			this.btnProveedores = new Guna.UI2.WinForms.Guna2Button();
			this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
			this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
			this.btnVigilancia = new Guna.UI2.WinForms.Guna2Button();
			this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
			this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
			this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
			this.btnVerSesiones = new Guna.UI2.WinForms.Guna2Button();
			this.btnRegistrarVenta = new Guna.UI2.WinForms.Guna2Button();
			this.lblHora = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnListarPDF = new Guna.UI2.WinForms.Guna2Button();
			this.btnListarPDF2 = new Guna.UI2.WinForms.Guna2Button();
			this.pdfGenerarPrecioArticulo = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(332, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(991, 470);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TP2JuanChavez.Properties.Resources.LOS_DOS_CHINOS_LOGO2;
			this.pictureBox1.Location = new System.Drawing.Point(340, 158);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(371, 259);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(18, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(956, 395);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnArticulos
			// 
			this.btnArticulos.AutoRoundedCorners = true;
			this.btnArticulos.BackColor = System.Drawing.Color.Transparent;
			this.btnArticulos.BorderColor = System.Drawing.Color.Transparent;
			this.btnArticulos.BorderRadius = 21;
			this.btnArticulos.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnArticulos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnArticulos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnArticulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnArticulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnArticulos.FillColor = System.Drawing.Color.Gray;
			this.btnArticulos.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnArticulos.ForeColor = System.Drawing.Color.Black;
			this.btnArticulos.IndicateFocus = true;
			this.btnArticulos.Location = new System.Drawing.Point(29, 133);
			this.btnArticulos.Name = "btnArticulos";
			this.btnArticulos.Size = new System.Drawing.Size(295, 45);
			this.btnArticulos.TabIndex = 8;
			this.btnArticulos.Text = "ARTÍCULOS";
			this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click_1);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.AutoRoundedCorners = true;
			this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
			this.btnUsuarios.BorderRadius = 21;
			this.btnUsuarios.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnUsuarios.FillColor = System.Drawing.Color.Gray;
			this.btnUsuarios.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
			this.btnUsuarios.IndicateFocus = true;
			this.btnUsuarios.Location = new System.Drawing.Point(29, 194);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(295, 45);
			this.btnUsuarios.TabIndex = 9;
			this.btnUsuarios.Text = "USUARIOS";
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// btnProveedores
			// 
			this.btnProveedores.AutoRoundedCorners = true;
			this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
			this.btnProveedores.BorderRadius = 21;
			this.btnProveedores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnProveedores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnProveedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnProveedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnProveedores.FillColor = System.Drawing.Color.Gray;
			this.btnProveedores.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnProveedores.ForeColor = System.Drawing.Color.Black;
			this.btnProveedores.IndicateFocus = true;
			this.btnProveedores.Location = new System.Drawing.Point(29, 255);
			this.btnProveedores.Name = "btnProveedores";
			this.btnProveedores.Size = new System.Drawing.Size(295, 45);
			this.btnProveedores.TabIndex = 10;
			this.btnProveedores.Text = "PROVEEDORES";
			this.btnProveedores.UseTransparentBackground = true;
			this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
			// 
			// btnVentas
			// 
			this.btnVentas.AutoRoundedCorners = true;
			this.btnVentas.BackColor = System.Drawing.Color.Transparent;
			this.btnVentas.BorderRadius = 21;
			this.btnVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnVentas.FillColor = System.Drawing.Color.Gray;
			this.btnVentas.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnVentas.ForeColor = System.Drawing.Color.Black;
			this.btnVentas.IndicateFocus = true;
			this.btnVentas.Location = new System.Drawing.Point(29, 315);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(295, 45);
			this.btnVentas.TabIndex = 11;
			this.btnVentas.Text = "VENTAS";
			this.btnVentas.UseTransparentBackground = true;
			this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
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
			this.btnCrear.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnCrear.ForeColor = System.Drawing.Color.Black;
			this.btnCrear.IndicateFocus = true;
			this.btnCrear.Location = new System.Drawing.Point(332, 608);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(295, 45);
			this.btnCrear.TabIndex = 12;
			this.btnCrear.Text = "CREAR";
			this.btnCrear.UseTransparentBackground = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnVigilancia
			// 
			this.btnVigilancia.AutoRoundedCorners = true;
			this.btnVigilancia.BackColor = System.Drawing.Color.Transparent;
			this.btnVigilancia.BorderRadius = 21;
			this.btnVigilancia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnVigilancia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnVigilancia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnVigilancia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnVigilancia.FillColor = System.Drawing.Color.Gray;
			this.btnVigilancia.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnVigilancia.ForeColor = System.Drawing.Color.Black;
			this.btnVigilancia.IndicateFocus = true;
			this.btnVigilancia.Location = new System.Drawing.Point(31, 374);
			this.btnVigilancia.Name = "btnVigilancia";
			this.btnVigilancia.Size = new System.Drawing.Size(295, 45);
			this.btnVigilancia.TabIndex = 14;
			this.btnVigilancia.Text = "VIGILANCIA";
			this.btnVigilancia.UseTransparentBackground = true;
			this.btnVigilancia.Click += new System.EventHandler(this.btnVigilancia_Click);
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
			this.btnCerrarSesion.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
			this.btnCerrarSesion.IndicateFocus = true;
			this.btnCerrarSesion.Location = new System.Drawing.Point(29, 608);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(295, 45);
			this.btnCerrarSesion.TabIndex = 15;
			this.btnCerrarSesion.Text = "CERRAR SESIÓN";
			this.btnCerrarSesion.UseTransparentBackground = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.AutoRoundedCorners = true;
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BorderRadius = 21;
			this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnModificar.FillColor = System.Drawing.Color.Gray;
			this.btnModificar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnModificar.ForeColor = System.Drawing.Color.Black;
			this.btnModificar.Location = new System.Drawing.Point(696, 608);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(295, 45);
			this.btnModificar.TabIndex = 16;
			this.btnModificar.Text = "MODIFICAR";
			this.btnModificar.UseTransparentBackground = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.AutoRoundedCorners = true;
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BorderRadius = 21;
			this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEliminar.FillColor = System.Drawing.Color.Gray;
			this.btnEliminar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.IndicateFocus = true;
			this.btnEliminar.Location = new System.Drawing.Point(1028, 608);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(295, 45);
			this.btnEliminar.TabIndex = 17;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseTransparentBackground = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnVerSesiones
			// 
			this.btnVerSesiones.AutoRoundedCorners = true;
			this.btnVerSesiones.BackColor = System.Drawing.Color.Transparent;
			this.btnVerSesiones.BorderRadius = 21;
			this.btnVerSesiones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnVerSesiones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnVerSesiones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnVerSesiones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnVerSesiones.FillColor = System.Drawing.Color.Gray;
			this.btnVerSesiones.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerSesiones.ForeColor = System.Drawing.Color.Black;
			this.btnVerSesiones.Location = new System.Drawing.Point(696, 668);
			this.btnVerSesiones.Name = "btnVerSesiones";
			this.btnVerSesiones.Size = new System.Drawing.Size(295, 45);
			this.btnVerSesiones.TabIndex = 18;
			this.btnVerSesiones.Text = "VER SESIONES";
			this.btnVerSesiones.UseTransparentBackground = true;
			this.btnVerSesiones.Click += new System.EventHandler(this.btnVerSesiones_Click);
			// 
			// btnRegistrarVenta
			// 
			this.btnRegistrarVenta.AutoRoundedCorners = true;
			this.btnRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
			this.btnRegistrarVenta.BorderRadius = 21;
			this.btnRegistrarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRegistrarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnRegistrarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRegistrarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnRegistrarVenta.FillColor = System.Drawing.Color.Gray;
			this.btnRegistrarVenta.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnRegistrarVenta.ForeColor = System.Drawing.Color.Black;
			this.btnRegistrarVenta.IndicateFocus = true;
			this.btnRegistrarVenta.Location = new System.Drawing.Point(696, 668);
			this.btnRegistrarVenta.Name = "btnRegistrarVenta";
			this.btnRegistrarVenta.Size = new System.Drawing.Size(295, 45);
			this.btnRegistrarVenta.TabIndex = 19;
			this.btnRegistrarVenta.Text = "REGISTRAR VENTA";
			this.btnRegistrarVenta.UseTransparentBackground = true;
			this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
			// 
			// lblHora
			// 
			this.lblHora.BackColor = System.Drawing.Color.Gray;
			this.lblHora.Font = new System.Drawing.Font("Rubik", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
			this.lblHora.Location = new System.Drawing.Point(92, 668);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(3, 2);
			this.lblHora.TabIndex = 20;
			this.lblHora.Text = null;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreUsuario.ForeColor = System.Drawing.Color.Transparent;
			this.lblNombreUsuario.Location = new System.Drawing.Point(88, 78);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(17, 30);
			this.lblNombreUsuario.TabIndex = 21;
			this.lblNombreUsuario.Text = "a";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 38);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(169, 34);
			this.guna2HtmlLabel1.TabIndex = 22;
			this.guna2HtmlLabel1.Text = "Bienvenido :";
			// 
			// btnListarPDF
			// 
			this.btnListarPDF.AutoRoundedCorners = true;
			this.btnListarPDF.BackColor = System.Drawing.Color.Transparent;
			this.btnListarPDF.BorderRadius = 21;
			this.btnListarPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnListarPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnListarPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnListarPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnListarPDF.FillColor = System.Drawing.Color.Gray;
			this.btnListarPDF.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnListarPDF.ForeColor = System.Drawing.Color.Black;
			this.btnListarPDF.IndicateFocus = true;
			this.btnListarPDF.Location = new System.Drawing.Point(696, 668);
			this.btnListarPDF.Name = "btnListarPDF";
			this.btnListarPDF.Size = new System.Drawing.Size(295, 45);
			this.btnListarPDF.TabIndex = 23;
			this.btnListarPDF.Text = "LISTAR PDF";
			this.btnListarPDF.UseTransparentBackground = true;
			this.btnListarPDF.Click += new System.EventHandler(this.btnListarPDF_Click);
			// 
			// btnListarPDF2
			// 
			this.btnListarPDF2.AutoRoundedCorners = true;
			this.btnListarPDF2.BackColor = System.Drawing.Color.Transparent;
			this.btnListarPDF2.BorderRadius = 21;
			this.btnListarPDF2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnListarPDF2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnListarPDF2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnListarPDF2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnListarPDF2.FillColor = System.Drawing.Color.Gray;
			this.btnListarPDF2.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnListarPDF2.ForeColor = System.Drawing.Color.Black;
			this.btnListarPDF2.IndicateFocus = true;
			this.btnListarPDF2.Location = new System.Drawing.Point(696, 608);
			this.btnListarPDF2.Name = "btnListarPDF2";
			this.btnListarPDF2.Size = new System.Drawing.Size(295, 45);
			this.btnListarPDF2.TabIndex = 24;
			this.btnListarPDF2.Text = "LISTAR PDF";
			this.btnListarPDF2.UseTransparentBackground = true;
			this.btnListarPDF2.Click += new System.EventHandler(this.btnListarPDF2_Click);
			// 
			// pdfGenerarPrecioArticulo
			// 
			this.pdfGenerarPrecioArticulo.AutoRoundedCorners = true;
			this.pdfGenerarPrecioArticulo.BackColor = System.Drawing.Color.Transparent;
			this.pdfGenerarPrecioArticulo.BorderRadius = 21;
			this.pdfGenerarPrecioArticulo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.pdfGenerarPrecioArticulo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.pdfGenerarPrecioArticulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.pdfGenerarPrecioArticulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.pdfGenerarPrecioArticulo.FillColor = System.Drawing.Color.Gray;
			this.pdfGenerarPrecioArticulo.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.pdfGenerarPrecioArticulo.ForeColor = System.Drawing.Color.Black;
			this.pdfGenerarPrecioArticulo.IndicateFocus = true;
			this.pdfGenerarPrecioArticulo.Location = new System.Drawing.Point(696, 548);
			this.pdfGenerarPrecioArticulo.Name = "pdfGenerarPrecioArticulo";
			this.pdfGenerarPrecioArticulo.Size = new System.Drawing.Size(295, 45);
			this.pdfGenerarPrecioArticulo.TabIndex = 25;
			this.pdfGenerarPrecioArticulo.Text = "GENERAR PRECIO";
			this.pdfGenerarPrecioArticulo.UseTransparentBackground = true;
			this.pdfGenerarPrecioArticulo.Click += new System.EventHandler(this.pdfGenerarPrecioArticulo_Click);
			// 
			// FrmInicioAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.FONDO_MENU_PRINCIPAL;
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.pdfGenerarPrecioArticulo);
			this.Controls.Add(this.btnListarPDF2);
			this.Controls.Add(this.btnListarPDF);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.lblNombreUsuario);
			this.Controls.Add(this.lblHora);
			this.Controls.Add(this.btnRegistrarVenta);
			this.Controls.Add(this.btnVerSesiones);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnVigilancia);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnVentas);
			this.Controls.Add(this.btnProveedores);
			this.Controls.Add(this.btnUsuarios);
			this.Controls.Add(this.btnArticulos);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInicioAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmInicioAdmin_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Guna.UI2.WinForms.Guna2Button btnArticulos;
		private Guna.UI2.WinForms.Guna2Button btnUsuarios;
		private Guna.UI2.WinForms.Guna2Button btnProveedores;
		private Guna.UI2.WinForms.Guna2Button btnVentas;
		private Guna.UI2.WinForms.Guna2Button btnCrear;
		private Guna.UI2.WinForms.Guna2Button btnVigilancia;
		private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
		private Guna.UI2.WinForms.Guna2Button btnModificar;
		private Guna.UI2.WinForms.Guna2Button btnEliminar;
		private Guna.UI2.WinForms.Guna2Button btnVerSesiones;
		private Guna.UI2.WinForms.Guna2Button btnRegistrarVenta;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblHora;
		private System.Windows.Forms.Timer timer1;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreUsuario;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2Button btnListarPDF;
		private Guna.UI2.WinForms.Guna2Button btnListarPDF2;
		private Guna.UI2.WinForms.Guna2Button pdfGenerarPrecioArticulo;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

