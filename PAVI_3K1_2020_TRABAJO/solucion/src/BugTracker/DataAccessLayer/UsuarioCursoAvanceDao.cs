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
        //public IList<UsuarioCursoAvance> GetByFiltersSinParametros(String condiciones)
        //{

        //    List<UsuarioCursoAvance> lst = new List<UsuarioCursoAvance>();
        //    String strSql = string.Concat("  SELECT 
        //                                  "   FROM UsuariosCurso UC",
        //                                  "   INNER JOIN Usuarios U ON (UC.id_usuario = U.id_usuario) INNER JOIN Cursos C ON(UC.id_curso = C.id_curso) WHERE UC.borrado=0 ");
        //    //agrego condiciones
        //    strSql += condiciones;
        //    DataManager dm = new DataManager();
        //    dm.Open();
        //    var resultado = dm.ConsultaSQL(strSql);

        //    foreach (DataRow row in resultado.Rows)
        //        lst.Add(ObjectMapping(row));

        //    return lst;
        //}

    }
}
