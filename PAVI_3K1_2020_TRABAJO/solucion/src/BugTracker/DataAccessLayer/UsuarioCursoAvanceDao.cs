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

        private UsuarioCursoAvance ObjectMapping(DataRow row)
        {
            UsuarioCursoAvance oUsuarioCursoAvance = new UsuarioCursoAvance
            {
                Actividad = new Actividad()
                {
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString()
                },
            };
            return oUsuarioCursoAvance;
        }
    }
}
