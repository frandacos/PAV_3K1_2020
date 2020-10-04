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

namespace BugTracker.GUILayer.Usuario_Curso_Avance
{ 
    public partial class frmUsuarioCursoAvance : Form
    {
       
        private UsuarioCursoAvanceService oUsuarioCursoAvanceService;
        private UsuarioCursoAvance oUsuarioCursoAvance;
        public int idCurso;
        public int idUsuario;

        public frmUsuarioCursoAvance(int idCurso, int idUsuario)
        {
            InitializeComponent();
            InitializeDataGridView();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();
            
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarioCursoAvance.ColumnCount = 3;
            dgvUsuarioCursoAvance.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarioCursoAvance.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarioCursoAvance.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCursoAvance.Columns[0].Name = "Actividad";
            dgvUsuarioCursoAvance.Columns[0].DataPropertyName = "Actividad";
            // Definimos el ancho de la columna.

            dgvUsuarioCursoAvance.Columns[1].Name = "Descripcion";
            dgvUsuarioCursoAvance.Columns[1].DataPropertyName = "Descripcion";

            dgvUsuarioCursoAvance.Columns[2].Name = "Finalizado";
            dgvUsuarioCursoAvance.Columns[2].DataPropertyName = "Finalizado";


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
            btnFinalizar.Enabled = false;
            btnNuevo.Enabled = true;
            String condiciones = "";
            condiciones += " AND UCA.id_curso=" + idCurso;
            condiciones += " AND UCA.id_usuario=" + idUsuario;

            dgvUsuarioCursoAvance.DataSource = oUsuarioCursoAvanceService.ConsultarConFiltrosSinParametros(condiciones);

            
        }

        private void pgreBar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var actividad = (UsuarioCursoAvance)dgvUsuarioCursoAvance.CurrentRow.DataBoundItem;
            btnNuevo.Enabled = false;
            btnFinalizar.Enabled = true;
            btnFinalizar.Focus();
            //dgvUsuarioCursoAvance.CurrentRow.DefaultCellStyle.BackColor = Color.Aquamarine;
            //oUsuarioCursoAvance.Fin = DateTime.Today;

            //oUsuarioCursoAvanceService.ActualizarUsuarioCursoAvance(oUsuarioCursoAvance);

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnFinalizar.Enabled = false;
            btnNuevo.Focus();

        }
    }
}
