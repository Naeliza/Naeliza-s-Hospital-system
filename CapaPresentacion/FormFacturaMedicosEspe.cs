using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormFacturaMedicosEspe : Form
    {
        public FormFacturaMedicosEspe()
        {
            InitializeComponent();
        }

        #region Filtrar por Especialidad
        public string Especialidad { get; set; }

        private void FormFacturaMedicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarMedicosEspecialidad' table. You can move, or remove it, as needed.
            this.FacturarMedicosEspecialidadTableAdapter.Fill(this.FinalProg1DataSet.FacturarMedicosEspecialidad,Especialidad);
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarMedicosEspecialidad' table. You can move, or remove it, as needed.
            this.FacturarMedicosEspecialidadTableAdapter.Fill(this.FinalProg1DataSet.FacturarMedicosEspecialidad,Especialidad);
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarMedicosEspecialidad' table. You can move, or remove it, as needed.
            this.FacturarMedicosEspecialidadTableAdapter.Fill(this.FinalProg1DataSet.FacturarMedicosEspecialidad,Especialidad);

            this.reportViewer1.RefreshReport();
        }

        #endregion

        #region Cerrar

        private void FormFacturaMedicosEspe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
