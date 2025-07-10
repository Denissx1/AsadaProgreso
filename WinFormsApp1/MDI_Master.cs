using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_datos;
using Capa_entidades;

namespace capa_Vista
{
    public partial class MDI_Master : Form
    {
        private int Idusuario;
        public MDI_Master(int idUsuario_esperado = 0)
        {
            InitializeComponent();
            Idusuario = idUsuario_esperado;
        }

        private void MDI_Master_Load(object sender, EventArgs e)
        {
            List<E_menu> permisos_esperados = D_Roles.ObtenerPermisos(Idusuario);
            MenuStrip miMenu = new MenuStrip();
            foreach (E_menu objMenu in permisos_esperados){
                ToolStripMenuItem menuPadre = new ToolStripMenuItem(objMenu.nombre);
                menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;
               // string rutaImagen = Path.GetFullPath(Path.Combine(Application.StartupPath, @"Iconos") + @objMenu.icono);

               // menuPadre.Image = new Bitmap(rutaImagen);
                menuPadre.ImageScaling = ToolStripItemImageScaling.None;

                miMenu.Items.Add(menuPadre);
            }

            this.MainMenuStrip = miMenu;
           Controls.Add(miMenu);
        }
    }
}
