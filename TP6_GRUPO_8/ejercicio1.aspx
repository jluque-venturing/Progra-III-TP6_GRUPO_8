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
            <h1>Productos</h1>
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10" OnPageIndexChanging="gvProductos_PageIndexChanging" OnRowDeleting="gvProductos_RowDeleting" OnRowCancelingEdit="gvProductos_RowCancelingEdit" OnRowEditing="gvProductos_RowEditing" OnRowUpdating="gvProductos_RowUpdating">
                <Columns>
                   <asp:CommandField ShowDeleteButton="True" DeleteText="Delete " ShowEditButton="True" EditText="Edit" CancelText="Cancel" UpdateText="Update" ValidationGroup="EditarProducto" />
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
                            <asp:TextBox ID="txtEditNombre" runat="server" MaxLength="40" Text='<%# Bind("NombreProducto") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtEditNombre" ValidationGroup="EditarProducto" ForeColor="Red" Display="Dynamic" ErrorMessage="Ingrese un nombre"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Cantidad Por Unidad">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditCantidad" runat="server" MaxLength="20" Text='<%# Bind("CantidadPorUnidad") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvCantidad" runat="server" ControlToValidate="txtEditCantidad" ValidationGroup="EditarProducto" ForeColor="Red" Display="Dynamic" ErrorMessage="Ingrese la cantidad por unidad"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Precio Unidad">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditPrecio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPrecio" runat="server" ControlToValidate="txtEditPrecio" ValidationGroup="EditarProducto" ForeColor="Red" Display="Dynamic" ErrorMessage="Ingrese un precio"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="cvPrecio" runat="server" ControlToValidate="txtEditPrecio" ValidationGroup="EditarProducto" ForeColor="Red" Display="Dynamic" Operator="GreaterThanEqual" ValueToCompare="0" Type="Double" ErrorMessage="Ingrese un precio numérico mayor o igual a 0"></asp:CompareValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
