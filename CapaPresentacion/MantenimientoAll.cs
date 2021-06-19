using System;
using System.Windows.Forms;

namespace CapaPresentacion
{

    //INTERFAZ

    #region Interfaz
    interface IAviso
    {
        string Aviso();
    }
    #endregion
    public partial class MantenimientoAll : FormBase, IAviso
    {
        public MantenimientoAll()
        {
            InitializeComponent();
        }

        //Implementado la Interfaz

        #region Interfaz Implementada
        public string Aviso()
        {
            return "Bienvenidos a nuestro menu de mantenimiento, \n Realizado por Naomi Céspedes \n Matricula: 2019-8127";
        }

        private void MantenimientoAll_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Aviso());
        }
        #endregion

        #region Mover Ventana
        int PosX = 0;
        int PosY = 0;
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
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

        #region Cerrar
        private void MantenimientoAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        //Aca Tambien aplico POLIMORFISMO para los Cruds

        CrudBase CB;

        #region Polimorfismo

        private void button1_Click(object sender, EventArgs e)
        {
            CB = new CrudDoctor();
            this.Hide();
            CB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CB = new CrudPacientes();
            this.Hide();
            CB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CB = new CrudHabitaciones();
            this.Hide();
            CB.Show();
        }
        #endregion

    }
}
