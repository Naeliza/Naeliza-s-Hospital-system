using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CrudBase : FormBase
    {
        public CrudBase()
        {
            InitializeComponent();
        }

        #region Mover Ventana
        int PosX = 0;
        int PosY = 0;
        private void bunifuGradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {
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
        }
        #endregion

        #region Botones
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            MantenimientoAll Man = new MantenimientoAll();
            Man.Show();
        }
        #endregion

        #region Cerrar
        private void CrudBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
