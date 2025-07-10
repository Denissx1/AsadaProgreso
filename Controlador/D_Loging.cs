using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;
using Capa_entidades;

namespace Capa_datos
{

    public class D_Loging
    {
        public static int Loguear(string usuario, string contra)
        {

            int idUsuario = 0;
           
            using (SqlConnection cn = new SqlConnection(D_conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_LoginUsuario",cn);
                    cmd.Parameters.AddWithValue("Usuario", usuario);
                    cmd.Parameters.AddWithValue("Contra", contra);
                    cmd.Parameters.AddWithValue("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    idUsuario = Convert.ToInt32(cmd.Parameters["IdUsuario"].Value);


                }
                catch (Exception ex)
                {
                    
                        idUsuario = 0;
                }
               
            }
            return idUsuario;
        }
    }
    
}
