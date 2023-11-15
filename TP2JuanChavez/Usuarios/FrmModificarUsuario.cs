using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2JuanChavez.Usuarios
{
	public partial class FrmModificarUsuario : Form
	{
		public FrmModificarUsuario()
		{
			InitializeComponent();
		}

		#region ConnectionString y Variables
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private bool nombreValidado = false;
		private bool emailValidado = false;
		private bool celularValidado = false;
		private bool usuarioValidado = false;
		private bool passwordValidado = false;
		#endregion


		private void FrmModificarUsuario_Load(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
			CargarCMB();
			LlenarUsuarios();
			btnAceptar.Enabled = false;
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
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
									txtNombre.Text = reader["nombre"].ToString();
									cmbAcceso.Text = reader["acceso"].ToString();
									txtEmail.Text = reader["email"].ToString();
									txtCelular.Text = reader["celular"].ToString();
									txtUsuario.Text = reader["usuario"].ToString();
									txtPassword.Text = reader["password"].ToString();
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
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			try
			{
				sqlConnection.Open();
				var usuarioID = cmbUsuarios.SelectedValue;

				string query = "UPDATE usuarios SET Nombre = @nombre, Acceso = @acceso, Email = @email, Celular = @celular, Usuario = @usuario, Password = @password WHERE Nombre = @usuarioID";
				cmd = new SqlCommand(query, sqlConnection);
				cmd.Parameters.AddWithValue("@usuarioID", usuarioID);
				cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
				cmd.Parameters.AddWithValue("@acceso", cmbAcceso.Text);
				cmd.Parameters.AddWithValue("@email", txtEmail.Text);
				cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
				cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
				cmd.Parameters.AddWithValue("@password", txtPassword.Text);

				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Usuario actualizado correctamente.");
				}
				else
				{
					MessageBox.Show("No se encontró el usuario a actualizar.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
				LimpiarPantalla();
				LimpiarError();
			}

			LimpiarPantalla();
			LimpiarError();
			LlenarUsuarios();
			cmbUsuarios.SelectedIndex = -1;
			sqlConnection.Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
			cmbUsuarios.SelectedIndex = -1;
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Validación
		private void txtNombre_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxString(txtNombre))
			{
				errorProvider1.SetError(txtNombre, string.Empty);
				nombreValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtNombre, "El nombre ingresado no cumple con las condiciones");
				nombreValidado = false;
			}
			ValidarCampos();
		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{
			if (ValidarEmail(txtEmail.Text))
			{
				errorProvider1.SetError(txtEmail, string.Empty);
				emailValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtEmail, "El email ingresado no cumple con las condiciones");
				emailValidado = false;
			}
			ValidarCampos();
		}

		private void txtCelular_TextChanged(object sender, EventArgs e)
		{
			if (ValidarCelular(txtCelular.Text))
			{
				errorProvider1.SetError(txtCelular, string.Empty);
				celularValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtCelular, "El celular ingresado no cumple con las condiciones");
				celularValidado = false;
			}
			ValidarCampos();
		}

		private void txtUsuario_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxString(txtUsuario))
			{
				errorProvider1.SetError(txtUsuario, string.Empty);
				usuarioValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtUsuario, "El usuario ingresado no cumple con las condiciones");
				usuarioValidado = false;
			}
			ValidarCampos();
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			if (ValidatePassword(txtPassword.Text))
			{
				errorProvider1.SetError(txtPassword, string.Empty);
				passwordValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPassword, "La contraseña ingresada no cumple con las condiciones");
				passwordValidado = false;
			}
			ValidarCampos();
		}
		#endregion

		#region Métodos Validación
		private bool ValidarTextBoxString(System.Windows.Forms.TextBox textBox)
		{
			string patron = "^[a-zA-Z ]+$";
			Regex regex = new Regex(patron);

			if (regex.IsMatch(textBox.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ValidarEmail(string email)
		{
			string patron = @"^[\w\.-]+@[\w\.-]+\.\w+$";
			return Regex.IsMatch(email, patron);
		}

		private bool ValidarCelular(string numeroTelefono)
		{
			string patron = @"^(?:(?:\+54|0)[\s-]?)?(\d{2,5}[\s-]?\d{4}[\s-]?\d{4})$";
			return Regex.IsMatch(numeroTelefono, patron);
		}

		public static bool ValidatePassword(string password)
		{
			string pattern = "^(?=.*[a-zA-Z])(?=.*\\d).{8,}$";

			return Regex.IsMatch(password, pattern);
		}

		private void ValidarCampos()
		{
			btnAceptar.Enabled = nombreValidado && emailValidado && celularValidado && usuarioValidado && passwordValidado;
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

		private void CargarCMB()
		{
			cmbAcceso.Items.Add("ADMINISTRADOR");
			cmbAcceso.Items.Add("CAJERO");
		}

		private void LimpiarPantalla()
		{
			txtNombre.Clear();
			cmbAcceso.SelectedIndex = -1;
			txtEmail.Clear();
			txtCelular.Clear();
			txtUsuario.Clear();
			txtPassword.Clear();
			btnAceptar.Enabled = false;
		}

		private void LimpiarError()
		{
			errorProvider1.SetError(txtNombre, string.Empty);
			errorProvider1.SetError(txtEmail, string.Empty);
			errorProvider1.SetError(txtCelular, string.Empty);
			errorProvider1.SetError(txtUsuario, string.Empty);
			errorProvider1.SetError(txtPassword, string.Empty);
		}
		#endregion

	}
}
