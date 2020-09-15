using BugTracker.DataAccessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    public class CursoService
    {
        private CursoDao oCursoDao;
        public CursoService()
        {
            oCursoDao = new CursoDao();
        }
        public IList<Curso> ObtenerTodos()
        {
            return oCursoDao.GetAll();
        }

        internal bool CrearCurso(Curso oCurso)
        {
            return oCursoDao.Create(oCurso);
        }

        internal bool ActualizarCurso(Curso oCursoSelected)
        {
            return oCursoDao.Update(oCursoSelected);
        }
        internal bool BorrarCurso(Curso oCursoSelected)
        {
            return oCursoDao.Delete(oCursoSelected);
        }
        internal bool ModificarEstadoUsuario(Curso oCursoSelected)
        {
            //throw new NotImplementedException();
            return oCursoDao.Update(oCursoSelected);
        }

        internal object ObtenerCurso(string curso)
        {
            //SIN PARAMETROS
            return oCursoDao.GetUserConParametros(curso);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }

      

        internal IList<Curso> ConsultarConFiltrosConParametros(Dictionary<string, object> filtros)
        {
            return oCursoDao.GetByFiltersConParametros(filtros);
        }

        internal IList<Curso> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oCursoDao.GetByFiltersSinParametros(condiciones);
        }
    }

}



