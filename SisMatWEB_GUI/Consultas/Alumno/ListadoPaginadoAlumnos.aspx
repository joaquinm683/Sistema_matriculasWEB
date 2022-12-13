<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoPaginadoAlumnos.aspx.cs" Inherits="SisMatWEB_GUI.Alumno.ListadoPaginadoAlumnos"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="container2">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
    <ContentTemplate >
    <h2>Lista paginada de alumnos:</h2>
    <p>
            <asp:Label ID="Label15" runat="server" Text="Seleccione la carrera:" CssClass="CajaDialogo"></asp:Label>
            &nbsp;<asp:DropDownList ID="cboCarrera" runat="server" Height="18px" Width="250px" CssClass="form__textbox--outline1">
        </asp:DropDownList>
    </p>
    <p>
            <asp:Label ID="Label16" runat="server" Text="Seleccione el sexo:"></asp:Label>
            <asp:RadioButtonList ID="rblSexo" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">Todos</asp:ListItem>
                <asp:ListItem Value="M"></asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
            </asp:RadioButtonList>
    </p>
    <p>
            <asp:Label ID="Label17" runat="server" Text="Tiene foto por defecto?"></asp:Label>
            <asp:RadioButtonList ID="rblFoto" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">Todos</asp:ListItem>
                <asp:ListItem>Si</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
    </p>
        <p>
            <asp:Label ID="Label18" runat="server" Text="Seleccione el departamento:"></asp:Label>
            <asp:DropDownList ID="cboDepartamento" runat="server" Height="18px" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" Width="209px" AutoPostBack="True" CssClass="form__textbox--outline1">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label19" runat="server" Text="Seleccione la provincia:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cboProvincia" runat="server" Height="18px" OnSelectedIndexChanged="cboProvincia_SelectedIndexChanged" Width="209px" AutoPostBack="True" CssClass="form__textbox--outline1">
            </asp:DropDownList>
        </p>
    <p>
            <asp:Label ID="Label14" runat="server" Text="Seleccione el distrito:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="cboDistrito" runat="server" Height="18px" Width="209px" AutoPostBack="True" CssClass="form__textbox--outline1">
        </asp:DropDownList>
    </p>
    <p>Seleccione el estado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cboEstado" runat="server" Height="18px" Width="209px" CssClass="form__textbox--outline1">
        <asp:ListItem Value="X">--Todos--</asp:ListItem>
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
        </asp:DropDownList>
    </p>
    <div class="row">
        <div>
            <br />
        </div>
        <asp:Button ID="btnFiltrar"  runat="server" Text="Filtrar" CssClass="form__button" CausesValidation="True" OnClick="btnFiltrar_Click"></asp:Button>
    </div>
    <asp:Label ID="lblRegistros" runat="server" CssClass="form__label py-3"></asp:Label>
    <asp:GridView ID="grvAlumnos" runat="server" BorderWidth="1px" BorderColor="#A0AEC0" AutoGenerateColumns="False" BackColor="#EDF2F7" Width="100%" EnableSortingAndPagingCallbacks="True" CellPadding="10" GridLines="Vertical" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:BoundField DataField="Id_alum" HeaderText="ID" />
            <asp:BoundField DataField="Nom_alum" HeaderText="Nombre" />
            <asp:BoundField DataField="Ape_alum" HeaderText="Apellido" />
            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
            <asp:TemplateField HeaderText="Foto">
                            <ItemTemplate>
                                <asp:Image ID="Image2" Width="24px" Height="24px" runat="server" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("Foto_alum"))%>' />
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Nom_carrera" HeaderText="Carrera" />
            <asp:BoundField DataField="Des_semestre" HeaderText="Semestre" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Tel_alum" HeaderText="Telefono" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Email_alum" HeaderText="Email" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" />
            <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
            <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
        </Columns>
        <HeaderStyle BackColor="#1A202C" ForeColor="White" />
    </asp:GridView>
        <tr>
               <td class="auto-style2">
                    <asp:DropDownList ID="cboPaginas" runat="server" Width="60px" AutoPostBack="True" OnSelectedIndexChanged="cboPaginas_SelectedIndexChanged" CssClass="DropDownList">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
        </tr>

    <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>

    <asp:Panel ID="pnlMensaje" runat="server" CssClass="modal__body center" Style="display: normal;" Width="500"> 
        <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:black; color: #FFFFFF;"> 
            <tr> 
                <td align="center"> 
                    <asp:Label ID="lblTitulo" runat="server" Text="Error" /> 
                </td> 
                <td width="12%"> 
                    <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" ImageAlign="Middle" /> 
                </td> 
            </tr> 
         </table>
         <div>
             <br />
            <asp:Label ID="lblMensajePopup" runat="server" CssClass="error"/>
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
        <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" 
            TargetControlID="lnkMensaje" PopupControlID="pnlMensaje" BackgroundCssClass="modal"  OkControlID="btnAceptar" />
        
        </ContentTemplate>
   </asp:UpdatePanel>
    <%--<asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0"  AssociatedUpdatePanelID ="UpdatePanel1">
          <ProgressTemplate>
              <div class="overlay">
                  <div class="overlayContent ">
                  <h2>Cargando</h2>  
                  <img src="../Images/loading2.gif" alt ="Loading" border="0" />              
              </div>
              </div>
          </ProgressTemplate>
    </asp:UpdateProgress>--%>
   </div>
</asp:Content>
