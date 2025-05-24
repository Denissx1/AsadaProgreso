
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace Datos
{
    public class D_conexion
    {
        SqlConnection con;
        public SqlConnection conectar()
        {
            try
            {
                con = new SqlConnection("server=.;database=AsadaProgreso;user=sa;password=1234");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede conectar a la base de datos");
            }

            return con;
        }
        public void desconectar()
        {
            con.Close();
        }
    } 
}

