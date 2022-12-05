<%@ Page Title="" Culture="pe-PE" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacturacionAnualWeb.aspx.cs" Inherits="SisMatWEB_GUI.TotalAnual.FacturacionAnualWeb" %>
<% @Import Namespace="System.Globalization" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 80%;
    }
    .auto-style2 {
        height: 17px;
    }
    .auto-style3 {
        height: 22px;
    }
        .auto-style4 {
            height: 22px;
            width: 512px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <h2>Grafico Facturacion Anual</h2>
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
<table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="2" align ="center">
            <asp:GridView ID="grvFacturaAnual" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="292px" Width="450px" AutoGenerateColumns="False" CssClass="py-3">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="Año" HeaderText="Año">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CantAlumMatriculados" HeaderText="AlumnosMatriculados">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="total" DataFormatString="S/.{0:n}" HeaderText="TotalAnual (S/.)">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" align ="center">
            <asp:Chart ID="grfTotales" runat="server" BackColor="WhiteSmoke" BorderlineColor="Transparent" CssClass="auto-style3" Palette="SeaGreen" Width="346px">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
                <Titles>
                    <asp:Title BackColor="Cyan" Font="ArdelaEdgeX01-Black, 9pt, style=Bold" Name="Total de ventas por año" Text="Total de ventas por año">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
        <td class="auto-style3" align ="center">
            <asp:Chart ID="grfMatriculados" runat="server" BackColor="WhiteSmoke" BorderlineColor="Wheat" Palette="EarthTones" Width="346px">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
                <Titles>
                    <asp:Title BackColor="Cyan" Font="ArdelaEdgeX01-Black, 8pt" Name="Alumnos Matriculados por año" Text="Alumnos Matriculados por año">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
</asp:Content>
