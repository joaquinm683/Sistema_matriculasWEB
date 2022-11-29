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
    public class AlumnoADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_insert_alumno";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id_Ubigeo", objAlumnoBE.Id_Ubigeo);
                command.Parameters.AddWithValue("@Dni_alum", objAlumnoBE.Dni_alum);

                if (objAlumnoBE.Foto_alum!= null)
                {
                    command.Parameters.AddWithValue("@Foto_alum", objAlumnoBE.Foto_alum);
                }
                command.Parameters.AddWithValue("@Fec_nac", objAlumnoBE.Fec_nac);
                command.Parameters.AddWithValue("@Sexo", objAlumnoBE.Sexo);
                command.Parameters.AddWithValue("@Nom_alum", objAlumnoBE.Nom_alum);
                command.Parameters.AddWithValue("@Ape_alum", objAlumnoBE.Ape_alum);
                command.Parameters.AddWithValue("@Dir_alum", objAlumnoBE.Dir_alum);
                command.Parameters.AddWithValue("@Tel_alum", objAlumnoBE.Tel_alum);
                command.Parameters.AddWithValue("@Email_alum", objAlumnoBE.Email_alum);
                command.Parameters.AddWithValue("@Usu_Registro", objAlumnoBE.Usu_Registro);
                command.Parameters.AddWithValue("@Fec_reg", objAlumnoBE.Fec_Registro);
                command.Parameters.AddWithValue("@Usu_Ult_Mod", objAlumnoBE.Usu_Ult_Mod);
                command.Parameters.AddWithValue("@Fec_Ult_Mod", objAlumnoBE.Fec_Ult_Mod);
                command.Parameters.AddWithValue("@Est_alum", objAlumnoBE.Est_alum);
                /*MATRICULA PARAMETERS*/
                /*
                command.Parameters.AddWithValue("@Id_semestre", objMatriculaBE.Id_semestre);
                command.Parameters.AddWithValue("@Id_carrera", objMatriculaBE.Id_carrera);*/
                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
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

        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_update_alumno";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_alumno", objAlumnoBE.Id_alum);
                command.Parameters.AddWithValue("@Id_Ubigeo", objAlumnoBE.Id_Ubigeo);
                command.Parameters.AddWithValue("@Dni_alum", objAlumnoBE.Dni_alum);
                command.Parameters.AddWithValue("@Foto_alum", objAlumnoBE.Foto_alum);
                command.Parameters.AddWithValue("@Fec_nac", objAlumnoBE.Fec_nac);
                command.Parameters.AddWithValue("@Sexo", objAlumnoBE.Sexo);
                command.Parameters.AddWithValue("@Nom_alum", objAlumnoBE.Nom_alum);
                command.Parameters.AddWithValue("@Ape_alum", objAlumnoBE.Ape_alum);
                command.Parameters.AddWithValue("@Dir_alum", objAlumnoBE.Dir_alum);
                command.Parameters.AddWithValue("@Tel_alum", objAlumnoBE.Tel_alum);
                command.Parameters.AddWithValue("@Email_alum", objAlumnoBE.Email_alum);
                command.Parameters.AddWithValue("@Usu_Ult_Mod", objAlumnoBE.Usu_Ult_Mod);
                command.Parameters.AddWithValue("@Fec_Ult_Mod", objAlumnoBE.Fec_Ult_Mod);
                command.Parameters.AddWithValue("@Est_alum", objAlumnoBE.Est_alum);
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
        public Boolean EliminarAlumno(Int16 strIdAlumno)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_delete_alumno";

                command.Parameters.AddWithValue("@id_alumno", strIdAlumno);
                sqlConnection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException e)
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
        public AlumnoBE ConsultarAlumno(Int16 idAlum)
        {
            try
            {
                AlumnoBE objAlumnoBE = new AlumnoBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_consultar_alumno";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id_alumno", idAlum);
                
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objAlumnoBE.Id_alum = Convert.ToInt16(dr["Id_alum"]);
                    objAlumnoBE.Id_Ubigeo = dr["Id_Ubigeo"].ToString();
                    objAlumnoBE.Dni_alum = dr["Dni_alum"].ToString();
                    if (dr["Foto_alum"] != DBNull.Value)
                    {
                        objAlumnoBE.Foto_alum = (Byte[])(dr["Foto_alum"]);
                    }
                    objAlumnoBE.Fec_nac = Convert.ToDateTime(dr["Fec_nac"]);
                    objAlumnoBE.Sexo = dr["Sexo"].ToString();
                    objAlumnoBE.Nom_alum = dr["Nom_alum"].ToString();
                    objAlumnoBE.Ape_alum = dr["Ape_alum"].ToString();
                    objAlumnoBE.Dir_alum = dr["Dir_alum"].ToString();
                    objAlumnoBE.Tel_alum = dr["Tel_alum"].ToString();
                    objAlumnoBE.Email_alum = dr["Email_alum"].ToString();
                    objAlumnoBE.Usu_Registro = dr["Usu_registro"].ToString();
                    objAlumnoBE.Fec_Registro = Convert.ToDateTime(dr["Fec_reg"].ToString());
                    if (dr["Usu_Ult_Mod"] != DBNull.Value)
                    {
                        objAlumnoBE.Usu_Ult_Mod = dr["Usu_Ult_Mod"].ToString();
                    }
                    if (dr["Fec_Ult_Mod"] != DBNull.Value)
                    {
                        objAlumnoBE.Fec_Ult_Mod = Convert.ToDateTime(dr["Fec_Ult_Mod"]);
                    }
                    objAlumnoBE.Est_alum = Convert.ToInt16(dr["Est_alum"]);
                }
                dr.Close();
                return objAlumnoBE;
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
        public DataTable ListarAlumno()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_listar_alumnos";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Alumnos");
                return dts.Tables["Alumnos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Int16 ConsultarAlumnoCarrera(Int16 idAlum)
        {
            Int16 carrera;
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ConsultarAlumnoCarrera";
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
        public Int16 ConsultarAlumnoSemestre(Int16 idAlum)
        {
            try
            {
                Int16 selectedId;
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ConsultarAlumnoSemestre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_alum", idAlum);
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    selectedId = Convert.ToInt16(dr["Id_semestre"]);
                }
                else
                {
                    throw new Exception("Error consulte TI");
                }
                return selectedId;
            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
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
