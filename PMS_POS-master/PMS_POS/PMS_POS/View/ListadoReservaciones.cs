using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.View;
using MySql.Data.MySqlClient;
using System.Configuration;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class ListadoReservaciones : UserControl
    {
        private static ListadoReservaciones _instance;
        public static ListadoReservaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListadoReservaciones();
                return _instance;
            }
        }

        Reservacion reservacion = new Reservacion();
        Habitacion habitacion = new Habitacion();
        Huesped huesped = new Huesped();
        public ListadoReservaciones()
        {
            InitializeComponent();
            this.BringToFront();
            
            dgvReservaciones.DataSource = reservacion.Select();
            //dgvInfoHuesped.DataSource = huesped.VistaTabla();
          //  dgvInfoHuesped.Columns[0].Visible = false;
          //  dgvInfoHuesped.Columns[16].Visible = false;
           // dgvInfoHuesped.Columns[17].Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                reservacion.IdReservacion = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[0].Value);
                if (reservacion.Delete(reservacion) == true)
                {   
                    MessageBox.Show("La reservación ha sido eliminada.");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Error al editar los datos.)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la reservación. (Error: " + ex + ")");
            }
        }

        private void Clear()
        {
        
            dgvInfoHuesped.DataSource = huesped.VistaTabla();
            dgvReservaciones.DataSource = reservacion.Select();
        }
        private void DgvReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idHuesped = dgvReservaciones.CurrentRow.Cells[1].Value.ToString();
            dgvInfoHuesped.DataSource = reservacion.SelectHuesped(idHuesped);
        }

        private void TxtBuscarHabitacion_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TxtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReservaciones.SelectedRows.Count > 0)
            {
                splitContainer1.Panel1Collapsed = true;
                dgvHabitaciones.DataSource = habitacion.Select();
               // dgvHuesped.DataSource = huesped.VistaTabla();
                // splitContainer1.Panel2Collapsed = true;
                //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                txtNombreHuesped.Text = dgvReservaciones.CurrentRow.Cells[0].Value.ToString();
                dtpFechaLlegadaRegRes.Value = Convert.ToDateTime(dgvReservaciones.CurrentRow.Cells[2].Value.ToString());
                dtpFechaSalidaRegRes.Value = Convert.ToDateTime(dgvReservaciones.CurrentRow.Cells[3].Value.ToString());
                txtPrecioPorNoche.Text = dgvReservaciones.CurrentRow.Cells[10].Value.ToString();
                txtCantidadNoches.Text = dgvReservaciones.CurrentRow.Cells[5].Value.ToString();
                nudCantidadAdultos.Value = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[6].Value.ToString());
                nudCantidadNinos.Value = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[7].Value.ToString());
                txtCanal.Text = dgvReservaciones.CurrentRow.Cells[8].Value.ToString();
                txtComentario.Text = dgvReservaciones.CurrentRow.Cells[9].Value.ToString();
                txtTotalNoche.Text = dgvReservaciones.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
       public void refresh()
        {
            dgvReservaciones.DataSource = reservacion.Select();
        }

        private void BtnRegistrarReservacion_Click(object sender, EventArgs e)
        {

            if (!ListadoReservaciones.Instance.Controls.Contains(NuevaReservacion.Instance))
            {

                ListadoReservaciones.Instance.Controls.Add(NuevaReservacion.Instance);
                NuevaReservacion.Instance.Dock = DockStyle.Fill;
                NuevaReservacion.Instance.BringToFront();
                
            }
            else
            {

                NuevaReservacion.Instance.BringToFront();
            }
            
          
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (!ListadoReservaciones.Instance.Controls.Contains(NuevaReservacion.Instance))
            {

                ListadoReservaciones.Instance.Controls.Add(NuevaReservacion.Instance);
                NuevaReservacion.Instance.Dock = DockStyle.Fill;
                NuevaReservacion.Instance.BringToFront();

            }
            else
            {

                NuevaReservacion.Instance.BringToFront();
            }

        }
    }
}
