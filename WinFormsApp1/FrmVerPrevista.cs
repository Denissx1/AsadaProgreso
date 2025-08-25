using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidades;
using Capa_datos;
using Capa_Negocio;
using Datos;

namespace capa_Vista
{
    public partial class FrmVerPrevista : Form
    {
        public FrmVerPrevista()
        {
            InitializeComponent();
        }
        N_Previstas N_Previstas = new N_Previstas();

        DataSet resultado = new DataSet();
        DataView mifiltro;
        public void leer_datos(string query, ref DataSet dstpricipal, string tabla)
        {
            try
            {
                string cadena = "server=.;database=AsadaProgreso;user=sa;password=1234";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstpricipal, tabla);
                da.Dispose();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos" + ex.Message);
            }
        }
        public void mostrar_Prevista()
        {
            dataGridPrevistas.DataSource = N_Previstas.mostrar_Previstas().Tables[0];
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerPrevista_Load(object sender, EventArgs e)
        {
            mostrar_Prevista();
            buscador();

        }

        public void buscador()
        {

        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void BtnBuscar_Click(object sender, EventArgs e)

        {
            D_conexion conexion = new D_conexion();
            conexion.conectar();

            string consulta = ("select Abonado,Cedula,Prevista,Pueblo,Direccion,Estado from Previstas where Prevista=" + int.Parse(txtBuscar.Text) + "");
            SqlCommand comando = new SqlCommand(consulta, conexion.conectar());
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridPrevistas.DataSource = dt;
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conexion.desconectar();

        }

        private DataView Mifiltro => mifiltro;

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e, DataView mifiltro)
        {
        }

        private DataView GetMifiltro() => mifiltro;

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e, DataView mifiltro)
        {

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            mostrar_Prevista();
        }
    }
}
