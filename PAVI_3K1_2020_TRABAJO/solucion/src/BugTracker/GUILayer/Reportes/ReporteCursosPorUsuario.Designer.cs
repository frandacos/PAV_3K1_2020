namespace BugTracker.GUILayer.Reportes
{
    partial class ReporteCursosPorUsuario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new BugTracker.DataSet1();
            this.cursosPorUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosPorUsuarioTableAdapter = new BugTracker.DataSet1TableAdapters.CursosPorUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosPorUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cursosPorUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.ReporteCursosPorUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(477, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosPorUsuarioBindingSource
            // 
            this.cursosPorUsuarioBindingSource.DataMember = "CursosPorUsuario";
            this.cursosPorUsuarioBindingSource.DataSource = this.dataSet1;
            // 
            // cursosPorUsuarioTableAdapter
            // 
            this.cursosPorUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCursosPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 331);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCursosPorUsuario";
            this.Text = "ReporteCursosPorUsuario";
            this.Load += new System.EventHandler(this.ReporteCursosPorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosPorUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cursosPorUsuarioBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CursosPorUsuarioTableAdapter cursosPorUsuarioTableAdapter;
    }
}