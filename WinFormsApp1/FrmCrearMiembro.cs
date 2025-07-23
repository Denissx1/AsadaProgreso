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
    public partial class FrmCrearMiembro : Form
    {
        public FrmCrearMiembro()
        {
            InitializeComponent();
        }
        N_Junta N_Junta = new N_Junta();
        public void mostrarMienbros()
        {
            DataGridMienbroJunta.DataSource = N_Junta.mostrar_MienbrosJunta().Tables[0];
        }
        private void FrmCrearMiembro_Load(object sender, EventArgs e)
        {
            mostrarMienbros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridMienbroJunta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
