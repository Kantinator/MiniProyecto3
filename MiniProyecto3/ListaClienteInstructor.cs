using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProyecto3
{
    public partial class ListaClienteInstructor : Form
    {
        public ListaClienteInstructor()
        {
            InitializeComponent();
            CargarInstructores();
        }

        private void CargarInstructores()
        {
            SQLGYM sqlGym = new SQLGYM();
            string query = "SELECT id_instructor, nombre_instructor FROM Instructor";

            using (SqlConnection connection = new SqlConnection(sqlGym.cadenaConexion))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbInstructores.Items.Add(new
                        {
                            Id = reader["id_instructor"],
                            Nombre = reader["nombre_instructor"].ToString()
                        });
                    }

                    cmbInstructores.DisplayMember = "Nombre";
                    cmbInstructores.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los instructores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            if (cmbInstructores.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var instructorSeleccionado = (dynamic)cmbInstructores.SelectedItem;
            int idInstructor = instructorSeleccionado.Id;

            SQLGYM sqlGym = new SQLGYM();
            var clientes = sqlGym.ObtenerClientesPorInstructor(idInstructor);

            dgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(
                    cliente["nombre_cliente"],
                    cliente["correo_electronico"],
                    cliente["celular"]
                );
            }

            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes para el instructor seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
