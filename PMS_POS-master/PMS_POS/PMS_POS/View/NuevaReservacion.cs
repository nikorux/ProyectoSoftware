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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PMS_POS.View
{
    public partial class NuevaReservacion : UserControl
    {

        private static NuevaReservacion _instance;
        public static NuevaReservacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NuevaReservacion();
                return _instance;
            }
        }


        Huesped obj = new Huesped();


        public NuevaReservacion()
        {
            InitializeComponent();

            dgvHuesped.DataSource = obj.VistaTabla();
            dgvHuesped.Columns[0].Visible = false;
            dgvHuesped.Columns[16].Visible = false;
            dgvHuesped.Columns[17].Visible = false;

            dgvHabitaciones.DataSource = habitacion.Select();
            dgvHabitaciones.Columns[0].Visible = false;
            dgvHabitaciones.Columns[10].Visible = false;
            dgvHabitaciones.Columns[11].Visible = false;

            if (txtPrecioPorNoche.Text != "0" && txtTotalNoche.Text == "0")
            {
                MessageBox.Show("Por favor, seleccione las fechas de estadía.");
            }

        }

        Reservacion nuevaReservacion = new Reservacion();
        Habitacion habitacion = new Habitacion();




        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Get values from input fields
            try
            {

                if (this.txtCantidadNoches.Text == "0" || this.txtNombreHuesped.Text == string.Empty || this.txtNumeroHabitacion.Text == string.Empty || this.txtPrecioPorNoche.Text == "0" || this.txtCanal.Text == string.Empty || txtComentario.Text == string.Empty || txtTotalNoche.Text == "0" || nudCantidadAdultos.Value == 0)
                {
                    MessageBox.Show("Falta ingresar algunos datos");
                }
                else
                {
                    nuevaReservacion.IdHuesped = Convert.ToInt32(dgvHuesped.CurrentRow.Cells[0].Value.ToString());
                    nuevaReservacion.FechaLlegada = dtpFechaLlegada.Value;
                    nuevaReservacion.FechaSalida = dtpFechaSalida.Value;
                    nuevaReservacion.PrecioPorNoche = float.Parse(txtPrecioPorNoche.Text);
                    nuevaReservacion.CantidadNoches = Convert.ToInt32(txtCantidadNoches.Text);
                    nuevaReservacion.CantidadAdultos = Convert.ToInt32(nudCantidadNinos.Value);
                    nuevaReservacion.CantidadInfantes = Convert.ToInt32(nudCantidadNinos.Value);
                    nuevaReservacion.Canal = txtCanal.Text;
                    nuevaReservacion.Comentario = txtComentario.Text;
                    nuevaReservacion.TotalPorEstadia = float.Parse(txtTotalNoche.Text);
                    int idHabitacion = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells[0].Value.ToString());
                    int rev = nuevaReservacion.SelectIdReservacion();
                    MessageBox.Show("ID DE RESERVACION:" + rev);
                    if (nuevaReservacion.Insert(nuevaReservacion) == true)
                    {
                        try
                        {
                            if (nuevaReservacion.Insert_reservacion_habitacion(idHabitacion, rev))
                            {
                                MessageBox.Show("Se ha insertado correctamente.");
                            }
                            else
                            {

                            }

                            //Insert a reservacion_hab
                            //nuevaReservacion.Insert_reservacion_habitacion(idHabitacion, Convert.ToInt32(nuevaReservacion.SelectIdReservacion()));
                        }
                        catch (Exception)
                        {

                        }

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
                        dgvHuesped.DataSource = obj.VistaTabla();
                        btnGuardar.Enabled = true;

                        MessageBox.Show("La reservación ha sido registrada.");
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

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {

        }

        private void TxtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {
            dgvHabitaciones.AllowUserToAddRows = false;

            if (txtBuscarHabitacion.Text != "")
            {

                dgvHabitaciones.CurrentCell = null;
                foreach (DataGridViewRow n in dgvHabitaciones.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvHabitaciones.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarHabitacion.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvHabitaciones.DataSource = habitacion.Select();
            }
        }

        private void DgvHuesped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreHuesped.Text = dgvHuesped.CurrentRow.Cells[1].Value.ToString() + " " + dgvHuesped.CurrentRow.Cells[2].Value.ToString();
        }

        private void DgvHuesped_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumeroHabitacion.Text = dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();
            int DiasEntreFechas = ((TimeSpan)(dtpFechaSalida.Value - dtpFechaLlegada.Value)).Days;
            string precioPorNoche = dgvHabitaciones.CurrentRow.Cells[9].Value.ToString();
            txtCantidadNoches.Text = Convert.ToString(DiasEntreFechas);
            txtPrecioPorNoche.Text = precioPorNoche;
            txtTotalNoche.Text = nuevaReservacion.calcularTotalNoches(DiasEntreFechas, float.Parse(precioPorNoche)).ToString();

        }

        private void DtpFechaLlegada_ValueChanged(object sender, EventArgs e)
        {
            txtNombreHuesped.Text = "";
            txtNumeroHabitacion.Text = "";
        }

        private void DtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            txtNombreHuesped.Text = "";
            txtNumeroHabitacion.Text = "";
        }

        private void TxtBuscarCoincidencias_TextChanged(object sender, EventArgs e)
        {
            dgvHuesped.AllowUserToAddRows = false;

            if (txtBuscarCoincidencias.Text != "")
            {
                dgvHuesped.CurrentCell = null;
                foreach (DataGridViewRow n in dgvHuesped.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvHuesped.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarCoincidencias.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvHuesped.DataSource = obj.VistaTabla();
            }
        }

        private void TxtBuscarHabitacion_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarHabitacion.Text = "";
        }

        private void TxtBuscarCoincidencias_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCoincidencias.Text = "";
        }
    }
}
