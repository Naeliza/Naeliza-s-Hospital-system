using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CrudDoctor : CrudBase
    {
        public CrudDoctor()
        {
            InitializeComponent();
        }

        #region Insertar
        public override bool Insertar()
        {
            string nombre = txtNombre.Text; string exe = txtExe.Text; string espe = txtEspecialidad.Text;

            if ((nombre == "") || (exe == "") || (espe == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute InsertarDoctores @Nombre='" + nombre + "', @Exequatur='" + exe + "', @Especialidad='" + espe + "'");
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
            string nombre = txtNombre.Text; string exe = txtExe.Text; string espe = txtEspecialidad.Text;

            if ((txtID.Text == "") || (nombre == "") || (exe == "") || (espe == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute ActualizarDoctores @ID_Medico=" + int.Parse(txtID.Text) + ", @Nombre='" + nombre + "', @Exequatur='" + exe + "', @Especialidad='" + espe + "'");
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

        #region Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ClaseN CN = new ClaseN();
            CN.RefrescarDoctor(dgvMedicos);
            txtNombre.Text = "";
            txtExe.Text = "";
            txtEspecialidad.Text = "";
            txtID.Text = "";
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
                    string cmd = string.Format("Execute EliminarDoctores @ID_Medico=" + int.Parse(txtID.Text) +"");
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

        #region Consultar
        public override void Consultar()
        {
            ConsultasBase CB = new ConsultarMedicos();
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
                txtExe.Text = "";
                txtEspecialidad.Text = "";
                this.Refresh();
            }
            else
            {
                ClaseD CD = new ClaseD();
                CD.llenarTextBoxMedicos(int.Parse(txtID.Text), txtNombre, txtExe, txtEspecialidad);
            }
        }
        #endregion
    }
}
