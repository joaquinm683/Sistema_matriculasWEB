using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class CarreraADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        public DataTable ListarCarrera()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarCarrera";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Carreras");
                return dts.Tables["Carreras"];
            } catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
        }
        public Int16 ConsultarMatriculaCarrera(Int16 idAlum)
        {
            Int16 carrera;
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ConsultarMatriculaCarrera";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_alum", idAlum);
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    carrera = Convert.ToInt16(dr["Id_carrera"]);
                }
                else
                {
                    throw new Exception("Consulte TI");
                }
                dr.Close();
                return carrera;
            } catch(SqlException e)
            {
                throw new Exception(e.Message);
            } finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
