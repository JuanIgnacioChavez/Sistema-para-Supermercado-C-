namespace TP2JuanChavez.Ventas
{
	partial class FrmVentasAdmin
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.rdbApagar = new System.Windows.Forms.RadioButton();
			this.rdbEncender = new System.Windows.Forms.RadioButton();
			this.lblMonto = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
			this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblArticulo = new System.Windows.Forms.Label();
			this.txtArticulo = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnImprimirTicket = new Guna.UI2.WinForms.Guna2Button();
			this.lblPagaCon = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtPagaCon = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblVuelto = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnTerminar = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblVuelto);
			this.panel1.Controls.Add(this.guna2HtmlLabel7);
			this.panel1.Controls.Add(this.txtPagaCon);
			this.panel1.Controls.Add(this.lblPagaCon);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.lblMonto);
			this.panel1.Controls.Add(this.lblTotal);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.txtCantidad);
			this.panel1.Controls.Add(this.txtPrecio);
			this.panel1.Controls.Add(this.guna2HtmlLabel4);
			this.panel1.Controls.Add(this.guna2HtmlLabel3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.guna2HtmlLabel2);
			this.panel1.Controls.Add(this.lblArticulo);
			this.panel1.Controls.Add(this.txtArticulo);
			this.panel1.Controls.Add(this.guna2HtmlLabel1);
			this.panel1.Location = new System.Drawing.Point(237, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(722, 442);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.rdbApagar);
			this.panel3.Controls.Add(this.rdbEncender);
			this.panel3.Location = new System.Drawing.Point(533, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(101, 59);
			this.panel3.TabIndex = 39;
			// 
			// rdbApagar
			// 
			this.rdbApagar.AutoSize = true;
			this.rdbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbApagar.Location = new System.Drawing.Point(7, 30);
			this.rdbApagar.Name = "rdbApagar";
			this.rdbApagar.Size = new System.Drawing.Size(78, 21);
			this.rdbApagar.TabIndex = 1;
			this.rdbApagar.TabStop = true;
			this.rdbApagar.Text = "Apagar";
			this.rdbApagar.UseVisualStyleBackColor = true;
			this.rdbApagar.Click += new System.EventHandler(this.rdbApagar_Click);
			// 
			// rdbEncender
			// 
			this.rdbEncender.AutoSize = true;
			this.rdbEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbEncender.Location = new System.Drawing.Point(7, 3);
			this.rdbEncender.Name = "rdbEncender";
			this.rdbEncender.Size = new System.Drawing.Size(95, 21);
			this.rdbEncender.TabIndex = 0;
			this.rdbEncender.TabStop = true;
			this.rdbEncender.Text = "Encender";
			this.rdbEncender.UseVisualStyleBackColor = true;
			this.rdbEncender.Click += new System.EventHandler(this.rdbEncender_Click);
			// 
			// lblMonto
			// 
			this.lblMonto.BackColor = System.Drawing.Color.Transparent;
			this.lblMonto.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonto.Location = new System.Drawing.Point(137, 353);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(3, 2);
			this.lblMonto.TabIndex = 11;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.Color.Transparent;
			this.lblTotal.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(14, 350);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(117, 40);
			this.lblTotal.TabIndex = 10;
			this.lblTotal.Text = "TOTAL: ";
			// 
			// btnAgregar
			// 
			this.btnAgregar.AutoRoundedCorners = true;
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BorderRadius = 21;
			this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAgregar.FillColor = System.Drawing.Color.Gray;
			this.btnAgregar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.Location = new System.Drawing.Point(264, 263);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(180, 45);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseTransparentBackground = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtCantidad
			// 
			this.txtCantidad.AutoRoundedCorners = true;
			this.txtCantidad.BorderRadius = 16;
			this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCantidad.DefaultText = "";
			this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCantidad.FillColor = System.Drawing.Color.Gray;
			this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCantidad.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtCantidad.ForeColor = System.Drawing.Color.White;
			this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCantidad.Location = new System.Drawing.Point(533, 188);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.PasswordChar = '\0';
			this.txtCantidad.PlaceholderForeColor = System.Drawing.Color.Black;
			this.txtCantidad.PlaceholderText = "";
			this.txtCantidad.SelectedText = "";
			this.txtCantidad.Size = new System.Drawing.Size(167, 34);
			this.txtCantidad.TabIndex = 8;
			this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
			// 
			// txtPrecio
			// 
			this.txtPrecio.AutoRoundedCorners = true;
			this.txtPrecio.BorderRadius = 16;
			this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrecio.DefaultText = "";
			this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrecio.FillColor = System.Drawing.Color.Gray;
			this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrecio.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtPrecio.ForeColor = System.Drawing.Color.White;
			this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrecio.Location = new System.Drawing.Point(152, 186);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.PasswordChar = '\0';
			this.txtPrecio.PlaceholderForeColor = System.Drawing.Color.Black;
			this.txtPrecio.PlaceholderText = "";
			this.txtPrecio.SelectedText = "";
			this.txtPrecio.Size = new System.Drawing.Size(169, 34);
			this.txtPrecio.TabIndex = 7;
			this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
			// 
			// guna2HtmlLabel4
			// 
			this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel4.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel4.Location = new System.Drawing.Point(349, 184);
			this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
			this.guna2HtmlLabel4.Size = new System.Drawing.Size(179, 40);
			this.guna2HtmlLabel4.TabIndex = 6;
			this.guna2HtmlLabel4.Text = "CANTIDAD:";
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 184);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 40);
			this.guna2HtmlLabel3.TabIndex = 5;
			this.guna2HtmlLabel3.Text = "PRECIO: ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(194, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(320, 50);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(194, 3);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(320, 40);
			this.guna2HtmlLabel2.TabIndex = 3;
			this.guna2HtmlLabel2.Text = "CÓDIGO DE BARRAS";
			// 
			// lblArticulo
			// 
			this.lblArticulo.AutoSize = true;
			this.lblArticulo.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArticulo.Location = new System.Drawing.Point(496, 136);
			this.lblArticulo.Name = "lblArticulo";
			this.lblArticulo.Size = new System.Drawing.Size(113, 23);
			this.lblArticulo.TabIndex = 2;
			this.lblArticulo.Text = "lblArticulo";
			// 
			// txtArticulo
			// 
			this.txtArticulo.Animated = true;
			this.txtArticulo.AutoRoundedCorners = true;
			this.txtArticulo.BorderRadius = 16;
			this.txtArticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtArticulo.DefaultText = "";
			this.txtArticulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtArticulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtArticulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtArticulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtArticulo.FillColor = System.Drawing.Color.Gray;
			this.txtArticulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtArticulo.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtArticulo.ForeColor = System.Drawing.Color.White;
			this.txtArticulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtArticulo.Location = new System.Drawing.Point(194, 129);
			this.txtArticulo.Name = "txtArticulo";
			this.txtArticulo.PasswordChar = '\0';
			this.txtArticulo.PlaceholderForeColor = System.Drawing.Color.Black;
			this.txtArticulo.PlaceholderText = "";
			this.txtArticulo.SelectedText = "";
			this.txtArticulo.Size = new System.Drawing.Size(287, 34);
			this.txtArticulo.TabIndex = 1;
			this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 129);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(174, 40);
			this.guna2HtmlLabel1.TabIndex = 0;
			this.guna2HtmlLabel1.Text = "ARTÍCULO: ";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 98);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(206, 269);
			this.dataGridView1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnImprimirTicket
			// 
			this.btnImprimirTicket.AutoRoundedCorners = true;
			this.btnImprimirTicket.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimirTicket.BorderRadius = 21;
			this.btnImprimirTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimirTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnImprimirTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnImprimirTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnImprimirTicket.FillColor = System.Drawing.Color.Gray;
			this.btnImprimirTicket.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnImprimirTicket.ForeColor = System.Drawing.Color.Black;
			this.btnImprimirTicket.Location = new System.Drawing.Point(35, 307);
			this.btnImprimirTicket.Name = "btnImprimirTicket";
			this.btnImprimirTicket.Size = new System.Drawing.Size(180, 45);
			this.btnImprimirTicket.TabIndex = 10;
			this.btnImprimirTicket.Text = "TICKET";
			this.btnImprimirTicket.UseTransparentBackground = true;
			this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
			// 
			// lblPagaCon
			// 
			this.lblPagaCon.BackColor = System.Drawing.Color.Transparent;
			this.lblPagaCon.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPagaCon.Location = new System.Drawing.Point(234, 350);
			this.lblPagaCon.Name = "lblPagaCon";
			this.lblPagaCon.Size = new System.Drawing.Size(103, 40);
			this.lblPagaCon.TabIndex = 46;
			this.lblPagaCon.Text = "PAGA:";
			// 
			// txtPagaCon
			// 
			this.txtPagaCon.AutoRoundedCorners = true;
			this.txtPagaCon.BorderRadius = 16;
			this.txtPagaCon.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPagaCon.DefaultText = "";
			this.txtPagaCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPagaCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPagaCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPagaCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPagaCon.FillColor = System.Drawing.Color.Gray;
			this.txtPagaCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPagaCon.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold);
			this.txtPagaCon.ForeColor = System.Drawing.Color.White;
			this.txtPagaCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPagaCon.Location = new System.Drawing.Point(336, 356);
			this.txtPagaCon.Name = "txtPagaCon";
			this.txtPagaCon.PasswordChar = '\0';
			this.txtPagaCon.PlaceholderForeColor = System.Drawing.Color.Black;
			this.txtPagaCon.PlaceholderText = "";
			this.txtPagaCon.SelectedText = "";
			this.txtPagaCon.Size = new System.Drawing.Size(114, 34);
			this.txtPagaCon.TabIndex = 47;
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(479, 350);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(140, 40);
			this.guna2HtmlLabel7.TabIndex = 48;
			this.guna2HtmlLabel7.Text = "VUELTO:";
			// 
			// lblVuelto
			// 
			this.lblVuelto.BackColor = System.Drawing.Color.Transparent;
			this.lblVuelto.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVuelto.Location = new System.Drawing.Point(625, 350);
			this.lblVuelto.Name = "lblVuelto";
			this.lblVuelto.Size = new System.Drawing.Size(3, 2);
			this.lblVuelto.TabIndex = 49;
			// 
			// btnTerminar
			// 
			this.btnTerminar.AutoRoundedCorners = true;
			this.btnTerminar.BackColor = System.Drawing.Color.Transparent;
			this.btnTerminar.BorderRadius = 21;
			this.btnTerminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTerminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTerminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTerminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTerminar.FillColor = System.Drawing.Color.Gray;
			this.btnTerminar.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold);
			this.btnTerminar.ForeColor = System.Drawing.Color.Black;
			this.btnTerminar.Location = new System.Drawing.Point(35, 383);
			this.btnTerminar.Name = "btnTerminar";
			this.btnTerminar.Size = new System.Drawing.Size(180, 45);
			this.btnTerminar.TabIndex = 11;
			this.btnTerminar.Text = "TERMINAR";
			this.btnTerminar.UseTransparentBackground = true;
			this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
			// 
			// FrmVentasAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP2JuanChavez.Properties.Resources.FONDO_VENTAS_ADMIN;
			this.ClientSize = new System.Drawing.Size(971, 470);
			this.Controls.Add(this.btnTerminar);
			this.Controls.Add(this.btnImprimirTicket);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVentasAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmVentasAdmin";
			this.Load += new System.EventHandler(this.FrmVentasAdmin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Guna.UI2.WinForms.Guna2TextBox txtArticulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private System.Windows.Forms.Label lblArticulo;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
		private Guna.UI2.WinForms.Guna2Button btnAgregar;
		private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
		private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblMonto;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rdbApagar;
		private System.Windows.Forms.RadioButton rdbEncender;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnImprimirTicket;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblPagaCon;
		private Guna.UI2.WinForms.Guna2TextBox txtPagaCon;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblVuelto;
		private Guna.UI2.WinForms.Guna2Button btnTerminar;
	}
}