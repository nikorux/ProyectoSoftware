using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_POS.View
{
    public partial class ConfigurarCategoriaProducto : UserControl
    {
        private static ConfigurarCategoriaProducto _instance;
        public static ConfigurarCategoriaProducto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarCategoriaProducto();
                return _instance;
            }
        }

        public ConfigurarCategoriaProducto()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void TxtCategoriaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurarCategoriaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
