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
using System.Globalization;

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
        Reservacion r = new Reservacion();
        Habitacion hab = new Habitacion();
        public void FillHab( string idHab, string numHab, string tipoHab, string precioHab)
        {
            hab.IdHabitacion = Convert.ToInt32(idHab);
            txtBoxNumeroHabitacion.Text = numHab;
            txtBoxTipoHabitacion.Text = tipoHab;
            txtBoxPrecio.Text = precioHab;
        }
        public void FillCliente(string idHuesped, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string documento)
        {
            r.IdHuesped = Convert.ToInt32(idHuesped);
            txtBoxNombre.Text = primerNombre +" "+ segundoNombre + " " + primerApellido + " " + segundoApellido;
            txtBoxDocumento.Text = documento;
        }


        public NuevaReservacion()
        {
            InitializeComponent();
            dateTimePickerLlegada.MinDate = DateTime.Now;
   

        }
        
        private void BtnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            BuscarHabitacion buscarhab = new BuscarHabitacion();
            buscarhab.Show();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.Show();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese una habitación.");
            }
            else
            {
                calcular();
            }
        }

        private void DateTimePickerLlegada_ValueChanged(object sender, EventArgs e)
        {
            if(txtBoxPrecio.Text != string.Empty)
            {
                calcular();
            }
           
            
           
        }
        public void calcular()
        {
            DateTime llegada = dateTimePickerLlegada.Value;
            DateTime salida = dateTimePickerSalida.Value;
            TimeSpan difference = salida.Date - llegada.Date;

            int resta = (int)difference.TotalDays;

            if (resta <= 0)
            {
                txtBoxNoches.Text = "";
                txtBoxTotal.Text = "";
                MessageBox.Show("Por favor, elegir una fecha correcta.");

            }
            else
            {
                r.FechaLlegada = llegada;
                r.FechaSalida = salida;
                txtBoxNoches.Text = resta.ToString();
                r.CantidadNoches = resta;
                int precio = (resta * int.Parse(txtBoxPrecio.Text));
                txtBoxTotal.Text = Convert.ToString(precio);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (this.txtBoxNombre.Text == string.Empty || this.txtBoxTipoHabitacion.Text == string.Empty || this.txtBoxNoches.Text == string.Empty || this.txtBoxTotal.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar algunos datos.");
            }
            else
            {
                r.CantidadAdultos = Convert.ToInt32(numAdultos.Value);
                r.CantidadInfantes = Convert.ToInt32(numInfantes.Value);
                r.Canal = txtBoxCanal.Text;
                r.Comentario = txtBoxComentarios.Text;
                r.PrecioPorNoche = float.Parse(txtBoxPrecio.Text, CultureInfo.InvariantCulture.NumberFormat);
                r.TotalPorEstadia = float.Parse(txtBoxTotal.Text, CultureInfo.InvariantCulture.NumberFormat);


                if (r.Insert(r) == true)
                {
                    if (r.Insert_reservacion_habitacion(r.SelectIdReservacion(), hab) == true)
                    {
                        if(hab.CambiarEstado(hab) == true)
                        {
                            Clear();
                            MessageBox.Show("La reservación ha sido creada.");
                            ListadoReservaciones.Instance.refresh();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear la reservación.");
                }
            }
               
            }
        public void Clear()
        {
            txtBoxNumeroHabitacion.Clear();
            txtBoxTipoHabitacion.Clear();
            txtBoxPrecio.Clear();
            txtBoxNombre.Clear();
            txtBoxDocumento.Clear();
            numAdultos.Value = 1;
            numInfantes.Value = 1;
            txtBoxNombre.Clear();
            txtBoxTotal.Clear();
            txtBoxCanal.Clear();
            txtBoxComentarios.Clear();
        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {

        }
    }


}
