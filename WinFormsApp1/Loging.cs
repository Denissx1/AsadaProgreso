using Capa_datos;
using Capa_entidades;
using capa_Vista;

namespace WinFormsApp1
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
        }

        private void BrnSalir_Click(object sender, EventArgs e)
        {
            // Permite cerrar un formulario
            this.Close();
        }
        private bool showPassword = false;
        private void PbPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                TxtContra.PasswordChar = '\0';
                PbPassword.Image = capa_Vista.Properties.Resources.OjoCerrado;

            }
            else
            {
                TxtContra.PasswordChar = '*';
                PbPassword.Image = capa_Vista.Properties.Resources.Ojo;
            }

        }

        private void HorayFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            int idUsuario_esperado = D_Loging.Loguear(TxtNombre.Text, TxtContra.Text);

            if (idUsuario_esperado != 0)
            {
                this.Hide();
                menu_Principal mdi = new menu_Principal(idUsuario_esperado);
                mdi.Show();

            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }
    }
}
