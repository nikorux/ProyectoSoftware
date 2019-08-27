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
    public partial class MostrarArticulosFactura : Form
    {
        Mostrador mostrador = new Mostrador();

        public MostrarArticulosFactura(int IdFactura, string NombreCliente)
        {
            InitializeComponent();
            txtIdFactura.Text = IdFactura.ToString();
            txtNombreCliente.Text = NombreCliente;
            this.dgvArticulos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dgvArticulos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.dgvArticulos.RowTemplate.MinimumHeight = 25;
            dgvArticulos.DataSource = mostrador.ItemsEnFactura(IdFactura);
        }
    }
}
