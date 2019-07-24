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
            txtNombre.Text = dgvHabitacion.Rows[0].Cells[4].Value.ToString();
            txtTelefono.Text = dgvHabitacion.Rows[0].Cells[5].Value.ToString();



        }
            public void RefreshDgv()
            {
            dgvHabitacion.DataSource = obj.reservacion(id);
            dgvHabitacion.Columns[0].Visible = false;
            dgvHabitacion.Columns[1].Visible = false;
            dgvHabitacion.Columns[2].Visible = false;
            dgvHabitacion.Columns[3].Visible = false;
            dgvHabitacion.Columns[4].Visible = false;
        }
    }
}
