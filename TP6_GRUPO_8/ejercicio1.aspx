<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP6_GRUPO_8.ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10" OnPageIndexChanging="gvProductos_PageIndexChanging" OnRowDeleting="gvProductos_RowDeleting" OnRowCancelingEdit="gvProductos_RowCancelingEdit" OnRowEditing="gvProductos_RowEditing" OnRowUpdating="gvProductos_RowUpdating">
                <Columns>
                   <asp:CommandField ShowDeleteButton="True" DeleteText="Delete " ShowEditButton="True" EditText="Edit" CancelText="Cancel" UpdateText="Update" />
                    <asp:TemplateField HeaderText="Id Producto">                        
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblEditId" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditNombre" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Cantidad Por Unidad">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditCantidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Precio Unidad">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditPrecio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
