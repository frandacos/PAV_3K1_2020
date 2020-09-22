using BugTracker.Cursos;
using BugTracker.GUILayer.Usuarios;
using BugTracker.GUILayer.Categorias;
using BugTracker.GUILayer.Usuarios_Curso;
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

        private void consultarBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBugs frmDetalle = new frmConsultaBugs();
            frmDetalle.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos frmDetalle = new frmCursos();
            frmDetalle.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmDetalle = new frmUsuarios();
            frmDetalle.ShowDialog();
        }

        private void usuariosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioCurso frmUsCurso = new frmUsuarioCurso();
            frmUsCurso.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frmDetalle = new frmCategorias();
            frmDetalle.ShowDialog();
        }
    }
    
}
