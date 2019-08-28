using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class MenuActual : Form
    {
        private static MenuActual _instance;
        public static MenuActual Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MenuActual("");
                return _instance;
            }
        }

        MenuConfigurar menu = new MenuConfigurar("");
        static public string Caja = null;
        public MenuActual(string NombreCaja)
        {
            InitializeComponent();
            Caja = NombreCaja;
        }

        Producto producto = new Producto();

        private void MenuActual_Load(object sender, EventArgs e)
        {
            //COMBOBOX DISPLAY CATEGORIA
            MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
            string queryCategoria = "SELECT NombreCategoria FROM categoria WHERE NombreCaja='" + Caja + "';";
            connectionCategoria.Open();
            MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
            MySqlDataReader readerCategoria = command.ExecuteReader();
            while (readerCategoria.Read())
            {
                cbxCategoria.Items.Add(readerCategoria.GetString("NombreCategoria"));
            }
            connectionCategoria.Close();

            for (int i = 1; i <= cbxCategoria.Items.Count-1; i++)
            {
                listMenuActual.Items.Add("========================");

                string nombreCategoria = cbxCategoria.Items[i].ToString();
                listMenuActual.Items.Add(nombreCategoria);
                int IdCategoria = producto.SelectIdCategoria(nombreCategoria);

                //print Menu en list
                MySqlConnection connection = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string query = "SELECT NombreInsumo, PrecioVenta FROM insumo WHERE IsDeleted=0 AND EnMostrador=1 AND IdCategoria=@idCategoria AND NombreCaja='" + Caja + "';";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
                MySqlDataReader reader = cmd.ExecuteReader();
                listMenuActual.Items.Add("========================");
                while (reader.Read())
                {
                    listMenuActual.Items.Add(reader.GetString("NombreInsumo"));
                }
                connection.Close();

                listMenuActual.Items.Add("- - - - - - - - - -");
                listMenuActual.Items.Add(" ");
            }
        }
    }
}
