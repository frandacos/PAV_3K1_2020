namespace BugTracker.GUILayer
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProgresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.cursosToolStripMenuItem1,
            this.actividadesToolStripMenuItem1,
            this.objetivosToolStripMenuItem1,
            this.categoriasToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // actividadesToolStripMenuItem1
            // 
            this.actividadesToolStripMenuItem1.Name = "actividadesToolStripMenuItem1";
            this.actividadesToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.actividadesToolStripMenuItem1.Text = "Actividades";
            this.actividadesToolStripMenuItem1.Click += new System.EventHandler(this.actividadesToolStripMenuItem1_Click);
            // 
            // objetivosToolStripMenuItem1
            // 
            this.objetivosToolStripMenuItem1.Name = "objetivosToolStripMenuItem1";
            this.objetivosToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.objetivosToolStripMenuItem1.Text = "Objetivos";
            this.objetivosToolStripMenuItem1.Click += new System.EventHandler(this.objetivosToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem1
            // 
            this.categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            this.categoriasToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.categoriasToolStripMenuItem1.Text = "Categorias";
            this.categoriasToolStripMenuItem1.Click += new System.EventHandler(this.categoriasToolStripMenuItem1_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosPorCursoToolStripMenuItem,
            this.consultarProgresoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Soporte";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // usuariosPorCursoToolStripMenuItem
            // 
            this.usuariosPorCursoToolStripMenuItem.Name = "usuariosPorCursoToolStripMenuItem";
            this.usuariosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.usuariosPorCursoToolStripMenuItem.Text = "Usuarios por Curso";
            this.usuariosPorCursoToolStripMenuItem.Click += new System.EventHandler(this.usuariosPorCursoToolStripMenuItem_Click);
            // 
            // consultarProgresoToolStripMenuItem
            // 
            this.consultarProgresoToolStripMenuItem.Name = "consultarProgresoToolStripMenuItem";
            this.consultarProgresoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarProgresoToolStripMenuItem.Text = "Consultar Progreso";
            this.consultarProgresoToolStripMenuItem.Click += new System.EventHandler(this.consultarProgresoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeCursosToolStripMenuItem,
            this.listaDeUsuariosToolStripMenuItem,
            this.listaDeActividadToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.reportesToolStripMenuItem.Text = "Listados";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // listaDeCursosToolStripMenuItem
            // 
            this.listaDeCursosToolStripMenuItem.Name = "listaDeCursosToolStripMenuItem";
            this.listaDeCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeCursosToolStripMenuItem.Text = "Lista de Cursos";
            this.listaDeCursosToolStripMenuItem.Click += new System.EventHandler(this.listaDeCursosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioLogueado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(360, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(0, 17);
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            this.listaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listaDeUsuariosToolStripMenuItem_Click);
            // 
            // listaDeActividadToolStripMenuItem
            // 
            this.listaDeActividadToolStripMenuItem.Name = "listaDeActividadToolStripMenuItem";
            this.listaDeActividadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeActividadToolStripMenuItem.Text = "Lista de Actividad";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "BugTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripMenuItem usuariosPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarProgresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeActividadToolStripMenuItem;
    }
}