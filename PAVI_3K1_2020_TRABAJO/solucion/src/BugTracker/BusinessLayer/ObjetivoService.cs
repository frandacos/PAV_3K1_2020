using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Entities;
using BugTracker.DataAccessLayer;

namespace BugTracker.BusinessLayer
{
    class ObjetivoService
    {
        private ObjetivoDao oObjetivoDao;
        public ObjetivoService()
        {
            oObjetivoDao = new ObjetivoDao();
        }
        public IList<Objetivo> ObtenerTodos()
        {
            return oObjetivoDao.GetAll();
        }

        internal bool CrearObjetivo(Objetivo oObjetivo)
        {
            return oObjetivoDao.Create(oObjetivo);
        }

        internal bool ActualizarObjetivo(Objetivo oObjetivoSelected)
        {
            return oObjetivoDao.Update(oObjetivoSelected);
        }

        internal bool BorrarObjetivo(Objetivo oObjetivoSelected)
        {
            return oObjetivoDao.Delete(oObjetivoSelected);
        }

        internal object ObtenerObjetivo(string objetivo)
        {
            //SIN PARAMETROS
            return oObjetivoDao.GetObjetivoSinParametros(objetivo);
        }

        internal IList<Objetivo> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oObjetivoDao.GetByFiltersSinParametros(condiciones);
        }

        internal IList<Objetivo> ConsultarConFiltrosConParametros(Dictionary<string, object> filtros)
        {
            return oObjetivoDao.GetByFiltersConParametros(filtros);
        }
    }
}
