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
            <asp:GridView ID="dgvTurnos" runat="server" BackColor="White" BorderColor="#003300" OnRowDataBound="dgvTurnos_RowDataBound"></asp:GridView>
                   </td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td style="height: 58px"></td>
                   <td style="width: 173px; height: 58px;">
                       <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="184px" />
                   </td>
                   <td style="height: 58px"></td>
               </tr>
           </table>
       </p>
</div>
          </center></table>
</asp:Content>
