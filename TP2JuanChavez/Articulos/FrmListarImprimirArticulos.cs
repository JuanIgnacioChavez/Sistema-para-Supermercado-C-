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

namespace TP2JuanChavez.Articulos
{
	public partial class FrmListarImprimirArticulos : Form
	{
		public FrmListarImprimirArticulos()
		{
			InitializeComponent();
		}

		#region ConnectionString y Paths
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string Path_PDFListadoArticulos = @"C:\Users\juani\source\repos\TP2JuanChavez\data\ListadoArticulos.pdf";
		private string Path_Logo = @"C:\Users\juani\source\repos\TP2JuanChavez\data\LOS DOS CHINOS LOGO.png";
		private List<Articulo> ListaDeArticulosSeleccionados = new List<Articulo>();
		#endregion

		private void FrmListarImprimirArticulos_Load(object sender, EventArgs e)
		{
			CargarDataGridView1();
		}

		#region Métodos
		private void CargarDataGridView1()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM articulos";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		}

		private void ConfigurarColumnasDataGridView2()
		{
			// Limpia las columnas existentes, si las hay
			dataGridView2.Columns.Clear();

			// Copia las columnas del primer DataGridView al segundo
			foreach (DataGridViewColumn columna in dataGridView1.Columns)
			{
				// Crea una nueva columna con la misma configuración
				DataGridViewColumn nuevaColumna = new DataGridViewTextBoxColumn
				{
					Name = columna.Name,
					HeaderText = columna.HeaderText,
					DataPropertyName = columna.DataPropertyName,
					ValueType = columna.ValueType,
					SortMode = columna.SortMode,
					// Copia más propiedades si es necesario
				};

				// Agrega la nueva columna al segundo DataGridView
				dataGridView2.Columns.Add(nuevaColumna);
			}
		}
		#endregion

		#region Botones
		private void btnAgregar_Click(object sender, EventArgs e)
		{

			ConfigurarColumnasDataGridView2();

			foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
			{
				string ArticuloID = selectedRow.Cells["ArticuloID"].Value.ToString();
				string Detalle = selectedRow.Cells["Detalle"].Value.ToString();
				string Presentacion = selectedRow.Cells["Presentacion"].Value.ToString();
				int PrecioCompra = Convert.ToInt32(selectedRow.Cells["PrecioCompra"].Value);
				int PrecioVenta = Convert.ToInt32(selectedRow.Cells["PrecioVenta"].Value);
				int Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
				string Proveedor = selectedRow.Cells["Proveedor"].Value.ToString();

				Articulo articuloSeleccionado = new Articulo(ArticuloID, Detalle, Presentacion, PrecioCompra, PrecioVenta, Stock, Proveedor);

				// Agrega la fila clonada al DataGridView de destino
				DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					newRow.Cells[cell.ColumnIndex].Value = cell.Value;
				}
				dataGridView2.Rows.Add(newRow);

				// Agrega el objeto Articulo a la lista si no está presente
				if (!ListaDeArticulosSeleccionados.Contains(articuloSeleccionado))
				{
					ListaDeArticulosSeleccionados.Add(articuloSeleccionado);
				}
			}
		}
		#endregion

		#region ImprimirPDF
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			var fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
			Document document = new Document();
			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path_PDFListadoArticulos, FileMode.Create));
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

			document.Add(infoSupermercadoTabla);

			document.Add(new Paragraph($"Fecha: {fecha}", FontFactory.GetFont(FontFactory.HELVETICA, 9f)));
			document.Add(new Chunk(new LineSeparator(0.8f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -2f)));

			PdfPTable tabla = new PdfPTable(6);
			tabla.AddCell(new PdfPCell(new Phrase("ARTICULO ID", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("DETALLE", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("PRESENTACION", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("PRECIO COMPRA", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("STOCK", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("PROVEEDOR", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));

			foreach (var fila in ListaDeArticulosSeleccionados)
			{
				tabla.AddCell(new PdfPCell(new Phrase(fila.ArticuloID, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Detalle, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Presentacion, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.PrecioCompra.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Stock.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Proveedor, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
			}

			document.Add(tabla);
			document.Close();

			System.Diagnostics.Process.Start(Path_PDFListadoArticulos);

		}
		#endregion

	}
}