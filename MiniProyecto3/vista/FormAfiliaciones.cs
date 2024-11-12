using System;
using System.Windows.Forms;

namespace MiniProyecto3.vista
{
    public partial class FormAfiliaciones : Form
    {
        MiniProyecto3.controlador.GimnasioMaster gm;
        public FormAfiliaciones()
        {
            InitializeComponent();
            gm = new MiniProyecto3.controlador.GimnasioMaster();
        }

        // Evento para el botón de crear afiliación
        private void btnCrearAfiliacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene valores de los controles
                MessageBox.Show(cmbIdPlan.Text);
                int idPlan = int.Parse(cmbIdPlan.Text);
                int idInstructor = int.Parse(cmbIdInstructor.Text);
                int idCliente = int.Parse(cmbIdCliente.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                // Crea una instancia de Afiliacion
                modelo.Afiliacion afiliacion = new modelo.Afiliacion(idPlan, idInstructor, idCliente, fechaInicio, fechaFin);


                // Llama al método para crear la afiliación en la BD
                bool exito = afiliacion.CrearAfiliacion();

                // Muestra mensaje según el resultado
                if (exito)
                {
                    MessageBox.Show("Afiliación creada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear la afiliación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormAfiliaciones_Load(object sender, EventArgs e)
        {
            gm.listaInstructores(this);
            gm.listaPlanes(this);
            gm.listaClientes(this);
        }

        private void cmbIdInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarInstructores(this);
        }

        private void cmbIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarPlanes(this);
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarClientes(this);
        }
    }
}
