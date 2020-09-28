using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class UsuarioCursoAvance
    {
        private Usuario usuario;
        private Curso curso;
        private Actividad actividad;
        private DateTime fin;
        private int porc_avance;
        private Boolean borrado;


     
        public DateTime Fin { get => fin; set => fin = value; }
        public int Porc_avance { get => porc_avance; set => porc_avance = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Curso Curso { get => curso; set => curso = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }

        public override string ToString()
        {
            return Curso.Nombre;
        }
    }
}
