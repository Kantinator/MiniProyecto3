using System;
using System.Windows.Forms;

namespace MiniProyecto3 
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent(); // Este método se invoca al iniciar el formulario
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            // Recuperamos los valores ingresados en los campos de texto
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string celular = txtCelular.Text;

            // Creamos un objeto Cliente con los datos del formulario
            Cliente cliente = new Cliente(nombre, correo, celular);

            // Intentamos crear el cliente en la base de datos
            bool exito = cliente.CrearCliente();

            if (exito)
            {
                MessageBox.Show("Cliente creado exitosamente");
            }
            else
            {
                MessageBox.Show("Error al crear el cliente");
            }
        }
    }
}
