using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3
{
    internal class SQLGYM
    {
        public string cadenaConexion = "Data Source=DESKTOP-2PNP6F6\\SQLBRIEF; Initial Catalog=GimnasioDB; Integrated Security=true;";

        public string VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT rol FROM Usuario WHERE nombre_usuario = @nombreUsuario AND contrasena = @contrasena";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    conexion.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString(); // Devuelve el rol del usuario si las credenciales son correctas
                    }
                    else
                    {
                        return null; // Retorna null si las credenciales no son correctas
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar credenciales: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
