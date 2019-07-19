<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Misturnos.aspx.cs" Inherits="PeluvetKustersWeb.Misturnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <table><center>
       <p>
             <h3>Mis turnos activos <span class="badge badge-secondary"></span></h3>
       </p>
       <p>
<div>
           <table style="width:100%;">
               <tr>
                   <td>&nbsp;</td>
                   <td style="width: 173px">&nbsp;</td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td>&nbsp;</td>
                   <td style="width: 173px">
            <asp:GridView  CssClass= "table table-striped table-bordered table-condensed" ID="dgvTurnos" runat="server" BackColor="White" BorderColor="#003300" OnRowDataBound="dgvTurnos_RowDataBound" BorderStyle="Solid" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged"></asp:GridView>
                   </td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td style="height: 58px">&nbsp;</td>
                   <td style="width: 173px; height: 58px;">
                       <asp:Button CssClass="btn btn-primary btn-lg"  ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="184px" />
                       <asp:Button  CssClass="btn btn-primary btn-lg" ID="btnPerfil" runat="server" Text="Mi perfil" OnClick="btnPerfil_Click" />
                   </td>
                   <td style="height: 58px">
                       &nbsp;</td>
               </tr>
           </table>
       </p>
</div>
          </center></table>
</asp:Content>
