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
        
        protected void Page_Load(object sender, EventArgs e) {}

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