using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        ClaseN.Casillas NegocioCasillas = new ClaseN.Casillas();
        ClaseN Negocio = new ClaseN();

        //Esto para que no haya un Focus cuando corra mi programa en el txtUsuario
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Label1;
        }

        #region Boton Loguearse etc

        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            MetodoLogin();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MetodoLogin();
            }
        }

        private void MetodoLogin()
        {
            var validar = Negocio.Login(txtUsuario.Text, txtContra.Text);
            if (validar == true)
            {
                this.Hide();
                MantenimientoAll Man = new MantenimientoAll();
                Man.Show();
            }
            else
            {
                this.ActiveControl = Label1;
                txtUsuario.Text = "";
                txtContra.Text = "";
                NegocioCasillas.CasillaVaciaUsuario(txtUsuario);
                NegocioCasillas.CasillaVaciaContra(txtContra);
            }
        }
        #endregion

        // Cosas para mi ventana ☻


        #region Validar Casillas Vacias/LLenas

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            NegocioCasillas.CasillaEnterUsuario(txtUsuario);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            NegocioCasillas.CasillaVaciaUsuario(txtUsuario);
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            NegocioCasillas.CasillaEnterContra(txtContra);
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            NegocioCasillas.CasillaVaciaContra(txtContra);
        }

        #endregion

        #region Mover Ventana

        int PosX = 0;
        int PosY = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }

        }
        #endregion

    }
}
