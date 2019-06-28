<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PeluvetKustersWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 
         <h3>
             <table class="nav-justified">
                 <tr>
                     <td style="height: 42px; width: 477px">&nbsp;</td>
                     <td style="width: 238px; height: 42px">
                         <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                     </td>
                     <td style="height: 42px">     
         <asp:TextBox ID="txtUsuario" runat="server" Height="26px"></asp:TextBox>        
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 477px"></td>
                     <td style="width: 238px"><asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                     </td>
                     <td>     
                         <asp:TextBox ID="txtContraseña" runat="server" Height="27px" TextMode="Password"></asp:TextBox>       
                     </td>
                 </tr>
         
               
             </table>
             <span class="label label-default"></span></h3>     
         <h3>
             <table style="width:100%;">
                 <tr>
                     <td style="width: 477px; height: 42px;"></td>
                     <td style="width: 240px; height: 42px;">
                         <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                     </td>
                     <td style="height: 42px">             
                        <asp:TextBox ID="txtNombre" runat="server" Height="27px"></asp:TextBox>
                     </td> 
                 </tr>
                 <tr>
                     <td style="width: 477px; height: 42px;"></td>
                     <td style="width: 240px; height: 42px;">
                         <asp:Label ID="Label4" runat="server" Text="Apellido:"></asp:Label>
                     </td>
                     <td style="height: 42px">             
                          <asp:TextBox ID="txtApellido" runat="server" Height="26px"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 477px; height: 42px;"></td>
                     <td style="width: 240px; height: 42px;">
                         <asp:Label ID="Label5" runat="server" Text="Numero  de contacto:"></asp:Label>
                     </td>
                     <td style="height: 42px">                
                            <asp:TextBox ID="txtcontacto" runat="server" Height="27px" TextMode="Number"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td style="width: 477px; height: 42px;"></td>
                     <td style="width: 240px; height: 42px;" class="bg-white">Localidad:</td>
                     <td style="height: 42px">
  

                      <asp:DropDownList ID="drpLocalidades" runat="server" OnSelectedIndexChanged="drpLocalidades_SelectedIndexChanged" AutoPostBack="True" Height="27px" Width="236px"></asp:DropDownList> 
                     </td>
                 </tr>
             </table>
         </h3>     
        <h3>&nbsp;</h3>             
            <h3>&nbsp;</h3>             
         <table style="width:100%;">
             <tr>
                 <td style="width: 737px">&nbsp;</td>
                 <td> 
         <asp:Button CssClass="btn btn-primary btn-lg" ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" style="margin-left: 0"/>
  

                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td style="width: 737px">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td style="width: 737px">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
         </table>
         <h3>&nbsp;</h3>                
         <h3>&nbsp;</h3>              
           

</asp:Content>
