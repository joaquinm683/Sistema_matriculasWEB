<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SisMatWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">

    <div style="margin:auto ; margin-top: 200px; background-color:whitesmoke; width:600px; border-radius:10px; padding:10px">

    <table align="center" class="auto-style1">
        <tr>
            <td colspan="2">  <h1 style="text-align:center">Consultas</h1> </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" CssClass="form__textbox--outline" PostBackUrl="~/Login/Menu.aspx" Text="Retornar al menu" />
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="XPFileExplorer" NodeIndent="15">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                    <Nodes>
                        <asp:TreeNode Text="Alumno" Value="New Nsadadode">
                            <asp:TreeNode NavigateUrl="~/Consultas/Alumno/AlumnoConsulta.aspx" Text="Alumno Consulta" Value="New Node"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/Consultas/Alumno/ListadoPaginadoAlumnos.aspx" Text="Listado Paginado" Value="Listado Paginado"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Bloque" Value="Bloque">
                            <asp:TreeNode NavigateUrl="~/Consultas/Bloque/BloqueConsulta.aspx" Text="Bloque Consulta" Value="Bloque Consulta"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Total Anual" Value="Total Anual">
                            <asp:TreeNode NavigateUrl="~/Consultas/TotalAnual/FacturacionAnualWeb.aspx" Text="Facturacion Anual" Value="Facturacion Anual"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
            </td>
            <td class="auto-style2">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/menu.gif" Width="250px" />
            </td>
        </tr>
    </table>

        </div>
</asp:Content>
