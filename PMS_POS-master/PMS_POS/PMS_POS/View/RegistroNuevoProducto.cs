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
    public partial class RegistroNuevoProducto : UserControl
    {
        private static RegistroNuevoProducto _instance;
        public static RegistroNuevoProducto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistroNuevoProducto();
                return _instance;
            }
        }

        public RegistroNuevoProducto()
        {
            InitializeComponent();
        }

        private void TxtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void CbxImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
