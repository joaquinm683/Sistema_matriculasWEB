using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class SemestreADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public DataTable ListaSemestre()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarSemestre";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Semestres");
                return dts.Tables["Semestres"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
