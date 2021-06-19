using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace CapaDatos
{

	public class ClaseD
	{
		#region Conexion
		public static SqlConnection Conectar = new SqlConnection("Data source = MSI; Initial Catalog = FinalProg1; Integrated Security = True");
		SqlCommand scmd;
		SqlDataReader dr;
		public static DataSet Ejecutar(string cmd)
		{
			Conectar.Open();

			DataSet ds = new DataSet();

			SqlDataAdapter da = new SqlDataAdapter(cmd, Conectar);

			da.Fill(ds);

			Conectar.Close();

			return ds;
		}

		#endregion

		#region Llenando TextBox para mi actualizar
		public void llenarTextBoxMedicos(int id, Bunifu.Framework.UI.BunifuMetroTextbox txtNombre, Bunifu.Framework.UI.BunifuMetroTextbox txtExe, Bunifu.Framework.UI.BunifuMetroTextbox txtEspe)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Crud_Medicos where ID_Medico=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtNombre.Text = dr["Nombre"].ToString();
					txtExe.Text = dr["Exequatur"].ToString();
					txtEspe.Text = dr["Especialidad"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		public void llenarTextBoxPacientes(int id, Bunifu.Framework.UI.BunifuMetroTextbox txtNombre, Bunifu.Framework.UI.BunifuMetroTextbox txtCed, ComboBox txtAse)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Crud_Pacientes where ID_Paciente=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtNombre.Text = dr["Nombre"].ToString();
					txtCed.Text = dr["Cedula"].ToString();
					txtAse.Text = dr["Asegurado"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		public void llenarTextBoxHabitaciones(int id, Bunifu.Framework.UI.BunifuMetroTextbox txtPrecio, Bunifu.Framework.UI.BunifuMetroTextbox txtNum, ComboBox cbxTipo)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Crud_Habitaciones where ID_Habitacion=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtPrecio.Text = dr["Precio"].ToString();
					txtNum.Text = dr["Numero"].ToString();
					cbxTipo.Text = dr["tipo"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		public void llenarTextBoxCitas(int id, Bunifu.Framework.UI.BunifuMetroTextbox txtIDD, Bunifu.Framework.UI.BunifuMetroTextbox txtIDP)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Citas_Medicas where ID_Cita=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtIDD.Text = dr["ID_Medico"].ToString();
					txtIDP.Text = dr["ID_Paciente"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		public void llenarTextBoxInternamiento(int id,  Bunifu.Framework.UI.BunifuMetroTextbox txtIDP, Bunifu.Framework.UI.BunifuMetroTextbox txtIDH)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Ingresos_Internamientos where ID_Internamiento=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtIDP.Text = dr["ID_Paciente"].ToString();
					txtIDH.Text = dr["ID_Habitacion"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		public void llenarTextBoxAlta(int id, Bunifu.Framework.UI.BunifuMetroTextbox txtIDI)
		{
			try
			{
				Conectar.Open();
				scmd = new SqlCommand("Select * from Alta_Medica where ID_Alta=" + id + "", Conectar);
				dr = scmd.ExecuteReader();
				if (dr.Read())
				{
					txtIDI.Text = dr["ID_Internamiento"].ToString();
				}
				dr.Close();
				Conectar.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo conectar: " + ex.ToString());
			}

		}
		#endregion
	}
}
