using SisMat_BE;
using SisMat_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMatWEB_GUI.Cuota
{
    public partial class CuotaMan : System.Web.UI.Page

    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si la pagina se carga por primera vez
            if (!Page.IsPostBack)
            {
                try
                {

                    CuotaBL objCuotaBL = new CuotaBL();

                    grvCuota.DataSource = objCuotaBL.ListarCuota();

                    grvCuota.DataBind();

                    Console.WriteLine(objCuotaBL.ListarCuota());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }



            }
        }
    }
}