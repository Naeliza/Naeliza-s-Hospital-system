namespace CapaPresentacion
{
    partial class FormFacturaAltaFecha
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
            this.FacturarAltaFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.facturarAltaFechaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalProg1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarAltaFechaTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarAltaFechaTableAdapter();
            this.finalProg1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarAltaFechaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarAltaPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturarAltaPacienteTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarAltaPacienteTableAdapter();
            this.finalProg1DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarAltaFechaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarAltaFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarAltaFechaBindingSource
            // 
            this.FacturarAltaFechaBindingSource.DataMember = "FacturarAltaFecha";
            this.FacturarAltaFechaBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FinalProg1DataSet
            // 
            this.FinalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.FinalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturarAltaFechaBindingSource1
            // 
            this.facturarAltaFechaBindingSource1.DataMember = "FacturarAltaFecha";
            this.facturarAltaFechaBindingSource1.DataSource = this.finalProg1DataSetBindingSource;
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
            reportDataSource1.Value = this.FacturarAltaFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteAltaFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(762, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarAltaFechaTableAdapter
            // 
            this.FacturarAltaFechaTableAdapter.ClearBeforeFill = true;
            // 
            // finalProg1DataSetBindingSource1
            // 
            this.finalProg1DataSetBindingSource1.DataSource = this.FinalProg1DataSet;
            this.finalProg1DataSetBindingSource1.Position = 0;
            // 
            // facturarAltaFechaBindingSource2
            // 
            this.facturarAltaFechaBindingSource2.DataMember = "FacturarAltaFecha";
            this.facturarAltaFechaBindingSource2.DataSource = this.finalProg1DataSetBindingSource1;
            // 
            // facturarAltaPacienteBindingSource
            // 
            this.facturarAltaPacienteBindingSource.DataMember = "FacturarAltaPaciente";
            this.facturarAltaPacienteBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // facturarAltaPacienteTableAdapter
            // 
            this.facturarAltaPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // finalProg1DataSetBindingSource2
            // 
            this.finalProg1DataSetBindingSource2.DataSource = this.FinalProg1DataSet;
            this.finalProg1DataSetBindingSource2.Position = 0;
            // 
            // facturarAltaFechaBindingSource3
            // 
            this.facturarAltaFechaBindingSource3.DataMember = "FacturarAltaFecha";
            this.facturarAltaFechaBindingSource3.DataSource = this.finalProg1DataSetBindingSource2;
            // 
            // FormFacturaAltaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFacturaAltaFecha";
            this.Text = "FormFacturaAltaFecha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFacturaAltaFecha_FormClosing);
            this.Load += new System.EventHandler(this.FormFacturaAltaFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarAltaFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarAltaFechaBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarAltaFechaBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private System.Windows.Forms.BindingSource facturarAltaFechaBindingSource1;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarAltaFechaTableAdapter FacturarAltaFechaTableAdapter;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource facturarAltaFechaBindingSource2;
        private System.Windows.Forms.BindingSource facturarAltaPacienteBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarAltaPacienteTableAdapter facturarAltaPacienteTableAdapter;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource2;
        private System.Windows.Forms.BindingSource facturarAltaFechaBindingSource3;
    }
}