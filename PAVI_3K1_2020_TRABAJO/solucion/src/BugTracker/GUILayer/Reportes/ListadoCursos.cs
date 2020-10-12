using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.Reportes
{
    public partial class ListadoCursos : Form
    {
        public ListadoCursos()
        {
            InitializeComponent();
        }

        private void ListadoCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dataSet1.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.dataSet1.Cursos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
