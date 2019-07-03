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
    public partial class RegistrarNuevaCompra : UserControl
    {
        private static RegistrarNuevaCompra _instance;
        public static RegistrarNuevaCompra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrarNuevaCompra();
                return _instance;
            }
        }

        public RegistrarNuevaCompra()
        {
            InitializeComponent();
        }

        private void TxtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void RegistrarNuevaCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
