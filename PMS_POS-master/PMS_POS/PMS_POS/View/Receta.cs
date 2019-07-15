using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class Receta : Form
    {
        private static Receta _instanceLP;
        public static Receta InstanceLP
        {
            get
            {
                if (_instanceLP == null)
                    _instanceLP = new Receta("NombreProducto");
                return _instanceLP;
            }
        }

        Producto producto = new Producto();

        public Receta(string nombreReceta)
        {
            InitializeComponent();
            dgvProductosEnInventario.DataSource = producto.Select();
            txtNombre.Text = nombreReceta;
            pnlMedidaEnReceta.Visible = false;
        }

        private void BtnAgregarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMedidaEnReceta.Visible = true;
        }

        private void BtnMedidaMedida_MouseClick(object sender, MouseEventArgs e)
        {
            nudCantidad.Value = 0;
            cbxMedida.Text = "";
            chkProductoLiquido.Checked = false;
            pnlMedidaEnReceta.Visible = false;
        }
    }
}
