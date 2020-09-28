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
using BugTracker.Entities;

namespace BugTracker.GUILayer
{
    public partial class frmConsultarActividades : Form
    {
        private CursoService oCursoService;
        private UsuarioService oUsuarioService;
        private UsuariosCursoAvanceService oUsuariosCursoAvanceService;

        public frmConsultarActividades()
        {
            InitializeComponent();
            InitializeDataGridView();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
        }

        private void frmConsultarActividades_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            habilitar(true);
            LlenarCombo(cboCursos, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cboUsuarios, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
        }

        private void habilitar(bool x)
        {
            cboUsuarios.Enabled = x;
            cboCursos.Enabled = x;
            btnConsultar.Enabled = x;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvActividades.ColumnCount = 3;
            dgvActividades.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvActividades.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvActividades.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvActividades.Columns[0].Name = "Id Actividad";
            dgvActividades.Columns[0].DataPropertyName = "Id_actividad";
            
            // Definimos el ancho de la columna.

            dgvActividades.Columns[1].Name = "Nombre";
            dgvActividades.Columns[1].DataPropertyName = "Nombre";

            dgvActividades.Columns[2].Name = "% Avance";
            dgvActividades.Columns[2].DataPropertyName = "Porc_avance";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvActividades.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvActividades.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
