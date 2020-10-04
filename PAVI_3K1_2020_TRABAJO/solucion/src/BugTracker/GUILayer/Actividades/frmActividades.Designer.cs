namespace BugTracker.GUILayer.Actividades
{
    partial class frmActividades
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
            this.pnlFiltros = new System.Windows.Forms.GroupBox();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiltros.Controls.Add(this.dgvActividades);
            this.pnlFiltros.Controls.Add(this.chkTodos);
            this.pnlFiltros.Controls.Add(this.Label3);
            this.pnlFiltros.Controls.Add(this.txtNombreAct);
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Location = new System.Drawing.Point(14, 13);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(6);
            this.pnlFiltros.Size = new System.Drawing.Size(826, 602);
            this.pnlFiltros.TabIndex = 38;
            this.pnlFiltros.TabStop = false;
            this.pnlFiltros.Text = "Actividades";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvActividades.Location = new System.Drawing.Point(6, 198);
            this.dgvActividades.Margin = new System.Windows.Forms.Padding(6);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersWidth = 82;
            this.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividades.Size = new System.Drawing.Size(814, 398);
            this.dgvActividades.TabIndex = 8;
            this.dgvActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellContentClick);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(148, 110);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(6);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(104, 29);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(46, 48);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 25);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Nombre:";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Location = new System.Drawing.Point(148, 44);
            this.txtNombreAct.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(358, 31);
            this.txtNombreAct.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(584, 44);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(174, 85);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::BugTracker.Properties.Resources.eliminar;
            this.btnQuitar.Location = new System.Drawing.Point(200, 627);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 77);
            this.btnQuitar.TabIndex = 41;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(760, 627);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 77);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::BugTracker.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(108, 627);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 77);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::BugTracker.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(16, 627);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 77);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 716);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "frmActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.GroupBox pnlFiltros;
        internal System.Windows.Forms.DataGridView dgvActividades;
        internal System.Windows.Forms.CheckBox chkTodos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNombreAct;
        internal System.Windows.Forms.Button btnConsultar;
    }
}