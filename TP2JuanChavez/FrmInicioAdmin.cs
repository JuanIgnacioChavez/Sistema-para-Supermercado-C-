using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2JuanChavez.Articulos;
using TP2JuanChavez.Proveedores;
using TP2JuanChavez.Usuarios;
using TP2JuanChavez.Camaras;
using TP2JuanChavez.Ventas;

namespace TP2JuanChavez
{
	public partial class FrmInicioAdmin : Form
	{
		public FrmInicioAdmin()
		{
			InitializeComponent();
		}

		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private string opcionSeleccionada;
		private Form formularioActual = null;

		private void FrmInicioAdmin_Load(object sender, EventArgs e)
		{
			CargarInformacionUsuarioEnSesion();
			dataGridView1.Visible = false;
			btnCrear.Visible = false;
			btnModificar.Visible = false;
			btnEliminar.Visible = false;
			panel1.Visible = true;
			btnVerSesiones.Visible= false;
			btnRegistrarVenta.Visible = false;
			btnListarPDF.Visible = false;
			btnListarPDF2.Visible = false;
			pdfGenerarPrecioArticulo.Visible = false;
			timer1.Interval = 1000; // Intervalo en milisegundos (1 segundo)
			timer1.Tick += timer1_Tick;
			timer1.Start();
		}

		#region Métodos

		private void MostrarFormularioEnPanel(Form formulario)
		{
			if (formularioActual != null)
			{
				formularioActual.Close(); // Cierra el formulario actual si existe.
			}

			formularioActual = formulario;
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;
			panel1.Controls.Add(formulario);
			formulario.Show();
		}

		private void CargarInformacionUsuarioEnSesion()
		{
			int usuarioIDEnSesion = DataBaseHelper.ObtenerUsuarioIDEnSesion();
			ActualizarNombreEnLabel(usuarioIDEnSesion);
		}

		private void ActualizarNombreEnLabel(int usuarioID)
		{
			string nombreUsuario = DataBaseHelper.ObtenerNombreUsuario(usuarioID);
			lblNombreUsuario.Text =  nombreUsuario;
		}

		private void CargarCRUDArticulos()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM articulos";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			dataGridView1.Visible = true;
			btnCrear.Visible = true;
			btnModificar.Visible = true;
			btnEliminar.Visible = true;
			btnRegistrarVenta.Visible = false;
			btnVerSesiones.Visible = false;
			btnListarPDF.Visible = true;
			btnListarPDF2.Visible = false;
			pdfGenerarPrecioArticulo.Visible = true;
			panel1.Controls.Clear();
			panel1.Controls.Add(dataGridView1);
		}

