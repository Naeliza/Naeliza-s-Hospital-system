namespace CapaPresentacion
{
    partial class FormFacturaMedicosEspe
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
            this.FacturarMedicosEspecialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.FacturarMedicosNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturarMedicosEspecialidadTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarMedicosEspecialidadTableAdapter();
            this.FacturarMedicosNombreTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter();
            this.finalProg1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturarMedicosEspecialidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarMedicosEspecialidadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosEspecialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosEspecialidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosEspecialidadBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarMedicosEspecialidadBindingSource
            // 
            this.FacturarMedicosEspecialidadBindingSource.DataMember = "FacturarMedicosEspecialidad";
            this.FacturarMedicosEspecialidadBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // FinalProg1DataSet
            // 
            this.FinalProg1DataSet.DataSetName = "FinalProg1DataSet";
            this.FinalProg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturarMedicosNombreBindingSource
            // 
            this.FacturarMedicosNombreBindingSource.DataMember = "FacturarMedicosNombre";
            this.FacturarMedicosNombreBindingSource.DataSource = this.FinalProg1DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturarMedicosEspecialidadBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteFisicoMedicoEspe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturarMedicosEspecialidadTableAdapter
            // 
            this.FacturarMedicosEspecialidadTableAdapter.ClearBeforeFill = true;
            // 
            // FacturarMedicosNombreTableAdapter
            // 
            this.FacturarMedicosNombreTableAdapter.ClearBeforeFill = true;
            // 
            // finalProg1DataSetBindingSource
            // 
            this.finalProg1DataSetBindingSource.DataSource = this.FinalProg1DataSet;
            this.finalProg1DataSetBindingSource.Position = 0;
            // 
            // facturarMedicosEspecialidadBindingSource1
            // 
            this.facturarMedicosEspecialidadBindingSource1.DataMember = "FacturarMedicosEspecialidad";
            this.facturarMedicosEspecialidadBindingSource1.DataSource = this.finalProg1DataSetBindingSource;
            // 
            // facturarMedicosEspecialidadBindingSource2
            // 
            this.facturarMedicosEspecialidadBindingSource2.DataMember = "FacturarMedicosEspecialidad";
            this.facturarMedicosEspecialidadBindingSource2.DataSource = this.FinalProg1DataSet;
            // 
            // FormFacturaMedicosEspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFacturaMedicosEspe";
            this.Text = "FormFacturaMedicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFacturaMedicosEspe_FormClosing);
            this.Load += new System.EventHandler(this.FormFacturaMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosEspecialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosEspecialidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosEspecialidadBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarMedicosEspecialidadBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private FinalProg1DataSetTableAdapters.FacturarMedicosEspecialidadTableAdapter FacturarMedicosEspecialidadTableAdapter;
        private System.Windows.Forms.BindingSource FacturarMedicosNombreBindingSource;
        private FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter FacturarMedicosNombreTableAdapter;
        private System.Windows.Forms.BindingSource facturarMedicosEspecialidadBindingSource1;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource;
        private System.Windows.Forms.BindingSource facturarMedicosEspecialidadBindingSource2;
    }
}