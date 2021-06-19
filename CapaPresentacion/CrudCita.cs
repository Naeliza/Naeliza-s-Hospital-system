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

namespace CapaPresentacion
{
    public partial class CrudCita : CrudBase
    {
        public CrudCita()
        {
            InitializeComponent();
        }

        ClaseN CN = new ClaseN();

        #region Guardando info de la fecha

        private void Hora_ValueChanged(object sender, EventArgs e)
        {
            CN.Tiempo = Hora.Value.Hour.ToString();
            CN.Minutos = Hora.Value.Minute.ToString();

        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            CN.Dia = Fecha.Value.ToString("yyyy-MM-dd");
        }
        #endregion

        #region Insertar

        public override bool Insertar()
        {
            string IDP = txtIDPaciente.Text; string IDD = txtDoctor.Text; string Fecha = CN.Dia; string Hora = CN.Tiempo; string Min = CN.Minutos;

            if ((IDP == "") || (IDD == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarCitas @IDDoctor=" + int.Parse(IDD) + ", @IDPaciente=" + int.Parse(IDP) + ", @Fecha='" + Fecha + "', @Hora='" + Hora+":"+Min + "'");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha insertado correctamente");
                    ClaseD.Conectar.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede registrar, Verifique que los ID que ingrese se encuentren registrados\n\n  La siguiente informacion es para el tecnico:\n\n" + ex.Message);
                    ClaseD.Conectar.Close();
                    return false;
                }

            }
        }
        #endregion

        #region Actualizar

        public override void Actualizar()
        {
            string ID = txtID.Text; string IDP = txtIDPaciente.Text; string IDD = txtDoctor.Text; string Fecha = CN.Dia; string Hora = CN.Tiempo; string Min = CN.Minutos;

            if ((IDP == "") || (IDD == "") || (ID == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarCitas @IDCita=" + int.Parse(ID) + ", @IDDoctor=" + int.Parse(IDD) + ", @IDPaciente=" + int.Parse(IDP) + ", @Fecha='" + Fecha + "', @Hora='" + Hora + ":" + Min + "'");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Actualizar, Verifique que los ID que ingrese se encuentren registrados\n\n  La siguiente informacion es para el tecnico:\n\n" + ex.Message);
                    ClaseD.Conectar.Close();
                }
            }
        }
        #endregion

        #region Consultas
        public override void Consultar()
        {
            ConsultasBase CB = new ConsultarCitas();
            Hide();
            CB.Show();
        }
        #endregion

        #region Borrar
        public override void Borrar()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe completar el campo ID");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute EliminarCitas @IDCita=" + int.Parse(txtID.Text) + "");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha Borrado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Borrar porque esta Cita no se encuentra registrada\n\n  La siguiente informacion es para el tecnico:\n\n" + ex.Message);

                }
            }
        }
        #endregion

        #region Validar
        private void txtIDPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este campo solo se debe introducir numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este campo solo se debe introducir numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este campo solo se debe introducir numeros");
                e.Handled = true;
                return;
            }
        }
        private void txtID_OnValueChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Para Filtrar debe poner un dato en el campo ID");
                txtDoctor.Text = "";
                txtIDPaciente.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxCitas(int.Parse(txtID.Text), txtDoctor, txtIDPaciente);
            }
        }

        #endregion

        #region Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarCitas(dgvCita);
            txtDoctor.Text = "";
            txtIDPaciente.Text = "";
            txtID.Text = "";
        }
        #endregion

    }
}
