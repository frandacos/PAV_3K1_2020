using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.DataAccessLayer;
using BugTracker.Entities;

namespace BugTracker.BusinessLayer
{
    class UsuarioCursoAvanceService
    {
        private UsuarioCursoAvanceDao oUsuarioCursoAvanceDao;

        public UsuarioCursoAvanceService()
        {
            oUsuarioCursoAvanceDao = new UsuarioCursoAvanceDao();
        }

        internal object ObtenerUsuariosCurso(int idCurso, int idUsuario)
        {
            //SIN PARAMETROS
            return oUsuarioCursoAvanceDao.GetUserConParametros(idCurso, idUsuario);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }
    }
}

