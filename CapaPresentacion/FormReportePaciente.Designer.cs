namespace CapaPresentacion
{
    partial class FormReportePaciente
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
            this.facturarPacientesNombreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.FacturarMedicosNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturarPacientesNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturarPacientesNombreTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarPacientesNombreTableAdapter();
            this.FacturarMedicosNombreTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter();
            this.facturarPacientesNombreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // facturarPacientesNombreBindingSource1
            // 
            this.facturarPacientesNombreBindingSource1.DataMember = "FacturarPacientesNombre";
            this.facturarPacientesNombreBindingSource1.DataSource = this.finalProg1DataSet;
            // 
            // finalProg1DataSet
            // 
            this.finalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.finalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturarMedicosNombreBindingSource
            // 
            this.FacturarMedicosNombreBindingSource.DataMember = "FacturarMedicosNombre";
            this.FacturarMedicosNombreBindingSource.DataSource = this.finalProg1DataSet;
            // 
            // facturarPacientesNombreBindingSource
            // 
            this.facturarPacientesNombreBindingSource.DataMember = "FacturarPacientesNombre";
            this.facturarPacientesNombreBindingSource.DataSource = this.finalProg1DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturarPacientesNombreBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePacienteNombre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturarPacientesNombreTableAdapter
            // 
            this.facturarPacientesNombreTableAdapter.ClearBeforeFill = true;
            // 
            // FacturarMedicosNombreTableAdapter
            // 
            this.FacturarMedicosNombreTableAdapter.ClearBeforeFill = true;
            // 
            // facturarPacientesNombreBindingSource2
            // 
            this.facturarPacientesNombreBindingSource2.DataMember = "FacturarPacientesNombre";
            this.facturarPacientesNombreBindingSource2.DataSource = this.finalProg1DataSet;
            // 
            // FormReportePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportePaciente";
            this.Text = "FormReportePaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportePaciente_FormClosing);
            this.Load += new System.EventHandler(this.FormReportePaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarPacientesNombreBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturarPacientesNombreBindingSource;
        private FinalProg1DataSet finalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarPacientesNombreTableAdapter facturarPacientesNombreTableAdapter;
        private System.Windows.Forms.BindingSource FacturarMedicosNombreBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter FacturarMedicosNombreTableAdapter;
        private System.Windows.Forms.BindingSource facturarPacientesNombreBindingSource1;
        private System.Windows.Forms.BindingSource facturarPacientesNombreBindingSource2;
    }
}