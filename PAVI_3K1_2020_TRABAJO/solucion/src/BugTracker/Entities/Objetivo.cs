using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Objetivo
    {
        private int id_objetivo;
        private string nombre_corto;
        private string nombre_largo;
        private string descripcion;
        private Boolean borrado;

        public int Id_objetivo { get => id_objetivo; set => id_objetivo = value; }
        public string Nombre_corto { get => nombre_corto; set => nombre_corto = value; }
        public string Nombre_largo { get => nombre_largo; set => nombre_largo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public override string ToString()
        {
            return Nombre_corto;
        }
    }
}
