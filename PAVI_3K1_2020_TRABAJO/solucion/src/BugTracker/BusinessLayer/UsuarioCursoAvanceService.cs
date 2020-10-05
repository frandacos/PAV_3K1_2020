using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using BugTracker.DataAccessLayer;
using BugTracker.Entities;

namespace BugTracker.BusinessLayer
{
    public class UsuarioCursoAvanceService
    {
        private UsuarioCursoAvanceDao oUsuarioCursoAvanceDao;

        public UsuarioCursoAvanceService()
        {
            oUsuarioCursoAvanceDao = new UsuarioCursoAvanceDao();
        }


  
        internal IList<UsuarioCursoAvance> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oUsuarioCursoAvanceDao.GetByFiltersSinParametros(condiciones);
        }


        internal bool ActualizarActUsuarioCursoAvance(int id_usuario,int id_curso,int id_actividad)
        {
            return oUsuarioCursoAvanceDao.UpdateActividad(id_usuario, id_curso, id_actividad);
        }

        //internal int UsuariosTrue(int id_usuario, int id_curso)
        //{
        //    return oUsuarioCursoAvanceDao.ConsultarUsuariosTrue(id_usuario, id_curso);
        //}
    }
}

