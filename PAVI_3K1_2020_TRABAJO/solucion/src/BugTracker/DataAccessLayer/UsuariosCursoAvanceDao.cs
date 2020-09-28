using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class UsuariosCursoAvanceDao
    {
        public IList<UsuariosCursoAvance> GetAll()
        {
            List<UsuariosCursoAvance> listadoUsuariosCursoAvance = new List<UsuariosCursoAvance>();

            String strSql = string.Concat(" SELECT uca.id_usuario, ",
                                          "        u.usuario,",
                                          "        uca.id_curso, ",
                                          "        c.nombre, ",
                                          "        uca.id_actividad, ",
                                          "        a.nombre, ",
                                          "        uca.fin, ",
                                          "        uca.porc_avance, ",
                                          "        uca.borrado,",
                                          "   FROM UsuariosCursoAvance uca",
                                          "   INNER JOIN Usuarios u ON (uca.id_usuario = u.id_usuario) " +
                                          "   INNER JOIN Cursos c ON(uca.id_curso = c.id_curso) " +
                                          "   INNER JOIN Actividades a ON (uca.id_actividad = a.id_actividad) WHERE UC.borrado=0 ");

            //var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuariosCursoAvance.Add(ObjectMapping(row));
            }

            return listadoUsuariosCursoAvance;
        }

        private UsuariosCursoAvance ObjectMapping(DataRow row)
        {
            UsuariosCursoAvance oUsuariosCursoAvance = new UsuariosCursoAvance
            {
                Porc_avance = Convert.ToInt32(row["porc_avance"].ToString()),
                Fin = Convert.ToDateTime(row["fin"]),
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
            return oUsuariosCursoAvance;
        }
    }
}
