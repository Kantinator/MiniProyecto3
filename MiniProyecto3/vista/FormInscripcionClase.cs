using System;
using System.Windows.Forms;

namespace MiniProyecto3.vista
{
    public partial class FormInscripcionClase : Form
    {
        public FormInscripcionClase()
        {
            InitializeComponent();
            CargarComboBoxes(); // Carga los datos en los ComboBox
        }

        // Método para cargar datos en ComboBoxes
        private void CargarComboBoxes()
        {
            // Cargar datos desde la base de datos en los ComboBoxes
            cmbIdGrupo.Items.Add("1");   // Simulación de carga desde la BD
            cmbIdCliente.Items.Add("1");
        }

        // Evento para el botón de inscripción en clase
        private void btnInscribirClase_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene valores de los controles
                int idGrupo = int.Parse(cmbIdGrupo.SelectedItem.ToString());
                int idCliente = int.Parse(cmbIdCliente.SelectedItem.ToString());
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
    }
}
