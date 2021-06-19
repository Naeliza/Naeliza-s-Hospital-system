namespace CapaPresentacion
{
    partial class FormFacturarAltaPaciente
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
            this.facturarAltaPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarAltaFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarAltaFechaTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarAltaFechaTableAdapter();
            this.FacturarMedicosEspecialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarMedicosEspecialidadTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarMedicosEspecialidadTableAdapter();
            this.facturarAltaPacienteTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarAltaPacienteTableAdapter();
            this.facturarAltaPacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarAltaFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosEspecialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // facturarAltaPacienteBindingSource
            // 
            this.facturarAltaPacienteBindingSource.DataMember = "FacturarAltaPaciente";
            this.facturarAltaPacienteBindingSource.DataSource = this.FinalProg1DataSet;
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
            reportDataSource1.Value = this.facturarAltaPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteAltaPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarAltaFechaBindingSource
            // 
            this.FacturarAltaFechaBindingSource.DataMember = "FacturarAltaFecha";
            this.FacturarAltaFechaBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarAltaFechaTableAdapter
            // 
            this.FacturarAltaFechaTableAdapter.ClearBeforeFill = true;
            // 
            // FacturarMedicosEspecialidadBindingSource
            // 
            this.FacturarMedicosEspecialidadBindingSource.DataMember = "FacturarMedicosEspecialidad";
            this.FacturarMedicosEspecialidadBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarMedicosEspecialidadTableAdapter
            // 
            this.FacturarMedicosEspecialidadTableAdapter.ClearBeforeFill = true;
            // 
            // facturarAltaPacienteTableAdapter
            // 
            this.facturarAltaPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // facturarAltaPacienteBindingSource1
            // 
            this.facturarAltaPacienteBindingSource1.DataMember = "FacturarAltaPaciente";
            this.facturarAltaPacienteBindingSource1.DataSource = this.FinalProg1DataSet;
            // 
            // FormFacturarAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFacturarAltaPaciente";
            this.Text = "FormFacturarAltaPaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFacturarAltaPaciente_FormClosing);
            this.Load += new System.EventHandler(this.FormFacturarAltaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarAltaFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosEspecialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarAltaFechaBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarAltaFechaTableAdapter FacturarAltaFechaTableAdapter;
        private System.Windows.Forms.BindingSource FacturarMedicosEspecialidadBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarMedicosEspecialidadTableAdapter FacturarMedicosEspecialidadTableAdapter;
        private System.Windows.Forms.BindingSource facturarAltaPacienteBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarAltaPacienteTableAdapter facturarAltaPacienteTableAdapter;
        private System.Windows.Forms.BindingSource facturarAltaPacienteBindingSource1;
    }
}