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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Tipo { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarIngresosTipo' table. You can move, or remove it, as needed.
            this.FacturarIngresosTipoTableAdapter.Fill(this.FinalProg1DataSet.FacturarIngresosTipo,Tipo);

            this.reportViewer1.RefreshReport();
        }

        #region Cerrar

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
