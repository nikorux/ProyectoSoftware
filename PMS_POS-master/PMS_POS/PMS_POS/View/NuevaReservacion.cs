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
        public void FillHab(Habitacion habitacion)
        {
            
            txtBoxNumeroHabitacion.Text = habitacion.NumHab.ToString();
            txtBoxTipoHabitacion.Text = habitacion.TipoHab.ToString();
            txtBoxPrecio.Text = habitacion.PrecioPorNoche.ToString();
            r.IdHabitacion = habitacion.IdHabitacion;

        }
        public void FillCliente(string idHuesped, string primerNombre, string segundoNombre, string primerApellido, string documento)
        {
            r.IdHuesped = Convert.ToInt32(idHuesped);
            txtBoxNombre.Text = primerNombre +" "+ segundoNombre + " " + primerApellido;
            txtBoxDocumento.Text = documento;
        }


        public NuevaReservacion()
        {
            InitializeComponent();

            dateTimePickerLlegada.MinDate = DateTime.Today;
            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
           // calcularNoches();
   

        }
        
        private void BtnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            DateTime llegada = r.FechaLlegada;
            DateTime salida = r.FechaSalida;
            BuscarHabitacion buscarhab = new BuscarHabitacion();
            buscarhab.getFechas(llegada,salida);
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
                calcularNoches();
            }
            else
            {
                calcularPrecio();
                calcularNoches();
            }
        }

       

        private void DateTimePickerLlegada_ValueChanged(object sender, EventArgs e)
        {
            if(txtBoxPrecio.Text == string.Empty)
            {
              calcularNoches();
            }
            else
            {
              calcularPrecio();
              calcularNoches();
            }
           
            
           
        }
        public void calcularPrecio()
        {
            DateTime llegada = dateTimePickerLlegada.Value;
            DateTime salida = dateTimePickerSalida.Value;
            TimeSpan difference = salida.Date - llegada.Date;

            int resta = (int)difference.TotalDays;

            if( resta <= 0)
            {
               // txtBoxNoches.Text = "";
                txtBoxTotal.Text = "";
              
            }
            else if ( resta > 0 )
            {
                errorProvider1.Clear();
              //  r.FechaLlegada = llegada;
              //  r.FechaSalida = salida;
             //   txtBoxNoches.Text = resta.ToString();
              //  r.CantidadNoches = resta;
                float precio = (resta * float.Parse(txtBoxPrecio.Text));
                txtBoxTotal.Text = Convert.ToString(precio);
            }
           

        }
        private void calcularNoches()
        {
            DateTime llegada = dateTimePickerLlegada.Value;
            DateTime salida = dateTimePickerSalida.Value;
            TimeSpan difference = salida.Date - llegada.Date;

            int resta = (int)difference.TotalDays;
            if ( resta < 0 || resta == 0 )
            {
                txtBoxNoches.Text = "";
                errorProvider1.SetError(this.dateTimePickerSalida, "Ingrese una fecha adecuada.");
            }
            else if ( resta > 0)
            {
                errorProvider1.Clear(); 
                r.FechaLlegada = llegada;
                r.FechaSalida = salida;
                txtBoxNoches.Text = resta.ToString();
                r.CantidadNoches = resta;

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
                        if (r.Insert_reservacion_habitacion(r.SelectIdReservacion(), r.IdHabitacion) == true)
                        {

                            Habitacion hab = new Habitacion();
                            hab.IsReserved(r.IdHabitacion, 1);
                               // MessageBox.Show("Sure");
                                Clear();

                            dateTimePickerLlegada.MinDate = DateTime.Today;
                            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
                            calcularNoches();


                            MessageBox.Show("La reservación ha sido creada.");

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

                        dateTimePickerLlegada.MinDate = DateTime.Today;
                        dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
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
            numInfantes.Value = 0;
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
           // getHabitacionInfo(idHabitacion);
            getHuespedInfo(idHuesped);
            try
            {
                dateTimePickerLlegada.Value = new DateTime(fechaLlegada.Year, fechaLlegada.Month, fechaLlegada.Day);
                dateTimePickerSalida.Value = new DateTime(fechaSalida.Year, fechaSalida.Month, fechaSalida.Day);
            }
            catch (Exception e)
            {
              //  MessageBox.Show("La reservación es muy vieja, por favor elimínela y cree una nueva.");
            }
            
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

        private void NuevaReservacion_Leave(object sender, EventArgs e)
        {
            

            dateTimePickerLlegada.MinDate = DateTime.Today;
            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
            

        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {
            
            dateTimePickerLlegada.MinDate = DateTime.Today;
            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
           
            calcularNoches();


        }

        private void TxtBoxNoches_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void DateTimePickerSalida_Leave(object sender, EventArgs e)
        {
      
        }

        private void NuevaReservacion_Enter(object sender, EventArgs e)
        {
           
            dateTimePickerLlegada.MinDate = DateTime.Today;
            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
        }

        private void NuevaReservacion_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }
        public void Reseting()
        {

            dateTimePickerLlegada.MinDate = DateTime.Today;
            dateTimePickerSalida.MinDate = DateTime.Today.AddDays(1);
            calcularNoches();
        }

        private void NuevaReservacion_LocationChanged(object sender, EventArgs e)
        {

        }

        private void NuevaReservacion_VisibleChanged(object sender, EventArgs e)
        {
            dateTimePickerLlegada.Value= DateTime.Today;
            dateTimePickerSalida.Value = DateTime.Today.AddDays(1);
        }
    }


}
