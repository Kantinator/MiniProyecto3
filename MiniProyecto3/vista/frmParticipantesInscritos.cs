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
    public partial class frmParticipantesInscritos : Form
    {
        MiniProyecto3.controlador.GimnasioMaster gm;
        public frmParticipantesInscritos()
        {
            InitializeComponent();
            gm = new MiniProyecto3.controlador.GimnasioMaster();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            gm.consultarParticipantesInscritos(this);
        }

        private void frnParticipantesInscritos_Load(object sender, EventArgs e)
        {
            gm.listaIdClases(this);
        }

        private void cmbIdClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarClases(this);
        }
    }
}
