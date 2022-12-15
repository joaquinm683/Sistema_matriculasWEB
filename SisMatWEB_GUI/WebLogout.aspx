<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebLogout.aspx.cs" Inherits="SisMatWEB_GUI.WebLogout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/MasterCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 44%;
        }
        .auto-style2 {
            height: 117px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div style="background-color:white; height:380px; width: 30% ; margin:auto; border-radius:20px; margin-top: 150px">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style5" style="text-align:center" colspan="2">  <h1>Logout</h1>  </td>
        </tr>
        
        <tr>
            <td class="auto-style2">Sesion finalizada con exito.</td>
            
        </tr>
        <tr>
            <td colspan="2"  style="text-align:center">
                <asp:Button ID="btnLogin" runat="server"  Text="Volver al Login"   style="width:200px; height : 60px; background-color:#ad6262; border:none ; border-radius:10px" CssClass="loginbtn" OnClick="btnFinSesion_Click"/>
            </td>
        </tr>
    </table>
          </div>
    </form>
</body>
</html>

