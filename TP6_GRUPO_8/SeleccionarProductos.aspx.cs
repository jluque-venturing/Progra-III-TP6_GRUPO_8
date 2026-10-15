using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_8.Conexion;

namespace TP6_GRUPO_8
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GestionProductos gestion = new GestionProductos();

                gvSeleccion.DataSource = gestion.ObtenerTabla(
                    "Productos",
                    "SELECT IdProducto, NombreProducto, IdProveedor, PrecioUnidad FROM Productos");

                gvSeleccion.DataBind();
            }
        }

        // Cambia la pagina actual de la grilla de productos. 
        protected void gvSeleccion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSeleccion.PageIndex = e.NewPageIndex;

            GestionProductos gestion = new GestionProductos();

            gvSeleccion.DataSource = gestion.ObtenerTabla(
                "Productos",
                "SELECT IdProducto, NombreProducto, IdProveedor, PrecioUnidad FROM Productos");

            gvSeleccion.DataBind();
        }

        protected void gvSeleccion_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow fila = gvSeleccion.Rows[e.NewSelectedIndex];

            int idProducto = int.Parse(((Label)fila.FindControl("lblIdProducto")).Text);
            string nombreProducto = ((Label)fila.FindControl("lblNombreProducto")).Text;
            int idProveedor = int.Parse(((Label)fila.FindControl("lblIdProveedor")).Text);
            decimal precio = decimal.Parse(((Label)fila.FindControl("lblPrecioUnidad")).Text);
        }
    }
}