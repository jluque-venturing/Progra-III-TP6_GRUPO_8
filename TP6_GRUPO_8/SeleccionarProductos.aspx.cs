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
    }
}