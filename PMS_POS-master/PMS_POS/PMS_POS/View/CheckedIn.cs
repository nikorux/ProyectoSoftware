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
    public partial class CheckedIn : UserControl
    {
        private static CheckedIn _instance;
        public static CheckedIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CheckedIn();
                return _instance;
            }
        }

        Reservacion reservacion = new Reservacion();
        public CheckedIn()
        {
            InitializeComponent();
            Refreshdgv();
        }

        private void CheckedIn_Load(object sender, EventArgs e)
        {
            Refreshdgv();
        }
        public void Refreshdgv()
        { 
            dgvCheckedIn.DataSource = reservacion.VistaCheckedIn();
            dgvCheckedIn.Columns[0].Visible = false;
            dgvCheckedIn.Columns[1].Visible = false;
            dgvCheckedIn.Columns[2].Visible = false;
            dgvCheckedIn.Columns[3].Visible = false;
            dgvCheckedIn.Columns[4].Visible = false;
            dgvCheckedIn.Columns[5].Visible = false;
            dgvCheckedIn.Columns[6].Visible = false;
            dgvCheckedIn.Columns[7].Visible = false;
            dgvCheckedIn.Columns[8].Visible = false;
            dgvCheckedIn.Columns[9].Visible = false;
            dgvCheckedIn.Columns[10].Visible = false;
            dgvCheckedIn.Columns[11].Visible = false;
            /* SOLO LAS DE HOY
          for (int i = 0; i < dgvCheckedIn.Rows.Count; i++)
            {
                if (DateTime.Parse(dgvCheckedIn.Rows[i].Cells[13].Value.ToString()) != DateTime.Today.Date)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCheckedIn.DataSource];
                    currencyManager1.SuspendBinding();
                    dgvCheckedIn.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                    
                }
            }
            */


         }

        private void DgvCheckedIn_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Refreshdgv();
        }

        private void BtnEliminarReservacion_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvCheckedIn.SelectedRows.Count > 0)
            {
                int row = 0;
                row = dgvCheckedIn.SelectedCells[0].RowIndex;

                if (!MainScreen.Instance.PnlContainer.Controls.ContainsKey("FacturacionCheckOut"))
                {
                    FacturacionCheckOut un = new FacturacionCheckOut();
                    un.Dock = DockStyle.Fill;
                    MainScreen.Instance.PnlContainer.Controls.Add(un);
                    DataGridViewRow selectedRow = dgvCheckedIn.Rows[row];

                    un.FillFactura(Convert.ToInt32(selectedRow.Cells["IdReservacion"].Value));
                }
                MainScreen.Instance.PnlContainer.Controls["FacturacionCheckOut"].BringToFront();


            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
    }
}
