using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_entidades;
using Datos;

namespace Capa_datos
{
    public class D_Prevista
    {
        D_conexion Dconexion = new D_conexion();
        public DataSet Mostrar_Previstas()
        {
            Dconexion.conectar();
            string sql = "select Abonado,Cedula,Prevista,Pueblo,Direccion,Estado from Previstas";
            DataSet dst = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, Dconexion.conectar());
            da.Fill(dst, "Previstas");
            Dconexion.desconectar();
            return dst;
        }
        // INSERTAR PREVISTA
        public void Insertar_Prevista(E_Previstas eP)
        {
            Dconexion.conectar();
            string sql = "insert into Previstas(Abonado,Cedula,Prevista,Pueblo,Direccion,Estado) values(@Abonado,@Cedula,@Prevista,@Pueblo,@Direccion,@Estado)";
            SqlCommand cmd = new SqlCommand(sql, Dconexion.conectar());
            cmd.Parameters.AddWithValue("@Abonado", eP.Abonado);
            cmd.Parameters.AddWithValue("@Cedula", eP.cedula);
            cmd.Parameters.AddWithValue("@Prevista", eP.Prevista);
            cmd.Parameters.AddWithValue("@Pueblo", eP.pueblo);
            cmd.Parameters.AddWithValue("@Direccion", eP.direccion);
            cmd.Parameters.AddWithValue("@Estado", eP.estado);
            cmd.ExecuteNonQuery();
            Dconexion.desconectar();
        }
        public void leer_datos(string query, ref DataSet ds)
        {
            Dconexion.conectar();
            SqlCommand cmd = new SqlCommand(query, Dconexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Dconexion.desconectar();
        }
        public void Buscar_Prevista(string buscar)
        {
            Dconexion.conectar();
            string cadena = "select Abonado,Cedula,Prevista,Pueblo,Direccion,Estado from Previstas where Abonado like @buscar";
            SqlCommand cmd = new SqlCommand(cadena, Dconexion.conectar());
            cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
            cmd.ExecuteNonQuery();
            Dconexion.desconectar();

        }

    }
}
