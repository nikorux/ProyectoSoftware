using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class RegistrarNuevaCompra : UserControl
    {
        private static RegistrarNuevaCompra _instance;
        public static RegistrarNuevaCompra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrarNuevaCompra();
                return _instance;
            }
        }

        public RegistrarNuevaCompra()
        {
            InitializeComponent();
            LoadPrdCompra();
            LoadHistorial();
        }
        public void LoadPrdCompra()//para listar...
        {
            dgvProductosRegistrados.DataSource = GetProvList();
        }
        private DataTable GetProvList()//listar 
        {
            DataTable dtProveedores = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM INSUMO", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtProveedores.Load(reader);
                }
            }

            return dtProveedores;

        }

        public void LoadHistorial()//para listar historial
        {
            dgvProductosComprados.DataSource = GetProvList2();
        }

        private DataTable GetProvList2()//listar historial

        {
            DataTable dt= new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM historial_compra_insumo", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;

        }

        private void TxtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void RegistrarNuevaCompra_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //otro metodo
        }

        private void dgvProductosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductosRegistrados.Rows[e.RowIndex];
                txtNombreProd.Text = row.Cells["NombreInsumo"].Value.ToString();
                txtPrecioProd.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtId.Text = row.Cells["IdInsumo"].Value.ToString();
                txtCantDisp.Text = row.Cells["CantActual"].Value.ToString();
                txtIdProveedor.Text= row.Cells["Proveedor"].Value.ToString();
                txtIdInsumo.Text = row.Cells["IdInsumo"].Value.ToString();


            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = Convert.ToInt32(txtCantDisp.Text);
                int cant2 = Convert.ToInt32(spnCantComprada.Text);
                int cantTotal = cant + cant2;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update hostal.insumo set CantActual='" + cantTotal + "' where IdInsumo='" + this.txtId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Registrados");
                LoadPrdCompra();
                
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //insertar en historial
            try
            {
                DateTime today = DateTime.Today;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
               // This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into hostal.historial_compra_insumo(FechaCompra,IdInsumo,CantidadComprada,IdProveedor, NombreProducto) values('" + DateTime.Now.ToString("dd-MM-yyyy hh:mm") + "','" + Convert.ToInt32(txtIdInsumo.Text)+"','" + Convert.ToInt32(spnCantComprada.Text)+ "','"+ this.txtIdProveedor.Text + "','"+ txtNombreProd.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Historial Actualizado");
                clearDatos();
                LoadHistorial();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //fin insertar en historial

        }
        public void clearDatos()
        {
            txtNombreProd.Text = "";
            txtPrecioProd.Text = "";
            txtId.Text = "";
            txtCantDisp.Text = "";
            spnCantComprada.Text = "1";
        }

        private void spnCantComprada_ValueChanged(object sender, EventArgs e)
        {
          /*  double total;
            int cantComprada = Convert.ToInt32(spnCantComprada.Text);
            double precio = Convert.ToDouble(txtPrecioProd.Text);
            total = cantComprada * precio;
            txtTotalCompra.Text = total.ToString();*/
        }
    }
}
