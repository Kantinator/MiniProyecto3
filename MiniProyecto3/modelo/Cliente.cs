using System.Data.SqlClient;
using System.Windows.Forms;
using System;
namespace MiniProyecto3.modelo
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }

        // Constructor
        public Cliente(string nombre, string correo, string celular)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = celular;
        }

        // Método para crear un cliente en la base de datos
        public bool CrearCliente()
        {

            try
            {

                using (var conexion = new SqlConnection("tu_conexion_a_base_de_datos"))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Clientes (Nombre, Correo, Celular) VALUES (@Nombre, @Correo, @Celular)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                        comando.Parameters.AddWithValue("@Correo", this.Correo);
                        comando.Parameters.AddWithValue("@Celular", this.Celular);

                        int resultado = comando.ExecuteNonQuery();  // Ejecuta la consulta
                        return resultado > 0;  // Si el número de filas afectadas es mayor que 0, es exitoso
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, lo mostramos en un mensaje de error
                MessageBox.Show("Error al crear el cliente: " + ex.Message);
                return false;
            }
        }
    }
}

