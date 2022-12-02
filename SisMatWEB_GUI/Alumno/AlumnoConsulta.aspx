<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoConsulta.aspx.cs" Inherits="SisMatWEB_GUI.Alumno.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <!--<div class="row">
        <asp:Label ID="Label1" runat="server" Text="DNI del Alumno">Código</asp:Label>
        <asp:TextBox ID="txtAlumnoId" width="100px" runat="server" CssClass="form__textbox form__textbox--outline"></asp:TextBox>
        <asp:Button ID="btnConsultarAlumno"  runat="server" Text="Consultar" CssClass="form__button" CausesValidation="False" OnClick="btnConsultarAlumno_Click"></asp:Button>
        <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
    </div>-->
    <!--<h2>Resultado</h2> --!>
    <!--<div class="form__content">
        <div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Label" CssClass="form__label">Nombre</asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Label" CssClass="form__label">Apellido</asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Label" CssClass="form__label">DNI</asp:Label>
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Label" CssClass="form__label">Fec. Nac.</asp:Label>
                <asp:TextBox ID="txtFecNac" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Label" CssClass="form__label">Sexo</asp:Label>
                <asp:TextBox ID="txtSexo" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label13" runat="server" Text="Label" CssClass="form__label">Fec. Reg.</asp:Label>
                <asp:TextBox ID="txtFecReg" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Label" CssClass="form__label">Email</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label8" runat="server" Text="Label" CssClass="form__label">Telefono</asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label10" runat="server" Text="Label" CssClass="form__label">Departamento</asp:Label>
                <asp:TextBox ID="txtDepartamento" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label16" runat="server" Text="Label" CssClass="form__label">Distritos</asp:Label>
                <asp:TextBox ID="txtDistrito" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label11" runat="server" Text="Label" CssClass="form__label">Provincia</asp:Label>
                <asp:TextBox ID="txtProvincia" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label9" runat="server" Text="Label" CssClass="form__label">Direccion</asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label12" runat="server" Text="Label" CssClass="form__label">Estado</asp:Label>
                <asp:TextBox ID="txtEstado" runat="server" CssClass="form__textbox--outline" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
    </div>-->
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
</asp:Content>
