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
    public partial class frmRegistroHorario : Form
    {
        MiniProyecto3.controlador.GimnasioMaster gm;
        public frmRegistroHorario()
        {
            InitializeComponent();
            gm = new MiniProyecto3.controlador.GimnasioMaster();
        }

        private void frmRegistroHorario_Load(object sender, EventArgs e)
        {
            gm.listaIdClases(this);
            gm.listaInstructores(this);
        }

        private void cmbClase_Click(object sender, EventArgs e)
        {
            gm.mostrarClases(this);
        }

        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarClases(this);
        }

        private void cmbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarInstructores(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gm.crearHorario(this);
        }
    }
}
