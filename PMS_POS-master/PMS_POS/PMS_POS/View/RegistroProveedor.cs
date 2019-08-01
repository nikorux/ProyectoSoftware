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
using System.Configuration;
using MySql.Data;


namespace PMS_POS.View
{
    public partial class RegistroProveedor :UserControl
    {
        int IdRubro = 0;
        private static RegistroProveedor _instance;
        public static RegistroProveedor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistroProveedor();
                return _instance;
            }
        }
        public RegistroProveedor()
        {
            InitializeComponent();
            fillComboboxRubro();
            fillComboboxDocumento();
            LoadProveedores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }
        public void fillComboboxRubro()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=root");

                string selectQuery = "SELECT * FROM hostal.rubro";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxRubro.Items.Add(reader.GetString("Nombre"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clearFields()
        {
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtNombreCompania.Text = "";
            txtNumDoc.Text = "";
            txtRNC.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";


        }

        public void LoadProveedores()
        {
            dgvProveedores.DataSource = GetProvList();
        }

        private DataTable GetProvList()
        {
            DataTable dtProveedores = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PROVEEDOR", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtProveedores.Load(reader);
                }
            }

            return dtProveedores;

        }

        public void fillComboboxDocumento()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=root");

                string selectQuery = "SELECT * FROM hostal.documento";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxTipoDocumento.Items.Add(reader.GetString("NombreDocumento"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)//boton guardar
        {
            try
            {
                //connection string 
                string MyConnection2 = "Datasource=localhost;port=3306;username=root;password=root;";
                //insert query 
                string Query = "insert into hostal.proveedor(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,NombreCompañia,TipoDocumento,NumDocumento,RNC,Telefono,Correo) " +
                    "values('" + this.txtPrimerNombre.Text + "','" + this.txtSegundoNombre.Text + "','" + this.txtPrimerApellido.Text + "','" + this.txtSegundoApellido.Text + "','" + this.txtNombreCompania.Text + "','" + this.cbxTipoDocumento.Text + "','" + this.txtNumDoc.Text + "','" + this.txtRNC.Text + "','" + this.txtTelefono.Text + "','" + this.txtCorreo.Text + "');";
                //MySqlConnection
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Datos Guardados");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                clearFields();
                LoadProveedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
