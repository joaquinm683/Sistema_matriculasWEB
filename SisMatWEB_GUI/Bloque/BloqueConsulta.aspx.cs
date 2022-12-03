using SisMat_BL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMatWEB_GUI.Bloque
{
    public partial class BloqueConsulta : System.Web.UI.Page
    {
        //Cultura
        CultureInfo MiCultura = new CultureInfo("es-ES");
        BloqueBL objBloqueBL = new BloqueBL();



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultarBloqueVacantes_Click(object sender, EventArgs e)
        {
            try
            {
                grvBloques.DataSource = objBloqueBL.ConsultarBloquesVacantes(Convert.ToInt16(txtVacantes.Text.Trim()));
                grvBloques.DataBind();

                Single total = grvBloques.Rows.Count;

                lblRegistros.Text = (total == 0) ? "0 resultados intente una cantidad diferente" : "Total " + total + (total != 1 ? " resultados" : " resultado");
            }
            catch (Exception ex)
            {
                //lblMensajePopup.Text = "Error: " + ex.Message;
                //PopMensaje.Show();

            }
        }
    }
}