using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ConsultasBase : FormBase
    {
        public ConsultasBase()
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
        
        #region Cerrar
        private void ConsultasBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
        #endregion

        #region Botones
        private void btnAtras_Click(object sender, EventArgs e)
        { 
            Hide();
            MantenimientoAll Man = new MantenimientoAll();
            Man.Show();
        }
        #endregion
    }
}
