using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_8.Conexion
{
    public class GestionProductos
    {
        public DataTable ObtenerTabla(string nombreTabla, string consulta)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adaptador = datos.ObtenerAdaptador(consulta);
            adaptador.Fill(ds, nombreTabla);
            return ds.Tables[nombreTabla];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos");
        }
    

    public bool EliminarProductos(int idProducto)
        {

            SqlCommand comando = new SqlCommand();
            SqlParameter sqlparametro = new SqlParameter("@idProducto", idProducto);
            comando.Parameters.Add(sqlparametro);

            AccesoDatos datos = new AccesoDatos();

            int filasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "SP_EliminarProducto");

            return filasAfectadas > 0;

        }

    public bool ActualizarProducto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            comando.Parameters.AddWithValue("@CantidadPorUnidad", cantidadPorUnidad);
            comando.Parameters.AddWithValue("PrecioUnidad", precioUnidad);

            AccesoDatos datos = new AccesoDatos();

            int filasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "SP_ActualizarProducto");

            return filasAfectadas > 0;
        }
    }
}