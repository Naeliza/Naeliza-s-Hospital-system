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
    public partial class FormCitasPacientes : Form
    {
        public FormCitasPacientes()
        {
            InitializeComponent();
        }

        public string Paciente { get; set; }
        private void FormCitasPacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarCitasPaciente' table. You can move, or remove it, as needed.
            this.FacturarCitasPacienteTableAdapter.Fill(this.FinalProg1DataSet.FacturarCitasPaciente, Paciente);

            this.reportViewer1.RefreshReport();
        }

        private void FormCitasPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
