using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class CursoDao
    {
        public IList<Curso> GetAll()
        {
            List<Curso> listadoCursos = new List<Curso>();

            String strSql = string.Concat(" SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.borrado as borrado, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        ca.id_categoria, ",
                                          "        ca.nombre as nombre_cat, ",
                                          "        ca.descripcion",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias ca ON (c.id_categoria=ca.id_categoria) WHERE c.borrado=0 ");

            //var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCursos.Add(ObjectMapping(row));
            }

            return listadoCursos;
        }

        public Curso GetUserConParametros(string nombreCurso)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.borrado as borrado, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        ca.id_categoria, ",
                                          "        ca.nombre as nombre_cat, ",
                                          "        ca.descripcion",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias ca ON (c.id_categoria=ca.id_categoria) WHERE c.borrado=0 AND c.nombre = @nombre");
                
                

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreCurso);
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

        public IList<Curso> GetByFiltersConParametros(Dictionary<string, object> parametros)
        {

            List<Curso> listadoCursos = new List<Curso>();
            String strSql = string.Concat(" SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.borrado as borrado, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        ca.id_categoria, ",
                                          "        ca.nombre as nombre_cat, ",
                                          "        ca.descripcion",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias ca ON (c.id_categoria=ca.id_categoria) WHERE c.borrado=0 ");


            if (parametros.ContainsKey("id_categoria"))
                strSql += " AND (c.id_categoria = @id_categoria) ";


            if (parametros.ContainsKey("curso"))
                strSql += " AND (c.nombre LIKE '%'" + "@nombre" + "'%') ";

            //var resultado = DBHelper.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                listadoCursos.Add(ObjectMapping(row));

            return listadoCursos;
        }

        public IList<Curso> GetByFiltersSinParametros(String condiciones)
        {

            List<Curso> lst = new List<Curso>();
            String strSql = string.Concat("  SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.borrado as borrado, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        ca.id_categoria, ",
                                          "        ca.nombre as nombre_cat, ",
                                          "        ca.descripcion",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias ca ON (c.id_categoria=ca.id_categoria) WHERE c.borrado=0");
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

        private Curso ObjectMapping(DataRow row)
        {
            Curso oCurso = new Curso
            {
                Id_curso = Convert.ToInt32(row["id_curso"].ToString()),
                Nombre = row["nombre"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString()),
                
                Descripcion = row["descripcion"].ToString(),
                Fecha_vigencia = Convert.ToDateTime(row["fecha_vigencia"]),
                Categoria = new Categoria()
                {
                    Id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    Nombre = row["nombre_cat"].ToString(),
                    Descripcion = row["descripcion"].ToString()
                }
            };

            return oCurso;
        }

        internal bool Create(Curso oCurso)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS
                //INSERT INTO Cursos VALUES (nombre, descripcion, fecha_vigencia, id_categoria, borrado)"

                string str_sql = "INSERT INTO Cursos (nombre, descripcion, fecha_vigencia, id_categoria, borrado)" +
                            " VALUES (" +
                            "'" + oCurso.Nombre + "'" + "," +
                            "'" + oCurso.Descripcion + "'" + "," +
                            "'" + oCurso.Fecha_vigencia + "'" + "," +
                            "'" + oCurso.Categoria.Id_categoria + "'" + "," +
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

        internal bool Update(Curso oCurso)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //"UPDATE Cursos SET c.nombre = '" + nombre + "', c.descripcion = '" + descrip + "', c.fecha_vigencia = '" + fecha + "', c.borrado = '" + borrado + "' WHERE c.id_curso = '" + id + "'"
                string str_sql = "UPDATE Cursos " +
                             "SET nombre =" + "'" + oCurso.Nombre + "'" + "," +
                             " descripcion =" + "'" + oCurso.Descripcion+ "'" + "," +
                             " fecha_vigencia =" + "'" + oCurso.Fecha_vigencia + "'" + "," +
                             " id_categoria=" + oCurso.Categoria.Id_categoria +
                             " WHERE  id_curso =" + oCurso.Id_curso + " AND  borrado=0";

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

        internal bool Delete(Curso oCurso)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Cursos " +
                             "SET borrado=1" +
                             " WHERE id_curso=" + oCurso.Id_curso + " AND  borrado=0";

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
