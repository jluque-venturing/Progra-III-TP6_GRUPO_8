using System;
using System.Collections.Generic;
using System.Data;
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
                lblAgregados.Text = string.Empty;

                GestionProductos gestion = new GestionProductos();

                gvSeleccion.DataSource = gestion.ObtenerTabla(
                    "Productos",
                    "SELECT IdProducto, NombreProducto, IdProveedor, PrecioUnidad FROM Productos");

                gvSeleccion.DataBind();
            }
        }
        private DataTable CrearTablaSeleccionados()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("IdProducto", typeof(int));
            dt.Columns.Add("NombreProducto", typeof(string));
            dt.Columns.Add("IdProveedor", typeof(int));
            dt.Columns.Add("PrecioUnidad", typeof(decimal));

            return dt;
        }

        private DataTable AgregarFila(DataTable tabla, int idProducto, string nombre, int idProveedor, decimal precio)
        {
            DataRow fila = tabla.NewRow();

            fila["IdProducto"] = idProducto;
            fila["NombreProducto"] = nombre;
            fila["IdProveedor"] = idProveedor;
            fila["PrecioUnidad"] = precio;

            tabla.Rows.Add(fila);

            return tabla;
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

            if (Session["ProductosSeleccionados"] == null)
            {
                Session["ProductosSeleccionados"] = CrearTablaSeleccionados();
            }

            DataTable tabla = (DataTable)Session["ProductosSeleccionados"];

            foreach (DataRow registro in tabla.Rows)
            {

                if (Convert.ToInt32(registro["IdProducto"]) == idProducto)
                {
                    lblAgregados.Text = "El producto ya fue seleccionado: " + nombreProducto;
                    return;                    break;

                }
                if (lblAgregados.Text == string.Empty)
                {
                    lblAgregados.Text = "Productos agregados: " + nombreProducto;
                }

                else
                {
                    lblAgregados.Text += ", " + nombreProducto;
                }


                tabla = AgregarFila(tabla, idProducto, nombreProducto,idProveedor, precio);

                Session["ProductosSeleccionados"] = tabla;
            }

            tabla = AgregarFila(
                tabla,
                idProducto,
                nombreProducto,
                idProveedor,
                precio);

            Session["ProductosSeleccionados"] = tabla;

            if (lblAgregados.Text == string.Empty)
            {
                lblAgregados.Text = "Productos agregados: " + nombreProducto;
            }
            else
            {
                lblAgregados.Text += ", " + nombreProducto;
            }

          
        }
    }
}