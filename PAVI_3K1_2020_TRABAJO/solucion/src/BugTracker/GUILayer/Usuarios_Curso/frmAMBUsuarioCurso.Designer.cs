namespace BugTracker.GUILayer.Usuarios_Curso
{
    partial class frmAMBUsuarioCurso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpFecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_Fin = new System.Windows.Forms.Label();
            this.lblFecha_Inicio = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboUsuario);
            this.panel1.Controls.Add(this.cboCurso);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.dtpFecha_fin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.lblFecha_Fin);
            this.panel1.Controls.Add(this.lblFecha_Inicio);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.lblObservaciones);
            this.panel1.Controls.Add(this.lblPuntuacion);
            this.panel1.Controls.Add(this.txtPuntuacion);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 310);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(75, 15);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(210, 21);
            this.cboUsuario.TabIndex = 1;
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(75, 59);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(210, 21);
            this.cboCurso.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(64, 275);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFecha_fin
            // 
            this.dtpFecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_fin.Location = new System.Drawing.Point(75, 235);
            this.dtpFecha_fin.Name = "dtpFecha_fin";
            this.dtpFecha_fin.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha_fin.TabIndex = 6;
            this.dtpFecha_fin.Value = new System.DateTime(2020, 9, 20, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(78, 200);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaInicio.TabIndex = 5;
            this.dtpFechaInicio.Value = new System.DateTime(2020, 9, 20, 0, 0, 0, 0);
            // 
            // lblFecha_Fin
            // 
            this.lblFecha_Fin.AutoSize = true;
            this.lblFecha_Fin.Location = new System.Drawing.Point(5, 235);
            this.lblFecha_Fin.Name = "lblFecha_Fin";
            this.lblFecha_Fin.Size = new System.Drawing.Size(54, 13);
            this.lblFecha_Fin.TabIndex = 11;
            this.lblFecha_Fin.Text = "Fecha fin:";
            // 
            // lblFecha_Inicio
            // 
            this.lblFecha_Inicio.AutoSize = true;
            this.lblFecha_Inicio.Location = new System.Drawing.Point(5, 200);
            this.lblFecha_Inicio.Name = "lblFecha_Inicio";
            this.lblFecha_Inicio.Size = new System.Drawing.Size(67, 13);
            this.lblFecha_Inicio.TabIndex = 10;
            this.lblFecha_Inicio.Text = "Fecha inicio:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(92, 143);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(185, 44);
            this.txtObservaciones.TabIndex = 4;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(5, 143);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(5, 104);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(64, 13);
            this.lblPuntuacion.TabIndex = 7;
            this.lblPuntuacion.Text = "Puntuacion:";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(75, 101);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(43, 20);
            this.txtPuntuacion.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(5, 59);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 13);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso (*):";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(5, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario (*):";
            // 
            // frmAMBUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 334);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAMBUsuarioCurso";
            this.Text = "frmAMBUsuarioCurso";
            this.Load += new System.EventHandler(this.frmAMBUsuarioCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DateTimePicker dtpFecha_fin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFecha_Fin;
        private System.Windows.Forms.Label lblFecha_Inicio;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.TextBox txtPuntuacion;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboUsuario;
    }
}