<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Miperfil.aspx.cs" Inherits="PeluvetKustersWeb.Miperfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <table style="width: 100%; height: 941px;">
        <tr>
            <td style="width: 45px; height: 86px;">
                </td>
            <td style="width: 207px; height: 86px;">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnMisTurnos" runat="server" Text="Mis turnos" Width="192px" OnClick="btnMisTurnos_Click" />
            </td>
            <td style="width: 204px; height: 86px;">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnPedirTurno" runat="server" Text="Pedir turno" Width="192px" OnClick="btnPedirTurno_Click" />
            </td>
            <td style="width: 218px; height: 86px;">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnAgregarMascotas" runat="server" OnClick="btnAgregarMascotas_Click" Text="Agregar mascotas" Width="196px" />
            </td>
            <td style="width: 150px; height: 86px;">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="194px" />
            </td>
        </tr>
        <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">&nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
        <tr>
             <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                <h3><asp:Label ID="lblMisMascotas" runat="server" Text="Mis mascotas"></asp:Label></h3>
             </td>
            <td style="width: 204px">
                &nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
            <tr>
            <td style="width: 45px; height: 155px;"></td>
            <td style="width: 207px; height: 155px;">
                    <asp:GridView  CssClass= "table table-striped table-bordered table-condensed" ID="gvMascotas" runat="server" Width="172px" OnRowDataBound="gvMascotas_RowDataBound"></asp:GridView>
                </td>
                <td style="width: 204px; height: 155px;">
                    &nbsp;</td>
            <td style="width: 218px; height: 155px;"></td>
            <td style="width: 150px; height: 155px;"></td>
        </tr>
            <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">&nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
            <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                &nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                &nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
        </tr>
                  <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                &nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
                  <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnCambarPass" runat="server" Text="Cambiar contraseña" Width="174px" />
                      </td>
            <td style="width: 204px">
                <asp:Button  CssClass="btn btn-primary btn-lg" ID="btnCerrarSesion" runat="server" Text="Cerrar sesión" Width="163px" OnClick="btnCerrarSesion_Click" />
                      </td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>
                  <tr>
            <td style="width: 45px">&nbsp;</td>
            <td style="width: 207px">
                &nbsp;</td>
            <td style="width: 204px">&nbsp;</td>
            <td style="width: 218px">&nbsp;</td>
            <td style="width: 150px">&nbsp;</td>
        </tr>

    </table>




</asp:Content>
