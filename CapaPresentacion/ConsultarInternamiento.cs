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
    public partial class ConsultarInternamiento : ConsultasBase
    {
        public ConsultarInternamiento()
        {
            InitializeComponent();
        }

        ClaseN CN = new ClaseN();

        #region Mostrar DGV
        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            CN.DiaI = Fecha.Value.ToString("yyyy-MM-dd");
        }

        private void Fecha_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarInternamiento(dgvc);
        }

        private void cbxTexto_TextChanged(object sender, EventArgs e)
        {
            if (cbxTexto.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarInternamiento(dgvc);
            }
        }

        private void ConsultarInternamiento_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarInternamiento(dgvc);
        }


        #endregion

        #region Buscar Por Habitaciones
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
                cmd.CommandText = "Select Ig.ID_Internamiento, P.Nombre as 'Paciente', H.Numero as 'Habitacion', Ig.Fecha_Ingreso as 'Fecha' " +
                    "From Ingresos_Internamientos Ig " +
                    "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ig.ID_Paciente)" +
                    "Inner Join Crud_Habitaciones H on(H.ID_Habitacion = Ig.ID_Habitacion) where H.tipo like('" + Texto + "%')";
                DataTable dtt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtt);

                dgvc.DataSource = dtt;

                ClaseD.Conectar.Close();
            }
        }
        #endregion

        #region Buscar Fecha
        private void btnFecha_Click(object sender, EventArgs e)
        {
            string Fecha = CN.DiaI;
            {
                try
                {
                    SqlDataAdapter da;

                    da = new SqlDataAdapter("Select Ig.ID_Internamiento, P.Nombre as 'Paciente', H.Numero as 'Habitacion', Ig.Fecha_Ingreso as 'Fecha' " +
                    "From Ingresos_Internamientos Ig " +
                    "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ig.ID_Paciente)" +
                     "Inner Join Crud_Habitaciones H on(H.ID_Habitacion = Ig.ID_Habitacion) where Ig.Fecha_Ingreso like('" + Fecha + "%')", ClaseD.Conectar);
                    DataTable dtf = new DataTable();
                    da.Fill(dtf);

                    dgvc.DataSource = dtf;

                    ClaseD.Conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Actualizar, Verifique que los ID que ingrese se encuentren registrados\n\n  La siguiente informacion es para el tecnico:\n\n" + ex.Message);
                    ClaseD.Conectar.Close();
                }

            }
        }

        #endregion

        #region Imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form1 Mostrar = new Form1();
            Mostrar.Tipo = cbxTexto.Text;
            Console.WriteLine(Mostrar.Tipo);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirFecha_Click(object sender, EventArgs e)
        {
            FormFacturaFechaIngreso Mostrar = new FormFacturaFechaIngreso();
            Mostrar.Fecha = CN.DiaI;
            Console.WriteLine(CN.DiaI);
            Mostrar.ShowDialog();
            this.Hide();

        }

        #endregion
    }
}
