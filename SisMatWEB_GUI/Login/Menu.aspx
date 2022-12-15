<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SisMatWEB_GUI.Menu.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 230px;
        }
        .auto-style2 {
            height: 76px;
        }
        .auto-style3 {
            height: 75px;
        }
        .auto-style4 {
            width: 254px;
        }
        .auto-style5 {
            height: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <body>
       <div style="height:500px; width: 800px; background-color:whitesmoke; margin:auto; margin-top:50px; border-radius: 20px">


          
          
          
           <table class="auto-style1">
                   <tr>
                   <td colspan="2">
                      <h1 style="text-align:center" class="auto-style5"> MENU PRINCIPAL</h1>
                   </td</tr>
               <tr>
                   <td rowspan="3" class="auto-style4">
                       <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/database-icon.png" Height="300px" />
                   </td>
                   <td class="auto-style2" style="text-align:center">
                       <asp:Button ID="Button1" runat="server" Text="Alumno"  
                         style="width:250px;
                                height : 80px;
                                background-color:#68aed6;
                                border:none ;
                                border-radius:10px;
                                color:white; 
                                font-weight:bold;
                                font-size:20px" PostBackUrl="~/Consultas/Alumno/AlumnoConsulta.aspx" />
                   </td>
               </tr>
               <tr>
                   <td style="text-align:center">
                       <asp:Button ID="Button2" runat="server" Text="Bloque" 
                           style="width:250px;
                                height : 80px;
                                background-color:#4580a3;
                                border:none ;
                                border-radius:10px;
                                color:white; 
                                font-weight:bold;
                                font-size:20px"  PostBackUrl="~/Consultas/Bloque/BloqueConsulta.aspx" />
                   </td>
               </tr>
               <tr style="text-align:center">
                   <td class="auto-style3">
                       <asp:Button ID="Button3" runat="server" Text="Facturacion Anual" 
                            style="width:250px;
                                height : 80px;
                                background-color:#1e6994;
                                border:none ;
                                border-radius:10px;
                                color:white; 
                                font-weight:bold;
                                font-size:20px"  PostBackUrl="~/Consultas/TotalAnual/FacturacionAnualWeb.aspx" />
                   </td>
               </tr>
           </table>


          
          
          
       </div>


   </body>
</asp:Content>
