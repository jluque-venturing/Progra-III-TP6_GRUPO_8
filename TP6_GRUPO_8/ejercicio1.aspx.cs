using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_8.Conexion;

namespace TP6_GRUPO_8
{
    public partial class ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvProductos.DataSource = new GestionProductos().ObtenerTodosLosProductos();
                gvProductos.DataBind();
            }
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            gvProductos.DataSource = new GestionProductos().ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblIdProducto = (Label)gvProductos.Rows[e.RowIndex].FindControl("Label1");

            int idProducto = int.Parse(lblIdProducto.Text);

            GestionProductos gestion = new GestionProductos();
            gestion.EliminarProductos(idProducto);


            e.Cancel = true;

            gvProductos.DataSource = gestion.ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            gvProductos.DataSource = new GestionProductos().ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            gvProductos.DataSource = new GestionProductos().ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            e.Cancel = true;

            if (!Page.IsValid)
            {
                return;
            }

            GridViewRow fila = gvProductos.Rows[e.RowIndex];

            Label lblProducto = (Label)fila.FindControl("lblEditId");
            TextBox txtNombre = (TextBox)fila.FindControl("txtEditNombre");
            TextBox txtCantidad = (TextBox)fila.FindControl("txtEditCantidad");
            TextBox txtPrecio = (TextBox)fila.FindControl("txtEditPrecio");

            int idProducto = int.Parse(lblProducto.Text);
            string nombreProducto = txtNombre.Text.Trim();
            string cantidadPorUnidad = txtCantidad.Text.Trim();
            decimal precioUnidad;

            if (nombreProducto == string.Empty || cantidadPorUnidad == string.Empty || !decimal.TryParse(txtPrecio.Text, out precioUnidad) || precioUnidad < 0)
            {
                return;
            }

            GestionProductos gestion = new GestionProductos();

            gestion.ActualizarProducto(idProducto, nombreProducto, cantidadPorUnidad, precioUnidad);

            gvProductos.EditIndex = -1;
            gvProductos.DataSource = gestion.ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }
    }
}
