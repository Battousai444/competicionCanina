<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="examen4.aspx.cs" Inherits="Examen4TorneoWeb.examen4.examen4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="2" style="font-size: x-large"><strong>
                <br />
                ADMINISTRACIÓN DE CLIENTES</strong></td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>CÓDIGO:</strong></td>
            <td>
                <asp:Label ID="lblCodigo" runat="server" style="font-size: large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>NOMBRE:</strong></td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>NOMBRE DUEÑO</strong></td>
            <td>
                <asp:TextBox ID="txtNombreDueño" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>FECHA TOENEO</strong></td>
            <td>
                <asp:TextBox ID="txtFechaTorneo" runat="server" style="font-size: large" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large; height: 27px;"><strong>NOMBRE TORNEO:</strong></td>
            <td style="height: 27px">
                <asp:DropDownList ID="cboNombreTorneo" runat="server" style="font-size: large">
                    <asp:ListItem>CARRERAS</asp:ListItem>
                    <asp:ListItem>OBSTACULOS</asp:ListItem>
                    <asp:ListItem>TRUCOS</asp:ListItem>
                    <asp:ListItem>COMPORTAMIENTO</asp:ListItem>
                    <asp:ListItem>AGILIDAD</asp:ListItem>
                    <asp:ListItem>LUCHA LIBRE</asp:ListItem>
                    <asp:ListItem>TIRO CON ARCO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="font-size: large; height: 29px;"><strong>RAZA</strong></td>
            <td style="height: 29px">
                <asp:DropDownList ID="cboRaza" runat="server" style="font-size: large">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="font-size: large; height: 30px;"><strong>P</strong><span style="font-weight: bold"><strong>UESTO</strong></span></td>
            <td style="height: 30px">
                <asp:TextBox ID="txtPuesto" runat="server" style="font-size: large" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 22px">
                <asp:Button ID="btnIngresar" runat="server" style="font-size: x-large" Text="INGRESAR" Width="220px" BackColor="#0033CC" Font-Bold="True" ForeColor="White" OnClick="btnIngresar_Click" />
            </td>
            <td class="text-center" style="height: 22px">
                <asp:Button ID="btnActualizar" runat="server" style="font-size: x-large" Text="ACTUALIZAR" Width="220px" BackColor="#0033CC" Font-Bold="True" ForeColor="White" OnClick="btnActualizar_Click" />
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnBorrar" runat="server" style="font-size: x-large" Text="BORRAR" Width="220px" BackColor="#0033CC" Font-Bold="True" ForeColor="White" OnClick="btnBorrar_Click" />
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" class="text-left">
                <asp:Label ID="lblError" runat="server" style="font-size: large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="text-left">
                <asp:GridView ID="grdUrgencias" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="font-size: large" OnSelectedIndexChanged="grdUrgencias_SelectedIndexChanged" Width="972px">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" SelectImageUrl="~/Imagenes/Editar.png" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>





