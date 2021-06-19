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
    public partial class FormFacturaAltaFecha : Form
    {
        public FormFacturaAltaFecha()
        {
            InitializeComponent();
        }

        public string Fecha { get; set; }

        private void FormFacturaAltaFecha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarAltaFecha' table. You can move, or remove it, as needed.
            this.FacturarAltaFechaTableAdapter.Fill(this.FinalProg1DataSet.FacturarAltaFecha,Fecha);

            this.reportViewer1.RefreshReport();
        }

        private void FormFacturaAltaFecha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
