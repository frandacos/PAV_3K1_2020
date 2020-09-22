using BugTracker.DataAccessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    public class CategoriaService
    {
        private CategoriaDao oCategoriaDao;
        public CategoriaService()
        {
            oCategoriaDao = new CategoriaDao();
        }
        public IList<Categoria> ObtenerTodos()
        {
            return oCategoriaDao.GetAll();
        }

        internal IList<Categoria> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oCategoriaDao.GetByFiltersSinParametros(condiciones);
        }

        internal object ObtenerCategoria(string categoria)
        {
            //SIN PARAMETROS
            return oCategoriaDao.GetUserConParametros(categoria);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }

        internal bool CrearCategoria(Categoria oCategoria)
        {
            return oCategoriaDao.Create(oCategoria);
        }

        internal bool ActualizarCategoria(Categoria oCategoriaSelected)
        {
            return oCategoriaDao.Update(oCategoriaSelected);
        }

        internal bool BorrarCategoria(Categoria oCategoriaSelected)
        {
            return oCategoriaDao.Delete(oCategoriaSelected);
        }
    }
}
