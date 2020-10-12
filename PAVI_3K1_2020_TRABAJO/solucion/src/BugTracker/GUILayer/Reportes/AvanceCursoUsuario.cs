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
    public partial class AvanceCursoUsuario : Form
    {
        public int idCurso;
        public int idUsuario;
        public AvanceCursoUsuario(int idCurso,int idUsuario)
        {
            InitializeComponent();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
        }

        private void AvanceCursoUsuario_Load(object sender, EventArgs e)
        {
            this.avanceTableAdapter.Fill(this.dataSet1.Avance,idUsuario,idCurso);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
