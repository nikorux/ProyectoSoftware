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
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class VentanaGraficos : Form
    {

        MySqlConnection conectar;
        public VentanaGraficos()
        {
            InitializeComponent();
        }

        /*static string MySqlConnectionSring = "server=localhost; database=hostal; Uid=root; pwd=root;";
        MySqlConnection connection = new MySqlConnection(MySqlConnectionSring);
   
        public void chart()
        {
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select Sexo from huesped";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    chart1.Series["Femenino"].Points.AddXY(reader.GetInt32("Sexo"), reader.GetInt32("Femenino"));
                    chart1.Series["Masculino"].Points.AddXY(reader.GetInt32("Sexo"), reader.GetInt32("Masculino"));

                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }*/


        public void Conectar()
        {
            try
            {
                conectar = new MySqlConnection("server = localhost; database = hostal; Uid = root; pwd = root;");
                conectar.Open();
            }
            catch (Exception)
            {

            }
        }



        public DataTable EnviarDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta,conectar);
            mda.Fill(tabla);
            return tabla;
        }

        private void VentanaGraficos_Load(object sender, EventArgs e)
        {
            Conectar();
            DatosTotalVentas();
            DatosTotalClientes();
            DatosTotalEmpleados();
            DatosTotalHabitaciones();
            DatosTotalReservaciones();

            /*chart1.Series["Series1"].LegendText = "Cantidad de Clientes por Género";*/
            chart1.Series["Series1"].XValueMember = "Sexo";
            chart1.Series["Series1"].YValueMembers = "Cant";
            chart1.DataSource = EnviarDatos("SELECT sexo, COUNT(Sexo) AS Cant FROM huesped GROUP BY Sexo");

            chart2.Series["Series1"].LegendText = "Cantidad de Clientes por País";
            chart2.Series["Series1"].XValueMember = "pais";
            chart2.Series["Series1"].YValueMembers = "Cant";
            chart2.DataSource = EnviarDatos("SELECT pais, COUNT(pais) AS Cant FROM huesped GROUP BY pais");

            chart3.Series["Series1"].XValueMember = "MONTHNAME(FechaLlegada)";
            chart3.Series["Series1"].YValueMembers = "Cant";
            chart3.DataSource = EnviarDatos("SET lc_time_names = 'es_ES'");
            chart3.DataSource = EnviarDatos("SELECT MONTHNAME(FechaLlegada), COUNT(FechaLlegada) AS Cant FROM reservacion GROUP BY MONTHNAME(FechaLlegada)");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DatosTotalVentas()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT SUM(PrecioTotal) as TotalVentas FROM reservacion WHERE IsDeleted = 0";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblTotalVentas.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }
        
        private void DatosTotalClientes()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdHuesped) as TotalClientes FROM huesped WHERE IsDeleted = 0";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblTotalClientes.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void DatosTotalEmpleados()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdEmpleado) as TotalEmpleados FROM empleado WHERE IsDeleted = 0";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblTotalEmpleados.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void DatosTotalHabitaciones()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdHabitacion) as TotalHabitaciones FROM habitacion WHERE IsDeleted = 0";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblTotalHabitaciones.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void DatosTotalReservaciones()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(IdReservacion) as TotalReservaciones FROM reservacion WHERE IsDeleted = 0";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lblTotalReservaciones.Text = myReader[0].ToString();
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
