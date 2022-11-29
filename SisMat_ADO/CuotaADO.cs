using SisMat_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class CuotaADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public Boolean InsertarCuota(CuotaBE objCuotaBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_insert_cuota";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Id_Alum", objCuotaBE.Id_alum);
                command.Parameters.AddWithValue("Ndoc_cuota", objCuotaBE.Ndoc_cuota);


                if(objCuotaBE.Fec_pago.Year ==9999)
                {
                    command.Parameters.AddWithValue("Fecha_pago", null);
                }
                else {
                    command.Parameters.AddWithValue("Fecha_pago", objCuotaBE.Fec_pago);

                }
                command.Parameters.AddWithValue("Est_cuota", objCuotaBE.Est_cuota);
                command.Parameters.AddWithValue("Tip_cuota", objCuotaBE.Tip_cuota);
                command.Parameters.AddWithValue("Vencimiento", objCuotaBE.Vencimiento);
                command.Parameters.AddWithValue("Precio_cuota", objCuotaBE.Precio_cuota);



       




        //   // command.Parameters.AddWithValue("parametro", objCuotaBE_campoX) PARAMETROS DE ENTRADA
        sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean ActualizarCuota(CuotaBE objCuotaBE)
        {
            sqlConnection.ConnectionString = ADOconnection.GetCnx();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_update_cuota";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("Id_Cuota", objCuotaBE.Id_cuota);
            command.Parameters.AddWithValue("Id_Alum", objCuotaBE.Id_alum);
            command.Parameters.AddWithValue("Ndoc_cuota", objCuotaBE.Ndoc_cuota);
            if (objCuotaBE.Fec_pago.Year == 9999)
            {
                command.Parameters.AddWithValue("Fecha_pago", null);
            }
            else
            {
                command.Parameters.AddWithValue("Fecha_pago", objCuotaBE.Fec_pago);

            }
            command.Parameters.AddWithValue("Est_cuota", objCuotaBE.Est_cuota);
            command.Parameters.AddWithValue("Tip_cuota", objCuotaBE.Tip_cuota);
            command.Parameters.AddWithValue("Vencimiento", objCuotaBE.Vencimiento);
            command.Parameters.AddWithValue("Precio_cuota", objCuotaBE.Precio_cuota);          
            sqlConnection.Open();
            command.ExecuteNonQuery();
            return true;
        }
        public CuotaBE ConsultarCuota(String idCuota)
        {
            try
            {
                CuotaBE objCuotaBE = new CuotaBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_consultar_cuota";
                command.Parameters.AddWithValue("id_cuota", idCuota);
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objCuotaBE.Id_cuota = Convert.ToInt16(dr["Id_cuota"]);
                    objCuotaBE.Id_alum = Convert.ToInt16(dr["Id_alum"]);
                    objCuotaBE.Ndoc_cuota = dr["Ndoc_cuota"].ToString();


                    if (dr["Fecha Pago"] != DBNull.Value)
                    {
                        objCuotaBE.Fec_pago = DateTime.ParseExact(Convert.ToString(dr["Fecha Pago"]), "dd/MM/yyyy", null); 
                    }

                                       
                    objCuotaBE.Est_cuota = Convert.ToInt16(dr["Est_cuota"]);
                    objCuotaBE.Tip_cuota = Convert.ToInt16(dr["Tip_cuota"]);
                    objCuotaBE.Vencimiento = DateTime.ParseExact(Convert.ToString(dr["Vencimiento"]), "dd/MM/yyyy", null);
                    objCuotaBE.Precio_cuota = Convert.ToSingle(dr["Precio"]);

                    
                }
                dr.Close();

                return objCuotaBE;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public DataTable ListarCuota()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_listar_cuota";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Cuotas");
                return dts.Tables["Cuotas"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarCuota(Int16 idCuota)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_EliminarCuota";

                // command.Parameters.AddWithValue("parametro", idCuota) ELIMINAR = CAMBIAR ESTADO A PAGADO
                sqlConnection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
