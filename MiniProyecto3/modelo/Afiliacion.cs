﻿using System;

namespace MiniProyecto3.modelo 
{
    public class Afiliacion
    {
        // Propiedades de la clase Afiliacion
        public int IdAfiliacion { get; set; }
        public int IdPlan { get; set; }
        public int IdInstructor { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Afiliacion(int idPlan, int idInstructor, int idCliente, DateTime fechaInicio, DateTime fechaFin)
        {
            IdPlan = idPlan;
            IdInstructor = idInstructor;
            IdCliente = idCliente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        // Método para registrar una afiliación en la base de datos
        public bool CrearAfiliacion()
        {
            try
            {
                using (var conexion = new System.Data.SqlClient.SqlConnection("Data Source = DESKTOP-ISIP9K7\\;Initial Catalog=GimnasioDB;Integrated Security = True"))
                {
                    conexion.Open();
                    string consulta = @"INSERT INTO Afiliacion (id_plan, id_instructor, id_cliente, fecha_inicio, fecha_Fin)
                                        VALUES (@IdPlan, @IdInstructor, @IdCliente, @FechaInicio, @FechaFin)";

                    using (var comando = new System.Data.SqlClient.SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdPlan", this.IdPlan);
                        comando.Parameters.AddWithValue("@IdInstructor", this.IdInstructor);
                        comando.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                        comando.Parameters.AddWithValue("@FechaInicio", this.FechaInicio);
                        comando.Parameters.AddWithValue("@FechaFin", this.FechaFin);

                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;  // Retorna true si la inserción fue exitosa
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al crear la afiliación: " + ex.Message);
                return false;
            }
        }
    }
}
