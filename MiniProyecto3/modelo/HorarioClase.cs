using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto3.modelo
{
    internal class HorarioClase
    {
        public int idClase;
        public int idGrupo;
        public String diaSemana;
        public String hora;
        public int idInstructor;
        public int maxParticipantes;

        //Constructor
        public HorarioClase(int idClase, int idGrupo, string diaSemana, string hora, int idInstructor, int maxParticipantes)
        {
            this.idClase = idClase;
            this.idGrupo = idGrupo;
            this.diaSemana = diaSemana;
            this.hora = hora;
            this.idInstructor = idInstructor;
            this.maxParticipantes = maxParticipantes;
        }

        public int IdClase { get { return idClase; } set {idClase = value; } }
        public int IdGrupo { get { return idGrupo; } set {idGrupo= value; } }
        public string DiaSemana { get { return diaSemana; } set { diaSemana = value; } }
        public string Hora { get { return hora; } set { hora = value; } }
        public int IdInstructor { get { return idInstructor; } set { idInstructor = value; } }
        public int MaxParticipantes { get { return maxParticipantes; } set { maxParticipantes = value; } }
    }
}
