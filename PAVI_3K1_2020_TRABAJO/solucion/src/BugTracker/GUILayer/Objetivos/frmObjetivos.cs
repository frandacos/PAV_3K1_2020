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

namespace BugTracker.GUILayer.Objetivos
{
    public partial class frmObjetivos : Form
    {
        private ObjetivoService oObjetivoService;

        public frmObjetivos()
        {
            InitializeComponent();
            InitializeDataGridView();
            oObjetivoService = new ObjetivoService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmABMObjetivos formulario = new frmABMObjetivos();
            var objetivo = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
            formulario.SeleccionarObjetivo(frmABMObjetivos.FormMode.update, objetivo);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void frmObjetivos_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMObjetivos formulario = new frmABMObjetivos();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();
            //usa filters para pasar los parámetros
            //usa condiciones para no usar parámetros en la consulta

            if (!chkTodos.Checked)
            {
                // Validar si el textBox 'Nombre' esta vacio.
                if (txtNombre_corto.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("nombre_corto", txtNombre_corto.Text);
                    condiciones += " AND nombre_corto LIKE '%" + txtNombre_corto.Text + "%'";
                }

                if (txtNombre_largo.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("nombre_largo", txtNombre_largo.Text);
                    condiciones += " AND nombre_largo LIKE '%" + txtNombre_largo.Text + "%'";
                }

                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    MessageBox.Show("Condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvObjetivos.DataSource = oObjetivoService.ConsultarConFiltrosSinParametros(condiciones);

                    //CON PARAMETROS
                    //dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                //selecciono el checkbox(todos)
                dgvObjetivos.DataSource = oObjetivoService.ObtenerTodos();
        }

        private void dgvObjetivos_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            frmABMObjetivos formulario = new frmABMObjetivos();
            var objetivo = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
            formulario.SeleccionarObjetivo(frmABMObjetivos.FormMode.delete, objetivo);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvObjetivos.ColumnCount = 3;
            dgvObjetivos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvObjetivos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvObjetivos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvObjetivos.Columns[0].Name = "Nombre corto";
            dgvObjetivos.Columns[0].DataPropertyName = "Nombre_corto";
            dgvObjetivos.Columns[0].Width = 115;
            // Definimos el ancho de la columna.

            dgvObjetivos.Columns[1].Name = "Nombre largo";
            dgvObjetivos.Columns[1].DataPropertyName = "Nombre_largo";
            dgvObjetivos.Columns[1].Width = 115;

            dgvObjetivos.Columns[2].Name = "Descripcion";
            dgvObjetivos.Columns[2].DataPropertyName = "Descripcion";
            dgvObjetivos.Columns[2].Width = 300;

            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvObjetivos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvObjetivos.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre_corto.Enabled = false;
                txtNombre_largo.Enabled = false;
            }
            else
            {
                txtNombre_corto.Enabled = true;
                txtNombre_largo.Enabled = true;
            }
        }
    }
}
