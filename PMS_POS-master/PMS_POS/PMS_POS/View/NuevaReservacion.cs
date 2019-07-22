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
        Huesped huesped = new Huesped();
        private bool editar = false;
        private bool first = false;
        int idRes = 0;
        public void FillHab( string idHab, string numHab, string tipoHab, string precioHab)
        {
            hab.IdHabitacion = Convert.ToInt32(idHab);
            r.IdHabitacion = Convert.ToInt32(idHab);
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
            Revisar();
            dateTimePickerLlegada.MinDate = DateTime.Now;
   

        }
        
        private void BtnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            BuscarHabitacion buscarhab = new BuscarHabitacion();
            buscarhab.Show();
            Revisar();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.Show();
            Revisar();
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

            if (resta <= 0 && editar == false)
            {
                txtBoxNoches.Text = "";
                txtBoxTotal.Text = "";
                MessageBox.Show("Por favor, elegir una fecha correcta.");

            }
            if(editar == true && resta < 0)
            {
                
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
            if (editar == false)
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
                            if (hab.CambiarEstado(hab,"Ocupada") == true)
                            {
                                Clear();
                                ListadoReservaciones.Instance.refresh();
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
            if (editar == true)
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
                    if (r.Update(r) == true)
                    {
                        if(r.Update_reservacion_habitacion(r.IdReservacion,r.IdHabitacion) == true)
                        btnBuscarCliente.Enabled = true;
                        
                        MessageBox.Show("update successful");
                    }
                
                    else
                    {
                        MessageBox.Show("update unsuccessful");
                    }
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
            txtBoxNoches.Clear();
        }
        public void Revisar()
        {
            if(txtBoxPrecio.Text != string.Empty && txtBoxNombre.Text != string.Empty)
            {
                dateTimePickerLlegada.Enabled = true;
                dateTimePickerSalida.Enabled = true;
                numAdultos.Enabled = true;
                numInfantes.Enabled = true;
                txtBoxCanal.Enabled = true;
                txtBoxComentarios.Enabled = true;
            }
        }

        public void RecibirDatos(int idReservacion,int idHuesped,int idHabitacion , DateTime fechaLlegada, DateTime fechaSalida, int noches, int numeroAdultos, int numeroInfantes, float total, string canal, string detalles)
            {
            editar = true;
            first = true;
            btnBuscarCliente.Enabled = false;
            idRes = idReservacion;
            r.IdReservacion = idReservacion;
            getHabitacionInfo(idHabitacion);
            getHuespedInfo(idHuesped);
            dateTimePickerLlegada.Value =  new DateTime(fechaLlegada.Year, fechaLlegada.Month, fechaLlegada.Day);
            dateTimePickerSalida.Value = new DateTime(fechaSalida.Year,fechaSalida.Month,fechaSalida.Day);
            txtBoxNoches.Text = noches.ToString();
            numAdultos.Value = numeroAdultos;
            numInfantes.Value = numeroInfantes;
            txtBoxTotal.Text = total.ToString();
            txtBoxCanal.Text = canal;
            txtBoxComentarios.Text = detalles;
                
            }
            
        
        private void RefreshDgv()
        {
            Reservaciones.Instance.RefreshDgv() ;
        }
        public void getHabitacionInfo(int idHabitacion)
        {
            DataTable habitacionInfo = new DataTable();
            habitacionInfo = hab.GetHabitacion(idHabitacion);
            hab.IdHabitacion = idHabitacion;
            r.IdHabitacion = idHabitacion;
            txtBoxNumeroHabitacion.Text = habitacionInfo.Rows[0].Field<int>("NumHab").ToString();
            txtBoxTipoHabitacion.Text = habitacionInfo.Rows[0].Field<string>("TipoHab");
            txtBoxPrecio.Text = habitacionInfo.Rows[0].Field<float>("PrecioPorNoche").ToString();
  
        }
        public void getHuespedInfo(int idHuesped)
        {
            DataTable huespedInfo = new DataTable();
            huespedInfo = huesped.GetHuesped(idHuesped);
            huesped.IdHuesped = idHuesped;
            r.IdHuesped = idHuesped;
            txtBoxNombre.Text = huespedInfo.Rows[0].Field<string>("PrimerNombre") + " " + huespedInfo.Rows[0].Field<string>("SegundoNombre") + " " + huespedInfo.Rows[0].Field<string>("PrimerApellido") + " " + huespedInfo.Rows[0].Field<string>("SegundoApellido");
            txtBoxDocumento.Text = huespedInfo.Rows[0].Field<string>("NumDocumento");
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }


}
