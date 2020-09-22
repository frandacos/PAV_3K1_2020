using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class CategoriaDao
    {
        public IList<Categoria> GetAll()
        {
            List<Categoria> listadoBugs = new List<Categoria>();

            var strSql = "SELECT ca.id_categoria, ca.nombre, ca.descripcion, ca.borrado FROM Categorias ca WHERE ca.borrado = 0 ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        public IList<Categoria> GetByFiltersSinParametros(String condiciones)
        {

            List<Categoria> lst = new List<Categoria>();
            //String strSql = string.Concat("  SELECT ca.id_categoria, ",
            //                              "        ca.nombre, ",
            //                              "        ca.descripcion, ",
            //                              "        ca.borrado, ",
            //                              "   FROM Categorias ca ",
            //                              "   WHERE ca.borrado=0 " );
            String strSql = ("SELECT ca.id_categoria, ca.nombre, ca.descripcion, ca.borrado FROM Categorias ca WHERE ca.borrado=0 ");
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

        public Categoria GetUserConParametros(string nombreCategoria)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT c.id_categoria, ",
                                          "        c.nombre, ",
                                          "        c.descripcion, ",
                                          "        c.borrado ",
                                          "   FROM Categorias c",
                                          "  WHERE c.borrado=0 AND c.nombre = @nombre");



            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreCategoria);
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

        private Categoria ObjectMapping(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                Id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oCategoria;
        }

        internal bool Create(Categoria oCategoria)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS
                //INSERT INTO Cursos VALUES (nombre, descripcion, fecha_vigencia, id_categoria, borrado)"

                string str_sql = "INSERT INTO Categorias (nombre, descripcion, borrado)" +
                            " VALUES (" +
                            "'" + oCategoria.Nombre + "'" + "," +
                            "'" + oCategoria.Descripcion + "'" + "," +
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

        internal bool Update(Categoria oCategoria)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Categorias " +
                             "SET nombre=" + "'" + oCategoria.Nombre + "'" + "," +
                             " descripcion=" + "'" + oCategoria.Descripcion + "'" +
                             " WHERE id_categoria=" + oCategoria.Id_categoria + " AND  borrado=0";

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

        internal bool Delete(Categoria oCategoria)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Categorias " +
                             "SET borrado=1" +
                             " WHERE id_categoria=" + oCategoria.Id_categoria + " AND  borrado=0";

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