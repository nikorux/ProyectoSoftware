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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class HistorialCompras : UserControl
    {
        private static HistorialCompras _instance;
        public static HistorialCompras Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HistorialCompras();
                return _instance;
            }
        }

        public HistorialCompras()
        {
            InitializeComponent();
            LoadHistorial();
        }
        public void LoadHistorial()//para listar historial
        {
            dgvCompras.DataSource = GetProvList2();
        }

        private DataTable GetProvList2()//listar historial

        {
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM historial_compra_insumo", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;

        }
        private void HistorialCompras_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCompras.AllowUserToAddRows = false;

            if (txtBuscar.Text != "")
            {

                dgvCompras.CurrentCell = null;
                foreach (DataGridViewRow n in dgvCompras.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvCompras.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                LoadHistorial();
               
            }
        }
    }
}
