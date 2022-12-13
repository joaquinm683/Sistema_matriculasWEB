using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SisMat_BL;
using System.Data;
using SisMat_BE;

namespace SisMatWEB_GUI.Alumno
{
    public partial class ListadoPaginadoAlumnos : System.Web.UI.Page
    {
        AlumnoBL objAlumno = new AlumnoBL();
        CarreraBL objCarrera = new CarreraBL();
        UbigeoBL objUbigeo = new UbigeoBL();

        String strTextPagina;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {

                    LlenarCombos();
                    LlenarUbigeo("0", "0", "0");

                    //Llenamos la grilla, llamando al metodo con el flag en falso
                    Filtrar(false);
                    
                }
                

            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        private void LlenarCombos()
        {

            DataTable dtCombos = new DataTable();
            DataRow drFila;

            // Llenamos la tabla de carreras
            dtCombos = objCarrera.ListarCarrera();
            drFila = dtCombos.NewRow();
            drFila["Id_carrera"] = 0;
            drFila["Nom_carrera"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);


            cboCarrera.DataSource = dtCombos;
            cboCarrera.DataTextField = "Nom_carrera";
            cboCarrera.DataValueField = "Id_carrera";
            cboCarrera.DataBind();

        }

        private void LlenarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            DataTable dtCombos = new DataTable();
            DataRow drFila;

            dtCombos = objUbigeo.Ubigeo_Departamentos();
            drFila = dtCombos.NewRow();
            drFila["IdDepa"] = "0";
            drFila["Departamento"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboDepartamento.DataSource = dtCombos;
            cboDepartamento.DataValueField = "IdDepa";
            cboDepartamento.DataTextField = "Departamento";
            cboDepartamento.DataBind();
            cboDepartamento.SelectedValue = IdDepa;

            dtCombos = objUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            drFila = dtCombos.NewRow();
            drFila["IdProv"] = "0";
            drFila["Provincia"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboProvincia.DataSource = dtCombos;
            cboProvincia.DataValueField = "IdProv";
            cboProvincia.DataTextField = "Provincia";
            cboProvincia.DataBind();
            cboProvincia.SelectedValue = IdProv;

            dtCombos = objUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            drFila = dtCombos.NewRow();
            drFila["IdDist"] = "0";
            drFila["Distrito"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboDistrito.DataSource = dtCombos;
            cboDistrito.DataTextField = "Distrito";
            cboDistrito.DataValueField = "IdDist";
            cboDistrito.DataBind();
            cboDistrito.SelectedValue = IdDist;
        }



        private void Filtrar(Boolean blnFlag)
        {

            Int16 pagina = 0;
            String estado;
            String departamento;
            String provincia;
            String distrito;
            String carrera;
            String sexo;
            String foto;

            // Tamaño de pagina : 15
            Int16 intsize = 15;
            Int16 intnumpag;

            // Configuramos los parametros ....
            if (cboDepartamento.SelectedIndex == 0)
            {

                departamento = "";

            }
            else
            {

                departamento = cboDepartamento.SelectedValue;

            }

            if (cboProvincia.SelectedIndex == 0)
            {

                provincia = "";

            }
            else
            {

                provincia = cboProvincia.SelectedValue;

            }

            if (cboDistrito.SelectedIndex == 0)
            {

                distrito = "";

            }
            else
            {

                distrito = cboDistrito.SelectedValue;
                
            }

            if (cboCarrera.SelectedIndex == 0)
            {

                carrera = "";
            }
            else
            {

                carrera = cboCarrera.SelectedItem.ToString();
            }

            if (rblSexo.SelectedIndex == 0)
            {
                sexo = "";
            }
            else
            {
                sexo = rblSexo.SelectedValue;
            }
            


            if (rblFoto.SelectedValue == "Todos")
            {
                foto = "";
            }
            else
            {
                foto = rblFoto.SelectedValue;
            }
            

            if (cboEstado.SelectedValue == "X")
            {
                estado = "";
            }
            else
            {
                estado = cboEstado.SelectedValue;
            }

            if (blnFlag == true)
            {
                //Se obtiene el nro de pagina seleccionado desde el dropdown cboPaginas menos 1

                strTextPagina = cboPaginas.SelectedItem.ToString();
                pagina = Convert.ToInt16(strTextPagina);
                pagina = Convert.ToInt16(pagina - 1);


            }
            else // caso contrario sera siempre la primera pagina
            {
                pagina = 0;

            }

            // Si el combo de paginas esta aun vacio , se cargan las primeras 15 facturas
            if (cboPaginas.Items.Count == 0)
            {
                grvAlumnos.DataSource = objAlumno.ListarAlumnos_Paginacion("","","", "", "","","", 0);

            }
            else 
            {
                grvAlumnos.DataSource = objAlumno.ListarAlumnos_Paginacion(departamento,provincia,distrito,carrera,sexo,estado,foto,pagina);

            }
            grvAlumnos.DataBind();


            Int16 intNumRegistros;
            intNumRegistros = objAlumno.NumPag_ListarAlumnos_Paginacion(departamento,provincia,distrito, carrera,sexo,estado,foto);


            String strValue = cboPaginas.Text;
            cboPaginas.Items.Clear();

            if (intNumRegistros == 0)
            {
                cboPaginas.Items.Add("0");
                cboPaginas.SelectedIndex = 0;

            }
            else
            {

                if (intNumRegistros % intsize == 0)
                {

                    intnumpag = Convert.ToInt16(intNumRegistros / intsize);

                }
                else
                {

                    intnumpag = Convert.ToInt16((intNumRegistros / intsize) + 1);
                }

                for (int indice = 1; indice <= intnumpag; indice = indice + 1)
                {
                    cboPaginas.Items.Add(indice.ToString());
                }

            }

            if (blnFlag == true)
            {
                cboPaginas.Text = strValue;
            }

            // Dormimos la aplicacion 2 segundos simulando la recarga de las paginas en un ambiente real....
            // NOTA : No hacer eso en produccion
            //System.Threading.Thread.Sleep(2000);

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Filtrar(false);
                
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
        protected void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando hay paginas se llama al metodo con el flag en verdadero
            Filtrar(true);
        }

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue == "0")
            {
                LlenarUbigeo("0", "0", "0");
            }
            else { 
            LlenarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
            }
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue == "0")
            {
                LlenarUbigeo("0", "0", "0");
            }
            else {
                LlenarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                    cboProvincia.SelectedValue.ToString(), "01");
            }
            
        }
    }
}