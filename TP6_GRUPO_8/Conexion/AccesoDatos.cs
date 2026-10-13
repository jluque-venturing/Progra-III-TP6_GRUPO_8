using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_8.Conexion
{
    public class AccesoDatos
    {
        public string CadenaConexion { get; set; }


    public AccesoDatos()
        {
            CadenaConexion = "Data Source=MIGUEL\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;";
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(CadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(string consulta)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, ObtenerConexion());
                return adaptador;
            }
            catch
            {
                return null;
            }
        }
        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string nombreSP)
        {
            comando.Connection = ObtenerConexion();
            comando.CommandText = nombreSP;
            comando.CommandType = CommandType.StoredProcedure;

            int filasAfectadas = comando.ExecuteNonQuery();

            comando.Connection.Close();

            return filasAfectadas;
        }

    }
}
