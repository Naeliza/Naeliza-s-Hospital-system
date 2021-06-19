using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class ConsultarHabitaciones : ConsultasBase
    {
        public ConsultarHabitaciones()
        {
            InitializeComponent();
        }

        #region Buscar por habitaciones
        private void btnHabi_Click(object sender, EventArgs e)
        {
            string Texto = cbxTexto.Text;

            if ((Texto == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                SqlCommand cmd = ClaseD.Conectar.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Crud_Habitaciones where tipo like ('" + Texto + "%')";
                DataTable dta = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dta);

                dgvc.DataSource = dta;

                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Mostrar DataGridView
        private void ConsultarHabitaciones_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarHabitaciones(dgvc);

        }

        private void cbxTexto_TextChanged(object sender, EventArgs e)
        {
            if (cbxTexto.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarHabitaciones(dgvc);
            }
        }

        #endregion

        #region Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormFacturarHabitacion Mostrar = new FormFacturarHabitacion();
            Mostrar.Tipo = cbxTexto.Text;
            Console.WriteLine(Mostrar.Tipo);
            Mostrar.ShowDialog();
            this.Hide();
        }
        #endregion
    }
}
