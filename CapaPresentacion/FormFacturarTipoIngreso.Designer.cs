namespace CapaPresentacion
{
    partial class Form1
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
            this.facturarIngresosTipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarIngresosTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarIngresosTipoTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarIngresosTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturarIngresosTipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarIngresosTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // facturarIngresosTipoBindingSource1
            // 
            this.facturarIngresosTipoBindingSource1.DataMember = "FacturarIngresosTipo";
            this.facturarIngresosTipoBindingSource1.DataSource = this.FinalProg1DataSet;
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
            reportDataSource1.Value = this.facturarIngresosTipoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteIngresoTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarIngresosTipoBindingSource
            // 
            this.FacturarIngresosTipoBindingSource.DataMember = "FacturarIngresosTipo";
            this.FacturarIngresosTipoBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarIngresosTipoTableAdapter
            // 
            this.FacturarIngresosTipoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturarIngresosTipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarIngresosTipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarIngresosTipoBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarIngresosTipoTableAdapter FacturarIngresosTipoTableAdapter;
        private System.Windows.Forms.BindingSource facturarIngresosTipoBindingSource1;
    }
}