using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace PMS_POS.View
{
    public partial class FacturacionCheckOut : UserControl
    {
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=hostal; Uid=root; pwd=root;");
        MySqlConnection conex;
        string cadenaconex;
        string instruccion;

        RegistroNuevoCliente form2 = new RegistroNuevoCliente();

        private static FacturacionCheckOut _instance;
        public static FacturacionCheckOut Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FacturacionCheckOut();
                return _instance;
            }
        }
        public FacturacionCheckOut()
        {
            InitializeComponent();
          //  FillCheckout(id.ToString());
         //   CargarRecargos();
        }
        Factura_Reservacion f = new Factura_Reservacion();
        Huesped h = new Huesped();
        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }
        int id = 0;
        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }

        private void FacturacionCheckOut_Load(object sender, EventArgs e)
        {
          //  FillCheckout(id.ToString());
          //  CargarRecargos();
        }

        private void LiquidarServiciosAdquiridos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //RefreshGrid();
        }
        private void BtnVisualizarPendiente_Click(object sender, EventArgs e)
        {
            LiquidarServiciosAdquiridos form2 = new LiquidarServiciosAdquiridos();
            form2.FormClosed += new FormClosedEventHandler(LiquidarServiciosAdquiridos_FormClosed);
            form2.ShowDialog();

        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Nueva ventana
            BuscarCheckedIn buscarCheckedIn = new BuscarCheckedIn();
            buscarCheckedIn.StartPosition = FormStartPosition.CenterScreen;
            buscarCheckedIn.Show();



            /*
            string cadSql = "Select * from huesped where IdHuesped = " + txtBusquedaCliente.Text;

            MySqlCommand comando = new MySqlCommand(cadSql, conectar);
            conectar.Open();

            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtIdCliente.Text = leer["IdHuesped"].ToString();
                txtNombre.Text = leer["PrimerNombre"].ToString();
                txtTelefono.Text = leer["Telefono"].ToString();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el registro");
                txtIdCliente.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
            }
            conectar.Close();
            */
        }
        
        private void BtnConfirmarSalida_Click(object sender, EventArgs e)
        {


            Factura_Reservacion f = new Factura_Reservacion();
            if (txtTotalAPagar.Text == "0")
            {
                //no debe
                f.IdReservacion = id;
                f.IdHuesped = Convert.ToInt32(txtIdCliente.Text);
                f.Empleado = txtAtendidoPor.Text;
                f.TotalAPagar = Convert.ToSingle(txtTotalAPagar.Text);
                f.Fecha = dtpFechaActual.Value;
                // f.FormaDePago = cmbFormaPago.Text;
                f.SubTotal = Convert.ToSingle(dgvFill.Rows[0].Cells[12].Value);
                // RESERVACION PASA DE CHECKED IN A CHECKED OUT
                Reservacion reserva = new Reservacion();
                reserva.IdReservacion = f.IdReservacion;
                reserva.CheckOut(reserva);
                // HABITACION PASA DE OCUPADA A DISPONIBLE Y SU ESTADO DE RESERVADA PASA A NEGATIVO
                Habitacion hab = new Habitacion();
                hab.IdHabitacion = Convert.ToInt32(dgvFill.Rows[0].Cells[3].Value);
                hab.CambiarEstados(hab.IdHabitacion, "Disponible");
                hab.IsReserved(hab.IdHabitacion, 0);
                FrmCorrecto.confirmacionForm("AGREGADO");

            }
            else
            {
                //debe
                if (cmbFormaPago.Text == string.Empty)
                {
                    ErrorDatosFaltantes.confirmacionForm("ERROR");
                }
                else
                {
                    if (cmbFormaPago.Text == "Tarjeta")
                    {
                        if (txtNombre.Text == string.Empty || txtTotalAPagar.Text == string.Empty || txtBoxDigitos.Text == string.Empty || txtBoxCompania.Text == string.Empty || txtAtendidoPor.Text == string.Empty)
                        {
                            ErrorDatosFaltantes.confirmacionForm("ERROR");
                        }
                        else
                        {
                            f.IdReservacion = id;
                            f.IdHuesped = Convert.ToInt32(txtIdCliente.Text);
                            f.Empleado = txtAtendidoPor.Text;
                            f.TotalAPagar = Convert.ToSingle(txtTotalAPagar.Text);
                            f.FormaDePago = cmbFormaPago.Text;
                            f.SubTotal = Convert.ToSingle(dgvFill.Rows[0].Cells[12].Value);
                            f.Fecha = dtpFechaActual.Value;
                            f.UltimosDigitos = Convert.ToInt32(txtBoxDigitos.Text);
                            f.CompaniaTarjeta = txtBoxCompania.Text;
                            if (txtDescuento.Text == string.Empty)
                            {
                                //do nothing

                            }
                            else
                            {
                                f.Descuento = Convert.ToSingle(txtDescuento.Text);
                            }


                            if (f.InsertTarjeta(f) == true)
                            {

                                // RESERVACION PASA DE SIN CONFIRMAR A CHECK IN
                                Reservacion reserva = new Reservacion();
                                reserva.IdReservacion = f.IdReservacion;
                                reserva.Confirmar(reserva);
                                // HABITACION PASA DE DISPONIBLE A OCUPADA
                                Habitacion hab = new Habitacion();
                                hab.IdHabitacion = Convert.ToInt32(dgvFill.Rows[0].Cells[3].Value);
                                hab.CambiarEstados(hab.IdHabitacion, "Disponible");
                                //   hab.IsReserved(hab.IdHabitacion, 1);
                                FrmCorrecto.confirmacionForm("CORRECTO");
                                f.IdFactura = f.SelectIdFactura();
                                btnImprimir.Enabled = true;

                            }
                            else
                            {
                                FrmSeguroCerrar.confirmacionForm("ERROR");
                            }

                        }
                    }
                    if (cmbFormaPago.Text == "Efectivo")
                    {
                        if (txtNombre.Text == string.Empty || txtEfectivo.Text == string.Empty || txtTotalAPagar.Text == string.Empty || txtCambio.Text == string.Empty || txtAtendidoPor.Text == string.Empty)
                        {
                            ErrorDatosFaltantes.confirmacionForm("ERROR");
                        }
                        else
                        {
                            /*
                             @IdReservacion, @IdHuesped, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @EfectivoRecibido, @Devuelta
                             */
                            f.IdReservacion = id;
                            f.IdHuesped = Convert.ToInt32(txtIdCliente.Text);
                            f.Empleado = txtAtendidoPor.Text;
                            f.TotalAPagar = Convert.ToSingle(txtTotalAPagar.Text);
                            f.Fecha = dtpFechaActual.Value;
                            f.FormaDePago = cmbFormaPago.Text;
                            f.SubTotal = Convert.ToSingle(dgvFill.Rows[0].Cells[12].Value);
                            if (txtDescuento.Text == string.Empty)
                            {
                                //do nothing

                            }
                            else
                            {
                                f.Descuento = Convert.ToSingle(txtDescuento.Text);
                            }
                            if (txtEfectivo.Text == string.Empty)
                            {
                                //do nothing

                            }
                            else
                            {
                                f.EfectivoRecibido = Convert.ToSingle(txtEfectivo.Text);
                            }
                            if (txtCambio.Text == string.Empty)
                            {
                                //do nothing
                                ErrorDatosFaltantes.confirmacionForm("ERROR");
                            }
                            else
                            {
                                f.Devuelta = Convert.ToSingle(txtCambio.Text);
                            }

                            if (f.InsertEfectivo(f) == true && txtCambio.Text != "")
                            {
                                // RESERVACION PASA DE SIN CONFIRMAR A CHECK IN
                                Reservacion reserva = new Reservacion();
                                reserva.IdReservacion = f.IdReservacion;
                                reserva.Confirmar(reserva);
                                // HABITACION PASA DE OCUPADA A DISPONIBLE

                                Habitacion hab = new Habitacion();
                                hab.IdHabitacion = Convert.ToInt32(dgvFill.Rows[0].Cells[3].Value);
                                hab.CambiarEstados(hab.IdHabitacion, "Disponible");
                                //  hab.IsReserved(hab.IdHabitacion, 1);
                                FrmCorrecto.confirmacionForm("CORRECTO");
                                f.IdFactura = f.SelectIdFactura();
                                btnImprimir.Enabled = true;
                            }
                            else
                            {
                                //  MessageBox.Show("Ha ocurrido un error al facturar.");
                            }
                        }
                    }
                
                }
            }
           
        }

        private void TxtCambio_Leave(object sender, EventArgs e)
        {

        }

        private void TxtEfectivo_Leave(object sender, EventArgs e)
        {
            int total, efectivo, cambio;
            total = Convert.ToInt32(txtTotalAPagar.Text);
            efectivo = Convert.ToInt32(txtEfectivo.Text);
            cambio = efectivo - total;
            txtCambio.Text = cambio.ToString();
        }

        public DataTable VistaTabla()
        {

            instruccion = "Select * from huesped where IdHuesped = " + txtIdCliente.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }

        private void TxtEfectivo_TextChanged(object sender, EventArgs e)
        {

        }

        internal void FillFactura(int idReservacion)
        {
            // hice trampa para accesar el nombre y el telefono
            // nombre = comentario 
            // telefono = canal
            //   RefreshDgv();
            id = idReservacion;

            //Si las filas son más de 0 se muestran los valores de la fila
            FillCheckout(idReservacion.ToString());
            

            txtIdCliente.Text = dgvFill.Rows[0].Cells[2].Value.ToString();
            txtNombre.Text = dgvFill.Rows[0].Cells[17].Value.ToString();
            txtTelefono.Text = dgvFill.Rows[0].Cells[18].Value.ToString();
            txtNumDocumento.Text = dgvFill.Rows[0].Cells[19].Value.ToString();
        }

        private void CmbFormaPago_TextChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text == "Tarjeta")
            {
                pnlTarjeta.Visible = true;
                txtEfectivo.Enabled = false;

            }
            if (cmbFormaPago.Text == "Efectivo")
            {
                pnlTarjeta.Visible = false;
                txtEfectivo.Enabled = true;

            }
        }
        public void FillCheckout(string idReservacion)
        {
          
            //LLENAR CHECKOUT
            instruccion = "Select hostal.reservacion.IsPaid,hostal.reservacion.IdReservacion,hostal.reservacion.IdHuesped,hostal.reservacion.IdHabitacion,hostal.habitacion.TipoHab, hostal.reservacion.FechaLlegada,hostal.reservacion.FechaSalida,hostal.reservacion.CantNoches,hostal.reservacion.CantAdultos,hostal.reservacion.CantInfantes,hostal.reservacion.Canal,hostal.reservacion.Comentario,hostal.reservacion.PrecioNoche,hostal.reservacion.PrecioTotal,hostal.reservacion.FechaLlegada as Llegada, hostal.reservacion.FechaSalida as Salida, hostal.habitacion.NumHab as Habitacion, hostal.reservacion.EstadoReservacion as Estado, CONCAT(huesped.PrimerNombre, ' ', huesped.SegundoNombre, ' ', huesped.PrimerApellido,' ', hostal.huesped.SegundoApellido) as Nombre, hostal.huesped.Telefono as Contacto, hostal.huesped.NumDocumento  FROM hostal.reservacion INNER JOIN hostal.habitacion ON hostal.reservacion.IdHabitacion = hostal.habitacion.IdHabitacion INNER JOIN hostal.huesped ON hostal.reservacion.IdHuesped = hostal.huesped.IdHuesped WHERE ( reservacion.IsDeleted = 0 AND reservacion.EstadoReservacion = 'Checked-In' AND reservacion.IdReservacion =" + idReservacion+" ) GROUP BY hostal.reservacion.FechaLlegada; ";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            dgvFill.DataSource = COnsulta;
           
           
        }

        private void TxtBoxDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros4(e, txtBoxDigitos);
        }
        
        private void TxtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumerosPunto(e, txtEfectivo);
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e, txtDescuento);
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            float subtotal, descuento;
            subtotal = Convert.ToSingle(txtTotalAPagar.Text);
            try
            {
                //Calcular el % de descuento
                subtotal = Convert.ToSingle(txtSubtotal.Text);
                descuento = Convert.ToSingle(txtDescuento.Text);

                descuento = descuento / 100;

                if (subtotal - (descuento * subtotal) >= 0)
                {
                    txtTotalAPagar.Text = (subtotal - (descuento * subtotal)).ToString();
                    txtCambio.Text = "";
                }
                else
                {
                    //MessageBox.Show("");
                }

            }
            catch
            {
                // 
            }
        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {
            CargarRecargos();
        }
        private void CargarRecargos()
        {
            //LLENAR RECARGOS
           int isDebt = Convert.ToInt32(dgvFill.Rows[0].Cells[0].Value.ToString());
            if(isDebt == 0)
            {
                txtSubtotal.Text = "0";
                txtTotalAPagar.Text = "0";
            }
            else
            {
                txtSubtotal.Text = dgvFill.Rows[0].Cells[12].Value.ToString();
                txtTotalAPagar.Text = dgvFill.Rows[0].Cells[12].Value.ToString();

            }
            // instruccion = "Select IsPaid from reservacion where IdReservacion = @IdReservacion";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            
            dataGridViewRecargos.DataSource = COnsulta;
            if(dataGridViewRecargos.Rows.Count == 0)
            {
                txtRecargoPendiente.Text = "0";
            }
            else
            {
                float total = 0;
                int rows = 0;
                rows = dataGridViewRecargos.RowCount;
               for(int i = 1; i <= rows; i++)
                {
                    //se recorren todas los pedidos del cliente
                    //y se suman al total
                  //  total += Convert.ToSingle(dataGridViewRecargos.Rows[i].Cells[4].Value);
                }

                txtRecargoPendiente.Text = total.ToString();

            }
        }

        private void BtnAgregarRecargo_Click(object sender, EventArgs e)
        {

        }

        private void TxtRecargoPendiente_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

            FacturaDetails();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file |*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(txtBoxFactura.Text));
                    }
                    catch (Exception ex)
                    {
                        FrmSeguroCerrar.confirmacionForm("ERROR");
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
        private void FacturaDetails()
        {
            if (cmbFormaPago.Text == "Efectivo")
            {
                txtBoxFactura.Text =
               "HOTEL XXXXX\n" +
               "************************************************************************\n" +
               "No. Factura: " + f.IdFactura.ToString() + "\n" +
               "Fecha: " + DateTime.Now + "\n" +
               "Le atendió: " + txtAtendidoPor.Text + "\n" +
               "--------------------------------------------------------------------------------\n" +
               "DESCRIPCIÓN          PRECIO POR NOCHE      SUBTOTAL \n" +
               "Habitación " + dgvFill.Rows[0].Cells[16].Value.ToString() + "                 " + dgvFill.Rows[0].Cells[11].Value.ToString() + " RD$               " + dgvFill.Rows[0].Cells[12].Value.ToString() +
               "RD$\n-------------------------------------------------------------------------------\n" +
               "Sub-Total                                                                 " + txtSubtotal.Text + " RD$\n" +
               "% Descuento                                                                " + txtDescuento.Text + " %\n\n" +
               "Total                                                                       " + txtTotalAPagar.Text + " RD$\n" +
               "Efectivo entregado                                                   " + txtEfectivo.Text + " RD$\n" +
               "Efectivo devuelto                                                    " + txtCambio.Text + " RD$" +
                "\n--------------------------------------------------------------------------------";

            }
            else
            {
                txtBoxFactura.Text =
             "HOTEL XXXXX\n" +
             "************************************************************************\n" +
             "No. Factura: " + f.IdFactura.ToString() + "\n" +
             "Fecha: " + DateTime.Now + "\n" +
             "Le atendió: " + txtAtendidoPor.Text + "\n" +
             "--------------------------------------------------------------------------------\n" +
             "DESCRIPCIÓN          PRECIO POR NOCHE      SUBTOTAL \n" +
             "Habitación " + dgvFill.Rows[0].Cells[16].Value.ToString() + "                 " + dgvFill.Rows[0].Cells[11].Value.ToString() + " RD$               " + dgvFill.Rows[0].Cells[12].Value.ToString() +
             "RD$\n--------------------------------------------------------------------------------\n" +
             "Sub-Total                                                                 " + txtSubtotal.Text + " RD$\n" +
             "% Descuento                                                                " + txtDescuento.Text + " %\n\n" +
             "Total                                                                       " + txtTotalAPagar.Text + " RD$\n" +
             "Tarjeta                                                                      " + txtBoxDigitos.Text + " RD$\n" +
              "Compañía                                                     " + txtBoxCompania.Text + " RD$" +
              "\n--------------------------------------------------------------------------------";
            }




        }
    }
}
