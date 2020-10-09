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
        private UsuarioCursoAvance oUsuarioCursoAvanceSelected;
       
       
        public frmUsuarioCursoAvance()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();

        }
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
            dgvUsuarioCursoAvance.Columns[0].Name = "Actividades";
            dgvUsuarioCursoAvance.Columns[0].DataPropertyName = "Actividad";
            // Definimos el ancho de la columna.;
            dgvUsuarioCursoAvance.Columns[1].Name = "Borrado";
            dgvUsuarioCursoAvance.Columns[1].DataPropertyName = "borrado";

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
            btnNuevo.Enabled = true;
            String condiciones = "";
            condiciones += " AND UCA.id_curso=" + idCurso;
            condiciones += " AND UCA.id_usuario=" + idUsuario;

            dgvUsuarioCursoAvance.DataSource = oUsuarioCursoAvanceService.ConsultarConFiltrosSinParametros(condiciones);

            int filas_totales = dgvUsuarioCursoAvance.RowCount;
            int count = 0;
            for (int fila = 0; fila < filas_totales ; fila++)
            {

                if (dgvUsuarioCursoAvance.Rows[fila].Cells[2].Value is true)
                {
                    count += 1;
                }
            }
            int filas_true = count;
            decimal total;
            if (filas_totales == 0)
            {
                total = 0;
            }
            else
            {
                total = (filas_true * 100) / filas_totales;
            }
            
            label2.Text = Convert.ToString(total) + '%';

            int total2 = Convert.ToInt32(total);
            pbrPorcentaje.Value = total2;
            //oUsuarioCursoAvanceService.ActividadesRealizadas();

            if ((filas_totales == filas_true) && (filas_totales != 0))
            {
                oUsuarioCursoAvanceService.ActualizarFechaFin(idCurso,idUsuario);
                MessageBox.Show("Curso finalizado con exito!");
                this.Close();
            }
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

            var id_usuario = actividad.Usuario.IdUsuario;
            var id_curso = actividad.Curso.Id_curso;
            var id_actividad = actividad.Actividad.Id_actividad;
            oUsuarioCursoAvanceService.ActualizarActUsuarioCursoAvance(id_usuario, id_curso, id_actividad);
            
            frmUsuarioCursoAvance_Load(sender, e);
            btnNuevo.Enabled = true;
            

            //oUsuarioCursoAvance.Fin = DateTime.Today;

            //oUsuarioCursoAvanceService.ActualizarUsuarioCursoAvance(oUsuarioCursoAvance);

        }

       

        private void dgvUsuarioCursoAvance_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarioCursoAvance_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Si" : "No";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
