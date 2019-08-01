using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class BuscarCheckedIn : Form
    {

        public static string idHuesped, nombre, telefono, documento;
        public BuscarCheckedIn()
        {
            InitializeComponent();
        }
        Reservacion reservacion = new Reservacion();
        private void TxtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBuscar.Text != "")
            {

                dgvBuscarCheckedIn.CurrentCell = null;
                foreach (DataGridViewRow n in dgvBuscarCheckedIn.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvBuscarCheckedIn.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBoxBuscar.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                RefreshDgv();
            }
        }

        private void BuscarCheckedIn_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }
        private void RefreshDgv()
        {
            dgvBuscarCheckedIn.DataSource = reservacion.VistaTablaCheckedIn();
            dgvBuscarCheckedIn.Columns[0].Visible = false;
            dgvBuscarCheckedIn.Columns[1].Visible = false;
            dgvBuscarCheckedIn.Columns[2].Visible = false;
            dgvBuscarCheckedIn.Columns[3].Visible = false;
            dgvBuscarCheckedIn.Columns[4].Visible = false;
            dgvBuscarCheckedIn.Columns[5].Visible = false;
            dgvBuscarCheckedIn.Columns[6].Visible = false;
            dgvBuscarCheckedIn.Columns[7].Visible = false;
            dgvBuscarCheckedIn.Columns[8].Visible = false;
            dgvBuscarCheckedIn.Columns[9].Visible = false;
            dgvBuscarCheckedIn.Columns[10].Visible = false;
            dgvBuscarCheckedIn.Columns[11].Visible = false;
            dgvBuscarCheckedIn.Columns[18].Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
          string idReservacion;
            if (dgvBuscarCheckedIn.SelectedRows.Count > 0)
            {
                /*
                 IdCliente            [1]
                 NombreCliente        [16]
                 Telefono             [17]
                 NumDocumento         [18]

                   */
                idReservacion = dgvBuscarCheckedIn.Rows[0].Cells[0].Value.ToString();
                FacturacionCheckOut.Instance.FillCheckout(idReservacion);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
    }
}
