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
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
//using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class ListadoProducto : UserControl
    {
        private static ListadoProducto _instance;
        public static ListadoProducto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListadoProducto();
                return _instance;
            }
        }

        Producto producto = new Producto();

        public ListadoProducto()
        {
            InitializeComponent();
            dgvProductos.DataSource = producto.Select();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(RegistroNuevoProducto.Instance))
            {
                panel1.BringToFront();
                panel1.Controls.Add(RegistroNuevoProducto.Instance);
                RegistroNuevoProducto.Instance.Dock = DockStyle.Fill;
                RegistroNuevoProducto.Instance.BringToFront();
            }
            else
            {
                RegistroNuevoProducto.Instance.BringToFront();
            }

            /*if (dgvHab.SelectedRows.Count > 0)
             {
                 //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                 editar = true;
                 txtBoxNumHab.Text = dgvHab.CurrentRow.Cells[1].Value.ToString();
                 cmbTipoHab.Text = dgvHab.CurrentRow.Cells[2].Value.ToString();
                 numCantCamas.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[3].Value);
                 numMaxPersonas.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[4].Value);
                 numPiso.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[5].Value);
                 cmbEstado.Text = dgvHab.CurrentRow.Cells[6].Value.ToString();
                 txtBoxDetalles.Text = dgvHab.CurrentRow.Cells[7].Value.ToString();
                 txtBoxPrecioPorNoche.Text = dgvHab.CurrentRow.Cells[9].Value.ToString();
             }
             else
             {
                 MessageBox.Show("Seleccione una fila.");
             }*/
        }

        private void BtnAjustarStock_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                producto.IdInsumo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                if (producto.Delete(producto) == true)
                {
                    MessageBox.Show("La habitación ha sido eliminada.");
                }
                else
                {
                    MessageBox.Show("Error al editar los datos.)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar las habitación. (Error: " + ex + ")");
            }
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text != "")
            {
                dgvProductos.CurrentCell = null;
                foreach (DataGridViewRow n in dgvProductos.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvProductos.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(dgvProductos.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvProductos.DataSource = producto.Select();
            }
        }


        private void DgvProductos(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProducto.Text = string.Empty;
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void ListadoProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
