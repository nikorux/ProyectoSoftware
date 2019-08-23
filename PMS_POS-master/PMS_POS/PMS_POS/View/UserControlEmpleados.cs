using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class UserControlEmpleados : UserControl
    {
        MySqlConnection conex;
        string cadenaconex;
        Empleado obj = new Empleado();

        RegistroNuevoEmpleado form2 = new RegistroNuevoEmpleado();


        public UserControlEmpleados()
        {
            InitializeComponent();
        }

        private void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            RegistroNuevoEmpleado form2 = new RegistroNuevoEmpleado();
            form2.FormClosed += new FormClosedEventHandler(RegistroNuevoEmpleado_FormClosed);
            form2.ShowDialog();
        }
        public void RefreshGrid()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = obj.VistaTabla();
        }

        private void UserControlEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = obj.VistaTabla();

        }

        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }

        private void TxtFiltroo_TextChanged(object sender, EventArgs e)
        {

            if (txtFiltroo.Text != "")
            {

                dgvEmpleados.CurrentCell = null;
                foreach (DataGridViewRow n in dgvEmpleados.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvEmpleados.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtFiltroo.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvEmpleados.DataSource = obj.VistaTabla();
            }
        }

        private void RegistroNuevoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void BtnEditarEmpleados_Click(object sender, EventArgs e)
        {

            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                form2.ObtenerDatos(dgvEmpleados.CurrentRow.Cells[0].Value.ToString(), dgvEmpleados.CurrentRow.Cells[1].Value.ToString(), dgvEmpleados.CurrentRow.Cells[2].Value.ToString(), dgvEmpleados.CurrentRow.Cells[3].Value.ToString(), dgvEmpleados.CurrentRow.Cells[4].Value.ToString(), dgvEmpleados.CurrentRow.Cells[5].Value.ToString(), dgvEmpleados.CurrentRow.Cells[6].Value.ToString(), dgvEmpleados.CurrentRow.Cells[7].Value.ToString(), dgvEmpleados.CurrentRow.Cells[8].Value.ToString(), dgvEmpleados.CurrentRow.Cells[9].Value.ToString());
                form2.FormClosed += new FormClosedEventHandler(RegistroNuevoEmpleado_FormClosed);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void BtnEliminarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    obj.IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                    if (obj.Delete(obj) == true)
                    {
                        FrmCorrecto.confirmacionForm("ELIMINADO");
                        dgvEmpleados.DataSource = null;
                        dgvEmpleados.DataSource = obj.VistaTabla();


                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar los datos.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el empleado. (Error: " + ex + ")");
            }
        }

    }
}
