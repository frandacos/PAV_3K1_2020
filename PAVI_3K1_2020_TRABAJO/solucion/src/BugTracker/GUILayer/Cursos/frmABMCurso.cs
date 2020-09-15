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
    public partial class frmABMCurso : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly CursoService oCursoService;
        private readonly CategoriaService oCategoriaService;
        private Curso oCursoSelected;

        public frmABMCurso()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oCategoriaService = new CategoriaService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void frmABMCurso_Load(object sender, EventArgs e)
        {
            
            LlenarCombo(cboCategoria,oCategoriaService.ObtenerTodos(), "Nombre", "Id_categoria");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Curso";
                        txtIdCurso.Enabled = false;
                        txtNombre.Enabled = true;
                        cboCategoria.Enabled = true;
                        dtpFechaVigencia.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Curso";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        
                        txtIdCurso.Enabled = false;
                        txtNombre.Enabled = true;
                        cboCategoria.Enabled = true;
                        dtpFechaVigencia.Enabled = true;
                        txtDescripcion.Enabled = true;
              

                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Curso";
                        txtIdCurso.Enabled = false;
                        txtNombre.Enabled = false;
                        cboCategoria.Enabled = false;
                        dtpFechaVigencia.Enabled = false;
                        txtDescripcion.Enabled = false;

                        break;
                    }
            }
        }
        public void SeleccionarCurso(FormMode op, Curso cursoSelected)
        {
            formMode = op;
            oCursoSelected = cursoSelected;
        }

        private void MostrarDatos()
        {
            if (oCursoSelected != null)
            {
                txtNombre.Text = oCursoSelected.Nombre;
                txtDescripcion.Text = oCursoSelected.Descripcion;
                txtIdCurso.Text = oCursoSelected.Id_curso.ToString();
                cboCategoria.Text = oCursoSelected.Categoria.Nombre;
                dtpFechaVigencia.Value = oCursoSelected.Fecha_vigencia;

            }
        }
        

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
        }

        private bool ExisteCurso()
        {
            return oCursoService.ObtenerCurso(txtNombre.Text) != null;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

       

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (ExisteCurso() == false)
                        {
                            
                            if (ValidarCampos())
                            {
                                var oCurso = new Curso();
                                oCurso.Nombre = txtNombre.Text;
                                oCurso.Categoria = new Categoria();
                                oCurso.Categoria.Id_categoria = (int)cboCategoria.SelectedValue;
                                oCurso.Fecha_vigencia = dtpFechaVigencia.Value;
                                oCurso.Descripcion = txtDescripcion.Text;
                                
                                
                                if (oCursoService.CrearCurso(oCurso))
                                {
                                    MessageBox.Show("Curso insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de curso encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oCursoSelected.Id_curso = int.Parse(txtIdCurso.Text);
                            oCursoSelected.Nombre = txtNombre.Text;
                            oCursoSelected.Categoria = new Categoria();
                            oCursoSelected.Categoria.Id_categoria = (int)cboCategoria.SelectedValue;
                            oCursoSelected.Fecha_vigencia = dtpFechaVigencia.Value;
                            oCursoSelected.Descripcion = txtDescripcion.Text;
                           
                            if (oCursoService.ActualizarCurso(oCursoSelected))
                            {
                                MessageBox.Show("Curso actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el curso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oCursoService.BorrarCurso(oCursoSelected))
                            {
                                MessageBox.Show("Curso Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
