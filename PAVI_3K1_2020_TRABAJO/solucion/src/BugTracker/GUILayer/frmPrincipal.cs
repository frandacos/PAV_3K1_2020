using BugTracker.Cursos;
using BugTracker.GUILayer.Usuarios;
using BugTracker.GUILayer.Objetivos;
using BugTracker.GUILayer.Categorias;
using BugTracker.GUILayer.Actividades;
using BugTracker.GUILayer.Usuarios_Curso;
using BugTracker.GUILayer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            lblUsuarioLogueado.Text = login.UsuarioLogueado;
     
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioCurso frmUsCurso = new frmUsuarioCurso();
            frmUsCurso.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarProgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProgreso frmDetalle = new frmConsultarProgreso();
            frmDetalle.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios frmDetalle = new frmUsuarios();
            frmDetalle.ShowDialog();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCursos frmDetalle = new frmCursos();
            frmDetalle.ShowDialog();
        }

        private void actividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmActividades frmDetalle = new frmActividades();
            frmDetalle.ShowDialog();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategorias frmDetalle = new frmCategorias();
            frmDetalle.ShowDialog();
        }

        private void objetivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmObjetivos frmDetalle = new frmObjetivos();
            frmDetalle.ShowDialog();
        }

        private void listaDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCursos listado = new ListadoCursos();
            listado.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoUsuarios listado = new ListadoUsuarios();
            listado.ShowDialog();
        }
    }
    
}
