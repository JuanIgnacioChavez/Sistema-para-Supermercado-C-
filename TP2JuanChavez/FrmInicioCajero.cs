using Emgu.CV;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using iTextSharp.text.pdf.draw;


namespace TP2JuanChavez
{
	public partial class FrmInicioCajero : Form
	{
		public FrmInicioCajero()
		{
			InitializeComponent();
		}

		#region Variables Privadas
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string Path_Logo = @"C:\Users\juani\source\repos\TP2_JuanChavez\data\LOS DOS CHINOS LOGO.png";
		private string Path_Pdf = @"C:\Users\juani\source\repos\TP2_JuanChavez\data\TICKET.pdf";
		private Mat Frame;
		private VideoCapture Camara;
		private BarcodeReader Reader;
		private bool ean13Validado = false;
		private bool precioValidado = false;
		private bool cantidadValidada = false;
		private List<Articulo> ListaArticulos { get; set; }
		private List<Articulo> ListaArticulosVenta = new List<Articulo>();
		private int usuarioID;
		#endregion
		// Listas, Paths, ConnectionString, Camaras, Bools

		private void FrmInicioCajero_Load(object sender, EventArgs e)
		{
			CargarInformacionUsuarioEnSesion();
			Frame = new Mat();
			Camara = new VideoCapture();
			Reader = new BarcodeReader();
			timer1.Interval = 40;
			timer2.Interval = 250;
			timer3.Interval = 1000; // Intervalo en milisegundos (1 segundo)
			timer3.Tick += timer3_Tick;
			timer3.Start();
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			rdbApagar.Checked = true;
			CargarArticulos();
			LimpiarError();
			lblArticulo.Visible = false;
		}

		#region Métodos
		private void CargarInformacionUsuarioEnSesion()
		{
			int usuarioIDEnSesion = DataBaseHelper.ObtenerUsuarioIDEnSesion();
			ActualizarNombreEnLabel(usuarioIDEnSesion);
		}

		private void ActualizarNombreEnLabel(int usuarioID)
		{
			string nombreUsuario = DataBaseHelper.ObtenerNombreUsuario(usuarioID);
			lblNombreUsuario.Text = nombreUsuario;
		}

		private int ObtenerNumeroDeSerieActual()
		{
			int numeroSerieActual = 0;
			string query = "SELECT NumeroSerie FROM Ventas WHERE NumeroSerie = 1";
			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Ejecutar la consulta y obtener el valor del número de serie actual
						object result = command.ExecuteScalar();
						if (result != null && result != DBNull.Value)
						{
							numeroSerieActual = (int)result;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener el número de serie actual: " + ex.Message);
			}

			return numeroSerieActual;
		}


		private int ObtenerNumeroVentaActual()
		{
			int numeroVentaActual = 0;

			string query = "SELECT TOP 1 NumeroVenta FROM Ventas ORDER BY Fecha DESC";

			try
			{

				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								numeroVentaActual = reader.GetInt32(0);
							}
						}
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener el número de venta actual: " + ex.Message);
			}


