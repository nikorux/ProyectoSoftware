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
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{//
    public partial class Reportes : UserControl//uygvoygo
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
        Mostrador mostrador = new Mostrador();

        public Reportes()
        {
            InitializeComponent();
            dgvAjustes.DataSource = producto.SelectAjustes();
            dgvRecepcion.DataSource = producto.SelectHistorialComprasProveedores();
            dgvFacturas.DataSource = producto.SelectFacturas();
            dgvOrdenes.DataSource = mostrador.SelectPedidos();
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

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                //COMBOBOX DISPLAY CATEGORIA
                MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryCategoria = "SELECT NombreCategoria FROM categoria";
                connectionCategoria.Open();
                MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
                MySqlDataReader readerCategoria = command.ExecuteReader();
                while (readerCategoria.Read())
                {
                    cbxRecepcion.Items.Add(readerCategoria.GetString("NombreCategoria"));
                }
                connectionCategoria.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscarVentas_TextChanged(object sender, EventArgs e)
        {
            dgvOrdenes.AllowUserToAddRows = false;

            if (txtBuscarVentas.Text != "")
            {

                dgvOrdenes.CurrentCell = null;
                foreach (DataGridViewRow n in dgvOrdenes.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvOrdenes.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarVentas.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvOrdenes.DataSource = mostrador.SelectPedidos();
            }
        }

        private void CbxEstadoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cbxFormaPago.SelectedItem.ToString();
            dgvFacturas.DataSource = mostrador.SelectEstadoPedido(search);
        }
    }
}
