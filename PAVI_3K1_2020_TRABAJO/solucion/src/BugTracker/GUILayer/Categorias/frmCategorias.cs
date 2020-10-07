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

namespace BugTracker.GUILayer.Categorias
{
    public partial class frmCategorias : Form
    {
        private CursoService oCursoService;
        private CategoriaService oCategoriaService;
        public frmCategorias()
        {
            InitializeComponent();
            InitializeDataGridView();
            oCursoService = new CursoService();
            oCategoriaService = new CategoriaService();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCategorias.ColumnCount = 3;
            dgvCategorias.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCategorias.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvCategorias.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvCategorias.Columns[0].Name = "Id Categoria";
            dgvCategorias.Columns[0].DataPropertyName = "id_categoria";
            dgvCategorias.Columns[0].Width = 115;
            // Definimos el ancho de la columna.

            dgvCategorias.Columns[1].Name = "Nombre";
            dgvCategorias.Columns[1].DataPropertyName = "nombre";
            dgvCategorias.Columns[1].Width = 115;

            dgvCategorias.Columns[2].Name = "Descripcion";
            dgvCategorias.Columns[2].DataPropertyName = "descripcion";
            dgvCategorias.Columns[2].Width = 300;

            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvObjetivos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvObjetivos.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el textBox 'Nombre' esta vacio.
                if (txtNombreCat.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("ca.nombre", txtNombreCat.Text);
                    condiciones += " AND ca.nombre LIKE " + "'%" + txtNombreCat.Text + "%'";
                }

                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    MessageBox.Show("condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dgvCategorias.DataSource = oCategoriaService.ConsultarConFiltrosSinParametros(condiciones);

                    //CON PARAMETROS
                    //dgvCursos.DataSource = oCursoService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //selecciono el checkbox(todos)
                dgvCategorias.DataSource = oCategoriaService.ObtenerTodos();
                habilitar();
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmABMCategoria formulario = new frmABMCategoria();
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            //habilitar(false);
            //frmCategorias_Load_1(sender, e);
        }

        private void habilitar()
        {
            btnEditar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void frmCategorias_Load_1(object sender, EventArgs e)
        {
            //this.habilitar(false);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            frmABMCategoria formulario = new frmABMCategoria();
            var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            formulario.SeleccionarCategoria(frmABMCategoria.FormMode.update, categoria);
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            //this.habilitar(false);
            //frmCursos_Load_1(sender, e);
        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    txtNombreCat.Enabled = false;

                }
                else
                {
                    txtNombreCat.Enabled = true;
                    ;
                }
            }
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            frmABMCategoria formulario = new frmABMCategoria();
            var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            formulario.SeleccionarCategoria(frmABMCategoria.FormMode.delete, categoria);
            formulario.ShowDialog();
            btnConsultar_Click_1(sender, e);
            //frmCursos_Load_1(sender, e);
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnQuitar.Enabled = false;
        }
    }


}
