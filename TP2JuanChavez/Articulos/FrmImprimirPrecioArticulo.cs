using iText.IO.Image;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.Drawing;
using System.Windows;

namespace TP2JuanChavez.Articulos
{
	public partial class FrmImprimirPrecioArticulo : Form
	{
		public FrmImprimirPrecioArticulo()
		{
			InitializeComponent();
		}

		#region ConnectionString y Paths
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string Path_Logo = @"C:\Users\juani\source\repos\TP2JuanChavez\data\LOS DOS CHINOS LOGO.png";
		private string Path_PrecioArticulo = @"C:\Users\juani\source\repos\TP2JuanChavez\data\PrecioArticulo.pdf";
		#endregion

		private void FrmImprimirPrecioArticulo_Load(object sender, EventArgs e)
		{
			CargarArticulos();
		}

		#region Métodos
		private void CargarArticulos()
		{
			using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
			{
				sqlConnection.Open();
				string query = "SELECT * FROM articulos";
				using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						dataGridView1.DataSource = dataTable;
					}
				}
			}
		}
		#endregion


		#region ImprimirPDF
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			// Verifica si se ha seleccionado una fila
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Obtiene los datos de la fila seleccionada
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

				// Obtén los valores de las celdas necesarias
				string articuloID = selectedRow.Cells["ArticuloID"].Value.ToString();
				string detalle = selectedRow.Cells["Detalle"].Value.ToString();
				string presentacion = selectedRow.Cells["Presentacion"].Value.ToString();
				string precioVenta = selectedRow.Cells["PrecioVenta"].Value.ToString();

				// Llama a una función para generar el archivo PDF con la información deseada
				GenerarPDF(articuloID, detalle, presentacion, precioVenta);
			}
			else
			{

			}
		}

		private void GenerarPDF(string articuloID, string detalle, string presentacion, string precioVenta)
		{
			string path = Path_PrecioArticulo;
			// Crear un nuevo documento
			using (Document document = new Document(new iTextSharp.text.Rectangle(250, 400)))
			{
				// Crear un escritor PDF
				using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create)))
				{
					// Abrir el documento para escribir
					document.Open();

					// Añadir el logo del negocio en el medio
					byte[] logoData = File.ReadAllBytes(Path_Logo);
					iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoData);
					logo.ScaleToFit(200, 200);
					logo.Alignment = Element.ALIGN_MIDDLE;
					document.Add(logo);


					// Agregar espacio entre el logo y los detalles
					document.Add(Chunk.NEWLINE);

					// Añadir detalles del artículo con formato de fuente, tamaño y bordes
					PdfPTable tablaDetalles = new PdfPTable(1); // Crear una tabla con una columna
					tablaDetalles.WidthPercentage = 100; // Ajustar el ancho de la tabla al 100%

					// Detalle
					Phrase detallePhrase = new Phrase(detalle, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14f, BaseColor.BLACK));
					PdfPCell detalleCell = new PdfPCell(detallePhrase);
					detalleCell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinea al centro
					tablaDetalles.AddCell(detalleCell);

					// Presentación
					Phrase presentacionPhrase = new Phrase(presentacion, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14f, BaseColor.BLACK));
					PdfPCell presentacionCell = new PdfPCell(presentacionPhrase);
					presentacionCell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinea al centro
					tablaDetalles.AddCell(presentacionCell);

					// Precio de Venta
					Phrase precioVentaPhrase = new Phrase("PRECIO:" + " " + "$" + precioVenta, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f, BaseColor.BLACK));
					PdfPCell precioVentaCell = new PdfPCell(precioVentaPhrase);
					precioVentaCell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinea al centro
					tablaDetalles.AddCell(precioVentaCell);

					PdfPCell espacioCell = new PdfPCell(new Phrase("       ")); // Celda con un espacio
					espacioCell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Elimina el borde
					tablaDetalles.AddCell(espacioCell);

					PdfPCell espacioCell2 = new PdfPCell(new Phrase("       ")); // Celda con un espacio
					espacioCell2.Border = iTextSharp.text.Rectangle.NO_BORDER; // Elimina el borde
					tablaDetalles.AddCell(espacioCell2);


					// Añadir un código de barras
					string codigoBarras = articuloID;
					BarcodeWriter barcodeWriter = new BarcodeWriter();
					barcodeWriter.Format = BarcodeFormat.CODE_128;
					barcodeWriter.Options = new ZXing.Common.EncodingOptions
					{
						Width = 200, // Ajusta el ancho del código de barras según tus necesidades
						Height = 50 // Ajusta la altura del código de barras según tus necesidades
					};
					Bitmap barcodeBitmap = barcodeWriter.Write(codigoBarras);

					using (MemoryStream memoryStream = new MemoryStream())
					{
						barcodeBitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
						byte[] barcodeData = memoryStream.ToArray();
						iTextSharp.text.Image barcodeImage = iTextSharp.text.Image.GetInstance(barcodeData);
						barcodeImage.Alignment = Element.ALIGN_CENTER; // Alinea al centro
						tablaDetalles.AddCell(barcodeImage);
					}

					document.Add(tablaDetalles);
					// Cerrar el documento
					document.Close();
					System.Diagnostics.Process.Start(path);
				}
			}
		}
		#endregion
	}
}
