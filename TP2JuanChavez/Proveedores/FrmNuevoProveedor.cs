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

namespace TP2JuanChavez.Proveedores
{
	public partial class FrmNuevoProveedor : Form
	{
		public FrmNuevoProveedor()
		{
			InitializeComponent();
		}
		#region ConnectionString y variables
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private bool nombreValidado = false;
		private bool cuitValidado = false;
		private bool emailValidado = false;
		private bool celularValidado = false;
		private bool rubroValidado = false;
		private bool direccionValidada = false;
		#endregion

		private void FrmNuevoProveedor_Load(object sender, EventArgs e)
		{
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
				errorProvider1.SetError(txtNombre, "El nombre ingresado no cumple con las condiciones.");
				nombreValidado = false;
			}
			ValidarCampos();
		}

		private void txtCuit_TextChanged(object sender, EventArgs e)
		{
			if (ValidarCUIT(txtCuit.Text))
			{
				errorProvider1.SetError(txtCuit, string.Empty);
				cuitValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtCuit, "El CUIT ingresado no cumple con las condiciones.");
				cuitValidado = false;
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
				errorProvider1.SetError(txtEmail, "El email ingresado no cumple con las condiciones.");
				emailValidado = false;
			}
			ValidarCampos();
		}

		private void txtRubro_TextChanged(object sender, EventArgs e)
		{
			if (ValidarCelular(txtCelular.Text))
			{
				errorProvider1.SetError(txtCelular, string.Empty);
				celularValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtCelular, "El celular ingresado no cumple con las condiciones, debe ser de Argentina +54.");
				celularValidado = false;
			}
			ValidarCampos();
		}

		private void txtDireccion_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxString(txtRubro))
			{
				errorProvider1.SetError(txtRubro, string.Empty);
				rubroValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtRubro, "El rubro ingresado no cumple con las condiciones.");
				rubroValidado = false;
			}
			ValidarCampos();
		}

		private void txtCelular_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtDireccion.Text))
			{
				errorProvider1.SetError(txtDireccion, string.Empty);
				direccionValidada = true;
			}
			else
			{
				errorProvider1.SetError(txtDireccion, "La dirección ingresada no cumple con las condiciones.");
				direccionValidada = false;
			}
			ValidarCampos();
		}
		#endregion

		#region Métodos Validación
		private void ValidarCampos()
		{
			btnCrear.Enabled = nombreValidado && cuitValidado && emailValidado && celularValidado && rubroValidado && direccionValidada;
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

		private bool ValidarCUIT(string cuit)
		{
			cuit = Regex.Replace(cuit, @"[-\s]", "");

			if (cuit.Length != 11 || !Regex.IsMatch(cuit, @"^\d{11}$"))
			{
				return false;
			}

			int[] coeficientes = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
			int suma = 0;
			int verificador = int.Parse(cuit[10].ToString());

			for (int i = 0; i < 10; i++)
			{
				suma += int.Parse(cuit[i].ToString()) * coeficientes[i];
			}

			int resto = suma % 11;
			int resultado = 11 - resto;

			if (resultado == 11)
			{
				resultado = 0;
			}

			return resultado == verificador;
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
		#endregion

		#region Botones 
		private void btnCrear_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			try
			{
				sqlConnection.Open();
				string query = "INSERT INTO proveedores (nombre, cuit, email, celular, rubro, direccion) VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6)";
				cmd = new SqlCommand(query, sqlConnection);
				cmd.Parameters.AddWithValue("@Valor1", txtNombre.Text);
				cmd.Parameters.AddWithValue("@Valor2", txtCuit.Text);
				cmd.Parameters.AddWithValue("@Valor3", txtEmail.Text);
				cmd.Parameters.AddWithValue("@Valor4", txtCelular.Text);
				cmd.Parameters.AddWithValue("@Valor5", txtRubro.Text);
				cmd.Parameters.AddWithValue("@Valor6", txtDireccion.Text);

				cmd.ExecuteNonQuery();
				MessageBox.Show("El proveedor fue cargado correctamente");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el proveedor: " + ex.Message);
			}
			sqlConnection.Close();
			LimpiarError();
			LimpiarPantalla();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
			MessageBox.Show("Se ha cancelado la operación y se ha limpiado la pantalla.");
		}
		#endregion

		#region Métodos
		private void LimpiarPantalla()
		{
			txtNombre.Clear();
			txtCuit.Clear();
			txtEmail.Clear();
			txtCelular.Clear();
			txtRubro.Clear();
			txtDireccion.Clear();
		}

		private void LimpiarError()
		{
			errorProvider1.SetError(txtNombre, string.Empty);
			errorProvider1.SetError(txtCuit, string.Empty);
			errorProvider1.SetError(txtEmail, string.Empty);
			errorProvider1.SetError(txtCelular, string.Empty);
			errorProvider1.SetError(txtRubro, string.Empty);
			errorProvider1.SetError(txtDireccion, string.Empty);
		}
		#endregion

	}
}
