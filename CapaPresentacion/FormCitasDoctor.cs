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
    public partial class FormCitasDoctor : Form
    {
        public FormCitasDoctor()
        {
            InitializeComponent();
        }

        public string Doctor { get; set; }
        private void FormCitasDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarCitasDoctor' table. You can move, or remove it, as needed.
            this.FacturarCitasDoctorTableAdapter.Fill(this.FinalProg1DataSet.FacturarCitasDoctor, Doctor);

            this.reportViewer1.RefreshReport();
        }

        private void FormCitasDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
