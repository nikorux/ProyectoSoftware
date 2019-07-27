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

        private void dgvProductosMostrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductosMostrador.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["NombreInsumo"].Value.ToString();
                txtPrecio.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtIdInsumo.Text = row.Cells["IdInsumo"].Value.ToString();
                txtIdInsumo.Text = row.Cells["IdInsumo"].Value.ToString();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarAFactura_Click(object sender, EventArgs e)
        {
            try
            {
                int contadorFactura = 1;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "insert into hostal.facturamostrador_insumo(IdFacturaMostrador,IdInsumo, PrecioVenta, CantidadComprada,nombreInsumo) values('" + contadorFactura + "','" +txtIdInsumo.Text  + "','" +txtPrecio.Text+ "','" + spnCantComprar.Text + "','"+ txtNombre.Text + "');"; ;
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //MessageBox.Show("Datos Registrados");
                LoadProdSeleccionados();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
