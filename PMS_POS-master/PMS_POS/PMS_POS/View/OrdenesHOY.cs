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
    public partial class OrdenesHOY : Form
    {
        Ordenes ordenes = new Ordenes();
        Mostrador mostrador = new Mostrador();
        Mesa mesa = new Mesa();
        static public string Caja = null;

        public OrdenesHOY(string NombreCaja)
        {
            InitializeComponent();
            Caja = NombreCaja;
            //STYLE DGV MESAS
            this.dgvMesas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dgvMesas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.dgvMesas.RowTemplate.MinimumHeight = 25;
            dgvMesas.DataSource = mostrador.SelectOrdenesAbiertasORDENES(Caja);

            //STYLE DGV DETALLES_ORDENES
            this.dgvDetallesOrdenes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dgvDetallesOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.dgvDetallesOrdenes.RowTemplate.MinimumHeight = 25;

            txtCajaSeleccionada.Text = Caja;
        }

        private void DgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = mostrador.ItemsEnFactura(Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value.ToString()));
            dgvDetallesOrdenes.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvDetallesOrdenes.Rows.Add(Convert.ToInt32(row["IdInsumo"].ToString()),
                   Convert.ToInt32(row["CantidadComprada"].ToString()),
                   row["NombreInsumo"].ToString());
            }

            int IdFactura = Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value.ToString());
            int IdPedido = mostrador.SearchIdPedidoFROMIdFactura(IdFactura, dgvMesas.CurrentRow.Cells[1].Value.ToString());
            txtCliente.Text =  mostrador.NombreClienteFROMIdPedido(IdPedido);
            txtMesa.Text = mostrador.NombreMesaFROMIdPedido(IdPedido);
            txtOrden.Text = dgvMesas.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnCheckOut_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                mostrador.UpdateCheckedOut(Convert.ToInt32(txtOrden.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMesas.DataSource = mostrador.SelectOrdenesAbiertasORDENES(Caja);
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

        private void PicRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            dgvMesas.DataSource = mostrador.SelectOrdenesAbiertasORDENES(Caja);
            dgvDetallesOrdenes.Rows.Clear();
            txtCliente.Text = "";
            txtMesa.Text = "";
            dgvMesas.DataSource = mostrador.SelectOrdenesAbiertasORDENES(Caja);
            txtOrden.Text = "";
        }

        private void OrdenesHOY_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
