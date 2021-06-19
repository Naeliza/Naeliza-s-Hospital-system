using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class CrudHabitaciones : CrudBase
    {
        public CrudHabitaciones()
        {
            InitializeComponent();
        }

        #region Insertar
        public override bool Insertar()
        {
            string precio = txtPrecio.Text; string num = txtNum.Text; string tipo = cbxTipo.Text;

            if ((precio == "") || (num == "") || (tipo == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarHabitacion @Precio=" + int.Parse(precio) + ", @Numero=" + int.Parse(num) + ", @tipo='" + tipo + "'");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha insertado correctamente");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede registrar, Ya se encuentra en uso: " + ex.ToString());
                    return false;
                }
            }
        }
        #endregion

        #region Actualizar

        public override void Actualizar()
        {
            string precio = txtPrecio.Text; string num = txtNum.Text; string tipo = cbxTipo.Text;

            if ((txtID.Text == "") || (precio == "") || (num == "") || (tipo == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarHabitacion @ID_Habitacion=" + int.Parse(txtID.Text) + ", @Precio=" + int.Parse(precio) + ", @Numero=" + int.Parse(num) + ", @tipo='" + tipo + "'");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Esta persona no se encuentra registrada " + ex.ToString());

                }
            }
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
                    string cmd = string.Format("Execute EliminarHabitacion @ID_Habitacion=" + int.Parse(txtID.Text) + "");
                    ClaseD.Ejecutar(cmd);
                    MessageBox.Show("Se ha Borrado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Borrar porque esta persona no se encuentra registrada " + ex.ToString());

                }
            }
        }

        #endregion

        #region Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarHabitaciones(dgvHabi);
            txtPrecio.Text = "";
            txtNum.Text = "";
            cbxTipo.Text = "";
            txtID.Text = "";
        }
        #endregion

        #region Consultar
        public override void Consultar()
        {
            ConsultasBase CB = new ConsultarHabitaciones();
            Hide();
            CB.Show();
        }

        #endregion

        #region Validar campo ID & Tipo
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
                txtPrecio.Text = "";
                txtNum.Text = "";
                cbxTipo.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxHabitaciones(int.Parse(txtID.Text), txtPrecio, txtNum, cbxTipo);
            }
        }

        private void cbxTipo_TextChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "Suite")
            {
                txtPrecio.Text = "7500";
            }
            else if(cbxTipo.Text == "Privada")
            {
                txtPrecio.Text = "5000";
            }
            else if (cbxTipo.Text == "Doble")
            {
                txtPrecio.Text = "2000";
            }
        }
        #endregion

        #region Boton Internamiento
        private void btnInternar_Click(object sender, EventArgs e)
        {
            CrudBase CB = new CrudInternamiento();
            Hide();
            CB.Show();
        }

        #endregion
    }
}