		private void CargarCRUDUsuarios()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM usuarios";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			dataGridView1.Visible = true;
			btnCrear.Visible = true;
			btnModificar.Visible = true;
			btnEliminar.Visible = true;
			btnRegistrarVenta.Visible = false;
			btnVerSesiones.Visible = true;
			btnListarPDF.Visible = false;
			btnListarPDF2.Visible = false;
			pdfGenerarPrecioArticulo.Visible = false;
			panel1.Controls.Clear();
			panel1.Controls.Add(dataGridView1);
		}

		private void CargarCRUDProveedores()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM proveedores";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			dataGridView1.Visible = true;
			btnCrear.Visible = true;
			btnModificar.Visible = true;
			btnEliminar.Visible = true;
			btnRegistrarVenta.Visible = false;
			btnVerSesiones.Visible = false;
			btnListarPDF.Visible = true;
			btnListarPDF2.Visible = false;
			pdfGenerarPrecioArticulo.Visible = false;
			panel1.Controls.Clear();
			panel1.Controls.Add(dataGridView1);
		}

		private void CargarTransacciones()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM ventas";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			btnRegistrarVenta.Visible = true;
			dataGridView1.Visible = true;
			btnCrear.Visible = false;
			btnModificar.Visible = false;
			btnEliminar.Visible = false;
			btnVerSesiones.Visible = false;
			btnListarPDF.Visible = false;
			btnListarPDF2.Visible = true;
			pdfGenerarPrecioArticulo.Visible = false;
			btnRegistrarVenta.Visible = true;
			panel1.Controls.Clear();
			panel1.Controls.Add(dataGridView1);
		}

		private void CargarSesiones()
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();
			string query = "SELECT * FROM sesiones";
			SqlCommand cmd = new SqlCommand(query, sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			panel1.Controls.Clear();
			panel1.Controls.Add(dataGridView1);

		}

		public static int ObtenerUsuarioIDEnSesion()
		{
			int usuarioIDEnSesion = -1;

			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();

					string query = "SELECT TOP 1 UsuarioID FROM Sesiones ORDER BY FechaInicio DESC";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						object result = command.ExecuteScalar();

						if (result != null)
						{
							usuarioIDEnSesion = Convert.ToInt32(result);
						}
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return usuarioIDEnSesion;
		}

		#endregion

		#region Botones

		private void btnArticulos_Click_1(object sender, EventArgs e)
		{
			CargarCRUDArticulos();
			opcionSeleccionada = "Articulos";
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			CargarCRUDUsuarios();
			opcionSeleccionada = "Usuarios";
		}

		private void btnProveedores_Click(object sender, EventArgs e)
		{
			CargarCRUDProveedores();
			opcionSeleccionada = "Proveedores";
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			switch (opcionSeleccionada)
			{
				case "Articulos":
					dataGridView1.Visible = false;
					var FormularioArticulos = new FrmCrearArticulo();
					MostrarFormularioEnPanel(FormularioArticulos);
					break;
				case "Proveedores":
					dataGridView1.Visible = false;
					var FormularioProveedores = new FrmNuevoProveedor();
					MostrarFormularioEnPanel(FormularioProveedores);
					break;
				case "Usuarios":
					dataGridView1.Visible = false;
					var FormularioUsuarios = new FrmNuevoUsuario();
					MostrarFormularioEnPanel(FormularioUsuarios);
					break;
				default:
					MessageBox.Show("Selecciona una opción antes de crear.");
					break;
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			switch (opcionSeleccionada)
			{
				case "Articulos":
					dataGridView1.Visible = false;
					var FormularioArticulos = new FrmModificarArticulo();
					MostrarFormularioEnPanel(FormularioArticulos);
					break;
				case "Proveedores":
					dataGridView1.Visible = false;
					var FormularioProveedores = new FrmModificarProveedor();
					MostrarFormularioEnPanel(FormularioProveedores);
					break;
				case "Usuarios":
					dataGridView1.Visible = false;
					var FormularioUsuarios = new FrmModificarUsuario();
					MostrarFormularioEnPanel(FormularioUsuarios);
					break;
				default:
					MessageBox.Show("Selecciona una opción antes de modificar.");
					break;
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			switch (opcionSeleccionada)
			{
				case "Articulos":
					dataGridView1.Visible = false;
					var FormularioArticulos = new FrmEliminarArticulo();
					MostrarFormularioEnPanel(FormularioArticulos);
					break;
				case "Proveedores":
					dataGridView1.Visible = false;
					var FormularioProveedores = new FrmEliminarProveedor();
					MostrarFormularioEnPanel(FormularioProveedores);
					break;
				case "Usuarios":
					dataGridView1.Visible = false;
					var FormularioUsuarios = new FrmEliminarUsuario();
					MostrarFormularioEnPanel(FormularioUsuarios);
					break;
				default:
					MessageBox.Show("Selecciona una opción antes de eliminar.");
					break;
			}
		}


		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Dispose();
			var ventana = new FrmLogin();
			ventana.ShowDialog();
		}

		private void btnVerSesiones_Click(object sender, EventArgs e)
		{
			CargarSesiones();
		}

		private void btnVigilancia_Click(object sender, EventArgs e)
		{
			btnCrear.Visible = false;
			btnModificar.Visible = false;
			btnEliminar.Visible = false;
			btnListarPDF.Visible = false;
			btnListarPDF2.Visible = false;
			btnRegistrarVenta.Visible = false;
			dataGridView1.Visible = false;
			pdfGenerarPrecioArticulo.Visible = false;
			var FormularioVigilancia = new FrmCamarasVigilancia();
			MostrarFormularioEnPanel(FormularioVigilancia);
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			CargarTransacciones();
		}

		private void btnRegistrarVenta_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = false;
			var FormularioVentas = new FrmVentasAdmin();
			MostrarFormularioEnPanel(FormularioVentas);
		}

		private void btnListarPDF_Click(object sender, EventArgs e)
		{
			switch (opcionSeleccionada)
			{
				case "Articulos":
					dataGridView1.Visible = false;
					var FormularioArticulos = new FrmListarImprimirArticulos();
					MostrarFormularioEnPanel(FormularioArticulos);
					break;
				case "Proveedores":
					dataGridView1.Visible = false;
					var FormularioProveedores = new FrmListarImprimirProovedores();
					MostrarFormularioEnPanel(FormularioProveedores);
					break;
				default:
					MessageBox.Show("Selecciona una opción antes de eliminar.");
					break;
			}
		}

		private void btnListarPDF2_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = false;
			var FormularioVentas = new FrmListarImprimirVentas();
			MostrarFormularioEnPanel(FormularioVentas);
		}

		private void pdfGenerarPrecioArticulo_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = false;
			var FormularioArticulos = new FrmImprimirPrecioArticulo();
			MostrarFormularioEnPanel(FormularioArticulos);
		}
		#endregion

		#region Timer
		private void timer1_Tick(object sender, EventArgs e)
		{
			lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
		}
		#endregion
	}
}
