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
   
    public  class N_Junta
    {
        D_Junta Djunta = new D_Junta();
        E_Junta e_Usuarios = new E_Junta();
        public DataSet mostrar_MienbrosJunta()
        {
            return Djunta.Mostrar_Mienbros();
        }
    }
}
