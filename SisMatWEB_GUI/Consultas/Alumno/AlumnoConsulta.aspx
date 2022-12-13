<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoConsulta.aspx.cs" Inherits="SisMatWEB_GUI.Alumno.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="container">
    <h2>Consulta Alumnos Matriculados Entre Fechas 📆</h2>
    <div class="row">
        <div>
            <asp:Label ID="Label14" runat="server" Text="Label" CssClass="form__label">Fecha Inicio</asp:Label>
            <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form__textbox--outline"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="txtFechaInicio_CalendarExtender" runat="server" BehaviorID="txtFechaInicio_CalendarExtender" TargetControlID="txtFechaInicio" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="txtFechaInicio" CssClass="error" ErrorMessage="Una fecha Inicio es obligatoria"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label15" runat="server" Text="Label" CssClass="form__label">Fecha Fin</asp:Label>
            <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form__textbox--outline"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="txtFechaFin_CalendarExtender" runat="server" BehaviorID="txtFechaFin_CalendarExtender" TargetControlID="txtFechaFin" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFechaFin" CssClass="error" ErrorMessage="Una fecha final es obligatoria"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnConsultarAlumnosFechas"  runat="server" Text="Consultar" CssClass="form__button" CausesValidation="True" OnClick="btnConsultarAlumnosFechas_Click"></asp:Button>
    </div>
    <asp:Label ID="lblTotalAlumnos" runat="server" Text="" CssClass="form__label py-3"></asp:Label>
    <asp:GridView ID="grvAlumnos" runat="server" BorderWidth="1px" BorderColor="#A0AEC0" AutoGenerateColumns="false" BackColor="#EDF2F7" Width="100%" EnableSortingAndPagingCallbacks="True" CellPadding="10" GridLines="Vertical" ShowHeaderWhenEmpty="false">
        <Columns>
            <asp:BoundField DataField="Fec_reg" HeaderText="Fec. Registro" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Nom_alum" HeaderText="Nombre" />
            <asp:BoundField DataField="Ape_alum" HeaderText="Apellido" />
            <asp:BoundField DataField="Tel_alum" HeaderText="Telefono" />
            <asp:BoundField DataField="Dni_alum" HeaderText="DNI" />
            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
            <asp:BoundField DataField="Email_alum" HeaderText="Email" />
            <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
            <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" />
        </Columns>
        <HeaderStyle BackColor="#1A202C" ForeColor="White" />
    </asp:GridView>
    <asp:Panel ID="pnlMensajeAlum" runat="server" CssClass="modal__body center" Style="display: normal;" Width="500"> 
        <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:black; color: #FFFFFF;"> 
            <tr> 
                <td align="center" class="auto-style1"> 
                    <asp:Label ID="lblTitulo" runat="server" Text="Error" /> 
                </td> 
                <td width="12%"> 
                    <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" ImageAlign="Middle" /> 
                </td> 
            </tr> 
         </table>
         <div>
            <br />
            <asp:Label ID="modalText" runat="server" CssClass="error" />
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
     <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
     <ajaxToolkit:ModalPopupExtender ID="modal" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensajeAlum" BackgroundCssClass="modal"  OkControlID="btnAceptar" />
        </div>
</asp:Content>
