<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CuotaMan.aspx.cs" Inherits="SisMatWEB_GUI.Cuota.CuotaMan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 165px;
        }
        .auto-style2 {
            width: 351px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <h1>Tabla</h1>
    <p>&nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:GridView ID="grvCuota" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" ShowHeaderWhenEmpty="True">
                    <Columns>
                        <asp:BoundField DataField="Id_Cuota" HeaderText="ID" />
                        <asp:BoundField DataField="NombreCompleto" HeaderText="Alumno" />
                        <asp:BoundField DataField="Ndoc_cuota" HeaderText="N. Cuota" />
                        <asp:BoundField DataField="TipoCuota" HeaderText="Tipo Cuota" />
                        <asp:BoundField DataField="Fecha pago" HeaderText="Fecha Pago" />
                        <asp:BoundField DataField="EstadoCuota" HeaderText="Estado" />
                        <asp:BoundField DataField="Vencimiento" HeaderText="Vencimiento" />
                        <asp:BoundField DataField="Precio" DataFormatString="{0:n}" HeaderText="Precio" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox1" />
                <br />
                Prueba Ajax</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
