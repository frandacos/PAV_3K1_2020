namespace BugTracker.GUILayer.Usuarios_Curso
{
    partial class frmUsuarioCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN_Curso = new System.Windows.Forms.Label();
            this.lblN_Usuario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dgvUsuarioCurso = new System.Windows.Forms.DataGridView();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.UsuarioCurso = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).BeginInit();
            this.UsuarioCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN_Curso
            // 
            this.lblN_Curso.AutoSize = true;
            this.lblN_Curso.Location = new System.Drawing.Point(90, 38);
            this.lblN_Curso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblN_Curso.Name = "lblN_Curso";
            this.lblN_Curso.Size = new System.Drawing.Size(158, 25);
            this.lblN_Curso.TabIndex = 0;
            this.lblN_Curso.Text = "Nombre curso: ";
            // 
            // lblN_Usuario
            // 
            this.lblN_Usuario.AutoSize = true;
            this.lblN_Usuario.Location = new System.Drawing.Point(74, 119);
            this.lblN_Usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblN_Usuario.Name = "lblN_Usuario";
            this.lblN_Usuario.Size = new System.Drawing.Size(176, 25);
            this.lblN_Usuario.TabIndex = 1;
            this.lblN_Usuario.Text = "Nombre usuario: ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(540, 179);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(182, 60);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(302, 179);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(104, 29);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // dgvUsuarioCurso
            // 
            this.dgvUsuarioCurso.AllowUserToAddRows = false;
            this.dgvUsuarioCurso.AllowUserToDeleteRows = false;
            this.dgvUsuarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCurso.Location = new System.Drawing.Point(46, 275);
            this.dgvUsuarioCurso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvUsuarioCurso.MultiSelect = false;
            this.dgvUsuarioCurso.Name = "dgvUsuarioCurso";
            this.dgvUsuarioCurso.ReadOnly = true;
            this.dgvUsuarioCurso.RowHeadersWidth = 82;
            this.dgvUsuarioCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioCurso.Size = new System.Drawing.Size(738, 331);
            this.dgvUsuarioCurso.TabIndex = 6;
            this.dgvUsuarioCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioCurso_CellContentClick);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(302, 104);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(416, 33);
            this.cboUsuario.TabIndex = 7;
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(302, 38);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(416, 33);
            this.cboCurso.TabIndex = 8;
            // 
            // UsuarioCurso
            // 
            this.UsuarioCurso.Controls.Add(this.cboCurso);
            this.UsuarioCurso.Controls.Add(this.cboUsuario);
            this.UsuarioCurso.Controls.Add(this.dgvUsuarioCurso);
            this.UsuarioCurso.Controls.Add(this.chkTodos);
            this.UsuarioCurso.Controls.Add(this.btnConsultar);
            this.UsuarioCurso.Controls.Add(this.lblN_Usuario);
            this.UsuarioCurso.Controls.Add(this.lblN_Curso);
            this.UsuarioCurso.Location = new System.Drawing.Point(22, 23);
            this.UsuarioCurso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UsuarioCurso.Name = "UsuarioCurso";
            this.UsuarioCurso.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UsuarioCurso.Size = new System.Drawing.Size(798, 631);
            this.UsuarioCurso.TabIndex = 9;
            this.UsuarioCurso.TabStop = false;
            this.UsuarioCurso.Text = "Filtros";
            this.UsuarioCurso.Enter += new System.EventHandler(this.UsuarioCurso_Enter);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::BugTracker.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(22, 665);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 77);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::BugTracker.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(118, 665);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 77);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Image = global::BugTracker.Properties.Resources.eliminar;
            this.btnQuitar.Location = new System.Drawing.Point(210, 665);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 77);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(740, 665);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 77);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 762);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.UsuarioCurso);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioCurso";
            this.Text = "frmUsuarioCurso";
            this.Load += new System.EventHandler(this.frmUsuarioCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).EndInit();
            this.UsuarioCurso.ResumeLayout(false);
            this.UsuarioCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblN_Curso;
        private System.Windows.Forms.Label lblN_Usuario;
        private System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridView dgvUsuarioCurso;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.GroupBox UsuarioCurso;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnSalir;
    }
}