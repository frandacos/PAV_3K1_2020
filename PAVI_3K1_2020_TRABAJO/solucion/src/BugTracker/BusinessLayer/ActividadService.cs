using BugTracker.DataAccessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    public class ActividadService
    {
        private ActividadDao oActividadDao;
        public ActividadService()
        {
            oActividadDao = new ActividadDao();
        }
        public IList<Actividad> ObtenerTodos()
        {
            return oActividadDao.GetAll();
        }

        internal IList<Actividad> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oActividadDao.GetByFiltersSinParametros(condiciones);
        }

        internal object ObtenerActividad(string actividad)
        {
            //SIN PARAMETROS
            return oActividadDao.GetUserConParametros(actividad);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }

        internal bool CrearActividad(Actividad oActividad)
        {
            return oActividadDao.Create(oActividad);
        }

        internal bool ActualizarActividad(Actividad oActividadSelected)
        {
            return oActividadDao.Update(oActividadSelected);
        }

        internal bool BorrarActividad(Actividad oActividadSelected)
        {
            return oActividadDao.Delete(oActividadSelected);
        }
    }
}
