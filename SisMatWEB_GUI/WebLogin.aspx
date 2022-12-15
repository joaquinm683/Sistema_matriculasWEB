<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="SitioVentasWEB_GUI.WebLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/MasterCSS.css" rel="stylesheet" type="text/css" />
  <style type="text/css">
        .auto-style1 {
            width: 60%;
            height: 350px;
        }
        .auto-style3 {
            width: 177px;
            height: 60px;
        }
        .auto-style5 {
            height: 90px;
        }
        .auto-style6 {
            font-weight: 400;
            color: #4A5568;
            display: inline-block;
            width: 96px;
            height: 60px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
      <div style="background-color:white; height:380px; width: 30% ; margin:auto; border-radius:20px; margin-top: 150px">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style5" style="text-align:center" colspan="2">  <h1>Sign In</h1>  </td>
        </tr>
        <tr>
            <td class="auto-style6">Email</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtLogin" runat="server" CssClass="form__textbox--outline"></asp:TextBox>
                <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form__textbox--outline"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"  style="text-align:center">
                <asp:Button ID="btnLogin" runat="server"  Text="Log in"   style="width:140px; height : 40px; background-color:#ad6262; border:none ; border-radius:10px" CssClass="loginbtn" OnClick="btnRegistrar_Click"/>
            </td>
        </tr>
    </table>
          </div>
    </form>
</body>
