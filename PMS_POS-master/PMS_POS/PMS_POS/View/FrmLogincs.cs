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
    public partial class FrmLogincs : Form
    {
        static FrmLogincs _obj;
        private string conn;
        private MySqlConnection connect;

        public static FrmLogincs Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmLogincs();
                }
                return _obj;
            }
        }
        public FrmLogincs()
        {
            InitializeComponent();
        }

        private void db_connection()
        {
            try
            {
                conn = "server = localhost; database = hostal; Uid = root; pwd = root;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from empleado where Usuario=@user and Contraseña=@contra";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@contra", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;
            if (usuario == "" || contra == "")
            {
                MessageBox.Show("Se han detectado campos vacíos, por favor llenarlos.");
                return;
            }
            bool r = validate_login(usuario, contra);
            if (r)
            {
               MainScreen abrir = new MainScreen();
               abrir.Show();
               //this.Close();
            }
            else
            {
                FrmSeguroCerrar.confirmacionForm("ERROR");
            }
        }

        private void FrmLogincs_Load(object sender, EventArgs e)
        {
            esclarecerForm.ShowAsyc(this);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Segur@ que desea cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
