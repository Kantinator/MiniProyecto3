using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3.modelo
{
    public class Clase
    {
        public String descripcion;

        //Constructor
        public Clase(string descripcion) 
        {
            this.descripcion = descripcion;
        }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
