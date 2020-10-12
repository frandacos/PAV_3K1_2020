using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.BusinessLayer;

namespace BugTracker.GUILayer.Reportes
{
    public partial class ReporteUsuariosEnCurso : Form
    {
        public int idCurso;
        
        public ReporteUsuariosEnCurso(int idCurso)
        {
            this.idCurso = idCurso;
        
            InitializeComponent();
        }

        private void ReporteUsuariosEnCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            
            
            this.usuariosEnCursoTableAdapter.Fill(this.dataSet1.UsuariosEnCurso, idCurso);
            this.reportViewer1.RefreshReport();
        }
    }
}
