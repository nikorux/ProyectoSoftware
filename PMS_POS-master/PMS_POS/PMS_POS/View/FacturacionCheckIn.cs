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
        }

        private void BtnRegistrarCheckIn_Click(object sender, EventArgs e)
        {
            Factura_Reservacion f = new Factura_Reservacion();
            if(txtNombre.Text == string.Empty && txtEfectivo.Text == string.Empty && txtTotalAPagar.Text == string.Empty)
            {
                MessageBox.Show("Faltan Ingresar datos.");
            }
            else
            {
                /*
                 @IdReservacion, @IdHuesped, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @EfectivoRecibido, @Devuelta
                 */
                f.IdReservacion = id;
                f.IdHuesped = Convert.ToInt32(dgvHabitacion.Rows[0].Cells[1].Value);
                f.SubTotal =  Convert.ToSingle(dgvHabitacion.Rows[0].Cells[12].Value);
                //  f.TotalAPagar = nicole
                f.Fecha = dtpFechaActual.Value;
                f.FormaDePago = cmbFormaPago.Text;
                if (f.Insert(f) == true)
                {
                    MessageBox.Show("Se ha facturado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al facturar.");
                }
            }
        }

        private void TxtEfectivo_Leave(object sender, EventArgs e)
        {
            int total, efectivo, cambio;
            total = Convert.ToInt32(txtTotalAPagar.Text);
            efectivo = Convert.ToInt32(txtEfectivo.Text);
            cambio = efectivo - total;
            txtCambio.Text = cambio.ToString();
        }
    }
}
 