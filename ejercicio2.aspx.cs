using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_GRUPO_8
{
    public partial class ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbEliminarProductosSeleccionados_Click(object sender, EventArgs e)
        {

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
    }
}