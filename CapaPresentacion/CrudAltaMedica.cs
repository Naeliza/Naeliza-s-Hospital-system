using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class CrudAltaMedica : CrudBase
    {
        public CrudAltaMedica()
        {
            InitializeComponent();
        }

        ClaseN CN = new ClaseN();

        #region Guardando info de la fecha

        private void FechaSalida_ValueChanged(object sender, EventArgs e)
        {
            CN.Salida = FechaSalida.Value.ToString("yyyy-MM-dd");
        }

        #endregion

        #region Insertar

        public override bool Insertar()
        {
            string IDI = txtIDInternamiento.Text; string Fecha = CN.Salida;

            if ((IDI == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarAlta @IDInter=" + int.Parse(IDI) + ", @FechaSal='" + Fecha + "'");
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
            string ID = txtID.Text; string IDI = txtIDInternamiento.Text; string Fecha = CN.Salida;

            if ((IDI == "") || (ID == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarAlta @IDAlta=" + int.Parse(ID) + ",  @IDInter=" + int.Parse(IDI) + ", @FechaSal='" + Fecha + "'");
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
            ConsultasBase CB = new ConsultarAltas();
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
                    string cmd = string.Format("Execute EliminarAlta @IDAlta=" + int.Parse(txtID.Text) + "");
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

        #region Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarAltas(dgvAltas);
            txtIDInternamiento.Text = "";
            txtID.Text = "";
        }

        #endregion

        #region Validar

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
                txtIDInternamiento.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxAlta(int.Parse(txtID.Text), txtIDInternamiento);
            }
        }


        private void txtIDInternamiento_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este campo solo se debe introducir numeros");
                e.Handled = true;
                return;
            }
        }
        #endregion

    }
}
