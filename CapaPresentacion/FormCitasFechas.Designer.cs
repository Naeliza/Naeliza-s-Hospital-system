namespace CapaPresentacion
{
    partial class FormCitasFechas
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
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.FacturarCitasFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarCitasFechasTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarCitasFechasTableAdapter();
            this.facturarCitasFechasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarCitasFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarCitasFechasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturarCitasFechasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteCitasFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FinalProg1DataSet
            // 
            this.FinalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.FinalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturarCitasFechasBindingSource
            // 
            this.FacturarCitasFechasBindingSource.DataMember = "FacturarCitasFechas";
            this.FacturarCitasFechasBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarCitasFechasTableAdapter
            // 
            this.FacturarCitasFechasTableAdapter.ClearBeforeFill = true;
            // 
            // facturarCitasFechasBindingSource1
            // 
            this.facturarCitasFechasBindingSource1.DataMember = "FacturarCitasFechas";
            this.facturarCitasFechasBindingSource1.DataSource = this.FinalProg1DataSet;
            // 
            // FormCitasFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCitasFechas";
            this.Text = "FormCitasFechas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCitasFechas_FormClosing);
            this.Load += new System.EventHandler(this.FormCitasFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarCitasFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarCitasFechasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarCitasFechasBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarCitasFechasTableAdapter FacturarCitasFechasTableAdapter;
        private System.Windows.Forms.BindingSource facturarCitasFechasBindingSource1;
    }
}