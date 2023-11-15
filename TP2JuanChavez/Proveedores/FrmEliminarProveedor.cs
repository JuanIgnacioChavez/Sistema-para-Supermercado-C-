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

namespace TP2JuanChavez.Proveedores
{
	public partial class FrmEliminarProveedor : Form
	{
		public FrmEliminarProveedor()
		{
			InitializeComponent();
		}
		#region ConnectionString
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		#endregion
		

		private void FrmEliminarProveedor_Load(object sender, EventArgs e)
		{
			LlenarProveedores();
			LimpiarPantalla();
			btnAceptar.Enabled = false;
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();

			if (cmbProveedores.SelectedItem != null)
			{
				string proveedorSeleccionado = cmbProveedores.SelectedItem.ToString();
				btnAceptar.Enabled = true;

				string query = "SELECT nombre, cuit, email, celular, rubro, direccion FROM Proveedores WHERE nombre = @Nombre";

				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
					{
						sqlConnection.Open();
						using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
						{
							cmd.Parameters.AddWithValue("@Nombre", proveedorSeleccionado);
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									lblNombre.Text = reader["nombre"].ToString();
									lblCuit.Text = reader["cuit"].ToString();
									lblEmail.Text = reader["email"].ToString();
									lblCelular.Text = reader["celular"].ToString();
									lblRubro.Text = reader["rubro"].ToString();
									lblDireccion.Text = reader["direccion"].ToString();
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la información del proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Desea eliminar el proveedor seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(ConnectionString))
					{
						connection.Open();
						string query = "DELETE FROM proveedores WHERE nombre = @Nombre";
						SqlCommand cmd = new SqlCommand(query, connection);
						cmd.Parameters.AddWithValue("@Nombre", lblNombre.Text);
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("No se eliminó el proveedor.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			LimpiarPantalla();
			LlenarProveedores();
			cmbProveedores.SelectedIndex = -1;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LlenarProveedores();
			cmbProveedores.SelectedIndex = -1;
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Métodos
		private void LlenarProveedores()
		{
			var ListaProveedores = new List<string>();
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader reader;
			try
			{
				sqlConnection.Open();
				string query = "SELECT nombre FROM proveedores";
				cmd = new SqlCommand(query, sqlConnection);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						string nombre = reader["nombre"].ToString();
						ListaProveedores.Add(nombre);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}

			sqlConnection.Close();

			cmbProveedores.DataSource = ListaProveedores;
			cmbProveedores.SelectedIndex = 0;
		}

		private void LimpiarPantalla()
		{
			lblNombre.Text = "";
			lblCuit.Text = "";
			lblEmail.Text = "";
			lblCelular.Text = "";
			lblRubro.Text = "";
			lblDireccion.Text = "";
			btnAceptar.Enabled = false;
		}
		#endregion

	}
}
