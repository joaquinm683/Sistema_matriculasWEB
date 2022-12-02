using SisMat_BE;
using SisMat_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMatWEB_GUI.Alumno
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        AlumnoBL alumnoBL = new AlumnoBL();
        UbigeoBL ubigeoBL = new UbigeoBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void btnConsultarAlumno_Click(object sender, EventArgs e)
        {/*
            try
            {
                //TODO: AGREGAR UNA CULTURA

                AlumnoBE objAlumno = alumnoBL.ConsultarAlumnoByDNI(txtAlumnoId.Text.Trim());

                //IF NO EXISTE ALUMNO
                if (objAlumno.Nom_alum == null & objAlumno.Ape_alum == null) {
                    throw new Exception("Ingrese un DNI Correcto");
                }

                lblMensaje.Text = "";

                String alumnoProvincia = "";
                String alumnoDistrito = "";
                String alumnoDepartamento = "";

                String idDepartamento = objAlumno.Id_Ubigeo.ToString().Substring(0, 2);
                String idProvincia = objAlumno.Id_Ubigeo.ToString().Substring(2, 2);
                String idDistrito = objAlumno.Id_Ubigeo.ToString().Substring(4, 2);

                DataTable departamentos = ubigeoBL.Ubigeo_Departamentos();
                DataTable provincias = ubigeoBL.Ubigeo_ProvinciasDepartamento(idDepartamento);
                DataTable distritos = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(idDepartamento, idProvincia);

                DataRow dr = departamentos.NewRow();
                

                foreach (DataRow row in departamentos.Rows)
                {
                    if (row["IDDEPA"].ToString() == idDepartamento)
                    {
                        alumnoDepartamento = row["DEPARTAMENTO"].ToString();
                    }
                }
               
                foreach (DataRow row in provincias.Rows)
                {
                    if (row["IDPROV"].ToString() == idProvincia)
                    {
                        alumnoProvincia = row["PROVINCIA"].ToString();
                    }
                }

                foreach (DataRow row in distritos.Rows)
                {
                    if (row["IDDIST"].ToString() == idDistrito)
                    {
                        alumnoDistrito = row["DISTRITO"].ToString();
                    }
                }

                txtDepartamento.Text = alumnoDepartamento;
                txtDistrito.Text = alumnoDistrito;
                txtProvincia.Text = alumnoProvincia;
                txtNombre.Text = objAlumno.Nom_alum.ToString();
                txtApellido.Text = objAlumno.Ape_alum.ToString();
                txtDNI.Text = objAlumno.Dni_alum.ToString();
                txtDireccion.Text = objAlumno.Dir_alum.ToString();
                txtTelefono.Text = objAlumno.Tel_alum.ToString();
                txtEmail.Text = objAlumno.Email_alum.ToString();
                txtFecNac.Text = Convert.ToDateTime(objAlumno.Fec_nac).ToString();
                txtFecReg.Text = Convert.ToDateTime(objAlumno.Fec_Registro).ToString();
                txtEstado.Text = Convert.ToByte(objAlumno.Est_alum) == 1 ? "ACTIVO" : "INACTIVO";
                txtSexo.Text = objAlumno.Sexo.ToString() == "M" ? "Masculino" : "Femenino";
             
            } catch(Exception ex)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDepartamento.Text = "";
                txtDireccion.Text = "";
                txtDistrito.Text = "";
                txtDNI.Text = "";
                txtEmail.Text = "";
                txtEstado.Text = "";
                txtFecNac.Text = "";
                txtFecReg.Text = "";
                txtProvincia.Text = "";
                txtSexo.Text = "";
                txtTelefono.Text = "";

                lblMensaje.Text = ex.Message;   
            }*/
        }

        protected void btnConsultarAlumnosFechas_Click(object sender, EventArgs e)
        {
            try
            {
                grvAlumnos.DataSource = alumnoBL.ConsultarAlumnoMatriculadoEntreFechas(
                    Convert.ToDateTime(txtFechaInicio.Text.Trim()),
                    Convert.ToDateTime(txtFechaFin.Text.Trim())
                );
                grvAlumnos.DataBind();

                Single total = grvAlumnos.Rows.Count;

                lblTotalAlumnos.Text = (total == 0) ? "0 resultados intente un rango entre Enero y Diciembre del 2022" : "Total " + total + (total != 1 ? " resultados" : " resultado");
            } catch (Exception _) {}
        }
    }
}