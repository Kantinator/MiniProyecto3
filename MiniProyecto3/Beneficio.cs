using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3
{
    internal class Beneficio
    {
        public string Descripcion { get; set; }
        public int IdPlan { get; set; }

        public Beneficio(string descripcion, int idPlan)
        {
            Descripcion = descripcion;
            IdPlan = idPlan;
        }

        public bool CrearBeneficio()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("tu_conexion_a_base_de_datos"))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Beneficio (descripcion_beneficio) VALUES (@Descripcion)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                        comando.ExecuteNonQuery();

                        // Asociar el beneficio con el plan
                        consulta = "INSERT INTO Plan_Beneficio (id_plan, id_beneficio) VALUES (@IdPlan, SCOPE_IDENTITY())";
                        comando.CommandText = consulta;
                        comando.Parameters.AddWithValue("@IdPlan", IdPlan);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar beneficio: " + ex.Message);
                return false;
            }
        }
    }
}
