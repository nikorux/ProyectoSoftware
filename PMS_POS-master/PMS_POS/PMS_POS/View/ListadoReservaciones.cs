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
            /*dgvInfoHuesped.DataSource = huesped.VistaTabla();
            dgvInfoHuesped.Columns[0].Visible = false;
            dgvInfoHuesped.Columns[16].Visible = false;
            dgvInfoHuesped.Columns[17].Visible = false;*/
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                reservacion.IdReservacion = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells[0].Value);
                if (reservacion.Delete(reservacion) == true)
                {
                    MessageBox.Show("La habitación ha sido eliminada.");
                    Clear();

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

        private void Clear()
        {
            dtpFechaLlegada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
            nupCantidadAdultos.Value = 0;
            nupCantidadNinos.Value = 0;
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
                dgvHuesped.DataSource = huesped.VistaTabla();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (this.txtCantidadNoches.Text == "0" || this.txtNombreHuesped.Text == string.Empty || this.txtNumeroHabitacion.Text == string.Empty || this.txtPrecioPorNoche.Text == "0" || this.txtCanal.Text == string.Empty || txtComentario.Text == string.Empty || txtTotalNoche.Text == "0" || nudCantidadAdultos.Value == 0)
                {
                    MessageBox.Show("Falta ingresar algunos datos");
                }
                else
                {
                    reservacion.IdHuesped = Convert.ToInt32(dgvHuesped.CurrentRow.Cells[0].Value.ToString());
                    reservacion.FechaLlegada = dtpFechaLlegada.Value;
                    reservacion.FechaSalida = dtpFechaSalida.Value;
                    reservacion.PrecioPorNoche = float.Parse(txtPrecioPorNoche.Text);
                    reservacion.CantidadNoches = Convert.ToInt32(txtCantidadNoches.Text);
                    reservacion.CantidadAdultos = Convert.ToInt32(nudCantidadNinos.Value);
                    reservacion.CantidadInfantes = Convert.ToInt32(nudCantidadNinos.Value);
                    reservacion.Canal = txtCanal.Text;
                    reservacion.Comentario = txtComentario.Text;
                    reservacion.TotalPorEstadia = float.Parse(txtTotalNoche.Text);

                    if (reservacion.Update(reservacion) == true)
                    {
                        txtCantidadNoches.Clear();
                        dtpFechaLlegada.Value = DateTime.Now;
                        dtpFechaSalida.Value = DateTime.Now;
                        txtPrecioPorNoche.Clear();
                        nudCantidadAdultos.Value = 0;
                        nudCantidadNinos.Value = 0;
                        txtCanal.Clear();
                        txtComentario.Clear();
                        txtTotalNoche.Clear();
                        dgvHabitaciones.DataSource = habitacion.Select();
                        dgvHuesped.DataSource = huesped.VistaTabla();
                        btnGuardar.Enabled = true;

                        MessageBox.Show("La reservación ha sido registrada.");
                        splitContainer1.Panel1Collapsed = true;
                        splitContainer1.Panel2Collapsed = false;
                        reservacion.Select();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar reservación.");
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = true;
        }

        private void DgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumeroHabitacion.Text = dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();
            int DiasEntreFechas = ((TimeSpan)(dtpFechaSalida.Value - dtpFechaLlegada.Value)).Days;
            string precioPorNoche = dgvHabitaciones.CurrentRow.Cells[9].Value.ToString();
            txtCantidadNoches.Text = Convert.ToString(DiasEntreFechas);
            txtPrecioPorNoche.Text = precioPorNoche;
            txtTotalNoche.Text = reservacion.calcularTotalNoches(DiasEntreFechas, float.Parse(precioPorNoche)).ToString();
        }

        private void DgvHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreHuesped.Text = dgvHuesped.CurrentRow.Cells[1].Value.ToString() + " " + dgvHuesped.CurrentRow.Cells[2].Value.ToString();

        }

        private void TxtBuscarHabitacion_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtBuscarHabitacion.Text = "";
        }

        private void TxtBuscarCoincidencias_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCoincidencias.Text = "";
        }
    }
}
