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
    public partial class frmRegistroInstructor : Form
    {
        public frmRegistroInstructor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreInstructor = txbNombre.Text;

            SQLGYM sqlGym = new SQLGYM();
            bool success = sqlGym.RegistrarInstructor(nombreInstructor);

            if (success)
            {
                MessageBox.Show("Instructor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar el instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
