namespace BugTracker.Cursos
{
    partial class frmABMCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMCurso));
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaVigencia = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaVigencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 112);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // dtpFechaVigencia
            // 
            this.dtpFechaVigencia.Enabled = false;
            this.dtpFechaVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVigencia.Location = new System.Drawing.Point(15, 313);
            this.dtpFechaVigencia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaVigencia.Name = "dtpFechaVigencia";
            this.dtpFechaVigencia.Size = new System.Drawing.Size(461, 37);
            this.dtpFechaVigencia.TabIndex = 45;
            this.dtpFechaVigencia.ValueChanged += new System.EventHandler(this.dtpFechaVigencia_ValueChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(16, 414);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(461, 225);
            this.txtDescripcion.TabIndex = 44;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(232, 88);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 37);
            this.textBox5.TabIndex = 43;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 371);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(137, 25);
            this.lblDescripcion.TabIndex = 42;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.AutoSize = true;
            this.lblFechaVigencia.Location = new System.Drawing.Point(35, 281);
            this.lblFechaVigencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(164, 25);
            this.lblFechaVigencia.TabIndex = 41;
            this.lblFechaVigencia.Text = "Fecha vigencia:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 662);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 77);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(78, 662);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(156, 77);
            this.btnAceptar.TabIndex = 48;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(35, 195);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(117, 25);
            this.lblCategoria.TabIndex = 50;
            this.lblCategoria.Text = "Categoría: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 143);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(461, 37);
            this.txtNombre.TabIndex = 52;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(15, 226);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(461, 33);
            this.cboCategoria.TabIndex = 54;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(35, 25);
            this.lblIdCurso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(92, 25);
            this.lblIdCurso.TabIndex = 40;
            this.lblIdCurso.Text = "Id Curso";
            this.lblIdCurso.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.Location = new System.Drawing.Point(16, 56);
            this.txtIdCurso.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(461, 37);
            this.txtIdCurso.TabIndex = 53;
            this.txtIdCurso.TextChanged += new System.EventHandler(this.txtIdCurso_TextChanged);
            // 
            // frmABMCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 758);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaVigencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFechaVigencia);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABMCurso";
            this.Text = "Edición Curso";
            this.Load += new System.EventHandler(this.frmABMCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaVigencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaVigencia;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
    }
}