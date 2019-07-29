using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class LiquidarServiciosAdquiridos : Form
    {

        MySqlConnection conex;
        string cadenaconex;
        string instruccion;
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=hostal; Uid=root; pwd=root;");
        FacturacionCheckOut obj = new FacturacionCheckOut();

        public LiquidarServiciosAdquiridos()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }
       
        private void LiquidarServiciosAdquiridos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void LiquidarServiciosAdquiridos_Load(object sender, EventArgs e)
        {
         //   dgvServiciosAdquiridos.DataSource = obj.VistaTabla();

        }
    }
}
