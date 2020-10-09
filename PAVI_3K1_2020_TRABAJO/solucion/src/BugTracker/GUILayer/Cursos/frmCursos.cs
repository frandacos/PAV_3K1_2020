using BugTracker.BusinessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.Cursos
{
    public partial class frmCursos : Form
    {
        private CursoService oCursoService;
        private CategoriaService oCategoriaService;

        
        public frmCursos()
        {
            InitializeComponent();
            InitializeDataGridView();
            oCursoService = new CursoService();
            oCategoriaService = new CategoriaService();
            
        }

        private void frmCursos_Load_1(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.CenterToParent();
            LlenarCombo(cboCategoria,oCategoriaService.ObtenerTodos(), "nombre", "id_categoria");
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void habilitar(bool x)
        {
            btnEditar.Enabled = x;
            btnQuitar.Enabled = x;
        }

       

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCursos.ColumnCount = 3;
            dgvCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvCursos.Columns[0].Name = "Nombre";
            dgvCursos.Columns[0].DataPropertyName = "Nombre";
            // Definimos el ancho de la columna.

            dgvCursos.Columns[1].Name = "Descripcion";
            dgvCursos.Columns[1].DataPropertyName = "Descripcion";

            dgvCursos.Columns[2].Name = "Categoria";
            dgvCursos.Columns[2].DataPropertyName = "Categoria";



            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();
            //usa filters para pasar los parámetros
            //usa condiciones para no usar parámetros en la consulta

            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Categoria' esta seleccionado.
                if (cboCategoria.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("c.id_categoria", cboCategoria.SelectedValue);
                    condiciones += " AND ca.id_categoria=" + cboCategoria.SelectedValue.ToString();

                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (txtNombre.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("c.nombre", txtNombre.Text);
                    condiciones += " AND c.nombre LIKE " + "'%" + txtNombre.Text + "%'";
                }

                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    MessageBox.Show("condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dgvCursos.DataSource = oCursoService.ConsultarConFiltrosSinParametros(condiciones);

                    //CON PARAMETROS
                    //dgvCursos.DataSource = oCursoService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //selecciono el checkbox(todos)
                dgvCursos.DataSource = oCursoService.ObtenerTodos();
                //habilitar(true);
            }

        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    txtNombre.Enabled = false;
                    cboCategoria.Enabled = false;
                }
                else
                {
                    txtNombre.Enabled = true;
                    cboCategoria.Enabled = true;
                }
            }

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmABMCurso formulario = new frmABMCurso();
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            habilitar(true);
            frmCursos_Load_1(sender,e);

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            frmABMCurso formulario = new frmABMCurso();
            var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            formulario.SeleccionarCurso(frmABMCurso.FormMode.update, curso);
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            this.habilitar(true);
            frmCursos_Load_1(sender, e);

        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            frmABMCurso formulario = new frmABMCurso();
            var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            formulario.SeleccionarCurso(frmABMCurso.FormMode.delete, curso);
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            frmCursos_Load_1(sender, e);

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCursos_CellContentClick(object sender, EventArgs e)
        {

        }

        
    }
}
