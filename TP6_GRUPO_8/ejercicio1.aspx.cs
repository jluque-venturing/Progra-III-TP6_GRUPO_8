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
    }
}
