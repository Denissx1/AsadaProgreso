using Capa_datos;
using Capa_entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_Vista;

namespace capa_Vista
{
    public partial class menu_Principal : Form
    {
        private int Idusuario;
        public menu_Principal(int idUsuario_esperado = 0)
        {
            InitializeComponent();
            Idusuario = idUsuario_esperado;
        }

        private void saliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Principal_Load(object sender, EventArgs e)
        {
            List<E_menu> permisos_esperados = D_Roles.ObtenerPermisos(Idusuario);
            MenuStrip miMenu = new MenuStrip();
            foreach (E_menu objMenu in permisos_esperados)
            {
                ToolStripMenuItem menuPadre = new ToolStripMenuItem(objMenu.nombre);
                menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;
                /*string rutaImagen = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../") + objMenu.icono);
                menuPadre.Image = new Bitmap(rutaImagen);
               menuPadre.ImageScaling = ToolStripItemImageScaling.None;*/

                foreach (subMenu objsubMenu in objMenu.listsubMenu)
                {
                    ToolStripMenuItem menuHijo = new ToolStripMenuItem(objsubMenu.nombre, null, click_em_menu, objsubMenu.nombreFormulario);

                    menuPadre.DropDownItems.Add(menuHijo);
                }
                miMenu.Items.Add(menuPadre);
            }

            this.MainMenuStrip = miMenu;
            Controls.Add(miMenu);
        }
        private void click_em_menu(object sender, System.EventArgs e)
        {
            ToolStripMenuItem menuSeleccionado = (ToolStripMenuItem)sender;

            //NOS AYUDA A VALIDAR SI EXISTE ELEMENTOS EN NUESTRO PROYECTO - OBTENEMOS PROYECTO
            //ASSEMBLY Obtiene el proceso de nuestro ejecutable
            Assembly asm = Assembly.GetEntryAssembly();

            Type elemento = asm.GetType(asm.GetName().Name + "." + menuSeleccionado.Name);

            if (elemento == null)
            {
                MessageBox.Show("Formulario no encontrado");
            }
            else
            {

                //IMPORTANTE CAMBIAR EL TEXTO DEL FORMULARIO CUANDO SE CREA , TIENE QUE SER DIFERENTE AL NAME
                Form FormularioCreado = (Form)Activator.CreateInstance(elemento);


                int encontrado = this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).ToList().Count();

                if (encontrado != 0)
                {

                    ((Form)this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).FirstOrDefault()).WindowState = FormWindowState.Normal;
                    ((Form)this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).FirstOrDefault()).Activate();

                }
                else
                {
                    this.IsMdiContainer = true;
                    // FormularioCreado.MdiParent = this;
                    FormularioCreado.Show();
                }

            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

