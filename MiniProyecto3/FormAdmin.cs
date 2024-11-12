using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreInstructor = txbNombre.Text;
            string cedula = txbCedula.Text;
            string telefono = txbTelefono.Text;
            string sexo = cbSexo.SelectedItem.ToString();

            SQLGYM sqlGym = new SQLGYM();
            bool success = sqlGym.RegistrarInstructor(nombreInstructor, cedula, telefono, sexo);

            if (success)
            {
                MessageBox.Show("Instructor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Cierra el formulario actual
            }
            else
            {
                MessageBox.Show("Error al registrar el instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClienteInstructor formclienteInstructor = new ListaClienteInstructor();

            // Suscribirse al evento FormClosed
            formclienteInstructor.FormClosed += (s, args) =>
            {
                // Volver a mostrar el formulario actual cuando se cierra formclienteInstructor
                this.Show();
            };

            formclienteInstructor.Show();
            this.Hide();
        }

    }
}
