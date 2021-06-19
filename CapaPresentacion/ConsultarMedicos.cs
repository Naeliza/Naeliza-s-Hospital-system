using CapaDatos;
using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ConsultarMedicos : ConsultasBase
    {
        public ConsultarMedicos()
        {
            InitializeComponent();
        }

        #region Mostrar DGV
        private void ConsultarMedicos_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarDoctor(dgvc);
        }
        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarDoctor(dgvc);
            }
        }

        #endregion

        #region Buscar Por Nombre

        private void btnNom_Click(object sender, EventArgs e)
        {
            string Texto = txtNombre.Text;

            if ((Texto == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                SqlCommand cmd = ClaseD.Conectar.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Crud_Medicos where Nombre like ('" + Texto + "%')";
                DataTable dtn = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtn);

                dgvc.DataSource = dtn;

                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Buscar Por Especialidad

        private void btnEspe_Click(object sender, EventArgs e)
        {
            string Texto = txtNombre.Text;

            if ((Texto == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                SqlCommand cmd = ClaseD.Conectar.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Crud_Medicos where Especialidad like ('" + Texto + "%')";
                DataTable dte = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dte);

                dgvc.DataSource = dte;

                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Imprimir
        private void btnImprimirEspe_Click(object sender, EventArgs e)
        {
            FormFacturaMedicosEspe Mostrar = new FormFacturaMedicosEspe();
            Mostrar.Especialidad = txtNombre.Text;
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirNom_Click(object sender, EventArgs e)
        {
            FormFacturarMedicosNom Mostrar = new FormFacturarMedicosNom();
            Mostrar.Nombre = txtNombre.Text;
            Console.WriteLine(Mostrar.Nombre);
            Mostrar.ShowDialog();
            this.Hide();
        }

        #endregion
    }
}
