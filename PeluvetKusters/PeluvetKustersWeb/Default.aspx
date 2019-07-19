<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PeluvetKustersWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class ="row">
             <div class ="col-md-3">
                 <table style="width:100%;">
                    
                     <tr>
                         <td style="width: 90px">

                             &nbsp;</td>
                         <td style="width: 139px">

                             <asp:Button  CssClass ="btn btn-primary btn-sm" ID="btnPerfil" runat="server" Text="Mis perfil" OnClick="btnPerfil_Click" Visible="False" Width="142px" Height="45px" />

                             </td>
                         <td>

                             &nbsp;</td>
                     </tr>
                     <tr>
                         <td style="width: 90px; height: 35px;">   <h3 aria-haspopup="False">
                             &nbsp;</h3></td>
                         <td style="height: 35px; width: 139px">
                             <h3>
                             <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                            </h3>
                         </td>
                         <td style="height: 35px">

                             <asp:TextBox ID="txtNombreUsuario" runat="server" Width="198px" OnTextChanged="txtNombreUsuario_TextChanged1"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td style="width: 90px">   <h3>&nbsp;</h3></td>
                         <td style="width: 139px">
                             <h3>
                             <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                             </h3>
                         </td>
                         <td>
                             <asp:TextBox ID="TxtContraseña" runat="server" Width="199px" TextMode="Password"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td style="width: 90px">&nbsp;</td>
                         <td style="width: 139px">
                             &nbsp;</td>
                         <td>
                             <asp:Button CssClass ="btn btn-primary btn-sm" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Onclick" />
                              <asp:Button CssClass ="btn btn-primary btn-sm" ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="brnRegistrarse_Click" />

                         </td>
                     </tr>
                 </table>
             </div>
        </div>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <div class="jumbotron">
          <h1 class="display-4">&nbsp;¿Queres un turno para tu mascota?</h1>
          <p class="lead">&nbsp;&nbsp;&nbsp; Podes hacerlo a travez de esta web!!! sea para peluqueria o para veterinaria.</p>
          <hr class="my-4">
          <p>&nbsp;&nbsp;&nbsp; si ya te registraste como cliente, hace click en el siguiente boton y ¡pedi tu turno!.</p>
          <asp:Button CssClass="btn btn-primary btn-lg" ID="btnPedirTurno" runat="server" Text="Pedir turno" OnClick="btnPedirTurno_Click1"/>
    </div>

</asp:Content>
