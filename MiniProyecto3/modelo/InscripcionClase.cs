using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniProyecto3.modelo 
{
    public class InscripcionClase
    {
        public int IdGrupo { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public InscripcionClase(int idGrupo, int idCliente, DateTime fechaInicio, DateTime fechaFin)
        {
            IdGrupo = idGrupo;
            IdCliente = idCliente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
        
        // Método para registrar inscripción en la base de datos
        public bool RegistrarInscripcion()
         {
             bool exito = false;
             string connectionString = "Data Source = DESKTOP-ISIP9K7\\;Initial Catalog=GimnasioDB;Integrated Security = True"; // Configura la cadena de conexión aquí

             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 string query = "INSERT INTO Inscripcion_Clase (id_grupo, id_cliente, fecha_inicio, fecha_fin) VALUES (@IdGrupo, @IdCliente, @FechaInicio, @FechaFin)";
                 SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("@IdGrupo", this.IdGrupo);
                 command.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                 command.Parameters.AddWithValue("@FechaInicio", this.FechaInicio);
                 command.Parameters.AddWithValue("@FechaFin", this.FechaFin);

                 try
                 {
                     connection.Open();
                     int result = command.ExecuteNonQuery();
                     exito = (result > 0);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error al registrar la inscripción: " + ex.Message);
                 }
             }

             return exito;
         }
    }
}
