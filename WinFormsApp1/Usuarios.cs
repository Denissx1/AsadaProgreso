using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Capa_entidades;
using Capa_Negocio;

namespace Vista
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        N_usuarios N_usuarios = new N_usuarios();

        //Metodo para mostrar los usuarios
        public void mostrarUsuarios()
        {
            gridUser.DataSource = N_usuarios.Mostrar_usuarios().Tables[0];
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            E_usuarios E_usuarios = new E_usuarios();

            E_usuarios.nomUsuarios = txtNombre.Text;
            E_usuarios.cedula = int.Parse(txtCedula.Text);
            E_usuarios.correo = txtCorreo.Text;
            E_usuarios.contrasena = txtcontra.Text;
            E_usuarios.tipoUsuario = txtTipo_Usuario.Text;

            N_usuarios.insertar_Usuarios(E_usuarios);
            mostrarUsuarios();
            MessageBox.Show("Usuario agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            E_usuarios E_usuarios = new E_usuarios();

            E_usuarios.nomUsuarios = gridUser.CurrentRow.Cells[0].Value.ToString();
            E_usuarios.cedula = int.Parse(txtCedula.Text);
            E_usuarios.correo = txtCorreo.Text;
            E_usuarios.contrasena = txtcontra.Text;
            E_usuarios.tipoUsuario = txtTipo_Usuario.Text;

            N_usuarios.editar_Usuario(E_usuarios);
            mostrarUsuarios();
            MessageBox.Show("Usuario Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = gridUser.CurrentRow.Cells[0].Value.ToString();
                txtCedula.Text = gridUser.CurrentRow.Cells[1].Value.ToString();
                txtCorreo.Text = gridUser.CurrentRow.Cells[2].Value.ToString();
                txtcontra.Text = gridUser.CurrentRow.Cells[3].Value.ToString();
                txtTipo_Usuario.Text = gridUser.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            E_usuarios E_usuarios = new E_usuarios();
            if (MessageBox.Show("¿Deseas eliminar el usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                E_usuarios.nomUsuarios = gridUser.CurrentRow.Cells[0].Value.ToString();
                N_usuarios.eliminar_Usuario(E_usuarios);
                mostrarUsuarios();
                MessageBox.Show("Usuario eliminado con exito","Elimino",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
