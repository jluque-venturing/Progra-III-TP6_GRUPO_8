<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="TP6_GRUPO_8.WebForm1" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Productos Seleccionados</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Productos Seleccionados por el Usuario:</h2>
            
            <asp:GridView ID="gvMostrar" runat="server" AutoGenerateColumns="True" OnSelectedIndexChanged="gvMostrar_SelectedIndexChanged">
            </asp:GridView>
            
            <br />
            
            <asp:HyperLink ID="hlVolverInicio" runat="server" NavigateUrl="~/ejercicio2.aspx">Volver al Inicio</asp:HyperLink>
        </div>
    </form>
</body>
</html>