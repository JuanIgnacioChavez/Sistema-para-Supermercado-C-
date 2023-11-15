using iTextSharp.text.pdf.draw;
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

namespace TP2JuanChavez.Ventas
{
	public partial class FrmListarImprimirVentas : Form
	{
		public FrmListarImprimirVentas()
		{
			InitializeComponent();
		}
		#region ConnectionString y Paths
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string Path_PDFListadoVentas = @"C:\Users\juani\source\repos\TP2JuanChavez\data\ListadoVentas.pdf";
		private string Path_Logo = @"C:\Users\juani\source\repos\TP2JuanChavez\data\LOS DOS CHINOS LOGO.png";
		private List<Venta> ListaDeVentasSeleccionadas = new List<Venta>();
		#endregion

		#region Botones
		private void btnCargar_Click(object sender, EventArgs e)
		{
			try
			{
				string fechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
				string fechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm");
				string query2 = "SELECT VentaID, Monto, Fecha, NumeroSerie, NumeroVenta FROM Ventas WHERE Fecha BETWEEN @FechaInicio AND @FechaFin";
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(query2, connection))
					{
						command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
						command.Parameters.AddWithValue("@FechaFin", fechaFin);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								Venta venta = new Venta
								{
									VentaID = reader.GetInt32(reader.GetOrdinal("VentaID")),
									Monto = reader.GetDecimal(reader.GetOrdinal("Monto")),
									Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
									NumeroSerie = reader.GetInt32(reader.GetOrdinal("NumeroSerie")),
									NumeroVenta = reader.GetInt32(reader.GetOrdinal("NumeroVenta"))

								};
								ListaDeVentasSeleccionadas.Add(venta);
							}
						}
					}
				}

				dataGridView1.DataSource = null;
				dataGridView1.DataSource = ListaDeVentasSeleccionadas;
				btnImprimir.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region ImprimirPDF
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			var fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
			Document document = new Document();
			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path_PDFListadoVentas, FileMode.Create));
			document.Open();

			byte[] imagenData = System.IO.File.ReadAllBytes(Path_Logo);
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

			PdfPCell cuitCelda = new PdfPCell(new Phrase($"CUIT: 30-50673003-8", FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK)));
			cuitCelda.Border = PdfPCell.NO_BORDER;
			infoSupermercadoTabla.AddCell(cuitCelda);

			document.Add(infoSupermercadoTabla);

			document.Add(new Paragraph($"Fecha: {fecha}", FontFactory.GetFont(FontFactory.HELVETICA, 9f)));
			document.Add(new Chunk(new LineSeparator(0.8f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -2f)));

			PdfPTable tabla = new PdfPTable(4);
			tabla.AddCell(new PdfPCell(new Phrase("NÚMERO SERIE TICKET", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("NÚMERO VENTA TICKET", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("MONTO", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("FECHA", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));

			decimal montoTotal = 0;

			foreach (var fila in ListaDeVentasSeleccionadas)
			{
				tabla.AddCell(new PdfPCell(new Phrase(fila.NumeroSerie.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.NumeroVenta.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Monto.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Fecha.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				montoTotal += fila.Monto;
			}

			document.Add(tabla);
			document.Add(new Paragraph($"TOTAL: ${montoTotal}", FontFactory.GetFont(FontFactory.HELVETICA, 11f.ToString(), Font.Bold)));

			document.Close();

			System.Diagnostics.Process.Start(Path_PDFListadoVentas);
		}
		#endregion

	}
}
