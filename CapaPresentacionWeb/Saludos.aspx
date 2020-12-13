<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saludos.aspx.cs" Inherits="CapaPresentacionWeb.Saludos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Ingresa tu nombre</td>
                <td class="auto-style4" style="margin-left: 40px">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Ingresa tu sueldo</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Label ID="lblSueldo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Ingresa numero del mes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNumMes" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Label ID="lblMes" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Ingresa una fecha</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblFecha" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
