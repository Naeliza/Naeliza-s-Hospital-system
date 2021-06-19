using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class ConsultarCitas : ConsultasBase
    {
        public ConsultarCitas()
        {
            InitializeComponent();
        }

        ClaseN CN = new ClaseN();

        #region Guardando info de la fecha
        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            CN.DiaC = Fecha.Value.ToString("yyyy-MM-dd");
        }
        #endregion

        #region Mostrar DGV
        private void ConsultarCitas_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarCitas(dgvc);
        }

        private void Fecha_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarCitas(dgvc);
        }
        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarCitas(dgvc);
            }
        }
        #endregion

        #region Buscar Fecha
        private void btnFecha_Click(object sender, EventArgs e)
        {
            string Fecha = CN.DiaC;
            {
                try
                {
                    SqlDataAdapter da;

                    da = new SqlDataAdapter("Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha," +
                    "Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)" +
                     "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where Fecha like('" + Fecha + "%')", ClaseD.Conectar);
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

        #region Buscar Por Paciente
        private void btnPaciente_Click(object sender, EventArgs e)
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
                cmd.CommandText = "Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha," +
                "Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)" +
                "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where P.Nombre like('" + Texto + "%')";
                DataTable dta = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dta);

                dgvc.DataSource = dta;

                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Buscar Por Doctor

        private void btnDoctor_Click(object sender, EventArgs e)
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
                cmd.CommandText = "Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha," +
                "Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)" +
                "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where D.Nombre like('" + Texto + "%')";
                DataTable dta = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dta);

                dgvc.DataSource = dta;

                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormCitasPacientes Mostrar = new FormCitasPacientes();
            Mostrar.Paciente = txtNombre.Text;
            Console.WriteLine(txtNombre.Text);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirDoctor_Click(object sender, EventArgs e)
        {
            FormCitasDoctor Mostrar = new FormCitasDoctor();
            Mostrar.Doctor = txtNombre.Text;
            Console.WriteLine(txtNombre.Text);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirFecha_Click(object sender, EventArgs e)
        {
            FormCitasFechas Mostrar = new FormCitasFechas();
            Mostrar.Fecha = CN.DiaC;
            Console.WriteLine(CN.DiaC);
            Mostrar.ShowDialog();
            this.Hide();
        }
        #endregion
    }
}
