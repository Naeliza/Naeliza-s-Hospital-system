namespace CapaPresentacion
{
    partial class FormReporteCedula
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
            this.FacturarPacientesCedulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.facturarPacientesCedulaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalProg1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarPacientesAseguradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarPacientesAseguradoTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarPacientesAseguradoTableAdapter();
            this.FacturarPacientesCedulaTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarPacientesCedulaTableAdapter();
            this.facturarPacientesCedulaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesCedulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesCedulaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesAseguradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesCedulaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarPacientesCedulaBindingSource
            // 
            this.FacturarPacientesCedulaBindingSource.DataMember = "FacturarPacientesCedula";
            this.FacturarPacientesCedulaBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FinalProg1DataSet
            // 
            this.FinalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.FinalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturarPacientesCedulaBindingSource1
            // 
            this.facturarPacientesCedulaBindingSource1.DataMember = "FacturarPacientesCedula";
            this.facturarPacientesCedulaBindingSource1.DataSource = this.finalProg1DataSetBindingSource;
            // 
            // finalProg1DataSetBindingSource
            // 
            this.finalProg1DataSetBindingSource.DataSource = this.FinalProg1DataSet;
            this.finalProg1DataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturarPacientesCedulaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePacienteCedula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarPacientesAseguradoBindingSource
            // 
            this.FacturarPacientesAseguradoBindingSource.DataMember = "FacturarPacientesAsegurado";
            this.FacturarPacientesAseguradoBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarPacientesAseguradoTableAdapter
            // 
            this.FacturarPacientesAseguradoTableAdapter.ClearBeforeFill = true;
            // 
            // FacturarPacientesCedulaTableAdapter
            // 
            this.FacturarPacientesCedulaTableAdapter.ClearBeforeFill = true;
            // 
            // facturarPacientesCedulaBindingSource2
            // 
            this.facturarPacientesCedulaBindingSource2.DataMember = "FacturarPacientesCedula";
            this.facturarPacientesCedulaBindingSource2.DataSource = this.FinalProg1DataSet;
            // 
            // FormReporteCedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteCedula";
            this.Text = "FormReporteCedula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteCedula_FormClosing);
            this.Load += new System.EventHandler(this.FormReporteCedula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesCedulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesCedulaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarPacientesAseguradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesCedulaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarPacientesAseguradoBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarPacientesAseguradoTableAdapter FacturarPacientesAseguradoTableAdapter;
        private System.Windows.Forms.BindingSource FacturarPacientesCedulaBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarPacientesCedulaTableAdapter FacturarPacientesCedulaTableAdapter;
        private System.Windows.Forms.BindingSource facturarPacientesCedulaBindingSource1;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource;
        private System.Windows.Forms.BindingSource facturarPacientesCedulaBindingSource2;
    }
}