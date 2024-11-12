using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3.vista
{
    
    public partial class frmRegistroClases : Form
    {
        MiniProyecto3.controlador.GimnasioMaster gm;
        public frmRegistroClases()
        {
            InitializeComponent();
            gm = new MiniProyecto3.controlador.GimnasioMaster();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            gm.crearClase(this);
        }
    }
}
