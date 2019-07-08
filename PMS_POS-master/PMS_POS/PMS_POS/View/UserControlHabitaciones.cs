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
using System.Configuration;

namespace PMS_POS.View
{
    public partial class UserControlHabitaciones : UserControl
    {
        //ControllerHabitacion cHabitacion = new ControllerHabitacion();
        private bool editar = false;
        private static UserControlHabitaciones _instance;
        public static UserControlHabitaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlHabitaciones();
                return _instance;
            }
        }
        public UserControlHabitaciones()
        {
            InitializeComponent();
        }

        Habitacion habitacion = new Habitacion();
        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        private void UserControlHabitaciones_Load(object sender, EventArgs e)
        {
            // BUSCAR LOS TIPOS DE HABITACION Y LLENAR EL COMBO BOX
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
               string sql = "SELECT * FROM tipo_habitacion";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbTipoHab.Items.Add(reader.GetString("NombreTipoHab"));
                }
                mySqlConn.Close();
            }
                dgvHab.DataSource = habitacion.Select();
                dgvHab.Columns[0].Visible = false;
        }       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                //Get values from input fields
                try
                {

                    if (this.txtBoxNumHab.Text == string.Empty || this.cmbTipoHab.Text == string.Empty || this.cmbEstado.Text == string.Empty || this.txtBoxPrecioPorNoche.Text == string.Empty)
                    {
                        MessageBox.Show("Falta ingresar algunos datos");
                    }
                    else
                    {
                        habitacion.NumHab = Convert.ToInt32(txtBoxNumHab.Text);
                        habitacion.TipoHab = cmbTipoHab.Text;
                        habitacion.CantCamas = Convert.ToInt32(numCantCamas.Value);
                        habitacion.MaxPersonas = Convert.ToInt32(numMaxPersonas.Value);
                        habitacion.Piso = Convert.ToInt32(numPiso.Value);
                        habitacion.Estado = cmbEstado.Text;
                        habitacion.Detalles = txtBoxDetalles.Text;
                        habitacion.PrecioPorNoche = Convert.ToSingle(txtBoxPrecioPorNoche.Text);


                        if (habitacion.Insert(habitacion) == true)
                        {
                            Clear();
                            MessageBox.Show("La habitación ha sido creada.");
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al crear la habitación.");
                        }

                    }
                }
                catch (Exception)
                {

                }


            }
            if (editar == true)
            {
                try
                {
                    //Controller code

                    //Shitty code
                    habitacion.IdHabitacion = Convert.ToInt32(dgvHab.CurrentRow.Cells[0].Value);
                    habitacion.NumHab = Convert.ToInt32(txtBoxNumHab.Text);
                    habitacion.TipoHab = cmbTipoHab.Text;
                    habitacion.CantCamas = Convert.ToInt32(numCantCamas.Value);
                    habitacion.MaxPersonas = Convert.ToInt32(numMaxPersonas.Value);
                    habitacion.Piso = Convert.ToInt32(numPiso.Value);
                    habitacion.Estado = cmbEstado.Text;
                    habitacion.Detalles = txtBoxDetalles.Text;
                    habitacion.PrecioPorNoche = Convert.ToSingle(txtBoxPrecioPorNoche.Text);


                   if (habitacion.Update(habitacion) == true)
                    {
                        MessageBox.Show("La habitación ha sido actualizada.");
                        Clear();
                        editar = false;
                        
                    }             

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar los datos. (Error: " + ex + ")");
                }


            }
        }



        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                habitacion.IdHabitacion = Convert.ToInt32(dgvHab.CurrentRow.Cells[0].Value);
                if (habitacion.Delete(habitacion) == true)
                {
                    MessageBox.Show("La habitación ha sido eliminada.");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Error al editar los datos.)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al borrar las habitación. (Error: " + ex + ")");
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {

            string message = "Quiere editar una habitación?";
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

                if (dgvHab.SelectedRows.Count > 0)
                {
                    //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                    editar = true;
                    txtBoxNumHab.Text = dgvHab.CurrentRow.Cells[1].Value.ToString();
                    cmbTipoHab.Text = dgvHab.CurrentRow.Cells[2].Value.ToString();
                    numCantCamas.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[3].Value);
                    numMaxPersonas.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[4].Value);
                    numPiso.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[5].Value);
                    cmbEstado.Text = dgvHab.CurrentRow.Cells[6].Value.ToString();
                    txtBoxDetalles.Text = dgvHab.CurrentRow.Cells[7].Value.ToString();
                    txtBoxPrecioPorNoche.Text = dgvHab.CurrentRow.Cells[9].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccione una fila.");
                }
            }
            else
            {
                
            }


        }
        private void Clear()
        {
            txtBoxNumHab.Clear();
            cmbTipoHab.Text = "";
            numCantCamas.Value = 1;
            numMaxPersonas.Value = 1;
            numPiso.Value = 1;
            cmbEstado.Text = "";
            txtBoxDetalles.Clear();
            txtBoxPrecioPorNoche.Clear();
            dgvHab.Columns[0].Visible = false;
            dgvHab.DataSource = habitacion.Select();
        }

        private void numPiso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
