﻿using BugTracker.Cursos;
using BugTracker.GUILayer;
using BugTracker.GUILayer.Usuarios_Curso;
using BugTracker.GUILayer.Usuario_Curso_Avance;
using BugTracker.GUILayer.Categorias;
using BugTracker.GUILayer.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuramos el frmPrincipal para que inicie con la aplicacion.
            Application.Run(new frmPrincipal());
        }
    }
}
