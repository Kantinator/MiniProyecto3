using System;
using System.Windows.Forms;

namespace MiniProyecto3.vista
{
    public partial class FormAfiliaciones : Form
    {
        public FormAfiliaciones()
        {
            InitializeComponent();
            CargarComboBoxes(); // Carga los datos en los ComboBox
        }

        // Método para cargar datos en ComboBoxes
        private void CargarComboBoxes()
        {
            cmbIdPlan.Items.Add("1");  
            cmbIdInstructor.Items.Add("1");
            cmbIdCliente.Items.Add("1");
        }

        // Evento para el botón de crear afiliación
        private void btnCrearAfiliacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene valores de los controles
                int idPlan = int.Parse(cmbIdPlan.SelectedItem.ToString());
                int idInstructor = int.Parse(cmbIdInstructor.SelectedItem.ToString());
                int idCliente = int.Parse(cmbIdCliente.SelectedItem.ToString());
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                // Crea una instancia de Afiliacion
                Afiliacion afiliacion = new Afiliacion(idPlan, idInstructor, idCliente, fechaInicio, fechaFin);

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
    }
}
