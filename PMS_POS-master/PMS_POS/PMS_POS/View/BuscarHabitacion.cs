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

        private void TxtBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (char.IsLetter(e.KeyChar) && txtBoxBuscar.Text != string.Empty || char.IsDigit(e.KeyChar) && txtBoxBuscar.Text != string.Empty)
            {
                dgv.DataSource = habitacion.Search(txtBoxBuscar.Text);

            }
            else
            {
                dgv.DataSource = habitacion.Select();
                dgv.Columns[0].Visible = false;
            }
        }

        private void BuscarHabitacion_Load(object sender, EventArgs e)
        {
            dgv.DataSource = habitacion.Select();
            dgv.Columns[0].Visible = false;
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
                idHab = dgv.CurrentRow.Cells[0].Value.ToString();
                numHab = dgv.CurrentRow.Cells[1].Value.ToString();
                tipoHab = dgv.CurrentRow.Cells[2].Value.ToString();
                precioHab = dgv.CurrentRow.Cells[9].Value.ToString();
                nr.FillHab(idHab,numHab, tipoHab, precioHab);
               // nr.calcular();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
    }
}
