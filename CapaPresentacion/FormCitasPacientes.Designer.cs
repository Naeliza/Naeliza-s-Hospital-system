namespace CapaPresentacion
{
    partial class FormCitasPacientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.FacturarCitasPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturarCitasPacienteTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarCitasPacienteTableAdapter();
            this.facturarCitasPacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarCitasPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarCitasPacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.facturarCitasPacienteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteCitasPaciente.rdlc";
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
            // FacturarCitasPacienteBindingSource
            // 
            this.FacturarCitasPacienteBindingSource.DataMember = "FacturarCitasPaciente";
            this.FacturarCitasPacienteBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FacturarCitasPacienteTableAdapter
            // 
            this.FacturarCitasPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // facturarCitasPacienteBindingSource1
            // 
            this.facturarCitasPacienteBindingSource1.DataMember = "FacturarCitasPaciente";
            this.facturarCitasPacienteBindingSource1.DataSource = this.FinalProg1DataSet;
            // 
            // FormCitasPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCitasPacientes";
            this.Text = "FormCitasPacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCitasPacientes_FormClosing);
            this.Load += new System.EventHandler(this.FormCitasPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarCitasPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarCitasPacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarCitasPacienteBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarCitasPacienteTableAdapter FacturarCitasPacienteTableAdapter;
        private System.Windows.Forms.BindingSource facturarCitasPacienteBindingSource1;
    }
}