using BugTracker.DataAccessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    class UsuariosCursoService
    {
        private UsuariosCursoDao oUsuariosCursoDao;
        public UsuariosCursoService()
        {
            oUsuariosCursoDao = new UsuariosCursoDao();
        }
        public IList<UsuariosCurso> ObtenerTodos()
        {
            return oUsuariosCursoDao.GetAll();
        }

        internal bool CrearUsuarioCurso(UsuariosCurso oUsuariosCurso)
        {
            return oUsuariosCursoDao.Create(oUsuariosCurso);
        }

        internal bool ActualizarUsuarioCurso(UsuariosCurso oUsuariosCursoSelected)
        {
            return oUsuariosCursoDao.Update(oUsuariosCursoSelected);
        }
        internal bool BorrarUsuarioCurso(UsuariosCurso oUsuariosCursoSelected)
        {
            return oUsuariosCursoDao.Delete(oUsuariosCursoSelected);
        }
       

        internal object ObtenerUsuariosCurso(string curso, string usuario)
        {
            //SIN PARAMETROS
            return oUsuariosCursoDao.GetUserConParametros(curso, usuario);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }



        internal IList<UsuariosCurso> ConsultarConFiltrosConParametros(Dictionary<string, object> filtros)
        {
            return oUsuariosCursoDao.GetByFiltersConParametros(filtros);
        }

        internal IList<UsuariosCurso> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oUsuariosCursoDao.GetByFiltersSinParametros(condiciones);
        }
    }
}
