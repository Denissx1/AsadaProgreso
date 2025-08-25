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
    public class N_Previstas
    {
        D_Prevista d_Prevista = new D_Prevista();
        E_Previstas e_Prevista = new E_Previstas();

        public DataSet mostrar_Previstas()
        {
            return d_Prevista.Mostrar_Previstas();
        }
        public void insertar_Prevista(E_Previstas ep)
        {
            d_Prevista.Insertar_Prevista(ep);

        }
        public void buscar_Prevista(string buscar)
        {
            d_Prevista.Buscar_Prevista(buscar);
        }
    }
}
