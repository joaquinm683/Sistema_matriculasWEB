using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisMat_BE;
using System.Data;
using System.Data.SqlClient;

namespace SisMat_ADO
{
    public class BloqueADO
    {

        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public DataTable ConsultarBloquesVacantes(Int16 vacantes)
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarBloquesVacantes";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vacantes", vacantes);
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Bloques");
                return dts.Tables["Bloques"];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



    }
}
