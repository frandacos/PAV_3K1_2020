using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using BugTracker.Entities;
using System.Data;
using System.Data.SqlClient;

namespace BugTracker.DataAccessLayer
{
    public class ObjetivoDao
    {
        public IList<Objetivo> GetAll()
        {
            List<Objetivo> listadoUsuarios = new List<Objetivo>();

            String strSql = string.Concat(" SELECT id_objetivo, ",
                                          " nombre_corto, ",
                                          " nombre_largo, ",
                                          " descripcion, ",
                                          " borrado ",
                                          " FROM Objetivos ",
                                          " WHERE borrado=0 ");
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }

            return listadoUsuarios;
        }

        public Objetivo GetObjetivoConParametros(string nombre_largo)
        {
            //Construimos la consulta sql para buscar el objetivo en la base de datos.
            String strSql = string.Concat(" SELECT id_objetivo, ",
                                          "        nombre_corto, ",
                                          "        nombre_largo, ",
                                          "        descripcion ",
                                          "   FROM Objetivos ",
                                          "  WHERE nombre_largo =  @nombre_largo AND borrado = 0 ");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre_largo", nombre_largo);
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

        public Objetivo GetObjetivoSinParametros(string nombre_largo)
        {
            //Construimos la consulta sql para buscar el objetivo en la base de datos.
            String strSql = string.Concat(" SELECT id_objetivo, ",
                                          "        nombre_corto, ",
                                          "        nombre_largo, ",
                                          "        descripcion, ",
                                          "        borrado ",
                                          "   FROM Objetivos ",
                                          "  WHERE borrado = 0 ");

            strSql += " AND nombre_largo = " + "'" + nombre_largo + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            // var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Objetivo> GetByFiltersConParametros(Dictionary<string, object> parametros)
        {

            List<Objetivo> lst = new List<Objetivo>();
            String strSql = string.Concat(" SELECT id_objetivo, ",
                                              "        nombre_corto, ",
                                              "        nombre_largo, ",
                                              "        descripcion, ",
                                              "        borrado ",
                                              "   FROM Objetivos ",
                                              "  WHERE borrado = 0 ");


            if (parametros.ContainsKey("id_objetivo"))
                strSql += " AND (u.id_objetivo = @id_objetivo) ";


            if (parametros.ContainsKey("nombre_largo"))
                strSql += " AND (nombre_largo LIKE '%' + @nombre_largo + '%') ";

            //var resultado = DBHelper.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public IList<Objetivo> GetByFiltersSinParametros(String condiciones)
        {

            List<Objetivo> lst = new List<Objetivo>();
            String strSql = string.Concat(" SELECT id_objetivo, ",
                                              "        nombre_corto, ",
                                              "        nombre_largo, ",
                                              "        descripcion, ",
                                              "        borrado ",
                                              "   FROM Objetivos ",
                                              "  WHERE borrado = 0 ");
            //agrego condiciones
            strSql += condiciones;

            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        internal bool Create(Objetivo oObjetivo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Objetivos (nombre_corto, nombre_largo, descripcion, borrado)" +
                            " VALUES (" +
                            "'" + oObjetivo.Nombre_corto + "', " +
                            "'" + oObjetivo.Nombre_largo + "', " +
                            "'" + oObjetivo.Descripcion + "', 0)";
                            


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

        internal bool Update(Objetivo oObjetivo)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Objetivos " +
                             "SET nombre_corto = " + "'" + oObjetivo.Nombre_corto + "'" + "," +
                             " nombre_largo = " + "'" + oObjetivo.Nombre_largo + "'" + "," +
                             " descripcion = " + "'" + oObjetivo.Descripcion + "'" +
                             " WHERE id_objetivo = " + oObjetivo.Id_objetivo + " AND  borrado = 0";

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

        internal bool Delete(Objetivo oObjetivo)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Objetivos " +
                             "SET borrado = 1" +
                             " WHERE id_objetivo = " + oObjetivo.Id_objetivo + " AND borrado = 0";

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


        private Objetivo ObjectMapping(DataRow row)
        {
            Objetivo oObjetivo = new Objetivo
            {
                Id_objetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                Nombre_corto = row["nombre_corto"].ToString(),
                Nombre_largo = row["nombre_largo"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString()),
            };
            
            return oObjetivo;
        }
    }
}
