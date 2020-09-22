using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Actividad
    {
        private int id_actividad;
        private string nombre;
        private string descripcion;
        private Boolean borrado;


        public int Id_actividad { get => id_actividad; set => id_actividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Boolean Borrado { get => borrado; set => borrado = value; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
