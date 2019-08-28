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
using PMS_POS.Reportes;

namespace PMS_POS.View
{
    public partial class UserControlClientes : UserControl
    {


        //MySqlConnection conex;
        MySqlConnection conex;
        string cadenaconex;
        Huesped obj = new Huesped();

        RegistroNuevoCliente form2 = new RegistroNuevoCliente();
        FacturacionCheckIn ucFacturacionCheckIn = null;


        /* private static UserControlClientes _instance;
         public static UserControlClientes Instance
         {
             get
             {
                 if (_instance == null)
                     _instance = new UserControlClientes();
                 return _instance;
             }
         }*/

        public UserControlClientes()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            /*Form formulario = new RegistroNuevoCliente();
            formulario.Show();*/

            RegistroNuevoCliente form2 = new RegistroNuevoCliente();
            form2.FormClosed += new FormClosedEventHandler(RegistroNuevoCliente_FormClosed);
            form2.ShowDialog();

        }

        public void RefreshGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = obj.VistaTabla();
        }

        private void UserControlClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = obj.VistaTabla();

        }
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
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

                    dgvClientes.CurrentCell = null;
                    foreach (DataGridViewRow n in dgvClientes.Rows)
                    {
                        n.Visible = false;
                    }
                    foreach (DataGridViewRow n in dgvClientes.Rows)
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
                    dgvClientes.DataSource = obj.VistaTabla();
                }

        }

        private void RegistroNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void RegistroNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                form2.ObtenerDatos(dgvClientes.CurrentRow.Cells[0].Value.ToString(), dgvClientes.CurrentRow.Cells[1].Value.ToString(), dgvClientes.CurrentRow.Cells[2].Value.ToString(), dgvClientes.CurrentRow.Cells[3].Value.ToString(), dgvClientes.CurrentRow.Cells[4].Value.ToString(), dgvClientes.CurrentRow.Cells[5].Value.ToString(), dgvClientes.CurrentRow.Cells[6].Value.ToString(), dgvClientes.CurrentRow.Cells[7].Value.ToString(), dgvClientes.CurrentRow.Cells[8].Value.ToString());
                form2.FormClosed += new FormClosedEventHandler(RegistroNuevoCliente_FormClosed);
                form2.ShowDialog();
                form2.DatosClientesD();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila.");
                }
        }

       
        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    obj.IdHuesped = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    if (obj.Delete(obj) == true)
                    {
                        FrmCorrecto.confirmacionForm("ELIMINADO");
                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = obj.VistaTabla();


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
            catch(Exception ex)
            {
                MessageBox.Show("Error al borrar los clientes. (Error: " + ex + ")");
            }
        }


        private void BtnCheckIn_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            //No va

        }

        private void BtnCheckIn_Click_1(object sender, EventArgs e)
        {
            if (!MainScreen.Instance.PnlContainer.Controls.ContainsKey("FacturacionCheckIn"))
            {
                FacturacionCheckIn un = new FacturacionCheckIn();
                un.Dock = DockStyle.Fill;
                MainScreen.Instance.PnlContainer.Controls.Add(un);
            }
            MainScreen.Instance.PnlContainer.Controls["FacturacionCheckIn"].BringToFront();

        }

        private void FrmReporteHuesped_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            frmReporteHuesped form2 = new frmReporteHuesped();
            form2.FormClosed += new FormClosedEventHandler(FrmReporteHuesped_FormClosed);
            form2.ShowDialog();
        }
    }
}
