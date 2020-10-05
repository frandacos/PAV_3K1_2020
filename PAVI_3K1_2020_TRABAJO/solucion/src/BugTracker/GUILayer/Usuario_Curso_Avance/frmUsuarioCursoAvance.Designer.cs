namespace BugTracker.GUILayer.Usuario_Curso_Avance
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.UsuarioCurso = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbrPorcentaje = new System.Windows.Forms.ProgressBar();
            this.dgvUsuarioCursoAvance = new System.Windows.Forms.DataGridView();
            this.UsuarioCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursoAvance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(318, 309);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(8, 309);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 40);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Finalizar Actividad";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // UsuarioCurso
            // 
            this.UsuarioCurso.Controls.Add(this.label2);
            this.UsuarioCurso.Controls.Add(this.label1);
            this.UsuarioCurso.Controls.Add(this.pbrPorcentaje);
            this.UsuarioCurso.Controls.Add(this.dgvUsuarioCursoAvance);
            this.UsuarioCurso.Location = new System.Drawing.Point(8, 8);
            this.UsuarioCurso.Name = "UsuarioCurso";
            this.UsuarioCurso.Size = new System.Drawing.Size(350, 295);
            this.UsuarioCurso.TabIndex = 14;
            this.UsuarioCurso.TabStop = false;
            this.UsuarioCurso.Text = "Actividades del Curso:";
            this.UsuarioCurso.Enter += new System.EventHandler(this.UsuarioCurso_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Progreso: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbrPorcentaje
            // 
            this.pbrPorcentaje.Location = new System.Drawing.Point(4, 250);
            this.pbrPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.pbrPorcentaje.Name = "pbrPorcentaje";
            this.pbrPorcentaje.Size = new System.Drawing.Size(338, 32);
            this.pbrPorcentaje.TabIndex = 9;
            this.pbrPorcentaje.Click += new System.EventHandler(this.pgreBar_Click);
            // 
            // dgvUsuarioCursoAvance
            // 
            this.dgvUsuarioCursoAvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCursoAvance.Location = new System.Drawing.Point(7, 18);
            this.dgvUsuarioCursoAvance.MultiSelect = false;
            this.dgvUsuarioCursoAvance.Name = "dgvUsuarioCursoAvance";
            this.dgvUsuarioCursoAvance.ReadOnly = true;
            this.dgvUsuarioCursoAvance.RowHeadersWidth = 82;
            this.dgvUsuarioCursoAvance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioCursoAvance.Size = new System.Drawing.Size(334, 200);
            this.dgvUsuarioCursoAvance.TabIndex = 6;
            this.dgvUsuarioCursoAvance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioCursoAvance_CellContentClick);
            // 
            // frmUsuarioCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 354);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.UsuarioCurso);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarioCursoAvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avance del Curso";
            this.Load += new System.EventHandler(this.frmUsuarioCursoAvance_Load);
            this.UsuarioCurso.ResumeLayout(false);
            this.UsuarioCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursoAvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox UsuarioCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbrPorcentaje;
        private System.Windows.Forms.DataGridView dgvUsuarioCursoAvance;
        private System.Windows.Forms.Label label2;
    }
}