using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class CategoriaDao
    {
        public IList<Categoria> GetAll()
        {
            List<Categoria> listadoBugs = new List<Categoria>();

            var strSql = "SELECT * From Categorias";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        private Categoria ObjectMapping(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                Id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())

            };

            return oCategoria;
        }
    }
}
