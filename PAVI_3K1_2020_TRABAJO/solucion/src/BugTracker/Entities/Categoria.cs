using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Categoria
    {
        private int id_categoria;
        private string nombre;
        private string descripcion;
        private Boolean borrado;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Boolean Borrado { get => borrado; set => borrado = value; }
        
        public override string ToString()
        {
        return Nombre;
        }
    }

    
}
