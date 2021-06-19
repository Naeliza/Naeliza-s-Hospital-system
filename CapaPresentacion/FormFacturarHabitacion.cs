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
    public partial class FormFacturarHabitacion : Form
    {
        public FormFacturarHabitacion()
        {
            InitializeComponent();
        }

        public String Tipo { get; set; }

        private void FormFacturarHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarHabitaciones' table. You can move, or remove it, as needed.
            this.FacturarHabitacionesTableAdapter.Fill(this.FinalProg1DataSet.FacturarHabitaciones, Tipo);

            this.reportViewer1.RefreshReport();
        }

        #region Cerrar
        private void FormFacturarHabitacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
