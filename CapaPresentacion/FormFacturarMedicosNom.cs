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
    public partial class FormFacturarMedicosNom : Form
    {
        public FormFacturarMedicosNom()
        {
            InitializeComponent();
        }

        #region Filtrar por Nombre
        public string Nombre { get; set; }
        private void FormFacturarMedicosNom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProg1DataSet.FacturarMedicosEspecialidad' table. You can move, or remove it, as needed.
            this.facturarMedicosNombreTableAdapter.Fill(this.FinalProg1DataSet.FacturarMedicosNombre, Nombre);

            this.reportViewer1.RefreshReport();
        }
        #endregion

        #region Cerrar
        private void FormFacturarMedicosNom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
