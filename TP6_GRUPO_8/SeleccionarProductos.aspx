<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_8.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="gvSeleccion" runat="server" AutoGenerateColumns="False"
                AllowPaging="True" PageSize="14" OnPageIndexChanging="gvSeleccion_PageIndexChanging" OnSelectedIndexChanging="gvSeleccion_SelectedIndexChanging">
                <Columns>

                    <asp:CommandField ShowSelectButton="True" />

                    <asp:TemplateField HeaderText="Id Producto">
                        <ItemTemplate>
                            <asp:Label ID="lblIdProducto" runat="server"
                                Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre Producto">
                        <ItemTemplate>
                            <asp:Label ID="lblNombreProducto" runat="server"
                                Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Id Proveedor">
                        <ItemTemplate>
                            <asp:Label ID="lblIdProveedor" runat="server"
                                Text='<%# Bind("IdProveedor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio Unitario">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecioUnidad" runat="server"
                                Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>

            <br />

            <asp:Label ID="lblAgregados" runat="server"></asp:Label>

            <br /><br />

            <asp:HyperLink ID="hlVolver" runat="server"
                NavigateUrl="~/Ejercicio2.aspx">
                Volver al Inicio
            </asp:HyperLink>

        </div>
    </form>
</body>
</html>