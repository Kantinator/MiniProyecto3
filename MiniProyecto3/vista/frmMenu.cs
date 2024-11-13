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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroInstructor frm = new frmRegistroInstructor();
            frm.ShowDialog();
        }

        private void clientesQueTrabajonConUnInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClienteInstructor frm = new ListaClienteInstructor();
            frm.ShowDialog();
        }

        private void planDeInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void beneficioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroClases frm = new frmRegistroClases();
            frm.ShowDialog();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroHorario frm = new frmRegistroHorario();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            frm.ShowDialog();
        }

        private void afiliacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfiliaciones frm = new FormAfiliaciones();
            frm.ShowDialog();
        }

        private void inscripcionAClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscripcionClase frm = new FormInscripcionClase();
            frm.ShowDialog();
        }

        private void participantesInscritosEnUnaClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParticipantesInscritos frm = new frmParticipantesInscritos();
            frm.ShowDialog();
        }

        private void clientesPorPlanDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetallesAfiliaciones frm = new frmDetallesAfiliaciones();
            frm.ShowDialog();
        }

        private void clientesConSuscripcionActivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesActivos frm = new frmClientesActivos();
            frm.ShowDialog();
        }
    }
}
