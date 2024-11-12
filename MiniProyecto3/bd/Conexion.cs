using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto3.bd
{
    internal class Conexion
    {
        private static SqlConnection conexion;

        public static SqlConnection getConexion()
        {
            if (conexion != null)
            {
                return conexion;

            }
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = DESKTOP-ISIP9K7\\;Initial Catalog=GimnasioDB;Integrated Security = True";
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de Conexion" + ex.Message);
                return null;

            }
        }
        public static void cerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}