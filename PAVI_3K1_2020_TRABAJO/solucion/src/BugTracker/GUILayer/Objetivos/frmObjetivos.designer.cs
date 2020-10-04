namespace BugTracker.GUILayer.Objetivos
{
    partial class frmObjetivos
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
            this.lblNombre_corto = new System.Windows.Forms.Label();
            this.lblNombre_largo = new System.Windows.Forms.Label();
            this.txtNombre_corto = new System.Windows.Forms.TextBox();
            this.txtNombre_largo = new System.Windows.Forms.TextBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre_corto
            // 
            this.lblNombre_corto.AutoSize = true;
            this.lblNombre_corto.Location = new System.Drawing.Point(40, 36);
            this.lblNombre_corto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre_corto.Name = "lblNombre_corto";
            this.lblNombre_corto.Size = new System.Drawing.Size(141, 25);
            this.lblNombre_corto.TabIndex = 0;
            this.lblNombre_corto.Text = "Nombre corto";
            // 
            // lblNombre_largo
            // 
            this.lblNombre_largo.AutoSize = true;
            this.lblNombre_largo.Location = new System.Drawing.Point(42, 94);
            this.lblNombre_largo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre_largo.Name = "lblNombre_largo";
            this.lblNombre_largo.Size = new System.Drawing.Size(141, 25);
            this.lblNombre_largo.TabIndex = 1;
            this.lblNombre_largo.Text = "Nombre largo";
            // 
            // txtNombre_corto
            // 
            this.txtNombre_corto.Location = new System.Drawing.Point(214, 30);
            this.txtNombre_corto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre_corto.Name = "txtNombre_corto";
            this.txtNombre_corto.Size = new System.Drawing.Size(364, 31);
            this.txtNombre_corto.TabIndex = 2;
            // 
            // txtNombre_largo
            // 
            this.txtNombre_largo.Location = new System.Drawing.Point(214, 88);
            this.txtNombre_largo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre_largo.Name = "txtNombre_largo";
            this.txtNombre_largo.Size = new System.Drawing.Size(364, 31);
            this.txtNombre_largo.TabIndex = 3;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(214, 148);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(104, 29);
            this.chkTodos.TabIndex = 4;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged_1);
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Location = new System.Drawing.Point(17, 210);
            this.dgvObjetivos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.RowHeadersWidth = 82;
            this.dgvObjetivos.Size = new System.Drawing.Size(814, 398);
            this.dgvObjetivos.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(634, 36);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(174, 85);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::BugTracker.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(15, 624);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 77);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::BugTracker.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(107, 624);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 77);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::BugTracker.Properties.Resources.eliminar;
            this.btnQuitar.Location = new System.Drawing.Point(199, 624);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 77);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(759, 624);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 77);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 716);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvObjetivos);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtNombre_largo);
            this.Controls.Add(this.txtNombre_corto);
            this.Controls.Add(this.lblNombre_largo);
            this.Controls.Add(this.lblNombre_corto);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.frmObjetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre_corto;
        private System.Windows.Forms.Label lblNombre_largo;
        private System.Windows.Forms.TextBox txtNombre_corto;
        private System.Windows.Forms.TextBox txtNombre_largo;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
    }
}