using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    // Comentario Candela Perez
    public partial class frmLogin : Form
    {

        // Intento N2 FC
        string user = "admin";
        string pass = "1234";
        public frmLogin()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string msj = "";
            if (this.txtUsuario.Text == string.Empty)
            {
                msj = "Debe ingresar su Usuario";
                MessageBox.Show(msj,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                msj = "Debe ingresar su Clave";
                MessageBox.Show(msj, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtClave.Focus();
                return;
            }

            // Validar Usuario y Clave //

            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
            {
                msj = "Logueado con Exito";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = "Usuario y/o Clave Incorrecta";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
    }
}
