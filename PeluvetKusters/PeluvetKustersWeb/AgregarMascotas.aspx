<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMascotas.aspx.cs" Inherits="PeluvetKustersWeb.AgregarMascotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <table style="width:100%; height: 1027px;">
        <tr>
            <td style="height: 64px; width: 479px"></td>
            <td style="width: 120px; height: 64px">                
            </td>
            <td style="width: 178px; height: 64px">
            </td>
            <td style="width: 155px; height: 64px"></td>
            <td style="width: 102px; height: 64px"></td>
            <td style="height: 64px"></td>
        </tr>
        <tr>
            <td style="height: 53px; width: 479px"></td>
            <td style="width: 120px; height: 53px">
               <h3> <asp:Label ID="lblEspecie" runat="server" Text="Especie:"></asp:Label></h3>
            </td>
            <td style="width: 178px; height: 53px">
                <asp:RadioButton  ID="rdbPerro" runat="server" Text="Perro" AutoPostBack="True" OnCheckedChanged="rdbPerro_CheckedChanged" Checked="True" />
            </td>
            <td style="width: 155px; height: 53px">
                <asp:RadioButton ID="rdbGato" runat="server" Text="Gato" AutoPostBack="True" OnCheckedChanged="rdbGato_CheckedChanged" />
            </td>
            <td style="width: 102px; height: 53px">
                <asp:RadioButton ID="rdbOtro" runat="server" Text="Otro" AutoPostBack="True" OnCheckedChanged="rdbOtro_CheckedChanged" />
            </td>
            <td style="height: 53px">
                <asp:TextBox ID="txtOtro" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td style="height: 102px; width: 479px"></td>
            <td style="width: 120px; height: 102px">
                <h3><asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></h3>

            </td>
            <td style="width: 178px; height: 102px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            <td style="width: 155px; height: 102px">
                </td>
            <td style="width: 102px; height: 102px"></td>
            <td style="height: 102px"></td>
        </tr>
            <tr>
            <td style="width: 479px; height: 115px;"></td>
            <td style="width: 120px; height: 115px;"> 
                <h3><asp:Label ID="lblRaza" runat="server" Text="Raza:"></asp:Label></h3>

            </td>
            <td style="width: 178px; height: 115px;">
                <asp:DropDownList ID="drpRazas" runat="server" Width="164px" AutoPostBack="True">
                </asp:DropDownList>
                </td>
            <td style="width: 155px; height: 115px;"></td>
            <td style="width: 102px; height: 115px;"></td>
            <td style="height: 115px"></td>
        </tr>
            <tr>
            <td style="width: 479px">&nbsp;</td>
            <td style="width: 120px">&nbsp;</td>
            <td style="width: 178px">
                <asp:Button CssClass ="btn btn-primary btn-lg" ID="btnAceptar" runat="server" Text="Aceptar" Width="156px" OnClick="btnAceptar_Click" />
                </td>
            <td style="width: 155px">
                <asp:Button CssClass ="btn btn-primary btn-lg" ID="BtnHome" runat="server" Text="Cancelar" Width="156px" OnClick="BtnHome_Click" />
                </td>
            <td style="width: 102px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td style="width: 479px">&nbsp;</td>
            <td style="width: 120px">&nbsp;</td>
            <td style="width: 178px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td style="width: 102px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
            <tr>
            <td style="width: 479px">&nbsp;</td>
            <td style="width: 120px">&nbsp;</td>
            <td style="width: 178px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td style="width: 102px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>



</asp:Content>
