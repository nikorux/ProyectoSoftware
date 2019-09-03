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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace PMS_POS.View
{
    public partial class FacturacionCheckIn : UserControl
    {
        private static FacturacionCheckIn _instance;
        public static FacturacionCheckIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FacturacionCheckIn();
                return _instance;
            }
        }

        public FacturacionCheckIn()
        {
            InitializeComponent();
            RefreshDgv();
        }
        Reservacion obj = new Reservacion();
        int id = 0;
        bool payLater = false;

        private void Facturacion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
        public void FillFactura(int idReservacion)
        {
            // hice trampa para accesar el nombre y el telefono
            // nombre = comentario 
            // telefono = canal
            id = idReservacion;
            RefreshDgv();


            //Si las filas son más de 0 se muestran los valores de la fila
            txtIdCliente.Text = dgvHabitacion.Rows[0].Cells[1].Value.ToString();
            txtNombre.Text = dgvHabitacion.Rows[0].Cells[3].Value.ToString();
            txtTelefono.Text = dgvHabitacion.Rows[0].Cells[4].Value.ToString();
            txtSubtotal.Text = dgvHabitacion.Rows[0].Cells[12].Value.ToString();
            txtTotalAPagar.Text = txtSubtotal.Text;
            txtNumDocumento.Text = dgvHabitacion.Rows[0].Cells[14].Value.ToString();


        }
            public void RefreshDgv()
            {
            dgvHabitacion.DataSource = obj.reservacion(id);
            dgvHabitacion.Columns[0].Visible = false;
            dgvHabitacion.Columns[1].Visible = false;
            dgvHabitacion.Columns[2].Visible = false;
            dgvHabitacion.Columns[3].Visible = false;
            dgvHabitacion.Columns[4].Visible = false;
            dgvHabitacion.Columns[9].Visible = false;
            dgvHabitacion.Columns[13].Visible = false;
            dgvHabitacion.Columns[14].Visible = false;

        }
        Factura_Reservacion f = new Factura_Reservacion();
        private void BtnRegistrarCheckIn_Click(object sender, EventArgs e)
        {
            if (payLater == true)
            {
                f.IdReservacion = id;
                Reservacion reserva = new Reservacion();
                reserva.IdReservacion = f.IdReservacion;
                reserva.Confirmar(reserva);
                // HABITACION PASA DE DISPONIBLE A OCUPADA
                Habitacion hab = new Habitacion();
                hab.IdHabitacion = Convert.ToInt32(dgvHabitacion.Rows[0].Cells[13].Value);
                hab.CambiarEstados(hab.IdHabitacion, "Ocupada");
                ErrorDatosFaltantes.confirmacionForm("AGREGADO");
            }
            else {
            if( cmbFormaPago.Text == string.Empty)
            {
                    ErrorDatosFaltantes.confirmacionForm("ERROR");
            }
            if ( cmbFormaPago.Text == "Tarjeta")
            {
                if (txtNombre.Text == string.Empty || txtTotalAPagar.Text == string.Empty || txtBoxDigitos.Text == string.Empty || txtBoxCompania.Text == string.Empty || txtCajero.Text == string.Empty)
                {
                        ErrorDatosFaltantes.confirmacionForm("ERROR");
                }
                else
                {
                    f.IdReservacion = id;
                    f.IdHuesped = Convert.ToInt32(txtIdCliente.Text);
                    f.Empleado = txtCajero.Text;
                    f.TotalAPagar = Convert.ToSingle(txtTotalAPagar.Text);
                    f.FormaDePago = cmbFormaPago.Text;
                    f.SubTotal = Convert.ToSingle(dgvHabitacion.Rows[0].Cells[12].Value);
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
                        hab.IdHabitacion = Convert.ToInt32(dgvHabitacion.Rows[0].Cells[13].Value);
                        hab.CambiarEstados(hab.IdHabitacion, "Ocupada");
                        FrmCorrecto.confirmacionForm("CORRECTO");
                        f.IdFactura = f.SelectIdFactura();
                        btnImprimir.Enabled = true;
                 
                    }
                    else
                    {
                            FrmCorrecto.confirmacionForm("CORRECTO");
                    }

                }
            }
            if(cmbFormaPago.Text == "Efectivo")
            {
                if (txtNombre.Text == string.Empty || txtEfectivo.Text == string.Empty || txtTotalAPagar.Text == string.Empty || txtCambio.Text == string.Empty || txtCajero.Text == string.Empty)
                {
                    MessageBox.Show("Faltan Ingresar datos.");
                }
                else
                {
                    /*
                     @IdReservacion, @IdHuesped, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @EfectivoRecibido, @Devuelta
                     */
                    f.IdReservacion = id;
                    f.IdHuesped = Convert.ToInt32(txtIdCliente.Text);
                    f.Empleado = txtCajero.Text;
                    f.TotalAPagar = Convert.ToSingle(txtTotalAPagar.Text);
                    f.Fecha = dtpFechaActual.Value;
                    f.FormaDePago = cmbFormaPago.Text;
                    f.SubTotal = Convert.ToSingle(dgvHabitacion.Rows[0].Cells[12].Value);
                    if (txtDescuento.Text == string.Empty)
                    {
                        //do nothing
                        
                    }
                    else
                    {
                        f.Descuento = Convert.ToSingle(txtDescuento.Text);
                    }
                    if( txtEfectivo.Text == string.Empty)
                    {
                        //do nothing
                       
                    }
                    else
                    {
                        f.EfectivoRecibido = Convert.ToSingle(txtEfectivo.Text);
                    }
                   if ( txtCambio.Text == string.Empty)
                    {
                        //do nothing
                        MessageBox.Show("Faltan Ingresar datos.");
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
                        // HABITACION PASA DE DISPONIBLE A OCUPADA
                        Habitacion hab = new Habitacion();
                        hab.IdHabitacion = Convert.ToInt32(dgvHabitacion.Rows[0].Cells[13].Value);
                        hab.CambiarEstados(hab.IdHabitacion, "Ocupada");
                        MessageBox.Show("Se ha facturado correctamente.");
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

        private void TxtEfectivo_Leave_1(object sender, EventArgs e)
        {
            
            float total, efectivo, cambio;
            total = Convert.ToSingle(txtTotalAPagar.Text);
            try
            {
                efectivo = Convert.ToSingle(txtEfectivo.Text);
                cambio = efectivo - total;

                if (cambio >= 0)
                {

                    txtCambio.Text = cambio.ToString();

                }
                else
                {

                   // MessageBox.Show("");
                }
            }
            catch
            {
                // 
            }
           
           
            
           
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

                if (subtotal - (descuento * subtotal) >= 0 )
                {
                    txtTotalAPagar.Text = (subtotal - (descuento * subtotal)).ToString();
                    txtCambio.Text = "";
                }
                else
                {
                    MessageBox.Show("");
                }
                
            }
            catch
            {
                // 
            }

        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e, txtDescuento);
        }

        private void TxtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumerosPunto(e, txtEfectivo);
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

        private void TxtEfectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDigitos_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            validar.soloNumeros4(e, txtBoxDigitos);
        }

        private void TxtNumDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TxtCajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void DtpFechaActual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotalAPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click_1(object sender, EventArgs e)
        {
            FacturaDetails();
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file |*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
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
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(cmbFormaPago.Text == "Efectivo")
            {
                txtBoxFactura.Text =
               "HOTEL XXXXX\n" +
               "************************************************************************\n" +
               "No. Factura: " + f.IdFactura.ToString() + "\n" +
               "Fecha: " + DateTime.Now + "\n" +
               "Le atendió: " + txtCajero.Text + "\n" +
               "--------------------------------------------------------------------------------\n" +
               "DESCRIPCIÓN          PRECIO POR NOCHE      SUBTOTAL \n" +
               "Habitación " + dgvHabitacion.Rows[0].Cells[6].Value.ToString() + "                 " + dgvHabitacion.Rows[0].Cells[11].Value.ToString() + " RD$               " + dgvHabitacion.Rows[0].Cells[12].Value.ToString() +
               "RD$\n--------------------------------------------------------------------------------\n" +
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
             "Le atendió: " + txtCajero.Text + "\n" +
             "--------------------------------------------------------------------------------\n" +
             "DESCRIPCIÓN          PRECIO POR NOCHE      SUBTOTAL \n" +
             "Habitación " + dgvHabitacion.Rows[0].Cells[6].Value.ToString() + "                 " + dgvHabitacion.Rows[0].Cells[11].Value.ToString() + " RD$               " + dgvHabitacion.Rows[0].Cells[12].Value.ToString() +
             "RD$\n--------------------------------------------------------------------------------\n" +
             "Sub-Total                                                                 " + txtSubtotal.Text + " RD$\n" +
             "% Descuento                                                                " + txtDescuento.Text + " %\n\n" +
             "Total                                                                       " + txtTotalAPagar.Text + " RD$\n" +
            "Tarjeta                                                                      " + txtBoxDigitos.Text + " RD$\n" +
              "Compañía                                                     " + txtBoxCompania.Text + " RD$" +
              "\n--------------------------------------------------------------------------------";
            }




        }

        private void ChkBoxPago_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlPay.Visible == true)
            {
                pnlPay.Visible = false;
                payLater = true;
                Reservacion reserva = new Reservacion();
                reserva.IdReservacion = id;
                reserva.PayLater(reserva,1);
            }
            else
            {
                pnlPay.Visible = true;
                payLater = false;
                Reservacion reserva = new Reservacion();
                reserva.IdReservacion = f.IdReservacion;
                reserva.PayLater(reserva, 0);
            }
            
        }
    }
}
 