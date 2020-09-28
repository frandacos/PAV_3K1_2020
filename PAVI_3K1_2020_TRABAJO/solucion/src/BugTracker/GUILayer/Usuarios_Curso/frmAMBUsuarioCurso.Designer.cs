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
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(150, 29);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(416, 33);
            this.cboUsuario.TabIndex = 1;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(150, 113);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(416, 33);
            this.cboCurso.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(348, 529);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(128, 529);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(156, 44);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFecha_fin
            // 
            this.dtpFecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_fin.Location = new System.Drawing.Point(150, 452);
            this.dtpFecha_fin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFecha_fin.Name = "dtpFecha_fin";
            this.dtpFecha_fin.Size = new System.Drawing.Size(194, 31);
            this.dtpFecha_fin.TabIndex = 6;
            this.dtpFecha_fin.Value = new System.DateTime(2020, 9, 20, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(156, 385);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(194, 31);
            this.dtpFechaInicio.TabIndex = 5;
            this.dtpFechaInicio.Value = new System.DateTime(2020, 9, 20, 0, 0, 0, 0);
            // 
            // lblFecha_Fin
            // 
            this.lblFecha_Fin.AutoSize = true;
            this.lblFecha_Fin.Location = new System.Drawing.Point(10, 452);
            this.lblFecha_Fin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha_Fin.Name = "lblFecha_Fin";
            this.lblFecha_Fin.Size = new System.Drawing.Size(107, 25);
            this.lblFecha_Fin.TabIndex = 11;
            this.lblFecha_Fin.Text = "Fecha fin:";
            // 
            // lblFecha_Inicio
            // 
            this.lblFecha_Inicio.AutoSize = true;
            this.lblFecha_Inicio.Location = new System.Drawing.Point(10, 385);
            this.lblFecha_Inicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha_Inicio.Name = "lblFecha_Inicio";
            this.lblFecha_Inicio.Size = new System.Drawing.Size(134, 25);
            this.lblFecha_Inicio.TabIndex = 10;
            this.lblFecha_Inicio.Text = "Fecha inicio:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(184, 275);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(366, 81);
            this.txtObservaciones.TabIndex = 4;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(10, 275);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(162, 25);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(10, 200);
            this.lblPuntuacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(126, 25);
            this.lblPuntuacion.TabIndex = 7;
            this.lblPuntuacion.Text = "Puntuacion:";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(150, 194);
            this.txtPuntuacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(82, 31);
            this.txtPuntuacion.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(10, 113);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(103, 25);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso (*):";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(10, 29);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(120, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario (*):";
            // 
            // frmAMBUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 642);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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