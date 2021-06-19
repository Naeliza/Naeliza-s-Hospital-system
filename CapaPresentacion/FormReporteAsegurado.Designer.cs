namespace CapaPresentacion
{
    partial class FormReporteAsegurado
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
            this.FacturarPacientesAseguradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarPacientesAseguradoTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarPacientesAseguradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesAseguradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarPacientesAseguradoBindingSource
            // 
            this.FacturarPacientesAseguradoBindingSource.DataMember = "FacturarPacientesAsegurado";
            this.FacturarPacientesAseguradoBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FinalProg1DataSet
            // 
            this.FinalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.FinalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturarPacientesAseguradoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePacienteAsegurado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarPacientesAseguradoTableAdapter
            // 
            this.FacturarPacientesAseguradoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteAsegurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteAsegurado";
            this.Text = "FormReporteAsegurado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteAsegurado_FormClosing);
            this.Load += new System.EventHandler(this.FormReporteAsegurado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesAseguradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarPacientesAseguradoBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarPacientesAseguradoTableAdapter FacturarPacientesAseguradoTableAdapter;
    }
}