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

namespace BugTracker.GUILayer.Actividades
{
    public partial class frmABMActividad : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ActividadService oActividadService;
        private Actividad oActividadSelected;
        public frmABMActividad()
        {
            InitializeComponent();
            oActividadService = new ActividadService();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMActividad_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Actividad";
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
                case FormMode.update:
                    {
                        MostrarDatos();
                        this.Text = "Actualizar Actividad";
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Actividad";
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oActividadSelected != null)
            {
                txtNombre.Text = oActividadSelected.Nombre;
                txtDescripcion.Text = oActividadSelected.Descripcion;
            }
        }

        public void SeleccionarActividad(FormMode op, Actividad actividadSelected)
        {
            formMode = op;
            oActividadSelected = actividadSelected;
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

        private bool ExisteActividad()
        {
            return oActividadService.ObtenerActividad(txtNombre.Text) != null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (ExisteActividad() == false)
                        {

                            if (ValidarCampos())
                            {
                                var oActividad = new Actividad();
                                oActividad.Nombre = txtNombre.Text;
                                oActividad.Descripcion = txtDescripcion.Text;


                                if (oActividadService.CrearActividad(oActividad))
                                {
                                    MessageBox.Show("Actividad insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de actividad encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oActividadSelected.Nombre = txtNombre.Text;
                            oActividadSelected.Descripcion = txtDescripcion.Text;

                            if (oActividadService.ActualizarActividad(oActividadSelected))
                            {
                                MessageBox.Show("Actividad actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la actividad!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar la actividad seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oActividadService.BorrarActividad(oActividadSelected))
                            {
                                MessageBox.Show("Actividad Habilitada/Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la actividad!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }
    }
}
