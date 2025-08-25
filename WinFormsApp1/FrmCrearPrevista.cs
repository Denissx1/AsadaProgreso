using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidades;
using Capa_Negocio;


namespace capa_Vista
{
    public partial class FrmCrearPrevista : Form
    {
        public FrmCrearPrevista()
        {
            InitializeComponent();
        }
        N_Previstas N_Previstas = new N_Previstas();

        public void mostrar_Prevista()
        {

            dataGridPrevistas.DataSource = N_Previstas.mostrar_Previstas().Tables[0];
        }
        private void FrmCrearPrevista_Load(object sender, EventArgs e)
        {
            mostrar_Prevista();
        }

        private void dataGridPrevistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void BtnGuadar_Click(object sender, EventArgs e)
        {

            E_Previstas E_prevista = new E_Previstas();

            E_prevista.Abonado = TxtAbonado.Text;
            E_prevista.cedula = int.Parse(TxtCedula.Text);
            E_prevista.Prevista = int.Parse(TxtPrevista.Text);
            E_prevista.pueblo = comboPueblo.Text;
            E_prevista.direccion = TxtDireccion.Text;
            E_prevista.estado = comboEstado.Text;
            N_Previstas.insertar_Prevista(E_prevista);
            mostrar_Prevista();
            MessageBox.Show("Prevista Creada con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrar_Prevista();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
