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
using BugTracker.GUILayer.Usuario_Curso_Avance;

namespace BugTracker.GUILayer
{
    public partial class frmConsultarProgreso : Form
    {
        private CursoService oCursoService;
        private UsuarioService oUsuarioService;
        private ComboBox cboUsuarios;
        private ComboBox cboCursos;
        private Label lblUsuarios;
        private Label lblCurso;
        private Button btnConsultar;
        private UsuariosCursoService oUsuarioCursoService;





        public frmConsultarProgreso()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
            oUsuarioCursoService = new UsuariosCursoService();
        }

        private void frmConsultarActividades_Load_1(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            if (ExisteUsuarioEnCurso())
            {   
                frmUsuarioCursoAvance frmDetalle = new frmUsuarioCursoAvance((int)cboCursos.SelectedValue, (int)cboUsuarios.SelectedValue);
            
                frmDetalle.ShowDialog();

            }
            else
                MessageBox.Show("Relacion usuario-curso no encontrado!. Ingrese un nombre de usuario o curso diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private bool ExisteUsuarioEnCurso()
        {
            string usuario = cboUsuarios.SelectedValue.ToString();
            string curso = cboCursos.SelectedValue.ToString();

            return oUsuarioCursoService.ObtenerUsuariosCurso(curso, usuario) != null;
        }
        private void InitializeComponent()
        {
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(110, 54);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(157, 21);
            this.cboUsuarios.TabIndex = 0;
            // 
            // cboCursos
            // 
            this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(110, 102);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(157, 21);
            this.cboCursos.TabIndex = 1;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(61, 57);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "Usuario";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(61, 105);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(298, 57);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 61);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultarProgreso
            // 
            this.ClientSize = new System.Drawing.Size(448, 183);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.cboUsuarios);
            this.Name = "frmConsultarProgreso";
            this.Text = "Consultar Progreso";
            this.Load += new System.EventHandler(this.frmConsultarActividades_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
