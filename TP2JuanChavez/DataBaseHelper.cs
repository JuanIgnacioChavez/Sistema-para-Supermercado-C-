using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2JuanChavez
{
	public class DataBaseHelper
	{
		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";

		public static int ObtenerUsuarioIDEnSesion()
		{
			int usuarioIDEnSesion = -1;

			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();

					string query = "SELECT TOP 1 UsuarioID FROM Sesiones ORDER BY HoraInicio DESC";

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

		public static string ObtenerNombreUsuario(int usuarioID)
		{
			string nombreUsuario = string.Empty;

			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();

					string query = "SELECT Nombre FROM Usuarios WHERE UsuarioID = @UsuarioID";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Agrega el parámetro para el UsuarioID
						command.Parameters.AddWithValue("@UsuarioID", usuarioID);

						// Ejecuta la consulta y obtén el nombre asociado al UsuarioID
						object result = command.ExecuteScalar();

						// Verifica si se obtuvo un resultado y asigna el nombre de usuario
						if (result != null)
						{
							nombreUsuario = result.ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener el nombre del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return nombreUsuario;
		}

	}


}
