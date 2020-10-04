namespace BugTracker.GUILayer.Usuarios
{
    partial class frmABMUsuario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 418);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 77);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(83, 418);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 77);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(19, 357);
            this.cboPerfil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(461, 33);
            this.cboPerfil.TabIndex = 38;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(32, 328);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 25);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Perfil(*):";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(32, 254);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(226, 25);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "Repetir Contraseña(*):";
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Location = new System.Drawing.Point(19, 284);
            this.txtConfirmarPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.PasswordChar = '*';
            this.txtConfirmarPass.Size = new System.Drawing.Size(461, 31);
            this.txtConfirmarPass.TabIndex = 31;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(32, 179);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(151, 25);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Contraseña(*):";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 211);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(461, 31);
            this.txtPassword.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(461, 31);
            this.txtEmail.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(32, 104);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 25);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Email:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(32, 25);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 25);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Nombre(*):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 61);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(461, 31);
            this.txtNombre.TabIndex = 27;
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 524);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtConfirmarPass);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.ComboBox cboPerfil;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtConfirmarPass;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.MaskedTextBox txtEmail;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNombre;
    }
}