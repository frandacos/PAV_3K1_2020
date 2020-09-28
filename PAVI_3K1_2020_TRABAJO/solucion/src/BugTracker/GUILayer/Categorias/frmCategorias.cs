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
            oCursoService = new CursoService();
            oCategoriaService = new CategoriaService();
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
                //selecciono el checkbox(todos)
                dgvCategorias.DataSource = oCategoriaService.ObtenerTodos();

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

        private void habilitar(bool x)
        {
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnQuitar.Enabled = !x;
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
    }


}
