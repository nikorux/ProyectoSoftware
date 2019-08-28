using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class RegistrarHab : Form
    {
        private static RegistrarHab _instance;
        public static RegistrarHab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrarHab();
                return _instance;
            }
        }

        public RegistrarHab()
        {
            InitializeComponent();

        }

        Habitacion habitacion = new Habitacion();
     
        private bool editar = false;
        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {

                    if (this.txtBoxNumHab.Text == string.Empty || this.cmbTipoHab.Text == string.Empty || this.cmbEstado.Text == string.Empty || this.txtBoxPrecioPorNoche.Text == string.Empty)
                    {
                        FrmSeguroCerrar.confirmacionForm("ERROR");
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
                            RefreshDgv();
                            Clear();
                            FrmCorrecto.confirmacionForm("AGREGADO");


                        }
                        else
                        {
                            FrmSeguroCerrar.confirmacionForm("ERROR");
                        }

                    }
                }
                catch (Exception)
                {

                }

            }
            if (editar == true)
            {
                if (this.txtBoxNumHab.Text == string.Empty || this.cmbTipoHab.Text == string.Empty || this.cmbEstado.Text == string.Empty || this.txtBoxPrecioPorNoche.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar algunos datos");
                }
                else
                {
                    try
                    {
                        //Controller code

                        //Shitty code
                        habitacion.IdHabitacion = Convert.ToInt32(txtBoxId.Text);
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
                            RefreshDgv();
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
        }


        
        

        private void Clear()
        {
            txtBoxNumHab.Clear();
            txtBoxId.Clear();
            cmbTipoHab.Text = "";
            numCantCamas.Value = 1;
            numMaxPersonas.Value = 1;
            numPiso.Value = 1;
            cmbEstado.Text = "";
            txtBoxDetalles.Clear();
            txtBoxPrecioPorNoche.Clear();
            
        }

        private void RegistrarHabitación_Load(object sender, EventArgs e)
        {

          // Llenar el combo box con el tipo de habitación

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
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            RefreshDgv();
            this.Close();

        }
        
        public void RecibirDatos(string id, string numHab, string tipoHab, int cantCamas, int maxPersonas, int numeroPiso, string estado, string detalles, string precio)
        {
            editar = true;
            txtBoxId.Text = id;
            txtBoxNumHab.Text = numHab;
            cmbTipoHab.Text = tipoHab;
            numCantCamas.Value = cantCamas;
            numMaxPersonas.Value = maxPersonas;
            numPiso.Value = numeroPiso;
            cmbEstado.Text = estado;
            txtBoxDetalles.Text = detalles;
            txtBoxPrecioPorNoche.Text = precio;
        }
        private void RefreshDgv()
        {
            UserControlHabitaciones.Instance.RefreshDgv();
        }

        private void TxtBoxNumHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e, txtBoxNumHab);
        }

        private void TxtBoxPrecioPorNoche_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumerosPunto(e, txtBoxPrecioPorNoche);
        }

        private void RegistrarHab_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }

}
