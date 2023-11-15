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

namespace TP2JuanChavez.Articulos
{
	public partial class FrmEliminarArticulo : Form
	{
		public FrmEliminarArticulo()
		{
			InitializeComponent();
		}
		#region ConecctionString
			private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		#endregion
		
		private void FrmEliminarArticulo_Load(object sender, EventArgs e)
		{
			LlenarArticulos();
			LimpiarPantalla();
			btnAceptar.Enabled = false;
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			if (cmbArticulos.SelectedItem != null)
			{
				btnAceptar.Enabled = true;

				string detalleSeleccionado = cmbArticulos.SelectedItem.ToString();

				string query = "SELECT articuloid, detalle, presentacion, preciocompra, precioventa, stock, proveedor FROM Articulos WHERE detalle = @Detalle";

				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					try
					{
						sqlConnection.Open();
						using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
						{
							cmd.Parameters.AddWithValue("@Detalle", detalleSeleccionado);
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									lblEan13.Text = reader["articuloid"].ToString();
									lblDetalle.Text = reader["detalle"].ToString();
									lblPresentacion.Text = reader["presentacion"].ToString();
									lblPrecioCompra.Text = reader["preciocompra"].ToString();
									lblPrecioVenta.Text = reader["precioventa"].ToString();
									lblStock.Text = reader["stock"].ToString();
									lblProveedor.Text = reader["proveedor"].ToString();
								}
								else
								{
									MessageBox.Show("Por favor, seleccione un artículo antes de cargar la información.");
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
					}

				}
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(ConnectionString))
					{
						connection.Open();
						string query = "DELETE FROM articulos WHERE articuloid = @ID";
						SqlCommand cmd = new SqlCommand(query, connection);
						cmd.Parameters.AddWithValue("@ID", lblEan13.Text);
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Artículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimpiarPantalla();
					LlenarArticulos();
					cmbArticulos.SelectedIndex = -1;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					LimpiarPantalla();
					LlenarArticulos();
					cmbArticulos.SelectedIndex = -1;
				}
			}
			else
			{
				MessageBox.Show("No se eliminó el artículo.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimpiarPantalla();
				LlenarArticulos();
				cmbArticulos.SelectedIndex = -1;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LlenarArticulos();
			cmbArticulos.SelectedIndex = -1;
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Métodos
		private void LlenarArticulos()
		{
			var ListaArticulos = new List<string>();
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader reader;
			try
			{
				sqlConnection.Open();
				string query = "SELECT detalle FROM Articulos";
				cmd = new SqlCommand(query, sqlConnection);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						string detalle = reader["detalle"].ToString();
						ListaArticulos.Add(detalle);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}

			sqlConnection.Close();

			cmbArticulos.DataSource = ListaArticulos;
			cmbArticulos.SelectedIndex = 0;
		}

		private void LimpiarPantalla()
		{
			lblEan13.Text = "";
			lblDetalle.Text = "";
			lblPresentacion.Text = "";
			lblPrecioCompra.Text = "";
			lblPrecioVenta.Text = "";
			lblStock.Text = "";
			lblProveedor.Text = "";
			btnAceptar.Enabled = false;
		}
		#endregion
	}
}
