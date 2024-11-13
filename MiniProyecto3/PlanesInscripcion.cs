using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3
{
    internal class PlanesInscripcion
    {
        public string Descripcion { get; set; }
        public int HorasSemanales { get; set; }
        public decimal CostoMensual { get; set; }

        public PlanesInscripcion(string descripcion, int horasSemanales, decimal costoMensual)
        {
            Descripcion = descripcion;
            HorasSemanales = horasSemanales;
            CostoMensual = costoMensual;
        }

        public bool CrearPlan()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("tu_conexion_a_base_de_datos"))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO [Plan] (descripcion, horas_semanales, costo_mensual) VALUES (@Descripcion, @Horas, @Costo)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                        comando.Parameters.AddWithValue("@Horas", HorasSemanales);
                        comando.Parameters.AddWithValue("@Costo", CostoMensual);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el plan: " + ex.Message);
                return false;
            }
        }
    }
}