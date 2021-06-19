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
    public partial class FormReporteCedula : Form
    {
        public FormReporteCedula()
        {
            InitializeComponent();
        }

        public string Cedula { get; set; }

        private void FormReporteCedula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarPacientesCedula' table. You can move, or remove it, as needed.
            this.FacturarPacientesCedulaTableAdapter.Fill(this.FinalProg1DataSet.FacturarPacientesCedula, Cedula);

            this.reportViewer1.RefreshReport();

        }

        private void FormReporteCedula_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
