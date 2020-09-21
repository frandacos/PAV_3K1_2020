using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class UsuariosCurso
    {
        private Usuario usuario;
        private Curso curso;
        private int puntuacion;
        private string observaciones;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private Boolean borrado;

        
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Curso Curso { get => curso; set => curso = value; }

        public override string ToString()
        {
            return Curso.Nombre;
        }
    }

}