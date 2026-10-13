<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_8.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 405px;
        }

        .auto-style3 {
            width: 316px;
        }

        .auto-style4 {
            height: 42px;
        }

        .auto-style5 {
            width: 405px;
            height: 42px;
        }

        .auto-style6 {
            width: 316px;
            height: 42px;
        }

        .auto-style10 {
            height: 11px;
        }

        .auto-style11 {
            width: 405px;
            height: 11px;
        }

        .auto-style12 {
            width: 316px;
            height: 11px;
        }

        .auto-style13 {
            height: 35px;
        }

        .auto-style14 {
            width: 405px;
            height: 35px;
        }

        .auto-style15 {
            width: 316px;
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    <asp:GridView ID="gvSeleccion" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="IdProducto" HeaderText="Id Producto" />
                            <asp:BoundField DataField="NombreProducto" HeaderText="Nombre Producto" />
                            <asp:BoundField DataField="IdProveedor" HeaderText="Id Proveedor" />
                            <asp:BoundField DataField="PrecioUnitario" HeaderText="Precio Unitario" />
                        </Columns>
                    </asp:GridView>

                </td>
                <td class="auto-style12"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
                <td class="auto-style15"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">

                    <asp:Label ID="lblAgregados" runat="server" Text=""></asp:Label>

                </td>
                <td class="auto-style6"></td>
                <td class="auto-style4">

                    <asp:HyperLink ID="hlVolver" runat="server"
                        NavigateUrl="~/Ejercicio2.aspx"
                        Text="Volver al Inicio">
                    </asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
