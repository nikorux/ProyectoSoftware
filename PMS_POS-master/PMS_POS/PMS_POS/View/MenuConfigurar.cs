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
        private static MenuConfigurar _instance;//kuyvkuvgy
        public static MenuConfigurar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MenuConfigurar("haha");
                return _instance;
            }
        }

        Mostrador mostrador = new Mostrador();
        static public string Caja = null;

        public MenuConfigurar(string NombreCaja)
        {
            InitializeComponent();
            Caja = NombreCaja;
            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu(Caja);
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu(Caja);
        }

        private void BtnVerMenuActual_MouseClick(object sender, MouseEventArgs e)
        {
            MenuActual menuactual = new MenuActual(Caja);
            menuactual.Show();
        }

        private void MenuConfigurar_Load(object sender, EventArgs e)
        {
            //COMBOBOX DISPLAY CATEGORIA
            MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
            //string queryCategoria = "SELECT NombreCategoria FROM categoria where EnMostrador=1 AND NombreCaja='" + this.txtCaja.Text + "';";
            string queryCategoria = "SELECT NombreCategoria FROM categoria WHERE NombreCaja='" + Caja + "';";
            connectionCategoria.Open();
            MySqlCommand cmd = new MySqlCommand(queryCategoria, connectionCategoria);
            MySqlDataReader readerCategoria = cmd.ExecuteReader();
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
                dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu(Caja);
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

            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu(Caja);
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu(Caja);
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

            dgvProductosDisponibles.DataSource = mostrador.SelectItemsDisponiblesParaMenu(Caja);
            dgvProductosEnMenu.DataSource = mostrador.SelectItemsEnMenu(Caja);
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProductosDisponibles.DataSource = mostrador.FiltrarPORcategoria(cbxCategoria.SelectedItem.ToString(), Caja);
        }
    }
}
