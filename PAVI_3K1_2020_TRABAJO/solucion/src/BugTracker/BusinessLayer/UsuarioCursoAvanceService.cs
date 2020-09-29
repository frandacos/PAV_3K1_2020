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
    class UsuarioCursoAvanceService
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


    }
}

