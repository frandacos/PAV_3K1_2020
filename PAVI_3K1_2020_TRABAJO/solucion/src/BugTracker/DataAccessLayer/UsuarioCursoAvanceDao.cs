using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace BugTracker.DataAccessLayer
{
    class UsuarioCursoAvanceDao
    {
        public UsuarioCursoAvance GetUserConParametros(int idCurso, int idUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.

            String strSql = string.Concat(" SELECT A.nombre, ",
                                          "        A.descripcion ",
                                          "   FROM UsuariosCursoAvance UCA",
                                          "   INNER JOIN Actividades A ON (UCA.id_actividad = A.id_actividad) WHERE (UCA.id_usuario = @idUsuario) AND (UCA.id_curso = @idCurso) AND (UCA.borrado = 0) ");

            var parametros = new Dictionary<string, object>();
            parametros.Add("idCurso", idCurso);
            parametros.Add("idUsuario", idUsuario);

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

        public IList<UsuarioCursoAvance> GetByFiltersSinParametros(String condiciones)
        {
            List<UsuarioCursoAvance> lst = new List<UsuarioCursoAvance>();

            String strSql = "SELECT UCA.id_usuario, " +
                " U.usuario as Nombre_usuario, "+
                " UCA.id_curso," +
                " C.nombre as Nombre_curso," +
                " UCA.id_actividad," +
                " A.nombre as Nombre_actividad," +
                " A.descripcion as Descripcion_actividad , " +
                " UCA.fin," +
                " UCA.porc_avance," +
                " UCA.finalizado," +
                " UCA.borrado" +
                " FROM UsuariosCursoAvance UCA INNER JOIN Usuarios U ON (UCA.id_usuario=U.id_usuario) " +
                " INNER JOIN Cursos C ON (UCA.id_curso = C.id_curso)" +
                " INNER JOIN Actividades A ON (UCA.id_actividad = A.id_actividad)" +
                " WHERE UCA.borrado=0";



            //agrego condiciones
            strSql += condiciones;
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        private UsuarioCursoAvance ObjectMapping(DataRow row)
        {
            UsuarioCursoAvance oUsuarioCursoAvance = new UsuarioCursoAvance
            {
                Usuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    NombreUsuario = row["Nombre_usuario"].ToString()
                },
                Curso = new Curso()
                {
                    Id_curso = Convert.ToInt32(row["id_curso"].ToString()),
                    Nombre = row["Nombre_curso"].ToString()
                },

                Actividad = new Actividad()
                {
                    Id_actividad = Convert.ToInt32(row["id_actividad"].ToString()),
                    Nombre = row["Nombre_actividad"].ToString(),
                    Descripcion = row["Descripcion_actividad"].ToString()
                },
             
                Finalizado = Convert.ToBoolean(row["finalizado"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };
            return oUsuarioCursoAvance;
        }

        internal bool UpdateActividad(int id_usuario, int id_curso, int id_actividad)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();


                string str_sql = "UPDATE UsuariosCursoAvance" +
                                " SET " +
                                " finalizado = 1" +
                                " WHERE id_usuario=" + id_usuario + " AND id_curso=" + id_curso + " AND id_actividad =" + id_actividad + "AND borrado=0";
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


    }

}