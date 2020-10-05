using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Actividad
    {
        public int Id_actividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;

        }

    }
}
