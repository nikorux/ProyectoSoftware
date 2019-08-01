using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class MostradorUI : UserControl
    {
        private static MostradorUI _instance;
        public static MostradorUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MostradorUI();
                return _instance;
            }
        }

        public MostradorUI()
        {
            InitializeComponent();
            LoadProdMostrador();
        }

        public void LoadProdMostrador()//para listar 
        {
            dgvProductosMostrador.DataSource = GetProvList();
        }

        private DataTable GetProvList()//listar
        {
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM insumo where EnMostrador = 1", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;

        }

        public void LoadProdSeleccionados()//para listar 
        {
            dgvFactura.DataSource = GetProvList2();
        }

        private DataTable GetProvList2()//listar
        {
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM facturamostrador_insumo", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;

        }

        private void btnGuardarOrdenAbierta_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarFacturaAOrden_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarAFactura_Click(object sender, EventArgs e)
        {
           

        }
    }
}
