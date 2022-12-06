<%@ Page Title="" Culture="es-ES" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BloqueConsulta.aspx.cs" Inherits="SisMatWEB_GUI.Bloque.BloqueConsulta" %>
<% @Import Namespace="System.Globalization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 20px;
    }
    .auto-style2 {
        text-align: center;
        height: 20px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <h2>Consulta de Vacantes</h2>
    <div class="row">
        <div>
            <asp:Label ID="Label14" runat="server" Text="Ingresar cantidad minima de vacantes: " CssClass="form__label"></asp:Label>
            <asp:TextBox ID="txtVacantes" runat="server" CssClass="form__textbox--outline" Width="100px" MaxLength="2"></asp:TextBox>
        </div>
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="txtVacantes" CssClass="error" ErrorMessage="Una cantidad de vacantes es obligatoria"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtVacantes" CssClass="error" ErrorMessage="Solo puede ingresar numeros" ValidationExpression="^[0-9]+$" Enabled="False"></asp:RegularExpressionValidator>
        </div>
        <asp:Button ID="btnConsultarBloqueVacantes"  runat="server" Text="Consultar" CssClass="form__button" CausesValidation="True" OnClick="btnConsultarBloqueVacantes_Click"></asp:Button>
    </div>
    <asp:Label ID="lblRegistros" runat="server" CssClass="form__label py-3"></asp:Label>
    <asp:GridView ID="grvBloques" runat="server" BorderWidth="1px" BorderColor="#A0AEC0" AutoGenerateColumns="False" BackColor="#EDF2F7" Width="100%" EnableSortingAndPagingCallbacks="True" CellPadding="10" GridLines="Vertical">
        <Columns>
            <asp:BoundField DataField="Id_bloque" HeaderText="ID" />
            <asp:BoundField DataField="Descripcion_Curso" HeaderText="Desc. Curso" />
            <asp:BoundField DataField="Nombre_Profesor" HeaderText="Nom. Profesor" />
            <asp:BoundField DataField="Horario" HeaderText="Horario" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Tip_bloque" HeaderText="Tipo. Bloque" />
            <asp:BoundField DataField="Vacantes" HeaderText="Vacantes" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Total_matriculados" HeaderText="Matriculados" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
        </Columns>
        <HeaderStyle BackColor="#1A202C" ForeColor="White" />
    </asp:GridView>

    <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--2 el panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:black ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center" class="auto-style1"> 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" CssClass="labelTitulo" /> 
                            </td> 
                            <td width="12%" class="auto-style2"> 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Middle" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                  <div>
                      <br />
                      <asp:Label ID="lblMensajePopup" runat="server" CssClass="error" />
                  </div>
                  <div>
                       <br />
                  </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="form__button" /> 
                    </div> 
                   <div>
                       <br />
                  </div>
                </asp:Panel> 
                <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />


</asp:Content>
