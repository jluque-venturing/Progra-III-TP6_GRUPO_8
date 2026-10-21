using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["ProductosSeleccionados"] != null)
                {

                    gvMostrar.DataSource = (DataTable)Session["ProductosSeleccionados"];
                    gvMostrar.DataBind();
                }
            }
        }

        protected void gvMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}