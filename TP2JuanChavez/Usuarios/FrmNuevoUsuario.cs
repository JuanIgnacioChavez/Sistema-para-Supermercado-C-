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
	public partial class FrmNuevoUsuario : Form
	{
		public FrmNuevoUsuario()
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

		private void FrmNuevoUsuario_Load(object sender, EventArgs e)
		{
			CargarCMB();
			LimpiarPantalla();
			btnCrear.Enabled = false;
			LimpiarError();
		}

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
		private void ValidarCampos()
		{
			btnCrear.Enabled = nombreValidado && emailValidado && celularValidado && usuarioValidado && passwordValidado;
		}

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

		#endregion

		#region Botones
		private void btnCrear_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			try
			{
				sqlConnection.Open();
				string query = "INSERT INTO usuarios (nombre, acceso, email, celular, password, usuario) VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6)";
				cmd = new SqlCommand(query, sqlConnection);
				cmd.Parameters.AddWithValue("@Valor1", txtNombre.Text);
				cmd.Parameters.AddWithValue("@Valor2", cmbAcceso.Text);
				cmd.Parameters.AddWithValue("@Valor3", txtEmail.Text);
				cmd.Parameters.AddWithValue("@Valor4", txtCelular.Text);
				cmd.Parameters.AddWithValue("@Valor5", txtPassword.Text);
				cmd.Parameters.AddWithValue("@Valor6", txtUsuario.Text);

				cmd.ExecuteNonQuery();
				MessageBox.Show("El usuario fue cargado correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el usuario: " + ex.Message);
			}
			sqlConnection.Close();
			LimpiarPantalla();
			LimpiarError();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Métodos
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
