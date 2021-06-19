using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ClaseN : Abstracta
    {

        //Esto es un validar para mis casillas.
        public class Casillas
        {
            //ABSTRACCION & ENCAPSULAMIENTO

            #region Constructor
            public Casillas()
            {

                Vacio = "";
                Usuario = "User";
                Contra = "Password";
            }

            #endregion

            #region Atributos

            private string vacio, usuario, contra;

            #endregion

            #region Propiedades

            public string Vacio { get => vacio; set => vacio = value; }
            public string Usuario { get => usuario; set => usuario = value; }
            public string Contra { get => contra; set => contra = value; }

            #endregion

            #region Metodos

            public void CasillaVaciaUsuario(Bunifu.Framework.UI.BunifuMetroTextbox Texto)
            {

                if (Texto.Text == Vacio)
                {
                    Texto.Text = Usuario;
                }

            }

            public void CasillaEnterUsuario(Bunifu.Framework.UI.BunifuMetroTextbox Texto)
            {
                if (Texto.Text == Usuario)
                {
                    Texto.Text = Vacio;
                }
            }

            public void CasillaVaciaContra(Bunifu.Framework.UI.BunifuMetroTextbox Text)
            {

                if (Text.Text == Vacio)
                {
                    Text.Text = Contra;
                    Text.isPassword = false;
                }

            }

            public void CasillaEnterContra(Bunifu.Framework.UI.BunifuMetroTextbox Text)
            {
                if (Text.Text == Contra)
                {
                    Text.Text = Vacio;
                    Text.isPassword = true;

                }
            }

            #endregion
        }

        //HERENCIA de mi clase abstracta

        #region MetodoLogin
        public bool Login(string user, string pass)
        {
            try
            {
                using (var Conexion = GetSqlConnection())
                {
                    Conexion.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexion;
                        cmd.CommandText = "SELECT Nombre, Contraseña from Usuarios where Nombre='" + user + "' AND Contraseña='" + pass + "'";
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Gracias por loguearte");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Te equivocas de Usuario");
                                return false;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        //Metodos que utilizo para refrescar mi Crud

        # region Metodos Refrescar
        public void RefrescarDoctor(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select * from Crud_Medicos", ClaseD.Conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }

        }
        public void RefrescarPacientes(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select * from Crud_Pacientes", ClaseD.Conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }
        }
        public void RefrescarHabitaciones(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select * from Crud_Habitaciones", ClaseD.Conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }
        }
        public void RefrescarCitas(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha, + " +
                    "Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico) " +
                    " Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente)", ClaseD.Conectar);

                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }
        }
        public void RefrescarInternamiento(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select Ig.ID_Internamiento as 'ID Internos', P.Nombre as 'Paciente', H.Numero as 'Habitacion', Ig.Fecha_Ingreso as 'Fecha'" +
                    "From Ingresos_Internamientos Ig " +
                    "Inner Join Crud_Pacientes P on(P.ID_Paciente = Ig.ID_Paciente) " +
                    "Inner Join Crud_Habitaciones H on(H.ID_Habitacion = Ig.ID_Habitacion)", ClaseD.Conectar);

                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }
        }
        public void RefrescarAltas(DataGridView dgvc)
        {
            try
            {
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select AL.ID_Alta as 'ID', Hab.Numero As 'Habitacion', Hab.tipo as 'Tipo', Hab.Precio as 'Precio', P.Nombre as 'Paciente', " +
                    "Inter.Fecha_Ingreso as 'Ingreso', Al.Fecha_Salida as 'Salida', sum(DATEDIFF(DAY, Inter.Fecha_Ingreso, AL.Fecha_Salida) * Hab.Precio) as 'Monto total'" +
                    "From Alta_Medica AL " +
                    "Inner Join Ingresos_Internamientos Inter on(AL.ID_Internamiento = Inter.ID_Internamiento) " +
                    "Inner Join Crud_Habitaciones Hab on(Inter.ID_Habitacion = Hab.ID_Habitacion) " +
                    "Inner join Crud_Pacientes P on(Inter.ID_Paciente = P.ID_Paciente) " +
                    "Group By Al.ID_Alta, Hab.Numero, Hab.tipo, Hab.Precio, P.Nombre, Inter.Fecha_Ingreso, AL.Fecha_Salida", ClaseD.Conectar);

                dt = new DataTable();
                da.Fill(dt);
                dgvc.DataSource = dt;
                ClaseD.Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consultar bien: " + ex.ToString());
                ClaseD.Conectar.Close();
            }
        }

        #endregion

        #region Atributos para fechas
        public string Dia { get; set; }
        public string DiaA { get; set; }
        public string DiaC { get; set; }
        public string DiaI { get; set; }
        public string Ingreso { get; set; }
        public string Salida { get; set; }
        public string Minutos { get; set; }
        public string Tiempo { get; set; }
        #endregion
    }
}
