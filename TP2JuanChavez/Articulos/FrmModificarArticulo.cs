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

namespace TP2JuanChavez.Articulos
{
	public partial class FrmModificarArticulo : Form
	{
		public FrmModificarArticulo()
		{
			InitializeComponent();
		}

		#region ConnectionString y Variables
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private bool ean13Validado = false;
		private bool detalleValidado = false;
		private bool presentacionValidado = false;
		private bool precioCompraValidado = false;
		private bool precioVentaValidado = false;
		private bool stockValidado = false;
		private bool proveedorValidado = false;
		#endregion

		private void FrmModificarArticulo_Load(object sender, EventArgs e)
		{
			LlenarArticulos();
			btnAceptar.Enabled = false;
			LimpiarError();
		}

		#region Botones
		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (cmbArticulos.SelectedItem != null)
			{
				string detalleSeleccionado = cmbArticulos.SelectedItem.ToString();

				string query = "SELECT articuloid, detalle, presentacion, preciocompra, precioventa, stock, proveedor FROM Articulos WHERE detalle = @Detalle";

				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					sqlConnection.Open();
					using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
					{
						cmd.Parameters.AddWithValue("@Detalle", detalleSeleccionado);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								txtEan13.Text = reader["articuloid"].ToString();
								txtDetalle.Text = reader["detalle"].ToString();
								txtPresentacion.Text = reader["presentacion"].ToString();
								txtPrecioCompra.Text = reader["preciocompra"].ToString();
								txtPrecioVenta.Text = reader["precioventa"].ToString();
								txtStock.Text = reader["stock"].ToString();
								txtProveedor.Text = reader["proveedor"].ToString();
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un artículo antes de cargar la información.");
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			try
			{
				sqlConnection.Open();
				string query = "UPDATE articulos SET Detalle = @detalle, Presentacion = @presentacion, PrecioCompra = @preciocompra, PrecioVenta = @precioventa, Stock = @stock, Proveedor = @proveedor WHERE ArticuloID = @articuloid";
				cmd = new SqlCommand(query, sqlConnection);
				cmd.Parameters.AddWithValue("@articuloid", txtEan13.Text);
				cmd.Parameters.AddWithValue("@detalle", txtDetalle.Text);
				cmd.Parameters.AddWithValue("@presentacion", txtPresentacion.Text);
				cmd.Parameters.AddWithValue("@preciocompra", txtPrecioCompra.Text);
				cmd.Parameters.AddWithValue("@precioventa", txtPrecioVenta.Text);
				cmd.Parameters.AddWithValue("@stock", txtStock.Text);
				cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text);
				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Artículo actualizado correctamente.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar el artículo: " + ex.Message);
			}

			LlenarArticulos();
			cmbArticulos.SelectedIndex = -1;
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

		#region Validación
		private void txtEan13_TextChanged(object sender, EventArgs e)
		{
			if (ValidateEAN13(txtEan13.Text))
			{
				errorProvider1.SetError(txtEan13, string.Empty);
				ean13Validado = true;
			}
			else
			{
				errorProvider1.SetError(txtEan13, "El código EAN-13 ingresado es inválido");
				ean13Validado = false;
			}
			ValidarCampos();
		}

		private void txtDetalle_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxAlfanumerico(txtDetalle))
			{
				errorProvider1.SetError(txtDetalle, string.Empty);
				detalleValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtDetalle, "El detalle ingresado es incorrecto");
				detalleValidado = false;
			}
			ValidarCampos();
		}

		private void txtPresentacion_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxAlfanumerico(txtPresentacion))
			{
				errorProvider1.SetError(txtPresentacion, string.Empty);
				presentacionValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPresentacion, "La presentación ingresada es incorrecta");
				presentacionValidado = false;
			}
			ValidarCampos();
		}

		private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxInt(txtPrecioCompra))
			{
				errorProvider1.SetError(txtPrecioCompra, string.Empty);
				precioCompraValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPrecioCompra, "El precio ingresado es incorrecto. Asegúrate de que el número ingresado sea formato INT");
				precioCompraValidado = false;
			}
			ValidarCampos();
		}

		private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxInt(txtPrecioVenta))
			{
				errorProvider1.SetError(txtPrecioVenta, string.Empty);
				precioVentaValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtPrecioVenta, "El precio ingresado es incorrecto. Asegúrate de que el número ingresado sea formato INT");
				precioVentaValidado = false;
			}
			ValidarCampos();
		}

		private void txtStock_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxInt(txtStock))
			{
				errorProvider1.SetError(txtStock, string.Empty);
				stockValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtStock, "El stock ingresado es incorrecto. Asegúrate de que el número ingresado sea formato INT");
				stockValidado = false;
			}
			ValidarCampos();
		}

		private void txtProveedor_TextChanged(object sender, EventArgs e)
		{
			if (ValidarTextBoxString(txtProveedor))
			{
				errorProvider1.SetError(txtProveedor, string.Empty);
				proveedorValidado = true;
			}
			else
			{
				errorProvider1.SetError(txtProveedor, "El proveedor ingresado es incorrecto");
				proveedorValidado = false;
			}
			ValidarCampos();
		}
		#endregion

		#region Métodos Validación

		private bool ValidarTextBoxAlfanumerico(System.Windows.Forms.TextBox textBox)
		{
			string patron = "^[a-zA-Z0-9 ]+$";
			Regex regex = new Regex(patron);

			return regex.IsMatch(textBox.Text);
		}

		private void ValidarCampos()
		{
			bool camposValidos = ean13Validado && detalleValidado && presentacionValidado && precioCompraValidado && precioVentaValidado && stockValidado && proveedorValidado;
			btnAceptar.Enabled = camposValidos;
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

		private bool ValidarTextBoxInt(System.Windows.Forms.TextBox textBox)
		{
			int numero;

			if (int.TryParse(textBox.Text, out numero))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ValidateEAN13(string ean13)
		{
			if (ean13.Length != 13)
			{
				return false;
			}

			int[] digits = ean13.Select(c => int.Parse(c.ToString())).ToArray();

			int sumEven = 0;
			int sumOdd = 0;

			for (int i = 0; i < 12; i++)
			{
				if (i % 2 == 0)
				{
					sumEven += digits[i];
				}
				else
				{
					sumOdd += digits[i];
				}
			}

			int total = (sumOdd * 3) + sumEven;
			int checksum = (10 - (total % 10)) % 10;

			return checksum == digits[12];
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
			txtEan13.Clear();
			txtDetalle.Clear();
			txtPresentacion.Clear();
			txtPrecioCompra.Clear();
			txtPrecioVenta.Clear();
			txtStock.Clear();
			txtProveedor.Clear();
		}

		private void LimpiarError()
		{
			errorProvider1.SetError(txtEan13, string.Empty);
			errorProvider1.SetError(txtDetalle, string.Empty);
			errorProvider1.SetError(txtPresentacion, string.Empty);
			errorProvider1.SetError(txtPrecioCompra, string.Empty);
			errorProvider1.SetError(txtPrecioVenta, string.Empty);
			errorProvider1.SetError(txtStock, string.Empty);
			errorProvider1.SetError(txtProveedor, string.Empty);
		}
		#endregion


	}
}
