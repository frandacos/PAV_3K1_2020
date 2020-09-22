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
    public partial class frmABMObjetivos : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ObjetivoService oObjetivoService;
        private Objetivo oObjetivoSelected;

        public frmABMObjetivos()
        {
            InitializeComponent();
            oObjetivoService = new ObjetivoService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMObjetivos_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Objetivo";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Objetivo";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtNombre_corto.Enabled = true;
                        txtNombre_largo.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Activar/Desactivar Objetivo";
                        txtNombre_corto.Enabled = false;
                        txtNombre_largo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        break;
                    }
            }
        }

        public void SeleccionarObjetivo(FormMode op, Objetivo objetivoSelected)
        {
            formMode = op;
            oObjetivoSelected = objetivoSelected;
        }

        private void MostrarDatos()
        {
            if (oObjetivoSelected != null)
            {
                txtNombre_corto.Text = oObjetivoSelected.Nombre_corto;
                txtNombre_largo.Text = oObjetivoSelected.Nombre_largo;
                txtDescripcion.Text = oObjetivoSelected.Descripcion;
            }
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre_corto.Text == string.Empty)
            {
                txtNombre_corto.BackColor = Color.Red;
                txtNombre_corto.Focus();
                return false;
            }
            else
                txtNombre_corto.BackColor = Color.White;

            if (txtNombre_largo.Text == string.Empty)
            {
                txtNombre_largo.BackColor = Color.Red;
                txtNombre_largo.Focus();
                return false;
            }
            else
                txtNombre_largo.BackColor = Color.White;

            return true;
        }

        private bool ExisteObjetivo()
        {
            return oObjetivoService.ObtenerObjetivo(txtNombre_largo.Text) != null;
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteObjetivo() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oObjetivo= new Objetivo();
                                oObjetivo.Nombre_corto = txtNombre_corto.Text;
                                oObjetivo.Nombre_largo = txtNombre_largo.Text;
                                oObjetivo.Descripcion = txtDescripcion.Text;

                                if (oObjetivoService.CrearObjetivo(oObjetivo))
                                {
                                    MessageBox.Show("Objetivo registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre largo de objetivo ya existente. Ingrese un nombre diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oObjetivoSelected.Nombre_corto = txtNombre_corto.Text;
                            oObjetivoSelected.Nombre_largo = txtNombre_largo.Text;
                            oObjetivoSelected.Descripcion = txtDescripcion.Text;

                            if (oObjetivoService.ActualizarObjetivo(oObjetivoSelected))
                            {
                                MessageBox.Show("Objetivo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el objetivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea activar/desactivar el objetivo seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            if (oObjetivoService.BorrarObjetivo(oObjetivoSelected))
                            {
                                MessageBox.Show("Usuario activado/desactivado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el objetivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_corto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
