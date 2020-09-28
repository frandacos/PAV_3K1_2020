using BugTracker.BusinessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BugTracker.GUILayer.Usuarios_Curso;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.UsuarioCursoAvance
{ 
    public partial class frmUsuarioCursoAvance : Form
    {
        private CursoService oCursoService;
        private UsuarioService oUsuarioService;
        private ActividadService oActividadService;
        private UsuarioCursoAvanceService oUsuarioCursoAvanceService;
        public int idCurso;
        public int idUsuario;


        public frmUsuarioCursoAvance()
        {
            InitializeComponent();
            InitializeDataGridView();
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
            oActividadService = new ActividadService();
        }

        public frmUsuarioCursoAvance(int idCurso, int idUsuario)
        {
            InitializeComponent();
            InitializeDataGridView();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
            oActividadService = new ActividadService();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarioCursoAvance.ColumnCount = 2;
            dgvUsuarioCursoAvance.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarioCursoAvance.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarioCursoAvance.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCursoAvance.Columns[0].Name = "Actividades";
            dgvUsuarioCursoAvance.Columns[0].DataPropertyName = "Actividades";
            // Definimos el ancho de la columna.

            dgvUsuarioCursoAvance.Columns[1].Name = "Descripcion";
            dgvUsuarioCursoAvance.Columns[1].DataPropertyName = "Descripcion";


            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvUsuarioCursoAvance.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsuarioCursoAvance.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void lblN_Curso_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioCurso_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarioCursoAvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuarioCursoAvance_Load(object sender, EventArgs e)
        {
            dgvUsuarioCursoAvance.DataSource = oUsuarioCursoAvanceService.ObtenerUsuariosCurso(idCurso,idUsuario);
        }

        private void pgreBar_Click(object sender, EventArgs e)
        {

        }
    }
}
