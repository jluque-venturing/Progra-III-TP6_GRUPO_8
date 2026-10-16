<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2.aspx.cs" Inherits="TP6_GRUPO_8.ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar productos</asp:HyperLink>
            </p>
            <p>
                <asp:LinkButton ID="lbEliminarProductosSeleccionados" runat="server" OnClick="lbEliminarProductosSeleccionados_Click">Eliminar productos seleccionados</asp:LinkButton>
            </p>
            <p>
                <asp:HyperLink ID="hlMostrarProductos" runat="server" NavigateUrl="~/MostrarProductos.aspx">Mostrar productos</asp:HyperLink>
            </p>
        </div>
    </form>
</body>
</html>