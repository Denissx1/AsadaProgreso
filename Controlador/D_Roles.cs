using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;
using Capa_entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using System.Xml.Linq;
using System.Net.Http.Headers;

namespace Capa_datos
{
    public  class D_Roles
    {

        public static List<E_menu> ObtenerPermisos(int P_Idusuario)
        {
         List<E_menu> Permisos = new List<E_menu>();

            using (SqlConnection cn = new SqlConnection(D_conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_ObtenerPermisos", cn);
                    cmd.Parameters.AddWithValue("idUsuario", P_Idusuario);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    /* < PERMISOS >
                  < DETALLEMENU >
                    < Menu >
                      < Nombre > Junta </ Nombre >
                      < Icono > Iconos\Junta.png </ Icono >
                      < DETALLEsubMENU >
                        < subMenu >
                          < Nombre > Crear Mienbro </ Nombre >
                          < NombreFormulario > FrmMiembro </ NombreFormulario >
                        </ subMenu >
                        < subMenu >
                          < Nombre > Ver Mienbro </ Nombre >
                          < NombreFormulario > FrmverMiembro </ NombreFormulario >
                        </ subMenu >
                      </ DETALLEsubMENU >
                    </ Menu >
                    < Menu >
                      < Nombre > Previstas </ Nombre >
                      < Icono > Iconos\Previstas.png </ Icono >
                      < DETALLEsubMENU >
                        < subMenu >
                          < Nombre > Crear Prevista </ Nombre >
                          < NombreFormulario > FrmPrevista </ NombreFormulario >
                        </ subMenu >
                        < subMenu >
                          < Nombre > Ver Previstas </ Nombre >
                          < NombreFormulario > FrmPrevista </ NombreFormulario >
                        </ subMenu >
                      </ DETALLEsubMENU >
                    </ Menu >
                  </ DETALLEMENU >
                </ PERMISOS >
                */
                    XmlReader leerXML = cmd.ExecuteXmlReader();
                    while (leerXML.Read())
                    {
                        XDocument doc = XDocument.Load(leerXML);
                        if (doc.Element("PERMISOS") != null)
                        {
                            Permisos = doc.Element("PERMISOS").Element("DETALLEMENU") ==null ? new List<E_menu>() :
                                ( from menu in doc.Element("PERMISOS").Element("DETALLEMENU").Elements("Menu")
                                  select new E_menu()
                                  {
                                      nombre = menu.Element("Nombre").Value,
                                      icono = menu.Element("Icono").Value,
                                      listsubMenu = menu.Element("DETALLEsubMENU") == null ? new List<subMenu>():
                                      (from subMenu in menu.Element("DETALLEsubMENU").Elements("subMenu")
                                       select new subMenu()
                                       {
                                           nombre = subMenu.Element("Nombre").Value,
                                           nombreFormulario = subMenu.Element("NombreFormulario").Value
                                       }
                                      ).ToList()
                                  }).ToList();


                        }
                    }
                }
                catch (Exception ex)
                {
                    Permisos = new List<E_menu>();

                }

            }
            return Permisos;
        }

    }
}

