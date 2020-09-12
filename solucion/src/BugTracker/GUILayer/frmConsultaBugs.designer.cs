namespace BugTracker.GUILayer
{
    partial class frmConsultaBugs
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
            this.btnDetalleBug = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.pnl_filtros.SuspendLayout();
            this.SuspendLayout();
            
           
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = global::BugTracker.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(805, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(32, 51);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Estado:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(76, 48);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(181, 21);
            this.cboEstados.TabIndex = 1;
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.cboEstados);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filtros.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(852, 142);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.btnDetalleBug);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmConsultaBugs";
            this.Text = "Consultar Bugs";
            this.Load += new System.EventHandler(this.frmBugs_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnDetalleBug;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.ComboBox cboEstados;
        internal System.Windows.Forms.GroupBox pnl_filtros;
    }
}