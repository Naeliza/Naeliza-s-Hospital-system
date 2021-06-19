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
    public partial class FormCitasFechas : Form
    {
        public FormCitasFechas()
        {
            InitializeComponent();
        }

        public string Fecha { get; set; }
        private void FormCitasFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarCitasFechas' table. You can move, or remove it, as needed.
            this.FacturarCitasFechasTableAdapter.Fill(this.FinalProg1DataSet.FacturarCitasFechas, Fecha);

            this.reportViewer1.RefreshReport();
        }

        private void FormCitasFechas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
