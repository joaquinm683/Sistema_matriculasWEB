using SisMat_BE;
using SisMat_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioVentasWEB_GUI
{
    public partial class WebLogin : System.Web.UI.Page
    {

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        Int16 intentos = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                //Si el Login no existe
                if (objUsuarioBE.Username == null)
                {
                    lblMensaje.Text = "Usuario no existe";
                    intentos += 1;
                    ValidaAccesos();
                }

                //Si el login existe, validamos el password...
                if (txtLogin.Text == objUsuarioBE.Username & txtPassword.Text == objUsuarioBE.password)
                {


                    Response.Redirect("/Login/Menu.aspx");
                }
                else
                {
                    lblMensaje.Text = "Usuario o Password incorrectos";
                    intentos += 1;
                    ValidaAccesos();
                }
            }
            else
            {
                lblMensaje.Text = "Usuario o Password obligatorios";
                intentos += 1;
                ValidaAccesos();
            }
        }


        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                lblMensaje.Text = "La Aplicacion ha sido bloqueada temporalmente";
            }
        }
    }

     
    
}