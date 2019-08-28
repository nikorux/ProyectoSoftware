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
using System.Text.RegularExpressions;

namespace PMS_POS.View
{
    public partial class VentasHOY : Form
    {
        static public string Caja = null;
        Mostrador mostrador = new Mostrador();

        public void controlColumns()
        {
            dgvVentas.Columns[3].Visible = false;
            dgvVentas.Columns[11].Visible = false;
            dgvVentas.Columns[12].Visible = false;
            dgvVentas.Columns[13].Visible = false;
            dgvVentas.Columns[14].Visible = false;
            dgvVentas.Columns[10].Visible = false;
        }
        public VentasHOY(string NombreCaja)
        {
            InitializeComponent();
            this.dgvVentas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.dgvVentas.RowTemplate.MinimumHeight = 25;
            Caja = NombreCaja;
            txtCajaSeleccionada.Text = Caja;
            dgvVentas.DataSource = mostrador.SelectOrdenesPagadas(Caja);
            controlColumns();
            txtBalance.Text = (balance(mostrador.SelectOrdenesPagadas(Caja))).ToString();
        }

        public float balance(DataTable dt)
        {
            float balance = 0;

            foreach (DataRow row in dt.Rows)
            {
                balance += float.Parse(row["Total"].ToString());
            }

            return balance;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int ampmHOUR = Convert.ToInt32(DateTime.Now.ToString("HH"));
            string ampm = null;
            if (ampmHOUR <= 11)
            {
                ampm = "AM";
            }
            else
            {
                ampm = "PM";
            }

            lblHora.Text = DateTime.Now.ToString("hh:mm ");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAMPM.Text = ampm;
        }

        private void VentasHOY_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dgvVentas.AllowUserToAddRows = false;

            if (txtBuscarFactura.Text != "" && txtBuscarFactura.Text != "Buscar")
            {

                dgvVentas.CurrentCell = null;
                foreach (DataGridViewRow n in dgvVentas.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvVentas.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarFactura.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvVentas.DataSource = mostrador.SelectOrdenesPagadas(Caja);
                controlColumns();
                txtBalance.Text = (balance(mostrador.SelectOrdenesPagadas(Caja))).ToString();
            }
        }

        private void TxtBuscarFactura_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarFactura.Text = "";
        }

        private void VentasHOY_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarFactura.Text = "Buscar";
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarFactura.Text = "Buscar";
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFormaDePago.Text == "Todas")
            {
                dgvVentas.DataSource = mostrador.SelectOrdenesPagadas(Caja);
                txtBalance.Text = (balance(mostrador.SelectOrdenesPagadas(Caja))).ToString();
                controlColumns(); 
            }
            else
            {
                dgvVentas.DataSource = mostrador.FiltrarPORFormaDePagoEnMostradorHOY(cbxFormaDePago.Text, Caja);
                txtBalance.Text = (balance(mostrador.FiltrarPORFormaDePagoEnMostradorHOY(cbxFormaDePago.Text, Caja))).ToString();
                controlColumns();
            }
        }

        private void PicRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            dgvVentas.DataSource = mostrador.SelectOrdenesPagadas(Caja);
            controlColumns();
            txtBuscarFactura.Text = "Buscar";
            cbxFormaDePago.Text = "Todas";
        }

        private void BtnMostrarArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                MostrarArticulosFactura mostrarArticulosFactura = new MostrarArticulosFactura(Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value.ToString()), dgvVentas.CurrentRow.Cells[1].Value.ToString());
                mostrarArticulosFactura.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
