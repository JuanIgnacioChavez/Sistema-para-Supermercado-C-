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
	public partial class FrmModificarProveedor : Form
	{
		public FrmModificarProveedor()
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

		private void FrmModificarProveedor_Load(object sender, EventArgs e)
		{
			LlenarProveedores();
			btnAceptar.Enabled = false;
			LimpiarError();
			LimpiarPantalla();
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (cmbProveedores.SelectedItem != null)
			{
				string proveedorSeleccionado = cmbProveedores.SelectedItem.ToString();

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
									txtNombre.Text = reader["nombre"].ToString();
									txtCuit.Text = reader["cuit"].ToString();
									txtEmail.Text = reader["email"].ToString();
									txtCelular.Text = reader["celular"].ToString();
									txtRubro.Text = reader["rubro"].ToString();
									txtDireccion.Text = reader["direccion"].ToString();
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
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			try
			{
				sqlConnection.Open();
				var proveedorID = cmbProveedores.SelectedValue;

				string query = "UPDATE Proveedores SET Nombre = @nombre, CUIT = @cuit, Email = @email, Celular = @celular, Rubro = @rubro, Direccion = @direccion WHERE Nombre = @proveedorID";
				cmd = new SqlCommand(query, sqlConnection);
				cmd.Parameters.AddWithValue("@proveedorID", proveedorID);
				cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
				cmd.Parameters.AddWithValue("@cuit", txtCuit.Text);
				cmd.Parameters.AddWithValue("@email", txtEmail.Text);
				cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
				cmd.Parameters.AddWithValue("@rubro", txtRubro.Text);
				cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Proveedor actualizado correctamente.");
					LimpiarPantalla();
				}
				else
				{
					MessageBox.Show("No se encontró el proveedor a actualizar.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
			}

			LlenarProveedores();
			LimpiarError();
			cmbProveedores.SelectedIndex = -1;
			sqlConnection.Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
			LimpiarError();
			cmbProveedores.SelectedIndex = -1;
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
			btnAceptar.Enabled = nombreValidado && cuitValidado && emailValidado && celularValidado && rubroValidado && direccionValidada;
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
