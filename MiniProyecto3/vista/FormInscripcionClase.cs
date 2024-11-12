using System;
using System.Windows.Forms;

namespace MiniProyecto3.vista
{
    public partial class FormInscripcionClase : Form
    {
        MiniProyecto3.controlador.GimnasioMaster gm;
        public FormInscripcionClase()
        {
            InitializeComponent();
            gm = new MiniProyecto3.controlador.GimnasioMaster();
        }


        // Evento para el botón de inscripción en clase
        private void btnInscribirClase_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene valores de los controles
                MessageBox.Show(cmbIdGrupo.Text);
                int idGrupo = int.Parse(cmbIdGrupo.Text);
                int idCliente = int.Parse(cmbIdCliente.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                // Crea una instancia de InscripcionClase
                modelo.InscripcionClase inscripcionClase = new modelo.InscripcionClase(idGrupo, idCliente, fechaInicio, fechaFin);


                // Llama al método para crear la inscripción en la BD
                bool exito = inscripcionClase.RegistrarInscripcion();

                // Muestra mensaje según el resultado
                if (exito)
                {
                    MessageBox.Show("Inscripción en clase creada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear la inscripción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormInscripcionClase_Load(object sender, EventArgs e)
        {
            gm.listaGrupo(this);
            gm.listaClientes(this);
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            gm.mostrarClientes(this);
        }
    }
}
