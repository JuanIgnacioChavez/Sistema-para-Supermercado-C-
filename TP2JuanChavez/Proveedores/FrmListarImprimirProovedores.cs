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

namespace TP2JuanChavez.Proveedores
{
	public partial class FrmListarImprimirProovedores : Form
	{
		public FrmListarImprimirProovedores()
		{
			InitializeComponent();
		}

		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string Path_PDFListadoProveedores = @"C:\Users\juani\source\repos\TP2JuanChavez\data\ListadoProveedores.pdf";
		private string Path_Logo = @"C:\Users\juani\source\repos\TP2JuanChavez\data\LOS DOS CHINOS LOGO.png";
		private List<Proveedor> ListaDeProveedoresSeleccionados = new List<Proveedor>();

		private void FrmListarImprimirProovedores_Load(object sender, EventArgs e)
		{
			CargarDataGridView1();
		}

		private void CargarDataGridView1()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM proveedores";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			ConfigurarColumnasDataGridView2();

			foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
			{
				int ProveedorID = Convert.ToInt32(selectedRow.Cells["ProveedorID"].Value);
				string Nombre = selectedRow.Cells["Nombre"].Value.ToString();
				string Rubro = selectedRow.Cells["Rubro"].Value.ToString();
				string Celular = selectedRow.Cells["Celular"].Value.ToString();
				string Email = selectedRow.Cells["Email"].Value.ToString();

				Proveedor proveedorSeleccionado = new Proveedor(ProveedorID, Nombre, Rubro, Celular, Email);

				// Agrega la fila clonada al DataGridView de destino
				DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					newRow.Cells[cell.ColumnIndex].Value = cell.Value;
				}
				dataGridView2.Rows.Add(newRow);

				// Agrega el objeto Articulo a la lista si no está presente
				if (!ListaDeProveedoresSeleccionados.Contains(proveedorSeleccionado))
				{
					ListaDeProveedoresSeleccionados.Add(proveedorSeleccionado);
				}
			}
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

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			var fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
			Document document = new Document();
			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path_PDFListadoProveedores, FileMode.Create));
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

			PdfPTable tabla = new PdfPTable(5);
			tabla.AddCell(new PdfPCell(new Phrase("PROVEEDOR ID", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("NOMBRE", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("RUBRO", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("CELULAR", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));
			tabla.AddCell(new PdfPCell(new Phrase("EMAIL", FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK))));

			foreach (var fila in ListaDeProveedoresSeleccionados)
			{
				tabla.AddCell(new PdfPCell(new Phrase(fila.ProveedorID.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Nombre, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Rubro, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Celular.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
				tabla.AddCell(new PdfPCell(new Phrase(fila.Email, FontFactory.GetFont(FontFactory.HELVETICA, 9f, BaseColor.BLACK))));
			}

			document.Add(tabla);
			document.Close();

			System.Diagnostics.Process.Start(Path_PDFListadoProveedores);

		}
	}
}
