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

namespace CapaPresentacion
{
    public partial class CrudInternamiento : CrudBase
    {
        public CrudInternamiento()
        {
            InitializeComponent();
        }
        ClaseN CN = new ClaseN();

        #region Guardando info de la fecha
        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            CN.Ingreso = Fecha.Value.ToString("yyyy-MM-dd");
        }
    
        #endregion

        #region Insertar

        public override bool Insertar()
        {
            string IDP = txtIDPaciente.Text; string IDH = txtHabi.Text; string Fecha = CN.Ingreso;

            if ((IDP == "") || (IDH == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarInter @IDHabi=" + int.Parse(IDH) + ", @IDPaciente=" + int.Parse(IDP) + ", @Fecha='" + Fecha + "'");
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
            string ID = txtID.Text; string IDP = txtIDPaciente.Text; string IDH = txtHabi.Text; string Fecha = CN.Ingreso;

            if ((IDP == "") || (IDH == "") || (ID == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarInter @IDInter=" + int.Parse(ID) + ", @IDHabi=" + int.Parse(IDH) + ", @IDPaciente=" + int.Parse(IDP) + ", @Fecha='" + Fecha + "'");
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
            ConsultasBase CB = new ConsultarInternamiento();
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
                    string cmd = string.Format("Execute EliminarInter @IDInter=" + int.Parse(txtID.Text) + "");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha Borrado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Borrar porque este Internamiento no se encuentra registrada\n\n  La siguiente informacion es para el tecnico:\n\n" + ex.Message);

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

        private void txtHabi_KeyPress(object sender, KeyPressEventArgs e)
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
                txtHabi.Text = "";
                txtIDPaciente.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxInternamiento(int.Parse(txtID.Text), txtIDPaciente, txtHabi);
            }
        }


        #endregion

        #region Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarInternamiento(dgvInternamiento);
            txtHabi.Text = "";
            txtIDPaciente.Text = "";
            txtID.Text = "";
        }

        #endregion

        #region Alta Medica Button
        private void btnAlta_Click(object sender, EventArgs e)
        {
            CrudBase CB = new CrudAltaMedica();
            Hide();
            CB.Show();
        }

        #endregion
    }
}
