using MiniProyecto3.vista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto3.bd
{
    internal class GestorGimnasio
    {
        SqlConnection conexion;

        public GestorGimnasio()
        {
            conexion = bd.Conexion.getConexion();
        }

        //Metodos Clases
        public void registrarClase(modelo.Clase c)
        {
            string query = "Insert into Clase (descripcion_clase) values (@Descripcion)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Clase registrada exitosamente.");
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Metodos Horario de clase
        public void registrarHorario(modelo.HorarioClase hc)
        {
            string query = "Insert into Horario_Clase (id_clase, id_grupo, dia_semana, hora, id_instructor, max_participantes) values (@IdClase, @IdGrupo, @Dia, @Hora, @IdInstructor, @MaxParticipantes)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@IdClase", Convert.ToInt32(hc.IdClase));
            cmd.Parameters.AddWithValue("@IdGrupo", Convert.ToInt32(hc.IdGrupo));
            cmd.Parameters.AddWithValue("@Dia", hc.DiaSemana);
            cmd.Parameters.AddWithValue("@Hora", hc.Hora);
            cmd.Parameters.AddWithValue("@IdInstructor", Convert.ToInt32(hc.IdInstructor));
            cmd.Parameters.AddWithValue("@MaxParticipantes", Convert.ToInt32(hc.MaxParticipantes));
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Horario de clase registrado exitosamente.");
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public SqlDataReader consultaParticipantesInscritos(int idClase)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "EXEC sp_Participantes_Inscritos_En_Clase @idClase = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idClase));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader consultaDetallesAfiliacion(string fechaInicio, string fechaFin)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "EXEC sp_Afiliciones_Plan @inicio = @fechaInicio, @fin = @fechaFin";
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader consultaClientesActivos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT*FROM vista_clientes_subscripcion_activa";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader mostrarClase(int idClase)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select descripcion_clase from Clase where id_clase = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idClase));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader mostrarClaseGrupo(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select descripcion_clase from Clase c INNER JOIN Horario_Clase hc ON hc.id_clase = c.id_clase where id_grupo = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idGrupo));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader mostrarInstructor(int idInstructor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select nombre_instructor from Instructor where id_instructor = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idInstructor));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader mostrarCliente(int idCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select nombre_cliente from Cliente where id_cliente = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idCliente));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader mostrarPlan(int idPlan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select descripcion from [Plan] where id_plan = @id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idPlan));
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader listadoIdClases()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select id_clase from Clase";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader listadoInstructores()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select id_instructor from Instructor";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader listadoCliente()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select id_cliente from Cliente";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader listadoPlan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select id_plan from [Plan]";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader listadoGrupo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select id_grupo from Horario_Clase";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
    }
}
