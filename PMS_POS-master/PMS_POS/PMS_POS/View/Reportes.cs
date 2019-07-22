using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class Reportes : UserControl
    {
        private static Reportes _instance;
        public static Reportes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reportes();
                return _instance;
            }
        }

        Producto producto = new Producto();

        public Reportes()
        {
            InitializeComponent();
            dgvAjustes.DataSource = producto.SelectAjustes();
            dgvRecepcion.DataSource = producto.SelectHistorialComprasProveedores();
            dgvFacturas.DataSource = producto.SelectFacturas();
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvAjustes.AllowUserToAddRows = false;

            if (txtBuscarProductoAjustesInventario.Text != "")
            {

                dgvAjustes.CurrentCell = null;
                foreach (DataGridViewRow n in dgvAjustes.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvAjustes.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarProductoAjustesInventario.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvAjustes.DataSource = producto.Select();
            }
        }

        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProductoAjustesInventario.Text = "";
        }

        private void CbxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxCategoriaInventario.Text == "Todas")
            {
                dgvAjustes.DataSource = producto.SelectAjustes();
            }
            else
            {
                dgvAjustes.DataSource = producto.FiltrarPORcategoria(cbxCategoriaInventario.SelectedItem.ToString());
            }
        }

        private void TxtBuscarRecepcion_TextChanged(object sender, EventArgs e)
        {
            dgvRecepcion.AllowUserToAddRows = false;

            if (txtBuscarInventario.Text != "")
            {

                dgvRecepcion.CurrentCell = null;
                foreach (DataGridViewRow n in dgvRecepcion.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvRecepcion.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarInventario.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvRecepcion.DataSource = producto.Select();
            }
        }

        private void TxtBuscarFacturas_TextChanged(object sender, EventArgs e)
        {
            dgvFacturas.AllowUserToAddRows = false;

            if (txtBuscarInventario.Text != "")
            {

                dgvFacturas.CurrentCell = null;
                foreach (DataGridViewRow n in dgvFacturas.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvFacturas.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarFacturas.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvFacturas.DataSource = producto.Select();
            }
        }

        private void ChxPagadas_CheckedChanged(object sender, EventArgs e)
        {
            if(chxPagadas.Checked == true)
            {
                dgvFacturas.DataSource = producto.getDetallesFacturas("Pagada");
            }
            else
            {
                dgvFacturas.DataSource = producto.getDetallesFacturas("Pendiente");
            }
        }

        private void CbxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cbxFormaPago.SelectedItem.ToString();
            dgvFacturas.DataSource = producto.getDetallesFacturas(search);
        }

        private void CbxFacturasTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cbxFacturasTipoPago.SelectedItem.ToString();
            dgvFacturas.DataSource = producto.getDetallesFacturas(search);
        }
    }
}
