using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class UsuariosCursoDao
    {
        public IList<UsuariosCurso> GetAll()
        {
            List<UsuariosCurso> listadoUsuariosCurso = new List<UsuariosCurso>();

            String strSql = string.Concat(" SELECT UC.id_usuario, ",
                                          "        U.usuario as Nombre_usuario, ",
                                          "        UC.id_curso, ",
                                          "        C.nombre as Nombre_curso, ",
                                          "        UC.puntuacion, ",
                                          "        UC.observaciones, ",
                                          "        UC.fecha_inicio, ",
                                          "        UC.fecha_fin,",
                                          "        UC.borrado",
                                          "   FROM UsuariosCurso UC",
                                          "   INNER JOIN Usuarios U ON (UC.id_usuario = U.id_usuario) INNER JOIN Cursos C ON(UC.id_curso = C.id_curso) WHERE UC.borrado=0 ");

            //var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuariosCurso.Add(ObjectMapping(row));
            }

            return listadoUsuariosCurso;
        }

        private UsuariosCurso ObjectMapping(DataRow row)
        {
            UsuariosCurso oUsuariosCurso = new UsuariosCurso
            {                
                Puntuacion = Convert.ToInt32(row["puntuacion"].ToString()),
                Observaciones = row["observaciones"].ToString(),
                Fecha_inicio = Convert.ToDateTime(row["fecha_inicio"]),
                Fecha_fin = DateTime.Now,
                Borrado = Convert.ToBoolean(row["borrado"].ToString()),
                Usuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    NombreUsuario = row["Nombre_usuario"].ToString()
                },
                Curso = new Curso()
                {
                    Id_curso = Convert.ToInt32(row["id_curso"].ToString()),
                    Nombre = row["Nombre_curso"].ToString()
                }

            };
            return oUsuariosCurso;
        }

        public UsuariosCurso GetUserConParametros(string curso, string usuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT UC.id_usuario, ",
                                          "        U.usuario as Nombre_usuario, ",
                                          "        UC.id_curso, ",
                                          "        C.nombre as Nombre_curso, ",
                                          "        UC.puntuacion, ",
                                          "        UC.observaciones, ",
                                          "        UC.fecha_inicio, ",
                                          "        UC.fecha_fin,",
                                          "        UC.borrado ",
                                          "   FROM UsuariosCurso UC",
                                          "   INNER JOIN Usuarios U ON (UC.id_usuario = U.id_usuario) INNER JOIN Cursos C ON(UC.id_curso = C.id_curso) WHERE UC.borrado=0  AND UC.id_curso = @curso AND UC.id_usuario = @usuario");



            var parametros = new Dictionary<string, object>();
            parametros.Add("curso", curso);
            parametros.Add("usuario", usuario);
   
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

        public IList<UsuariosCurso> GetByFiltersConParametros(Dictionary<string, object> parametros)
        {

            List<UsuariosCurso> listadoUsuariosCursos = new List<UsuariosCurso>();
            String strSql = string.Concat(" SELECT UC.id_usuario, ",
                                          "        U.usuario as Nombre_usuario, ",
                                          "        UC.id_curso, ",
                                          "        C.nombre as Nombre_curso, ",
                                          "        UC.puntuacion, ",
                                          "        UC.observaciones, ",
                                          "        UC.fecha_inicio, ",
                                          "        UC.fecha_fin,",
                                          "        UC.borrado",
                                          "   FROM UsuariosCurso UC",
                                          "   INNER JOIN Usuarios U ON (UC.id_usuario = U.id_usuario) INNER JOIN Cursos C ON(UC.id_curso = C.id_curso) WHERE UC.borrado=0 ");


            if (parametros.ContainsKey("usuario"))
                strSql += " AND (UC.id_usuario = @usuario) ";


            if (parametros.ContainsKey("curso"))
                strSql += " AND (UC.id_curso= @curso ";

            //var resultado = DBHelper.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                listadoUsuariosCursos.Add(ObjectMapping(row));

            return listadoUsuariosCursos;
        }

        public IList<UsuariosCurso> GetByFiltersSinParametros(String condiciones)
        {

            List<UsuariosCurso> lst = new List<UsuariosCurso>();
            String strSql = string.Concat("  SELECT UC.id_usuario, ",
                                          "        U.usuario as Nombre_usuario, ",
                                          "        UC.id_curso, ",
                                          "        C.nombre as Nombre_curso, ",
                                          "        UC.puntuacion, ",
                                          "        UC.observaciones, ",
                                          "        UC.fecha_inicio, ",
                                          "        UC.fecha_fin,",
                                          "        UC.borrado",
                                          "   FROM UsuariosCurso UC",
                                          "   INNER JOIN Usuarios U ON (UC.id_usuario = U.id_usuario) INNER JOIN Cursos C ON(UC.id_curso = C.id_curso) WHERE UC.borrado=0 ");
            //agrego condiciones
            strSql += condiciones;
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        internal bool Create(UsuariosCurso oUsuariosCurso)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string str_sql = "INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones,fecha_inicio,fecha_fin, borrado)" +
                            " VALUES (" +
                                 "'" + oUsuariosCurso.Usuario.IdUsuario + "',"
                               + "'" + oUsuariosCurso.Curso.Id_curso + "',"
                               + "'" + oUsuariosCurso.Puntuacion + "',"
                               + "'" + oUsuariosCurso.Observaciones + "'" + ","
                               + "'" + oUsuariosCurso.Fecha_inicio.ToString("yyyy-MM-dd") + "',"
                               + "NULL, 0) ";


                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);
                dm.EjecutarSQL(str_sql);

                string sql = "INSERT INTO UsuariosCursoAvance (id_usuario, id_curso, id_actividad, porc_avance, finalizado, borrado) " +
                             " SELECT uc.id_usuario, uc.id_curso, ac.id_actividad, ac.porc_de_avance, ac.borrado , ac.borrado" +
                             " FROM UsuariosCurso uc INNER JOIN ActividadesXCurso ac ON " +
                             " (uc.id_curso=ac.id_curso)" +
                             " WHERE uc.id_usuario =" + oUsuariosCurso.Usuario.IdUsuario +
                             " AND uc.id_curso =" + oUsuariosCurso.Curso.Id_curso;

                dm.EjecutarSQL(sql);

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

        internal bool Update(UsuariosCurso oUsuariosCurso)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                
                string str_sql = "UPDATE UsuariosCurso" +
                                " SET "+
                                " puntuacion=" + "'" + oUsuariosCurso.Puntuacion + "'," +
                                " observaciones= " + "'" + oUsuariosCurso.Observaciones + "'," +
                                " fecha_inicio= " + "'" + oUsuariosCurso.Fecha_inicio.ToString("yyyy-MM-dd") + "'," +
                                " fecha_fin= " + "'" + oUsuariosCurso.Fecha_fin.ToString("yyyy-MM-dd") + "'" +
                                " WHERE id_usuario=" + oUsuariosCurso.Usuario.IdUsuario + " AND id_curso=" + oUsuariosCurso.Curso.Id_curso + " AND  borrado=0";

                dm.EjecutarSQL(str_sql);

                
                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);

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

        internal bool Delete(UsuariosCurso oUsuariosCurso)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE UsuariosCurso  " +
                             "SET borrado=1" +
                             " WHERE  id_curso =" + oUsuariosCurso.Curso.Id_curso + " AND id_usuario= " + oUsuariosCurso.Usuario.IdUsuario + " AND  borrado=0";

                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
                dm.EjecutarSQL(str_sql);

                string sql = "UPDATE UsuariosCursoAvance" +
                                " SET " +
                                " borrado = 1 " +
                                " WHERE id_usuario=" + oUsuariosCurso.Usuario.IdUsuario + " AND id_curso=" + oUsuariosCurso.Curso.Id_curso + " AND  borrado=0";

                dm.EjecutarSQL(sql);

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
