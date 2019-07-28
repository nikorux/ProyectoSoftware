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
    public partial class MenuConfigurar : Form
    {
        private static MenuConfigurar _instance;
        public static MenuConfigurar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MenuConfigurar();
                return _instance;
            }
        }

        Mostrador mostrador = new Mostrador();

        public MenuConfigurar()
        {
            InitializeComponent();
            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu();
        }

        private void BtnVerMenuActual_MouseClick(object sender, MouseEventArgs e)
        {
            MenuActual menuactual = new MenuActual();
            menuactual.Show();
        }

        private void MenuConfigurar_Load(object sender, EventArgs e)
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
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProductosDisponibles.AllowUserToAddRows = false;

            if (txtBuscarProducto.Text != "")
            {

                dgvProductosDisponibles.CurrentCell = null;
                foreach (DataGridViewRow n in dgvProductosDisponibles.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvProductosDisponibles.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarProducto.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            }
        }

        private void BtnRemoverItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosEnMenu.SelectedRows.Count > 0)
            {
                int IdInsumo = Convert.ToInt32(dgvProductosEnMenu.CurrentRow.Cells[0].Value);

                if (mostrador.UpdateRemoverDelMostrador(IdInsumo) == true);
                else
                {
                    MessageBox.Show("Error al registrar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu();
        }

        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProducto.Text = "";
        }

        private void BtnAgregarItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosDisponibles.SelectedRows.Count > 0)
            {
                int IdInsumo = Convert.ToInt32(dgvProductosDisponibles.CurrentRow.Cells[0].Value);

                if (mostrador.UpdateProductoAMenu(IdInsumo) == true);
                else
                {
                    MessageBox.Show("Error al registrar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu();
        }

        Producto producto = new Producto();

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCategoria.Text = cbxCategoria.Text;
            if (cbxCategoria.Text == "Todas")
            {
                dgvProductosDisponibles.DataSource = producto.Select();
            }
            else
            {   
                dgvProductosDisponibles.DataSource = producto.FiltrarPORcategoria(cbxCategoria.SelectedItem.ToString());
            }
        }
    }
}
