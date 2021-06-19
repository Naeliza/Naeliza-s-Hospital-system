namespace CapaPresentacion
{
    partial class FormFacturarMedicosNom
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
            this.FacturarMedicosNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProg1DataSet = new CapaPresentacion.FinalProg1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturarMedicosNombreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarMedicosNombreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarMedicosNombreBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.facturarMedicosNombreTableAdapter = new CapaPresentacion.FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter();
            this.finalProg1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarMedicosNombreBindingSource
            // 
            this.FacturarMedicosNombreBindingSource.DataMember = "FacturarMedicosNombre";
            this.FacturarMedicosNombreBindingSource.DataSource = this.FinalProg1DataSet;
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
            reportDataSource1.Value = this.FacturarMedicosNombreBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteFisicoMedicoNom.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturarMedicosNombreBindingSource1
            // 
            this.facturarMedicosNombreBindingSource1.DataMember = "FacturarMedicosNombre";
            this.facturarMedicosNombreBindingSource1.DataSource = this.FinalProg1DataSet;
            // 
            // facturarMedicosNombreBindingSource2
            // 
            this.facturarMedicosNombreBindingSource2.DataMember = "FacturarMedicosNombre";
            this.facturarMedicosNombreBindingSource2.DataSource = this.FinalProg1DataSet;
            // 
            // facturarMedicosNombreBindingSource3
            // 
            this.facturarMedicosNombreBindingSource3.DataMember = "FacturarMedicosNombre";
            this.facturarMedicosNombreBindingSource3.DataSource = this.FinalProg1DataSet;
            // 
            // facturarMedicosNombreTableAdapter
            // 
            this.facturarMedicosNombreTableAdapter.ClearBeforeFill = true;
            // 
            // finalProg1DataSetBindingSource
            // 
            this.finalProg1DataSetBindingSource.DataSource = this.FinalProg1DataSet;
            this.finalProg1DataSetBindingSource.Position = 0;
            // 
            // FormFacturarMedicosNom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFacturarMedicosNom";
            this.Text = "FormFacturarMedicosNom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFacturarMedicosNom_FormClosing);
            this.Load += new System.EventHandler(this.FormFacturarMedicosNom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturarMedicosNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProg1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturarMedicosNombreBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProg1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturarMedicosNombreBindingSource;
        private FinalProg1DataSet FinalProg1DataSet;
        private System.Windows.Forms.BindingSource facturarMedicosNombreBindingSource1;
        private System.Windows.Forms.BindingSource facturarMedicosNombreBindingSource2;
        private System.Windows.Forms.BindingSource facturarMedicosNombreBindingSource3;
        private FinalProg1DataSetTableAdapters.FacturarMedicosNombreTableAdapter facturarMedicosNombreTableAdapter;
        private System.Windows.Forms.BindingSource finalProg1DataSetBindingSource;
    }
}