			return numeroVentaActual;
		}

		private void LimpiarPantalla()
		{
			txtArticulo.Clear();
			lblArticulo.Text = string.Empty;
			txtPrecio.Clear();
			txtCantidad.Clear();
			dataGridView1.DataSource = null;
			lblMonto.Text = string.Empty;
			ListaArticulosVenta.Clear();
			lblVuelto.Text = string.Empty;
			txtPagaCon.Clear();
		}

		private void LimpiarPantalla2()
		{
			txtArticulo.Clear();
			lblArticulo.Text = string.Empty;
			txtPrecio.Clear();
			txtCantidad.Clear();
		}

		private void LimpiarError()
		{
			errorProvider1.SetError(txtArticulo, string.Empty);
			errorProvider1.SetError(txtPrecio, string.Empty);
			errorProvider1.SetError(txtCantidad, string.Empty);
		}

		private void CargarArticulos()
		{
			ListaArticulos = new List<Articulo>();
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader reader;
			try
			{
				sqlConnection.Open();
				string query = "SELECT ArticuloID, Detalle, PrecioVenta, Stock FROM articulos";
				cmd = new SqlCommand(query, sqlConnection);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						var ID = reader["ArticuloID"].ToString();
						var detalle = reader["Detalle"].ToString();
						var precioventa = reader["PrecioVenta"].ToString();
						ListaArticulos.Add(new Articulo(ID, detalle, int.Parse(precioventa)));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}

			sqlConnection.Close();
		}

		private (string ArticuloID, string Detalle, int PrecioVenta) ObtenerArticuloIDDetalleYPrecio(string _codigoBarra)
		{
			string articuloid = string.Empty;
			string detalle = string.Empty;
			int precioventa = 0;

			if (!string.IsNullOrEmpty(_codigoBarra))
			{
				var articulo = ListaArticulos.FirstOrDefault(art => art.ArticuloID == _codigoBarra);

				if (articulo != null)
				{
					articuloid = articulo.ArticuloID;
					detalle = articulo.Detalle;
					precioventa = articulo.PrecioVenta;
				}
			}

			return (articuloid, detalle, precioventa);
		}

		private bool VerificarStockSuficiente(string articuloID, int cantidadVendida)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					sqlConnection.Open();
					string query = "SELECT Stock FROM articulos WHERE ArticuloID = @ArticuloID";
					using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
					{
						cmd.Parameters.AddWithValue("@ArticuloID", articuloID);
						int stockActual = (int)cmd.ExecuteScalar();
						return stockActual >= cantidadVendida;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al verificar el stock: " + ex.Message);
				return false;
			}
		}

		private void ActualizarStock(string articuloID, int stock)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					sqlConnection.Open();
					string query = "UPDATE articulos SET Stock = Stock - @CantidadVendida WHERE ArticuloID = @ArticuloID";
					using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
					{
						cmd.Parameters.AddWithValue("@ArticuloID", articuloID);
						cmd.Parameters.AddWithValue("@CantidadVendida", stock);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar el stock: " + ex.Message);
			}
		}

		private void BotonAgregarActivado()
		{
			btnAgregar.Enabled = ean13Validado && precioValidado && cantidadValidada;
		}

		private void BotonImprimirTicketActivado()
		{
			btnImprimirTicket.Enabled = dataGridView1.DataSource != null;
		}

		private int ObtenerUsuarioActual()
		{
			int usuarioID = -1;

			using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
			{
				sqlConnection.Open();

				string query = "SELECT TOP 1 UsuarioID FROM Sesiones WHERE HoraFinalizacion IS NULL ORDER BY SesionID DESC";

				using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							usuarioID = reader.GetInt32(0);
						}
					}
				}
			}

			return usuarioID;
		}

		#endregion

		#region Validación
		private void txtArticulo_TextChanged(object sender, EventArgs e)
		{
			if (ValidateEAN13(txtArticulo.Text))
			{
				errorProvider1.SetError(txtArticulo, string.Empty);
				ean13Validado = true;
				string articuloSeleccionado = txtArticulo.Text;
				string query = "SELECT Detalle, PrecioVenta FROM articulos WHERE ArticuloID = @ArticuloID";
				lblArticulo.Visible = true;
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
					{
						sqlConnection.Open();
						using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
						{
							cmd.Parameters.AddWithValue("ArticuloID", articuloSeleccionado);
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									lblArticulo.Text = reader["detalle"].ToString();
									txtPrecio.Text = reader["precioventa"].ToString();
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la información del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				errorProvider1.SetError(txtArticulo, "El codigo EAN-13 ingresado no cumple con las condiciones");
				ean13Validado = false;
			}
			BotonAgregarActivado();
		}

		private void txtPrecio_TextChanged(object sender, EventArgs e)
		{
			if (intValidate(txtPrecio.Text))
			{
				errorProvider1.SetError(txtPrecio, string.Empty);
				precioValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPrecio, "El precio ingresado no cumple con las condiociones ($)");
				precioValidado = false;
			}
			BotonAgregarActivado();
		}

		private void txtCantidad_TextChanged(object sender, EventArgs e)
		{
			if (intValidate(txtCantidad.Text))
			{
				errorProvider1.SetError(txtCantidad, string.Empty);
				cantidadValidada = true;
			}
			else
			{
				errorProvider1.SetError(txtCantidad, "La cantidad ingresada no cumple con las condiciones");
				cantidadValidada = false;
			}
			BotonAgregarActivado();
		}

		private void txtPagaCon_TextChanged(object sender, EventArgs e)
		{
			if (intValidate(txtPagaCon.Text))
			{
				errorProvider1.SetError(txtPrecio, string.Empty);
				precioValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPrecio, "El precio ingresado no cumple con las condiociones ($)");
				precioValidado = false;
			}
		}
		#endregion

		#region MétodosValidar
		private bool ValidateEAN13(string ean13)
		{
			if (ean13.Length != 13)
			{
				return false;
			}

			int[] digits = ean13.Select(c => int.Parse(c.ToString())).ToArray();

			int sumEven = 0;
			int sumOdd = 0;

			for (int i = 0; i < 12; i++)
			{
				if (i % 2 == 0)
				{
					sumEven += digits[i];
				}
				else
				{
					sumOdd += digits[i];
				}
			}

			int total = (sumOdd * 3) + sumEven;
			int checksum = (10 - (total % 10)) % 10;

			return checksum == digits[12];
		}


		public bool intValidate(string texto)
		{
			int numero;
			return int.TryParse(texto, out numero);
		}

		#endregion

		#region Botones
		private void rdbEncender_Click(object sender, EventArgs e)
		{
			Camara.Start();
			if (!timer1.Enabled) timer1.Enabled = true;
			if (!timer2.Enabled) timer2.Enabled = true;
			timer1.Start();
			timer2.Start();
		}

		private void rdbApagar_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			timer2.Stop();
			timer1.Enabled = false;
			timer2.Enabled = false;
			Camara.Stop();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtArticulo.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCantidad.Text))
				{
					MessageBox.Show("Por favor, complete todos los campos antes de agregar un artículo a la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string articuloID = txtArticulo.Text;
				string detalle = lblArticulo.Text;
				int precioVenta = int.Parse(txtPrecio.Text);
				int cantidadVendida = int.Parse(txtCantidad.Text);

				if (!VerificarStockSuficiente(articuloID, cantidadVendida))
				{

					MessageBox.Show("No hay suficiente stock disponible para este artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				Articulo articuloVenta = new Articulo(articuloID, detalle, precioVenta, cantidadVendida);
				ListaArticulosVenta.Add(articuloVenta);

				dataGridView1.DataSource = null;
				dataGridView1.DataSource = ListaArticulosVenta;
				int totalVenta = ListaArticulosVenta.Sum(articulo => articulo.PrecioVenta * articulo.Cantidad);
				lblMonto.Text = "$" + totalVenta.ToString();

				BotonImprimirTicketActivado();
				LimpiarPantalla2();
				LimpiarError();
				ActualizarStock(articuloID, cantidadVendida);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Dispose();
			var ventana = new FrmLogin();
			ventana.ShowDialog();
		}


		private void btnTerminar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
		}

		#endregion

		#region Timers

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Camara.IsOpened)
			{
				Camara.Read(Frame);
				pictureBox1.Image = Frame.ToBitmap();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			Result resultado;
			if (pictureBox1.Image != null)
			{
				resultado = Reader.Decode((Bitmap)pictureBox1.Image);
				if (resultado != null)
				{
					(string ArticuloID, string Detalle, int PrecioVenta) infoArticulo = ObtenerArticuloIDDetalleYPrecio(resultado.Text);
					lblArticulo.Text = infoArticulo.Detalle;
					txtArticulo.Text = resultado.Text;
					txtPrecio.Text = infoArticulo.PrecioVenta.ToString();
				}
			}
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		#endregion

		#region ImprimirPDF

		private void btnImprimirTicket_Click(object sender, EventArgs e)
		{
			var fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
			decimal total = 0;
			int numeroSerie = 1;
			int numeroVenta = 1;
			int numeroSerieActual = ObtenerNumeroDeSerieActual();
			int numeroVentaActual = ObtenerNumeroVentaActual();
			usuarioID = ObtenerUsuarioActual();

			if (numeroVentaActual >= 99999)
			{
				numeroVenta = 1;
				numeroSerie++;
			}
			else
			{
				numeroVenta = numeroVentaActual + 1;
			}
			if (numeroSerieActual > 0)
			{
				numeroSerie = numeroSerieActual;
			}

			string numeroTicket = $"{numeroSerie:D4} - {numeroVenta:D5}";


			Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

			try
			{
				PdfWriter.GetInstance(document, new FileStream(Path_Pdf, FileMode.Create));

				document.Open();

				// Agregar el encabezado
				byte[] imagenData = File.ReadAllBytes(Path_Logo);
				iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(imagenData);
				imagen.ScaleToFit(250, 250);
				imagen.Alignment = Element.ALIGN_CENTER;
				document.Add(imagen);

				PdfPTable infoSupermercadoTabla = new PdfPTable(1);
				infoSupermercadoTabla.WidthPercentage = 100;

				PdfPCell direccionCelda = new PdfPCell(new Phrase($"Dirección: Avda. 9 de Julio 394", FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK)));
				direccionCelda.Border = PdfPCell.NO_BORDER;
				infoSupermercadoTabla.AddCell(direccionCelda);

				PdfPCell telefonoCelda = new PdfPCell(new Phrase($"Teléfono: 2954385848", FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK)));
				telefonoCelda.Border = PdfPCell.NO_BORDER;
				infoSupermercadoTabla.AddCell(telefonoCelda);

				document.Add(infoSupermercadoTabla);

				PdfPTable encabezadoTabla = new PdfPTable(1);
				encabezadoTabla.WidthPercentage = 100;

				PdfPCell contenidoCelda = new PdfPCell();
				contenidoCelda.Border = PdfPCell.NO_BORDER;

				encabezadoTabla.AddCell(contenidoCelda);
				document.Add(encabezadoTabla);

				// Agregar el contenido
				document.Add(new Paragraph($"Fecha: {fecha}", FontFactory.GetFont(FontFactory.HELVETICA, 9f)));
				document.Add(new Chunk(new LineSeparator(0.8f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -2f)));
				document.Add(new Paragraph($"Numero Ticket: {numeroTicket}", FontFactory.GetFont(FontFactory.HELVETICA, 9f)));
				document.Add(new Chunk(new LineSeparator(0.8f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -2f)));

				PdfPTable tabla = new PdfPTable(4);
				tabla.WidthPercentage = 100;
				tabla.AddCell(new PdfPCell(new Phrase("CANTIDAD", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase("DESCRIPCION", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase("PRECIO", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase("SUBTOTAL", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));

				decimal subtotal = 0;
				foreach (var articulo in ListaArticulosVenta)
				{
					tabla.AddCell(new PdfPCell(new Phrase(articulo.Cantidad.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK))));
					tabla.AddCell(new PdfPCell(new Phrase(articulo.Detalle, FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK))));
					tabla.AddCell(new PdfPCell(new Phrase(articulo.PrecioVenta.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK))));
					subtotal = articulo.PrecioVenta * articulo.Cantidad;
					total += subtotal;
					tabla.AddCell(new PdfPCell(new Phrase(subtotal.ToString("C"), FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK))));
				}

				document.Add(tabla);

				document.Add(new Paragraph($"TOTAL: ${total}", FontFactory.GetFont(FontFactory.HELVETICA, 11f.ToString(), Font.Bold)));
				document.Add(new Paragraph($"GRACIAS POR SU COMPRA", FontFactory.GetFont(FontFactory.HELVETICA, 13f.ToString(), Font.Bold))
				{
					Alignment = Element.ALIGN_CENTER
				});
				document.Close();

				decimal montoTotal = total;  // Debes obtener el total de la compra de alguna manera
				decimal montoPagado = decimal.Parse(txtPagaCon.Text);  // Asumo que tienes un TextBox para ingresar el monto pagado
				decimal vuelto = montoPagado - montoTotal;

				// Mostrar el vuelto en el Label
				lblVuelto.Text = vuelto.ToString();

				DialogResult resultado = MessageBox.Show("¿Desea imprimir el ticket?", "Confirmar Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (resultado == DialogResult.Yes)
				{
					// Imprimir el PDF
					System.Diagnostics.Process.Start(Path_Pdf);
					// Insertar en la base de datos
					string query = "INSERT INTO Ventas (monto, fecha, UsuarioID, numeroSerie, numeroVenta) VALUES (@Monto, @Fecha, @UsuarioID, @NumeroSerie, @NumeroVenta)";
					using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
					{
						sqlConnection.Open();

						using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
						{
							cmd.Parameters.AddWithValue("@Monto", total);
							cmd.Parameters.AddWithValue("@Fecha", fecha);
							cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
							cmd.Parameters.AddWithValue("@NumeroSerie", numeroSerie);
							cmd.Parameters.AddWithValue("@NumeroVenta", numeroVenta);
							cmd.ExecuteNonQuery();
						}
					}

				}
				else
				{
					MessageBox.Show("No se imprimió el ticket.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		#endregion
	}
}
