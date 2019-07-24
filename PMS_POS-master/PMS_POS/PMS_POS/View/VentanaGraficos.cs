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

        public void Conectar()
        {
            try
            {
                conectar = new MySqlConnection("server=localhost; database=hostal; Uid=root; pwd=root;");
                conectar.Open();
                MessageBox.Show("Conecto");
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
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
            HabitacionesPreferidas.Series["Series1"].LegendText = "Gráfico de Habitaciones Preferidas";
            HabitacionesPreferidas.Series["Series1"].XValueMember = "IdHabitacion";
            HabitacionesPreferidas.Series["Series1"].YValueMembers = "IdHuesped";
            HabitacionesPreferidas.DataSource = EnviarDatos("Select IdHabitacion, IdHuesped from reservacion;");




        }
    }
}
