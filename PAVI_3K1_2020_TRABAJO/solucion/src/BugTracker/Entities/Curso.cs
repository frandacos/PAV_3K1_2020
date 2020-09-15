using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Curso
    {
        private int id_curso;
        private string nombre;
        private string descripcion;
        private DateTime fecha_vigencia;
        private Boolean borrado;
        private Categoria categoria;

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_vigencia { get => fecha_vigencia; set => fecha_vigencia = value; }
        public Boolean Borrado { get => borrado; set => borrado = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    

        public override string ToString()
        {
            return Nombre;
        }

    }
}

