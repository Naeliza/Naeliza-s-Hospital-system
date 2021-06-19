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
    public partial class FormFacturaFechaIngreso : Form
    {
        public FormFacturaFechaIngreso()
        {
            InitializeComponent();
        }

        public string Fecha { get; set; }

        private void FormFacturaFechaIngreso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarIngresosFechas' table. You can move, or remove it, as needed.
            this.FacturarIngresosFechasTableAdapter.Fill(this.FinalProg1DataSet.FacturarIngresosFechas, Fecha);

            this.reportViewer1.RefreshReport();
        }

        #region Cerrar

        private void FormFacturaFechaIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
