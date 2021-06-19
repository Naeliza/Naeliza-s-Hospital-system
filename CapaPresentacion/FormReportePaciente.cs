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
    public partial class FormReportePaciente : Form
    {
        public FormReportePaciente()
        {
            InitializeComponent();
        }

        public string Nombre { get; set; }

        private void FormReportePaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormReportePaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProg1DataSet.FacturarPacientesNombre' table. You can move, or remove it, as needed.
            this.facturarPacientesNombreTableAdapter.Fill(this.finalProg1DataSet.FacturarPacientesNombre, Nombre);
            this.reportViewer1.RefreshReport();


        }
    }
}
