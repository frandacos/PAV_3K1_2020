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

namespace BugTracker.GUILayer.Actividades
{
    public partial class frmActividades : Form
    {
        private ActividadService oActividadService;
        public frmActividades()
        {
            InitializeComponent();
            InitializeDataGridView();
            oActividadService = new ActividadService();
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
            dgvActividades.Columns[0].DataPropertyName = "id_actividad";
            dgvActividades.Columns[0].Width = 115;
            // Definimos el ancho de la columna.

            dgvActividades.Columns[1].Name = "Nombre";
            dgvActividades.Columns[1].DataPropertyName = "nombre";
            dgvActividades.Columns[1].Width = 115;

            dgvActividades.Columns[2].Name = "Descripcion";
            dgvActividades.Columns[2].DataPropertyName = "descripcion";
            dgvActividades.Columns[2].Width = 300;

            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvObjetivos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvObjetivos.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el textBox 'Nombre' esta vacio.
                if (txtNombreAct.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("ac.nombre", txtNombreAct.Text);
                    condiciones += " AND ac.nombre LIKE " + "'%" + txtNombreAct.Text + "%'";
                }

                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    MessageBox.Show("condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dgvActividades.DataSource = oActividadService.ConsultarConFiltrosSinParametros(condiciones);

                    //CON PARAMETROS
                    //dgvCursos.DataSource = oCursoService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                //selecciono el checkbox(todos)
                dgvActividades.DataSource = oActividadService.ObtenerTodos();

        }

        private void habilitar(bool x)
        {
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnQuitar.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMActividad formulario = new frmABMActividad();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
            //habilitar(false);
            //frmCategorias_Load_1(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMActividad formulario = new frmABMActividad();
            var actividad = (Actividad)dgvActividades.CurrentRow.DataBoundItem;
            formulario.SeleccionarActividad(frmABMActividad.FormMode.update, actividad);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
            //this.habilitar(false);
            //frmCursos_Load_1(sender, e);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            frmABMActividad formulario = new frmABMActividad();
            var actividad = (Actividad)dgvActividades.CurrentRow.DataBoundItem;
            formulario.SeleccionarActividad(frmABMActividad.FormMode.delete, actividad);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
            //frmCursos_Load_1(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombreAct.Enabled = false;
            }
            else
            {
                txtNombreAct.Enabled = true;
            }
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
