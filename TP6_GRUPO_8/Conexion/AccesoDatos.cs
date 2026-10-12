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
    }


}
