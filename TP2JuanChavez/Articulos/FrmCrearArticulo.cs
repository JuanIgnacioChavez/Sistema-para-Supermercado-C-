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
	public partial class FrmCrearArticulo : Form
	{
		public FrmCrearArticulo()
		{
			InitializeComponent();
		}

		#region Variables

		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private bool ean13Validado = false;
		private bool detalleValidado = false;
		private bool presentacionValidado = false;
		private bool precioCompraValidado = false;
		private bool precioVentaValidado = false;
		private bool stockValidado = false;
		private bool proveedorValidado = false;

		#endregion

		#region Métodos
		private void ValidarCampos()
		{
			btnCrear.Enabled = ean13Validado && detalleValidado && presentacionValidado && precioCompraValidado && precioVentaValidado && stockValidado && proveedorValidado;
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

		private void FrmCrearArticulo_Load(object sender, EventArgs e)
		{
			LimpiarPantalla();
			btnCrear.Enabled = false;
			LimpiarError();
		}

		#region MétodosValidación
		private bool ValidarTextBoxAlfanumerico(System.Windows.Forms.TextBox textBox)
		{
			string patron = "^[a-zA-Z0-9 ]+$";
			Regex regex = new Regex(patron);

			return regex.IsMatch(textBox.Text);
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

		#region Botones
		private void btnCrear_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;

			try
			{
				sqlConnection.Open();

				// Verificar si el artículo ya existe
				string verificarQuery = "SELECT COUNT(*) FROM articulos WHERE articuloid = @Valor1";
				using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, sqlConnection))
				{
					verificarCmd.Parameters.AddWithValue("@Valor1", txtEan13.Text);
					int articuloExistente = (int)verificarCmd.ExecuteScalar();

					if (articuloExistente > 0)
					{
						MessageBox.Show("El artículo con el código EAN-13 ya existe.", "Artículo Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return; // No realizar la inserción si ya existe
					}
				}

				// Si no existe, realizar la inserción
				string insertarQuery = "INSERT INTO articulos (articuloid, detalle, presentacion, preciocompra, precioventa, stock, proveedor) VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6, @Valor7)";
				cmd = new SqlCommand(insertarQuery, sqlConnection);
				cmd.Parameters.AddWithValue("@Valor1", txtEan13.Text);
				cmd.Parameters.AddWithValue("@Valor2", txtDetalle.Text);
				cmd.Parameters.AddWithValue("@Valor3", txtPresentacion.Text);
				cmd.Parameters.AddWithValue("@Valor4", txtPrecioCompra.Text);
				cmd.Parameters.AddWithValue("@Valor5", txtPrecioVenta.Text);
				cmd.Parameters.AddWithValue("@Valor6", txtStock.Text);
				cmd.Parameters.AddWithValue("@Valor7", txtProveedor.Text);

				cmd.ExecuteNonQuery();
				MessageBox.Show("El artículo fue cargado correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el artículo: " + ex.Message);
			}
			finally
			{
				sqlConnection.Close();
			}

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

	}
}
