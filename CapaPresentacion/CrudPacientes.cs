using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class CrudPacientes : CrudBase
    {
        public CrudPacientes()
        {
            InitializeComponent();
        }

        #region Insertar
        public override bool Insertar()
        {
            string nombre = txtNombre.Text; string ced = txtCed.Text; string ase = cbxAsegurado.Text;

            if ((nombre == "") || (ced == "") || (ase == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarPacientes @Nombre='" + nombre + "', @Cedula='" + ced + "', @Asegurado='" + ase +"'");
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
            string nombre = txtNombre.Text; string ced = txtCed.Text; string ase = cbxAsegurado.Text;

            if ((txtID.Text == "") || (nombre == "") || (ced == "") || (ase == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarPacientes @ID_Paciente=" + int.Parse(txtID.Text) + ", @Nombre='" + nombre + "', @Cedula='" + ced + "', @Asegurado='" + ase + "'");
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
                    string cmd = string.Format("Execute EliminarPacientes @ID_Paciente=" + int.Parse(txtID.Text) + "");
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
                CN.RefrescarPacientes(dgvPacientes);
                txtNombre.Text = "";
                txtCed.Text = "";
                cbxAsegurado.Text = "";
                txtID.Text = "";
        }
        #endregion

        #region Consultar
        public override void Consultar()
        {
            ConsultasBase CB = new ConsultarPacientes();
            Hide();
            CB.Show();
        }
        #endregion  

        #region Validar campo ID
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
                txtNombre.Text = "";
                txtCed.Text = "";
                cbxAsegurado.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxPacientes(int.Parse(txtID.Text), txtNombre, txtCed, cbxAsegurado);
            }
        }
        #endregion

        #region Citas
        private void btnCita_Click(object sender, EventArgs e)
        {
            CrudBase CB = new CrudCita();
            Hide();
            CB.Show();
        }
        #endregion
    }
}
