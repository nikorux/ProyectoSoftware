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
    public partial class ListadoProveedores : UserControl
    {
        private static ListadoProveedores _instance;
        public static ListadoProveedores Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListadoProveedores();
                return _instance;
            }
        }
        public ListadoProveedores()
        {
            InitializeComponent();
            LoadProveedores();//funcion para cargar los proveedores
            
        }
       public void LoadProveedores()//para listar proveedores
        {
            dgvProv.DataSource = GetProvList();   
        }

        private DataTable GetProvList()//listar proveedores
        {
            DataTable dtProveedores = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PROVEEDOR", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtProveedores.Load(reader);
                }
            }

                return dtProveedores;
        
        }
    }
}
