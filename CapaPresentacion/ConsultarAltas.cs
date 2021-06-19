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
    public partial class ConsultarAltas : ConsultasBase
    {
        public ConsultarAltas()
        {
            InitializeComponent();
        }

        ClaseN CN = new ClaseN();

        #region Mostrar DGV
        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            CN.DiaA = Fecha.Value.ToString("yyyy-MM-dd");
        }

        private void Fecha_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarAltas(dgvc);
        }

        private void ConsultarAltas_Load(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarAltas(dgvc);
        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ClaseN CN = new ClaseN();
                CN.RefrescarAltas(dgvc);
            }
        }

        #endregion

        #region Buscar por Paciente

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
                cmd.CommandText = "Select AL.ID_Alta as 'ID', Hab.Numero As 'Habitacion', Hab.tipo as 'Tipo', Hab.Precio as 'Precio', P.Nombre as 'Paciente', " +
               "Inter.Fecha_Ingreso as 'Ingreso', Al.Fecha_Salida as 'Salida', sum(DATEDIFF(DAY, Inter.Fecha_Ingreso, AL.Fecha_Salida) * Hab.Precio) as 'Monto total' " +
               "From Alta_Medica AL " +
               "Inner Join Ingresos_Internamientos Inter on(AL.ID_Internamiento = Inter.ID_Internamiento) " +
               "Inner Join Crud_Habitaciones Hab on(Inter.ID_Habitacion = Hab.ID_Habitacion) " +
               "inner join Crud_Pacientes P on(Inter.ID_Paciente = P.ID_Paciente) wHERE P.Nombre like('" + Texto + "%')" +
               "Group By Al.ID_Alta, Hab.Numero, Hab.tipo, Hab.Precio, P.Nombre, Inter.Fecha_Ingreso, AL.Fecha_Salida";
                DataTable dtA = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtA);

                dgvc.DataSource = dtA;

                ClaseD.Conectar.Close();
            }
        }
        #endregion

        #region Buscar Fecha
        private void btnFecha_Click(object sender, EventArgs e)
        {
            string Fecha = CN.DiaA;
            {
                try
                {
                    SqlDataAdapter da;

                    da = new SqlDataAdapter("Select AL.ID_Alta as 'ID', Hab.Numero As 'Habitacion', Hab.tipo as 'Tipo', Hab.Precio as 'Precio', P.Nombre as 'Paciente', " +
                    "Inter.Fecha_Ingreso as 'Ingreso', Al.Fecha_Salida as 'Salida', sum(DATEDIFF(DAY, Inter.Fecha_Ingreso, AL.Fecha_Salida) * Hab.Precio) as 'Monto total' " +
                    "From Alta_Medica AL  " +
                    "Inner Join Ingresos_Internamientos Inter on(AL.ID_Internamiento = Inter.ID_Internamiento)" +
                    "Inner Join Crud_Habitaciones Hab on(Inter.ID_Habitacion = Hab.ID_Habitacion)" +
                    "inner join Crud_Pacientes P on(Inter.ID_Paciente = P.ID_Paciente) WHERE AL.Fecha_Salida like('" + Fecha + "%') " +
                    "Group By Al.ID_Alta, Hab.Numero, Hab.tipo, Hab.Precio, P.Nombre, Inter.Fecha_Ingreso, AL.Fecha_Salida", ClaseD.Conectar);
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
            FormFacturarAltaPaciente Mostrar = new FormFacturarAltaPaciente();
            Mostrar.Paciente = txtNombre.Text;
            Console.WriteLine(txtNombre.Text);
            Mostrar.ShowDialog();
            this.Hide();
        }

        private void btnImprimirFecha_Click(object sender, EventArgs e)
        {
            FormFacturaAltaFecha Mostrar = new FormFacturaAltaFecha();
            Mostrar.Fecha = CN.DiaA;
            Console.WriteLine(CN.DiaA);
            Mostrar.ShowDialog();
            this.Hide();
        }
        #endregion
    }
}
