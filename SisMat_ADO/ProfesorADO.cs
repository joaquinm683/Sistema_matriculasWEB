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
    public class ProfesorADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_insert_profesor";
                command.Parameters.Clear();

                // command.Parameters.AddWithValue("parametro", objProfesorBE_campoX) PARAMETROS DE ENTRADA

                command.Parameters.AddWithValue("@Id_esp", objProfesorBE.Id_esp);
                command.Parameters.AddWithValue("@Foto_profe", objProfesorBE.Foto_profe);
                command.Parameters.AddWithValue("@Sexo", objProfesorBE.Sexo);
                command.Parameters.AddWithValue("@Dni_profe", objProfesorBE.Dni_profe);
                command.Parameters.AddWithValue("@Nom_profe", objProfesorBE.Nom_profe);
                command.Parameters.AddWithValue("@Ape_profe", objProfesorBE.Ape_profe);

                command.Parameters.AddWithValue("@Tel_profe", objProfesorBE.Tel_profe);
                command.Parameters.AddWithValue("@Email_profe", objProfesorBE.Email_profe);
                command.Parameters.AddWithValue("@Id_Ubigeo", objProfesorBE.Id_Ubigeo);
                command.Parameters.AddWithValue("@Usu_Registro", objProfesorBE.Usu_Registro);
                command.Parameters.AddWithValue("@Est_prof", objProfesorBE.Est_profe);






                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            } catch(SqlException e)
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

        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_update_profesor";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("parametro", objProfesorBE_campoX) PARAMETROS DE ENTRADA


                command.Parameters.AddWithValue("@Id_profe", objProfesorBE.Id_profe);
                command.Parameters.AddWithValue("@Id_esp", objProfesorBE.Id_esp);
                command.Parameters.AddWithValue("@Foto_profe", objProfesorBE.Foto_profe);
                command.Parameters.AddWithValue("@Sexo", objProfesorBE.Sexo);
                command.Parameters.AddWithValue("@Dni_profe", objProfesorBE.Dni_profe);
                command.Parameters.AddWithValue("@Nom_profe", objProfesorBE.Nom_profe);
                command.Parameters.AddWithValue("@Ape_profe", objProfesorBE.Ape_profe);

                command.Parameters.AddWithValue("@Tel_profe", objProfesorBE.Tel_profe);
                command.Parameters.AddWithValue("@Email_profe", objProfesorBE.Email_profe);
                command.Parameters.AddWithValue("@Id_Ubigeo", objProfesorBE.Id_Ubigeo);
                command.Parameters.AddWithValue("@Usu_Ult_Mod", objProfesorBE.Usu_Ult_Mod);
                command.Parameters.AddWithValue("@Est_prof", objProfesorBE.Est_profe);


                sqlConnection.Open();
                command.ExecuteNonQuery();

                return true;

            } catch (SqlException e)
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
        public Boolean EliminarProfesor(Int16 strIdProfesor)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_delete_profesor";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("@Id_profe", strIdProfesor) PARAMETROS DE ENTRADA

                command.Parameters.AddWithValue("@Id_profe", strIdProfesor);


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
        public ProfesorBE ConsultarProfesor(Int16 strIdProfesor)
        {
            try
            {
                ProfesorBE objProfesorBE = new ProfesorBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_consultar_profesor";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("@Id_profe", strIdProfesor) PARAMETROS DE ENTRADA

                command.Parameters.AddWithValue("@Id_profe", strIdProfesor);


                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objProfesorBE.Id_profe = Convert.ToInt16(dr["Id_profe"]);
                    objProfesorBE.Id_Ubigeo = dr["Id_Ubigeo"].ToString();
                    objProfesorBE.Id_esp = Convert.ToInt16(dr["Id_esp"]);
                    objProfesorBE.Foto_profe = (Byte[])(dr["Foto_Profe"]);
                    objProfesorBE.Sexo = dr["Sexo"].ToString();
                    objProfesorBE.Dni_profe = dr["Dni_profe"].ToString();
                    objProfesorBE.Tel_profe = dr["Tel_profe"].ToString();
                    objProfesorBE.Nom_profe = dr["Nom_profe"].ToString();
                    objProfesorBE.Ape_profe = dr["Ape_profe"].ToString();
                    objProfesorBE.Email_profe = dr["Email_profe"].ToString();
                    objProfesorBE.Est_profe = Convert.ToInt16(dr["Est_prof"]);
                }
                dr.Close();
                return objProfesorBE;
            } catch (SqlException e)
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
        public DataTable ListarProfesor()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_listar_profesores";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Profesores");
                return dts.Tables["Profesores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
