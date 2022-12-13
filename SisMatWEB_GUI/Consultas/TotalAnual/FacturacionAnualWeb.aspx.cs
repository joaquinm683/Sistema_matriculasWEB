using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SisMat_BL;

namespace SisMatWEB_GUI.TotalAnual
{
    public partial class FacturacionAnualWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				if(Page.IsPostBack == false)
				{
					FacturacionBL objFacturacionBL = new FacturacionBL();
					grvFacturaAnual.DataSource= objFacturacionBL.ListarFacturaAnual();
					grvFacturaAnual.DataBind();

					//grfTotales
					DataTableReader dtReaderTotales = objFacturacionBL.ListarFacturaAnual().CreateDataReader();
					grfTotales.Series.Add("Totales");
					grfTotales.Series["Totales"].Points.DataBindXY(dtReaderTotales,"Año",dtReaderTotales,"total");
					grfTotales.Series["Totales"].IsValueShownAsLabel= true;
					grfTotales.Series["Totales"].LabelFormat = "c";

					//grfMatriculados
					DataTableReader dtReaderMatriculados = objFacturacionBL.ListarFacturaAnual().CreateDataReader();
                    grfMatriculados.Series.Add("Matriculados");
                    grfMatriculados.Series["Matriculados"].Points.DataBindXY(dtReaderMatriculados,"Año", dtReaderMatriculados,"CantAlumMatriculados");
                    grfMatriculados.Series["Matriculados"].IsValueShownAsLabel = true;
					grfMatriculados.Series["Matriculados"].LabelFormat = "n";
				}
			}
			catch (Exception ex)
			{

				lblMensaje.Text = ex.Message;
			}
        }
    }
}