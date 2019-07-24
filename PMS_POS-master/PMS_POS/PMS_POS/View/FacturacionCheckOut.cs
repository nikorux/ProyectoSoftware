using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class FacturacionCheckOut : UserControl
    {
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=hostal; Uid=root; pwd=root;");
        MySqlConnection conex;
        string cadenaconex;
        string instruccion;

        RegistroNuevoCliente form2 = new RegistroNuevoCliente();

        private static FacturacionCheckOut _instance;
        public static FacturacionCheckOut Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FacturacionCheckOut();
                return _instance;
            }
        }
        public FacturacionCheckOut()
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

        private void FacturacionCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void LiquidarServiciosAdquiridos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //RefreshGrid();
        }
        private void BtnVisualizarPendiente_Click(object sender, EventArgs e)
        {
            LiquidarServiciosAdquiridos form2 = new LiquidarServiciosAdquiridos();
            form2.FormClosed += new FormClosedEventHandler(LiquidarServiciosAdquiridos_FormClosed);
            form2.ShowDialog();

        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cadSql = "Select * from huesped where IdHuesped = " + txtBusquedaCliente.Text;

            MySqlCommand comando = new MySqlCommand(cadSql, conectar);
            conectar.Open();

            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtIdCliente.Text = leer["IdHuesped"].ToString();
                txtNombre.Text = leer["PrimerNombre"].ToString();
                txtTelefono.Text = leer["Telefono"].ToString();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el registro");
                txtIdCliente.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
            }
            conectar.Close();
        }

        private void BtnConfirmarSalida_Click(object sender, EventArgs e)
        {

        }

        private void TxtCambio_Leave(object sender, EventArgs e)
        {

        }

        private void TxtEfectivo_Leave(object sender, EventArgs e)
        {
            int total, efectivo, cambio;
            total = Convert.ToInt32(txtTotalAPagar.Text);
            efectivo = Convert.ToInt32(txtEfectivo.Text);
            cambio = efectivo - total;
            txtCambio.Text = cambio.ToString();
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select * from huesped where IdHuesped = " + txtIdCliente.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
    }
}
