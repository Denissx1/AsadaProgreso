using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidades
{
    public class E_menu
    {
        public string nombre {  get; set; }
        public string icono { get; set; }
        public List<subMenu> listsubMenu {  get; set; }
    }
}
