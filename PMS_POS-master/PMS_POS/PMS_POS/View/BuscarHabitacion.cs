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
                idHab = dgv.CurrentRow.Cells[0].Value.ToString();
                numHab = dgv.CurrentRow.Cells[1].Value.ToString();
                tipoHab = dgv.CurrentRow.Cells[2].Value.ToString();
                precioHab = dgv.CurrentRow.Cells[9].Value.ToString();
                nr.FillHab(idHab,numHab, tipoHab, precioHab);
                nr.Revisar();
                nr.calcular();
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
            dgv.DataSource = habitacion.Select();
            dgv.Columns[0].Visible = false;
         //   dgv.Columns[10].Visible = false;
          //  dgv.Columns[11].Visible = false;
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
