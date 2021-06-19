using System;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodos virtuales

        #region Metodos Virtuales
        public virtual void Borrar()
        {

        }

        public virtual Boolean Insertar()
        {
            return false;
        }

        public virtual void Actualizar()
        {

        }

        public virtual void Consultar()
        {

        }
        #endregion
    }
}
