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

namespace TP2JuanChavez.Usuarios
{
	public partial class FrmEliminarUsuario : Form
	{
		public FrmEliminarUsuario()
		{
			InitializeComponent();
		}

		#region ConnectionString
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		#endregion

		private void FrmEliminarUsuario_Load(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LlenarUsuarios();
			btnAceptar.Enabled = false;
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();

			if (cmbUsuarios.SelectedItem != null)
			{
				string usuarioSeleccionado = cmbUsuarios.SelectedItem.ToString();
				btnAceptar.Enabled = true;
				string query = "SELECT nombre, acceso, email, celular, password, usuario FROM usuarios WHERE nombre = @Nombre";

				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
					{
						sqlConnection.Open();
						using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
						{
							cmd.Parameters.AddWithValue("@Nombre", usuarioSeleccionado);
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									lblNombre.Text = reader["nombre"].ToString();
									lblAcceso.Text = reader["acceso"].ToString();
									lblEmail.Text = reader["email"].ToString();
									lblCelular.Text = reader["celular"].ToString();
									lblUsuario.Text = reader["usuario"].ToString();
									lblPassword.Text = reader["password"].ToString();
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
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(ConnectionString))
					{
						connection.Open();
						string query = "DELETE FROM usuarios WHERE nombre = @Nombre";
						SqlCommand cmd = new SqlCommand(query, connection);
						cmd.Parameters.AddWithValue("@Nombre", lblNombre.Text);
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al eliminar el Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("No se eliminó el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			LimpiarPantalla();
			cmbUsuarios.SelectedIndex = -1;
			LlenarUsuarios();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LlenarUsuarios();
			cmbUsuarios.SelectedIndex = -1;
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Métodos
		private void LlenarUsuarios()
		{
			var ListaUsuarios = new List<string>();
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader reader;
			try
			{
				sqlConnection.Open();
				string query = "SELECT nombre FROM usuarios";
				cmd = new SqlCommand(query, sqlConnection);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						string nombre = reader["nombre"].ToString();
						ListaUsuarios.Add(nombre);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}

			sqlConnection.Close();

			cmbUsuarios.DataSource = ListaUsuarios;
			cmbUsuarios.SelectedIndex = -1;
		}

		private void LimpiarPantalla()
		{
			lblNombre.Text = string.Empty;
			lblAcceso.Text = string.Empty;
			lblEmail.Text = string.Empty;
			lblCelular.Text = string.Empty;
			lblUsuario.Text = string.Empty;
			lblPassword.Text = string.Empty;
			btnAceptar.Enabled = false;
		}
		#endregion


	}
}
