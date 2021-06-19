using System.Data.SqlClient;

namespace CapaDatos
{
    //Clase Abstracta
    public abstract class Abstracta
    {
        private readonly string Conectar;

        #region Constructor

        public Abstracta()
        {
            Conectar = "Data source = MSI; Initial Catalog = FinalProg1; Integrated Security = True";
        }

        #endregion

        #region Metodo


        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(Conectar);
        }

        #endregion
    }
}
