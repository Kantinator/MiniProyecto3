using MiniProyecto3.vista;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txbUsuario.Text;
            string contrasena = txbPassword.Text;

            SQLGYM sqlGym = new SQLGYM();
            string rol = sqlGym.VerificarCredenciales(nombreUsuario, contrasena);

            if (rol == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rol == "Administrador")
            {
                MessageBox.Show("Inicio de sesión exitoso como Administrador", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muestra el formulario de administrador
                frmMenu menu = new frmMenu();
                menu.Show();

                // Oculta el formulario de inicio de sesión después de iniciar sesión
                this.Hide();
            }
            else
            {
                // Muestra un mensaje de error si el rol no es "Administrador"
                MessageBox.Show("Acceso denegado. Solo los administradores pueden iniciar sesión.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
