namespace BugTracker.GUILayer.UsuarioCursoAvance
{
    partial class frmUsuarioCursoAvance
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.UsuarioCurso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgreBar = new System.Windows.Forms.ProgressBar();
            this.dgvUsuarioCursoAvance = new System.Windows.Forms.DataGridView();
            this.UsuarioCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursoAvance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(635, 595);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 77);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(179, 595);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 77);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Finalizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(18, 595);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 77);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Iniciar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // UsuarioCurso
            // 
            this.UsuarioCurso.Controls.Add(this.label1);
            this.UsuarioCurso.Controls.Add(this.pgreBar);
            this.UsuarioCurso.Controls.Add(this.dgvUsuarioCursoAvance);
            this.UsuarioCurso.Location = new System.Drawing.Point(15, 15);
            this.UsuarioCurso.Margin = new System.Windows.Forms.Padding(6);
            this.UsuarioCurso.Name = "UsuarioCurso";
            this.UsuarioCurso.Padding = new System.Windows.Forms.Padding(6);
            this.UsuarioCurso.Size = new System.Drawing.Size(697, 568);
            this.UsuarioCurso.TabIndex = 14;
            this.UsuarioCurso.TabStop = false;
            this.UsuarioCurso.Text = "Atividades del Curso:";
            this.UsuarioCurso.Enter += new System.EventHandler(this.UsuarioCurso_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Progreso: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pgreBar
            // 
            this.pgreBar.Location = new System.Drawing.Point(9, 481);
            this.pgreBar.Name = "pgreBar";
            this.pgreBar.Size = new System.Drawing.Size(676, 61);
            this.pgreBar.TabIndex = 9;
            this.pgreBar.Click += new System.EventHandler(this.pgreBar_Click);
            // 
            // dgvUsuarioCursoAvance
            // 
            this.dgvUsuarioCursoAvance.AllowUserToAddRows = false;
            this.dgvUsuarioCursoAvance.AllowUserToDeleteRows = false;
            this.dgvUsuarioCursoAvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCursoAvance.Location = new System.Drawing.Point(14, 35);
            this.dgvUsuarioCursoAvance.Margin = new System.Windows.Forms.Padding(6);
            this.dgvUsuarioCursoAvance.MultiSelect = false;
            this.dgvUsuarioCursoAvance.Name = "dgvUsuarioCursoAvance";
            this.dgvUsuarioCursoAvance.ReadOnly = true;
            this.dgvUsuarioCursoAvance.RowHeadersWidth = 82;
            this.dgvUsuarioCursoAvance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioCursoAvance.Size = new System.Drawing.Size(667, 385);
            this.dgvUsuarioCursoAvance.TabIndex = 6;
            this.dgvUsuarioCursoAvance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioCursoAvance_CellContentClick);
            // 
            // frmUsuarioCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 681);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.UsuarioCurso);
            this.Name = "frmUsuarioCursoAvance";
            this.Text = "frmUsuarioCursoAvance";
            this.Load += new System.EventHandler(this.frmUsuarioCursoAvance_Load);
            this.UsuarioCurso.ResumeLayout(false);
            this.UsuarioCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursoAvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox UsuarioCurso;
        private System.Windows.Forms.DataGridView dgvUsuarioCursoAvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgreBar;
    }
}