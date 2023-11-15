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

namespace TP2JuanChavez
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private static readonly string ConnectionString = "Server=192.168.0.11;Database=ChinoDB; User id = user; Password = 1234; TrustServerCertificate=True;";
		private int usuarioID;

		#region Botones

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			CerrarSesion();
			Application.Exit();
		}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader reader;

			try
			{
				sqlConnection.Open();
				string query = "SELECT * FROM usuarios where usuario='" + txtUser.Text + "' and password='" + txtPass.Text + "'";
				cmd = new SqlCommand(query, sqlConnection);
				reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					if (reader.Read())
					{
						usuarioID = Convert.ToInt32(reader["UsuarioID"]);
						string nivelAcceso = (reader["acceso"].ToString());
						if (nivelAcceso == "ADMINISTRADOR")
						{
							RegistrarInicioSesion();
							this.Hide();
							var ventanaAdmin = new FrmInicioAdmin();
							ventanaAdmin.ShowDialog();
						}
						else
						{
							RegistrarInicioSesion();
							this.Hide();
							var ventanaOperador = new FrmInicioCajero();
							ventanaOperador.ShowDialog();
						}
					}
				}
				else
				{
					MessageBox.Show("Usuario o contraseña incorrectos.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlConnection.Dispose();
			}
		}

		#endregion

		#region Métodos
		private void RegistrarInicioSesion()
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					sqlConnection.Open();
					string insertQuery = "INSERT INTO Sesiones (UsuarioID, Fecha, HoraInicio) VALUES (@UsuarioID, @Fecha, @HoraInicio)";
					using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection))
					{
						insertCmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
						insertCmd.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						insertCmd.Parameters.AddWithValue("@HoraInicio", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						insertCmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar el inicio de sesión: " + ex.Message);
			}
		}

		private void CerrarSesion()
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
				{
					sqlConnection.Open();
					string updateQuery = "UPDATE Sesiones SET HoraFinalizacion = @HoraFinalizacion WHERE SesionID = (SELECT TOP 1 SesionID FROM Sesiones WHERE UsuarioID = @UsuarioID ORDER BY Fecha DESC, HoraInicio DESC)";
					using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlConnection))
					{
						updateCmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
						updateCmd.Parameters.AddWithValue("@HoraFinalizacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						updateCmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar la finalización de sesión: " + ex.Message);
			}
		}

		private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			CerrarSesion();
		}
		#endregion
	}
}
