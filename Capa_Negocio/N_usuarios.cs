using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_entidades;
using Datos;


namespace Capa_Negocio
{
    public  class N_usuarios
    {
       D_Usuarios dUsuarios = new D_Usuarios();
    E_usuarios e_Usuarios = new E_usuarios();

        public DataSet Mostrar_usuarios()
        {
           return dUsuarios.Mostrar_usuarios();
        }
        public void insertar_Usuarios(E_usuarios ep)
        {
            dUsuarios.insertar_Usuarios(ep);
            
        }
        public void editar_Usuario(E_usuarios ep)
        {
            dUsuarios.editar_Usuario(ep);
        }

        public void eliminar_Usuario(E_usuarios ep)
        {
            dUsuarios.eliminar_Usuario(ep);
        }
    }
}
