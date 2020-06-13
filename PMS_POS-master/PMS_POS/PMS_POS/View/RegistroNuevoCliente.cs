using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;


namespace PMS_POS.View
{
    public partial class RegistroNuevoCliente : Form
    {

        public RegistroNuevoCliente()
        {
            InitializeComponent();
        }

        Huesped habitacion = new Huesped();
        private bool editar = false;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
             if (editar == false)
            {
                if (this.txtPrimerNombre.Text == string.Empty || this.txtPrimerApellido.Text == string.Empty)
                {
                    ErrorDatosFaltantes.confirmacionForm("ERROR");
                }
                else
                {
                    Huesped pHuesped = new Huesped();
                    pHuesped.PrimerNombre = txtPrimerNombre.Text.Trim();
                    pHuesped.SegundoNombre = txtSegundoNombre.Text.Trim();
                    pHuesped.PrimerApellido = txtPrimerApellido.Text.Trim();
                    pHuesped.SegundoApellido = txtSegundoApellido.Text.Trim();
                    pHuesped.Compania = cbxCompania.Text.Trim();
                    pHuesped.NombreCompania = txtNombreCompania.Text.Trim();
                    pHuesped.TipoDocumento = cbxTipoIdentificacion.Text.Trim();
                    pHuesped.NumDocumento = txtIdentificacion.Text.Trim();
                    pHuesped.Sexo = cbxSexo.Text.Trim();
                    pHuesped.Telefono = txtTelefono.Text.Trim();
                    pHuesped.Direccion = txtDireccion.Text.Trim();
                    pHuesped.Ciudad = txtCiudad.Text.Trim();
                    pHuesped.Provincia = txtProvincia.Text.Trim();
                    pHuesped.Pais = txtPaisNatal.Text.Trim();
                    pHuesped.Correo = txtCorreo.Text.Trim();

                    int resultado = HuespedD.Agregar(pHuesped);
                    if (resultado > 0)
                    {
                        FrmCorrecto.confirmacionForm("AGREGADO");
                        txtPrimerNombre.Text = "";
                        txtSegundoNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtNombreCompania.Text = "";
                        cbxCompania.SelectedIndex = -1;
                        cbxTipoIdentificacion.SelectedIndex = -1;
                        cbxSexo.SelectedIndex = -1;
                        txtTelefono.Text = "";
                        txtDireccion.Text = "";
                        txtCiudad.Text = "";
                        txtProvincia.Text = "";
                        txtPaisNatal.Text = "";
                        txtCorreo.Text = "";
                        //dgvclie.DataSource = null;
                        //dgvHuespedes.DataSource = obj.VistaTabla();
                        Huesped limpiar = new Huesped();
                        //limpiar.BorrarCampos(this, groupBox1);
                        //cbxTipoIdentificacion.Items.Clear();
                        //cbxTipoIdentificacion.SelectedIndex = 0;


                    }
                    else
                    {
                        FrmSeguroCerrar.confirmacionForm("ERROR");
                    }
                }
            }

            if (editar == true)
            {
                try
                {
                    string MyConnection2 = "server=localhost; database=hostal; Uid=root; pwd=root";
                    string Query = "update hostal.huesped set PrimerNombre='" + this.txtPrimerNombre.Text + "',SegundoNombre='" + this.txtSegundoNombre.Text + "',PrimerApellido='" + this.txtPrimerApellido.Text + "',SegundoApellido='" + this.txtSegundoApellido.Text + "' where IdHuesped='" + this.txtIdHuesped.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("El cliente ha sido modificado.");
                    Huesped limpiar = new Huesped();
                    //limpiar.BorrarCampos(this, groupbox1);
                    //cbxTipoIdentificacion.Items.Clear();
                    //cbxTipoIdentificacion.SelectedIndex = 0;
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
                





        private void RegistroNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void RegistroNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void DatosClientes()
        {
            string myConnection = "server = localhost; database = hostal; Uid = root; pwd = root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "Select * from huesped WHERE IdHuesped ='" + txtIdHuesped.Text + "'";
            //command.CommandText = "Select * from huesped WHERE IdHuesped Like '%" + txtIdHuesped.Text + "%'";

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    txtIdHuesped.Text = Convert.ToString(myReader["IdHuesped"]);
                    txtPrimerNombre.Text = Convert.ToString(myReader["PrimerNombre"]);
                    txtSegundoNombre.Text = Convert.ToString(myReader["SegundoNombre"]);
                    txtPrimerApellido.Text = Convert.ToString(myReader["PrimerApellido"]);
                    // txtSegundoApellido.Text = myReader[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        public void DatosClientesD()
        {
            string connStr = "server = localhost; database = hostal; Uid = root; pwd = root";
            using (MySqlConnection conexion = new MySqlConnection(connStr))
            {
                conexion.Open();

                string query = "SELECT * FROM huesped WHERE IdHuesped = ?id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("?id", txtIdHuesped.Text);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtIdHuesped.Text = Convert.ToString(reader["IdHuesped"]);
                    txtPrimerNombre.Text = Convert.ToString(reader["PrimerNombre"]);
                    txtSegundoNombre.Text = Convert.ToString(reader["SegundoNombre"]);
                }

                reader.Close();
            }
        }

   

    public void ObtenerDatos(string IdHuesped, string PrimerNombre, string SegundoNombre, string PrimerApellido,
            string TipoDocumento, string NumDocumento,
            string Telefono, string Correo, string Pais)
        {
            editar = true;
            txtIdHuesped.Text = IdHuesped;
            txtPrimerNombre.Text = PrimerNombre;
            txtSegundoNombre.Text = SegundoNombre;
            txtPrimerApellido.Text = PrimerApellido;
            //txtSegundoApellido.Text = SegundoApellido;
            //cbxSexo.Text = Sexo;
            //cbxCompania.Text = Compañia;
            //txtNombreCompania.Text = NombreCompañia;
            cbxTipoIdentificacion.Text = TipoDocumento;
            txtIdentificacion.Text = NumDocumento;
            txtTelefono.Text = Telefono;
            //txtDireccion.Text = Direccion;
            txtPaisNatal.Text = Pais;
            txtCorreo.Text = Correo;
            //txtProvincia.Text = Provincia;
            //txtCiudad.Text = Ciudad;
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (validar.ValidarEmail(txtCorreo.Text) == true)
            {
                errorProviderCorreo.Clear();
            }
            else
            {
                errorProviderCorreo.SetError(this.txtCorreo, "Ingrese un correo válido.");
            }

        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

            if (cbxTipoIdentificacion.Text == "Cédula")
            {
                if ((validar.ValidarCedula(txtIdentificacion.Text) == true))
                {
                    errorProviderCedula.Clear();
                }
                else
                {
                    errorProviderCedula.SetError(this.txtIdentificacion, "Ingrese una cédula válida.");
                }
            }
        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtPrimerNombre);
        }

        private void TxtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtPrimerApellido);
        }

        private void TxtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtSegundoApellido);
        }

        private void TxtPaisNatal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtPaisNatal);
        }

        private void TxtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtProvincia);
        }

        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtCiudad);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    
        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (cbxTipoIdentificacion.Text == "Pasaporte")
            {
                validar.ValidarPasaporte(e, txtIdentificacion);
            }
        }

        private void CbxTipoIdentificacion_TextChanged(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RegistroNuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

