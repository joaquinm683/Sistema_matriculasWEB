<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoConsulta.aspx.cs" Inherits="SisMatWEB_GUI.Alumno.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <h1>Consulta de alumnos</h1>
    <div class="row">
        <asp:Label ID="Label1" runat="server" Text="Label">Código</asp:Label>
        <asp:TextBox ID="txtAlumnoId" width="100px" runat="server" CssClass="form__textbox form__textbox--outline"></asp:TextBox>
        <asp:Button ID="btnConsultarAlumno"  runat="server" Text="Consultar" CssClass="form__button" CausesValidation="False" OnClick="btnConsultarAlumno_Click"></asp:Button>
        <asp:Label ID="lblMensaje" Text="Mensaje" runat="server"></asp:Label>
    </div>
    <h2>Resultado</h2>
    <div class="form__content">
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
    </div>
</asp:Content>
