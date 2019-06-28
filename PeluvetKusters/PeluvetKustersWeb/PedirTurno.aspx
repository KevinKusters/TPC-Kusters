<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedirTurno.aspx.cs" Inherits="PeluvetKustersWeb.PedirTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
<table><center>

 <p>
     <h3>Rubro <span class="badge badge-secondary"></span></h3>
     <asp:DropDownList ID="drpRubro" runat="server" OnTextChanged="drpRubro_TextChanged" AutoPostBack="True"></asp:DropDownList>
 </p>
    <p></p>
    <p>
         <h3>Fecha <span class="badge badge-secondary"></span></h3>
         <asp:TextBox ID="txtFecha" runat="server" TextMode="Date"></asp:TextBox>
         </p>
    <p></p>
    <p>
         <h3>Hora <span class="badge badge-secondary"></span></h3>
            <asp:TextBox ID="txtHora" runat="server" TextMode="Time" OnTextChanged="txtHora_TextChanged"></asp:TextBox>
         <h3>Hora finalizacion<span class="badge badge-secondary"></span></h3>
          <asp:TextBox ID="txtHoraFinal" runat="server" ReadOnly="True" OnTextChanged="txtHoraFinal_TextChanged"></asp:TextBox>
    </p>
    <p></p>
    <p>
         <h3>Profesional <span class="badge badge-secondary"></span></h3>
         <asp:DropDownList ID="drpProfesionales" runat="server"></asp:DropDownList>
    </p>
    <p></p>
    <p>
        <h3>Mascota <span class="badge badge-secondary"></span></h3>
        <asp:DropDownList ID="drpMascotas" runat="server" AutoPostBack="True"></asp:DropDownList>
    </p>
     <p></p>
     <p>
        <h3>Servicio <span class="badge badge-secondary"></span></h3>
        <asp:DropDownList ID="drpServicios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpServicios_SelectedIndexChanged"></asp:DropDownList>
         <h3>Costo <span class="badge badge-secondary"></span></h3>
         <asp:TextBox ID="txtCosto" runat="server" ReadOnly="True"></asp:TextBox>
     </p>
    <p></p>
    <p>
        <asp:Button ID="btnAceptar" runat="server" Text="Pedir turno" OnClick="btnAceptar_Click" UseSubmitBehavior="False"></asp:Button>
    </p>
   
</table> </center>
    </asp:Content>
