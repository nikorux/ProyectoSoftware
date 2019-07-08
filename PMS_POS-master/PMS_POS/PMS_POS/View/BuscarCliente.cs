using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class BuscarCliente : Form
    {
       
        public BuscarCliente()
        {
            InitializeComponent();
        }
                Huesped obj = new Huesped();
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && txtBuscarCliente.Text != string.Empty)
            {
                dgvBuscarCliente.DataSource = obj.Search(txtBuscarCliente.Text);
            }
            else
            {
                dgvBuscarCliente.DataSource = obj.VistaTabla();
                dgvBuscarCliente.Columns[0].Visible = false;
            }
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            dgvBuscarCliente.DataSource = obj.VistaTabla();
            dgvBuscarCliente.Columns[0].Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string idHuesped,primerNombre, segundoNombre, primerApellido, segundoApellido, documento;
            if (dgvBuscarCliente.SelectedRows.Count > 0)
            {
                //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                NuevaReservacion nr = NuevaReservacion.Instance;
                idHuesped = dgvBuscarCliente.CurrentRow.Cells[0].Value.ToString();
                primerNombre = dgvBuscarCliente.CurrentRow.Cells[1].Value.ToString();
                segundoNombre = dgvBuscarCliente.CurrentRow.Cells[2].Value.ToString();
                primerApellido = dgvBuscarCliente.CurrentRow.Cells[3].Value.ToString();
                segundoApellido = dgvBuscarCliente.CurrentRow.Cells[4].Value.ToString();
                documento = dgvBuscarCliente.CurrentRow.Cells[8].Value.ToString();
               
                nr.FillCliente(idHuesped,primerNombre, segundoNombre, primerApellido, segundoApellido, documento);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
    }
}
