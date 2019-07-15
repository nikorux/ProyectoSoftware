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
                    _instance = new MenuActual();
                return _instance;
            }
        }

        MenuConfigurar menu = new MenuConfigurar();

        public MenuActual()
        {
            InitializeComponent();
        }

        Mostrador mostrador = new Mostrador();

        private void MenuActual_Load(object sender, EventArgs e)
        {
            //COMBOBOX DISPLAY CATEGORIA
            MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
            string queryCategoria = "SELECT NombreCategoria FROM categoria";
            connectionCategoria.Open();
            MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
            MySqlDataReader readerCategoria = command.ExecuteReader();
            while (readerCategoria.Read())
            {
                cbxCategoria.Items.Add(readerCategoria.GetString("NombreCategoria"));
            }
            connectionCategoria.Close();

           /* for (int i = 1; i <= cbxCategoria.Items.Count-1; i++)
            {
                listMenuActual.Items.Add(cbxCategoria.SelectedItem.ToString()[i]);
                listMenuActual.Items.Add(" ");
                listMenuActual.Items.Add(mostrador.SelectItemsListMenu(cbxCategoria.SelectedItem.ToString()[i]);
                listMenuActual.Items.Add(" ");
            }*/
        }
    }
}
