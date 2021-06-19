using CapaDatos;
using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ConsultarPacientes : ConsultasBase
    {
        public ConsultarPacientes()
        {
            InitializeComponent();
        }

        #region Buscar Por Nombre
        private void btnNom_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM Crud_Pacientes where Nombre like ('" + Texto + "%')";
                DataTable dtn = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtn);

                dgvc.DataSource = dtn;

                ClaseD.Conectar.Close();
            }
        }
        #endregion

        #region Buscar Por Cedula
        private void btnCed_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM Crud_Pacientes where Cedula like ('" + Texto + "%')";
                DataTable dtc = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtc);

                dgvc.DataSource = dtc;

                ClaseD.Conectar.Close();
            }
        }
        #endregion

        #region Buscar Por Seguro
        private void btnAse_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM Crud_Pacientes where Asegurado like ('" + Texto + "%')";
                DataTable dta = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dta);

                dgvc.DataSource = dta;

                ClaseD.Conectar.Close();
            }
        }
        #endregion

        #region Mostrar DGV
        private void cbxTexto_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarPacientes(dgvc);
            }
        }

        private void ConsultarPacientes_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarPacientes(dgvc);
        }

        #endregion

        #region Imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormReportePaciente Mostrar = new FormReportePaciente();
            Mostrar.Nombre = cbxTexto.Text;
            Console.WriteLine(Mostrar.Nombre);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirAsegurado_Click(object sender, EventArgs e)
        {
            FormReporteAsegurado Mostrar = new FormReporteAsegurado();
            Mostrar.Asegurado = cbxTexto.Text;
            Console.WriteLine(Mostrar.Asegurado);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirCed_Click(object sender, EventArgs e)
        {
            FormReporteCedula Mostrar = new FormReporteCedula();
            Mostrar.Cedula = cbxTexto.Text;
            Console.WriteLine(Mostrar.Cedula);
            Mostrar.ShowDialog();
            this.Hide();
        }

        #endregion
    }
}
