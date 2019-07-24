using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;
namespace PMS_POS.View
{
    public partial class Reservaciones : UserControl
    {
        Reservacion obj = new Reservacion();

        private static Reservaciones _instance;
        public static Reservaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reservaciones();
                return _instance;
            }
        }
        UserControlInicio userControlInicio1 = new UserControlInicio();
        public Reservaciones()
        {
            InitializeComponent();
        }
        Reservacion reservacion = new Reservacion();

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            RefreshDgv();


        }
       /*
        private void DgvReservaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the
            // value.
            if (this.dgvReservaciones.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        string stringValue = e.Value == DBNull.Value ? string.Empty : (string)e.Value;
                        stringValue = stringValue.ToLower();
                        if ((stringValue.IndexOf("sin confirmar") > -1))
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            

        }
        */

        private void BtnEditarReservacion_Click(object sender, EventArgs e)
        {
            if (dgvReservaciones.SelectedRows.Count > 0)
            {
                NuevaReservacion nr = NuevaReservacion.Instance;
                
                int index = dgvReservaciones.CurrentCell.RowIndex;
                this.Controls.Add(NuevaReservacion.Instance);
                nr.RecibirDatos(
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[0].Value),
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[1].Value),
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[2].Value),
                    Convert.ToDateTime(dgvReservaciones.Rows[index].Cells[3].Value),
                    Convert.ToDateTime(dgvReservaciones.Rows[index].Cells[4].Value),
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[5].Value),
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[6].Value),
                    Convert.ToInt32(dgvReservaciones.Rows[index].Cells[7].Value),
                    Convert.ToSingle(dgvReservaciones.Rows[index].Cells[11].Value),
                    dgvReservaciones.Rows[index].Cells[8].Value.ToString(),
                    dgvReservaciones.Rows[index].Cells[9].Value.ToString());
                    nr.BringToFront();


            }

        }
        public void RefreshDgv()
        {
            dgvReservaciones.DataSource = obj.VistaTabla();
            dgvReservaciones.Columns[0].Visible = false;
            dgvReservaciones.Columns[1].Visible = false;
            dgvReservaciones.Columns[2].Visible = false;
            dgvReservaciones.Columns[3].Visible = false;
            dgvReservaciones.Columns[4].Visible = false;
            dgvReservaciones.Columns[5].Visible = false;
            dgvReservaciones.Columns[6].Visible = false;
            dgvReservaciones.Columns[7].Visible = false;
            dgvReservaciones.Columns[8].Visible = false;
            dgvReservaciones.Columns[9].Visible = false;
            dgvReservaciones.Columns[10].Visible = false;
            dgvReservaciones.Columns[11].Visible = false;

        }

        private void BtnEliminarReservacion_Click(object sender, EventArgs e)
        {

            if (dgvReservaciones.SelectedRows.Count > 0)
            {
                obj.IdReservacion = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[0].Value);
                obj.IdHabitacion = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[2].Value);
                if (obj.Delete(obj) == true)
                {
                    Habitacion hab = new Habitacion();
                    hab.IdHabitacion = obj.IdHabitacion;

                    if (hab.CambiarEstado(hab.IdHabitacion, "Disponible") == true)
                    {
                        MessageBox.Show("La reservacion ha sido eliminada.");
                        RefreshDgv();
                    }

                }
                else
                {
                    MessageBox.Show("Error al eliminar los datos.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvReservaciones.SelectedRows.Count > 0)
            { int row = 0;
                row = dgvReservaciones.SelectedCells[0].RowIndex;
         
                if (!MainScreen.Instance.PnlContainer.Controls.ContainsKey("FacturacionCheckIn"))
                {
                    FacturacionCheckIn un = new FacturacionCheckIn();
                    un.Dock = DockStyle.Fill;
                    MainScreen.Instance.PnlContainer.Controls.Add(un);
                    DataGridViewRow selectedRow = dgvReservaciones.Rows[row];
                    
                    un.FillFactura(Convert.ToInt32(selectedRow.Cells["IdReservacion"].Value));
                }
                MainScreen.Instance.PnlContainer.Controls["FacturacionCheckIn"].BringToFront();
                
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void Reservaciones_Enter(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void txtFiltroo_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtFiltroo.Text != "")
                {

                    dgvReservaciones.CurrentCell = null;
                    foreach (DataGridViewRow n in dgvReservaciones.Rows)
                    {
                        n.Visible = false;
                    }
                    foreach (DataGridViewRow n in dgvReservaciones.Rows)
                    {
                        foreach (DataGridViewCell m in n.Cells)
                        {
                            if ((m.Value.ToString().ToUpper().IndexOf(txtFiltroo.Text.ToUpper()) == 0))
                            {
                                n.Visible = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    dgvReservaciones.DataSource = obj.VistaTabla();
                }

            }

        }

        private void btnRegistrarCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}

