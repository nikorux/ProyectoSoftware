using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.View;

namespace PMS_POS.Model
{
    public partial class BuscarHabitacion : Form
    {

        public BuscarHabitacion()
        {
            InitializeComponent();
          
        }

       public void getFechas(DateTime llegada, DateTime salida)
        {
            FechaLlegada = llegada;
            FechaSalida = salida;
        }

        private static BuscarHabitacion _instance;
        public static BuscarHabitacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BuscarHabitacion();
                return _instance;
            }
        }
        Habitacion habitacion = new Habitacion();
        DateTime FechaLlegada;
        DateTime FechaSalida;
        private void BuscarHabitacion_Load(object sender, EventArgs e)
        {

            cargar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        { 
            string idHab,numHab, tipoHab, precioHab;
            if (dgv.SelectedRows.Count > 0)
            {
                //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                NuevaReservacion nr = NuevaReservacion.Instance;
               habitacion.IdHabitacion = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
               habitacion.NumHab = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
               habitacion.TipoHab = dgv.CurrentRow.Cells[2].Value.ToString();
               habitacion.PrecioPorNoche = Convert.ToSingle(dgv.CurrentRow.Cells[9].Value);
                nr.FillHab(habitacion);
                nr.Revisar();
                nr.calcularPrecio();
               // nr.calcular();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
        void cargar()
        {
            dgv.DataSource = habitacion.SelectBuscarHabitacion();
            dgv.Columns[0].Visible = false;
            dgv.Columns[10].Visible = false;
            Filtrar();
          //  dgv.Columns[11].Visible = false;
        }

        private void Filtrar()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                // SI ESTÁ RESERVADA 
                if (dgv.Rows[i].Cells[10].Value.ToString() == "1")
                {
                    // QUE EL ID DE LA HABITACION LLENE EL DATAGRIDVIEW DE RESERVACIONES CON ESE IDHABITACION
                    dgvReservedRooms.DataSource = habitacion.ReservationsInRoom(Convert.ToInt32(dgv.Rows[i].Cells[0].Value));
                    //LUEGO QUE COMPARE LA FECHA DE LLEGADA CON LAS FECHAS DE LLEGADA Y SALIDA DE LAS RESERVACIONES
                    for (int j = 0; j < dgvReservedRooms.Rows.Count; j++)
                    {
                        //SI LA FECHA DE LLEGADA NUEVA SE ENCUENTRA ENTRE EL RANGO DE LA FECHA DE LLEGADA Y FECHA DE SALIDA DE LA RESERVACION ENTONCES
                        //QUE NO SE MUESTRE ESA FILA

                        if ((FechaLlegada >= DateTime.Parse(dgvReservedRooms.Rows[j].Cells[2].Value.ToString())) && (FechaLlegada < DateTime.Parse(dgvReservedRooms.Rows[j].Cells[3].Value.ToString())))
                        {
                            dgv.Rows[i].Visible = false;
                        }
                    }

                }
                if (dgv.Rows[i].Cells[10].Value.ToString() == "0")
                {
                    // QUE EL ID DE LA HABITACION LLENE EL DATAGRIDVIEW DE RESERVACIONES CON ESE IDHABITACION
                    dgvReservedRooms.DataSource = habitacion.ReservationsInRoom(Convert.ToInt32(dgv.Rows[i].Cells[0].Value));
                    //LUEGO QUE COMPARE LA FECHA DE LLEGADA CON LAS FECHAS DE LLEGADA Y SALIDA DE LAS RESERVACIONES
                    for (int j = 0; j < dgvReservedRooms.Rows.Count; j++)
                    {
                        //SI LA FECHA DE LLEGADA NUEVA SE ENCUENTRA ENTRE EL RANGO DE LA FECHA DE LLEGADA Y FECHA DE SALIDA DE LA RESERVACION ENTONCES
                        //QUE NO SE MUESTRE ESA FILA

                        if ((FechaLlegada >= DateTime.Parse(dgvReservedRooms.Rows[j].Cells[2].Value.ToString())) && (FechaLlegada < DateTime.Parse(dgvReservedRooms.Rows[j].Cells[3].Value.ToString())))
                        {
                        //    dgv.Rows[i].Visible = false;
                        }
                    }

                }

            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[6].Value.ToString() == "Ocupada")
                {
                    dgv.Rows[i].Cells[6].Value = "Disponible";
                }
            }
        }
        private void TxtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBuscar.Text != "")
            {

               dgv.CurrentCell = null;
                foreach (DataGridViewRow n in dgv.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgv.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBoxBuscar.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                cargar();
            }
        }
    }
}
