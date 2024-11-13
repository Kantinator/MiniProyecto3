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

        public bool RegistrarInstructor(string nombreInstructor, string cedula, string telefono, string sexo)
        {
            // Primero, verificar si la cédula ya existe en la base de datos
            if (ComprobarCedulaExistente(cedula))
            {
                MessageBox.Show("La cédula ingresada ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO Instructor (nombre_instructor, cedula, telefono, sexo) VALUES (@nombre_instructor, @cedula, @telefono, @sexo)";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros
                        command.Parameters.AddWithValue("@nombre_instructor", nombreInstructor);
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@sexo", sexo);

                        // Ejecutar el comando
                        int result = command.ExecuteNonQuery();

                        // Verificar si el registro fue exitoso
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool ComprobarCedulaExistente(string cedula)
        {
            string query = "SELECT COUNT(*) FROM Instructor WHERE cedula = @cedula";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cedula", cedula);

                        int count = (int)command.ExecuteScalar();

                        // Si count es mayor a 0, significa que la cédula ya existe
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar la cédula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public List<Dictionary<string, string>> ObtenerClientesPorInstructor(int idInstructor)
        {
            List<Dictionary<string, string>> clientes = new List<Dictionary<string, string>>();

            string query = @"
        SELECT c.nombre_cliente, c.correo_electronico, c.celular
        FROM Cliente c
        INNER JOIN Afiliacion a ON c.id_cliente = a.id_cliente
        WHERE a.id_instructor = @id_instructor";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_instructor", idInstructor);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Dictionary<string, string> cliente = new Dictionary<string, string>
                        {
                            { "nombre_cliente", reader["nombre_cliente"].ToString() },
                            { "correo_electronico", reader["correo_electronico"].ToString() },
                            { "celular", reader["celular"].ToString() }
                        };
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return clientes;
        }


    }
}
