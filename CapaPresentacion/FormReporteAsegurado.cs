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
    public partial class FormReporteAsegurado : Form
    {
        public FormReporteAsegurado()
        {
            InitializeComponent();
        }

        public string Asegurado { get; set; }
        private void FormReporteAsegurado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarPacientesAsegurado' table. You can move, or remove it, as needed.
            this.FacturarPacientesAseguradoTableAdapter.Fill(this.FinalProg1DataSet.FacturarPacientesAsegurado, Asegurado);

            this.reportViewer1.RefreshReport();
        }

        private void FormReporteAsegurado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
