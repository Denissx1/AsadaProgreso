using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_entidades;
using Datos;

namespace Capa_datos
{
    public class D_Junta
    {
        D_conexion Dconexion = new D_conexion();
        public DataSet Mostrar_Mienbros()
        {
            Dconexion.conectar();
            string sql = "select nomMiembro,idCedula,puesto,estado,fecha_Ingreso,fecha_Salida,Descripcion from juntaDirectiva";
            DataSet dst = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, Dconexion.conectar());
            da.Fill(dst, "Usuarios");
            Dconexion.desconectar();
            return dst;
        }
    }
}
