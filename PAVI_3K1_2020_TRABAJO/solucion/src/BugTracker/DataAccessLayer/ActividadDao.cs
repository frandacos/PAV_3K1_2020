using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class ActividadDao
    {
        public IList<Actividad> GetAll()
        {
            List<Actividad> listadoBugs = new List<Actividad>();

            var strSql = "SELECT ac.id_actividad, ac.nombre, ac.descripcion, ac.borrado FROM Actividades ac WHERE ac.borrado = 0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        public IList<Actividad> GetByFiltersSinParametros(String condiciones)
        {

            List<Actividad> lst = new List<Actividad>();
            //String strSql = string.Concat("  SELECT ca.id_categoria, ",
            //                              "        ca.nombre, ",
            //                              "        ca.descripcion, ",
            //                              "        ca.borrado, ",
            //                              "   FROM Categorias ca ",
            //                              "   WHERE ca.borrado=0 " );
            String strSql = ("SELECT ac.id_actividad, ac.nombre, ac.descripcion, ac.borrado FROM Actividades ac WHERE ac.borrado = 0");
            //agrego condiciones
            strSql += condiciones;


            // if (parametros.ContainsKey("idPerfil"))
            //   strSql += " AND (u.id_perfil = @idPerfil) ";


            // if (parametros.ContainsKey("usuario"))
            //    strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            //var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public Actividad GetUserConParametros(string nombreActividad)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT ac.id_actividad, ",
                                          "        ac.nombre, ",
                                          "        ac.descripcion, ",
                                          "        ac.borrado ",
                                          "   FROM Actividades ac",
                                          "  WHERE ac.borrado=0 AND ac.nombre = @nombre");



            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreActividad);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            //var resultado = DBHelper.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        private Actividad ObjectMapping(DataRow row)
        {
            Actividad oActividad = new Actividad
            {
                Id_actividad = Convert.ToInt32(row["id_actividad"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion1 = row["descripcion"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oActividad;
        }

        internal bool Create(Actividad oActividad)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS
                //INSERT INTO Cursos VALUES (nombre, descripcion, fecha_vigencia, id_categoria, borrado)"

                string str_sql = "INSERT INTO Actividades (nombre, descripcion, borrado)" +
                            " VALUES (" +
                            "'" + oActividad.Nombre + "'" + "," +
                            "'" + oActividad.Descripcion1 + "'" + "," +
                             "0)";


                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);
                dm.EjecutarSQL(str_sql);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        internal bool Update(Actividad oActividad)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Actividades " +
                             "SET nombre=" + "'" + oActividad.Nombre + "'" + "," +
                             " descripcion=" + "'" + oActividad.Descripcion1 + "'" +
                             " WHERE id_actividad=" + oActividad.Id_actividad + " AND  borrado=0";

                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);
                dm.EjecutarSQL(str_sql);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }
        internal bool Delete(Actividad oActividad)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Actividades " +
                             "SET borrado=1" +
                             " WHERE id_actividad=" + oActividad.Id_actividad + " AND  borrado=0";

                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
                dm.EjecutarSQL(str_sql);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

    }
}
