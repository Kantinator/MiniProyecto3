using MiniProyecto3.vista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto3.controlador
{
    public class GimnasioMaster
    {
        private bd.GestorGimnasio gg;

        public GimnasioMaster()
        {
            gg = new bd.GestorGimnasio();
        }

        public void crearClase(frmRegistroClases r)
        {
            gg.registrarClase(new modelo.Clase(r.txtDescripcion.Text));
        }

        public void crearHorario(frmRegistroHorario r)
        {
            System.Windows.Forms.MessageBox.Show(r.cmbClase.Text);
            gg.registrarHorario(new modelo.HorarioClase(int.Parse(r.cmbClase.Text), int.Parse(r.numIdGrupo.Text), r.txtDia.Text, r.dtpHora.Value.ToShortTimeString(), int.Parse(r.cmbInstructor.Text), int.Parse(r.numParticipantes.Text)));
        }

        public void listaIdClases(frmRegistroHorario registro)
        {
            SqlDataReader lector = gg.listadoIdClases();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_clase", typeof(int));
            dt.Load(lector);
            registro.cmbClase.ValueMember = "id_clase";
            registro.cmbClase.DataSource = dt;
        }

        public void listaInstructores(frmRegistroHorario registro)
        {
            SqlDataReader lector = gg.listadoInstructores();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_instructor", typeof(int));
            dt.Load(lector);
            registro.cmbInstructor.ValueMember = "id_instructor";
            registro.cmbInstructor.DataSource = dt;
        }

        public void listaInstructores(FormAfiliaciones f)
        {
            SqlDataReader lector = gg.listadoInstructores();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_instructor", typeof(int));
            dt.Load(lector);
            f.cmbIdInstructor.ValueMember = "id_instructor";
            f.cmbIdInstructor.DataSource = dt;
        }

        public void listaPlanes(FormAfiliaciones f)
        {
            SqlDataReader lector = gg.listadoPlan();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_plan", typeof(int));
            dt.Load(lector);
            f.cmbIdPlan.ValueMember = "id_plan";
            f.cmbIdPlan.DataSource = dt;
        }

        public void listaClientes(FormAfiliaciones f)
        {
            SqlDataReader lector = gg.listadoCliente();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_cliente", typeof(int));
            dt.Load(lector);
            f.cmbIdCliente.ValueMember = "id_cliente";
            f.cmbIdCliente.DataSource = dt;
        }
        public void listaClientes(FormInscripcionClase f)
        {
            SqlDataReader lector = gg.listadoCliente();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_cliente", typeof(int));
            dt.Load(lector);
            f.cmbIdCliente.ValueMember = "id_cliente";
            f.cmbIdCliente.DataSource = dt;
        }

        public void listaGrupo(FormInscripcionClase f)
        {
            SqlDataReader lector = gg.listadoGrupo();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_grupo", typeof(int));
            dt.Load(lector);
            f.cmbIdGrupo.ValueMember = "id_grupo";
            f.cmbIdGrupo.DataSource = dt;
        }

        public void mostrarClases(frmRegistroHorario r)
        {
            using (SqlDataReader lector = gg.mostrarClase(int.Parse(r.cmbClase.Text)))
            {
                if (lector.Read())
                {
                    r.lblClase.Text = lector["descripcion_clase"].ToString();
                }
            }
        }

        public void mostrarClases(frmParticipantesInscritos r)
        {
            using (SqlDataReader lector = gg.mostrarClase(int.Parse(r.cmbClase.Text)))
            {
                if (lector.Read())
                {
                    r.lblClase.Text = lector["descripcion_clase"].ToString();
                }
            }
        }
        public void mostrarInstructores(frmRegistroHorario r)
        {
            using (SqlDataReader lector = gg.mostrarInstructor(int.Parse(r.cmbInstructor.Text)))
            {
                if (lector.Read())
                {
                    r.lblInstructor.Text = lector["nombre_instructor"].ToString();
                }
            }
        }

        public void mostrarInstructores(FormAfiliaciones f)
        {
            using (SqlDataReader lector = gg.mostrarInstructor(int.Parse(f.cmbIdInstructor.Text)))
            {
                if (lector.Read())
                {
                    f.lblInstructor.Text = lector["nombre_instructor"].ToString();
                }
            }
        }
        public void mostrarPlanes(FormAfiliaciones f)
        {
            using (SqlDataReader lector = gg.mostrarPlan(int.Parse(f.cmbIdPlan.Text)))
            {
                if (lector.Read())
                {
                    f.lblPlan.Text = lector["descripcion"].ToString();
                }
            }
        }
        public void mostrarClientes(FormAfiliaciones f)
        {
            using (SqlDataReader lector = gg.mostrarCliente(int.Parse(f.cmbIdCliente.Text)))
            {
                if (lector.Read())
                {
                    f.lblCliente.Text = lector["nombre_cliente"].ToString();
                }
            }
        }

        public void mostrarClientes(FormInscripcionClase f)
        {
            using (SqlDataReader lector = gg.mostrarCliente(int.Parse(f.cmbIdCliente.Text)))
            {
                if (lector.Read())
                {
                    f.lblCliente.Text = lector["nombre_cliente"].ToString();
                }
            }
        }
    }
}
