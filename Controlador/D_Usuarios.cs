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
    public class D_Usuarios
    {
        D_conexion Dconexion = new D_conexion();
        E_usuarios eUsuarios = new E_usuarios();

        // Metodo para mostrar usuarios
        public DataSet Mostrar_usuarios()
        {
            Dconexion.conectar();
            string sql = "select nomUsuario,cedula,correo,contrasena,tipoUsuario from Usuarios";
            DataSet dst = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql,Dconexion.conectar());
            da.Fill(dst,"Usuarios");
            Dconexion.desconectar();
            return dst;
        }
        //Metodo para registrar un Usuario
        public void insertar_Usuarios(E_usuarios ep)
        {
            Dconexion.conectar();
            string sql = "insert into Usuarios (nomUsuario,cedula,correo,contrasena,tipoUsuario) " +
                "values('"+ ep.nomUsuarios +"',"+ ep.cedula +",'" + ep.correo + "','"+ ep.contrasena + "','"+ ep.tipoUsuario+"')";
            SqlCommand cmd = new SqlCommand(sql,Dconexion.conectar());
            cmd.ExecuteNonQuery();
            Dconexion.desconectar();
        }
        public void editar_Usuario(E_usuarios ep)
        {
            Dconexion.conectar();
            string sql = "update Usuarios set cedula = " + ep.cedula + ",correo = '" +ep.correo+ "',contrasena= '"+ep.contrasena+ "',tipoUsuario='"+ep.tipoUsuario+"'where nomUsuario ='"+ep.nomUsuarios+"'";
            SqlCommand cmd = new SqlCommand(sql, Dconexion.conectar());
            cmd.ExecuteNonQuery();
            Dconexion.desconectar();
        }
        //Metodo para eliminar un usuario
        public void eliminar_Usuario(E_usuarios ep)
        {
            Dconexion.conectar();
            string sql = "DELETE FROM Usuarios WHERE nomUsuario = '"+ep.nomUsuarios+"'";
            SqlCommand cmd = new SqlCommand(sql, Dconexion.conectar());
            cmd.ExecuteNonQuery();
            Dconexion.desconectar();
        }
        public void buscar_Usuario()
        {
            Console.WriteLine("Not function");
        }
    }
}
