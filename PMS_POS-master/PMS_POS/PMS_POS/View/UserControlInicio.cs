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
    public partial class UserControlInicio : UserControl
    {
        MySqlConnection conex;
        string cadenaconex;
        EstadoHabitaciones obj = new EstadoHabitaciones();


        private static UserControlInicio _instance;
        public static UserControlInicio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlInicio();
                return _instance;
            }
        }

        public UserControlInicio()
        {
            InitializeComponent();
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


        private void btnVerDetallesReservadas_Click(object sender, EventArgs e)
        {

        }

        private void UserControlInicio_Load(object sender, EventArgs e)
        {
            dgvEstadoHabitaciones.DataSource = obj.VistaTabla();
            DatosTotalOcupadas();
            DatosTotalLibres();
            DatosTotalMantenimiento();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void DatosTotalOcupadas()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdHabitacion) as TotalOcupadas FROM habitacion WHERE (Estado = 'Ocupada') AND (IsDeleted = 0)";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblOcupadas.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void DatosTotalLibres()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdHabitacion) as TotalLibres FROM habitacion WHERE (Estado = 'Disponible') AND (IsDeleted = 0)";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblLibres.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void DatosTotalMantenimiento()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdHabitacion) as TotalMantenimiento FROM habitacion WHERE (Estado = 'Mantenimiento') AND (IsDeleted = 0)";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblMantenimiento.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

    }
}
