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
    public partial class RegistroNuevoEmpleado : Form
    {
        public RegistroNuevoEmpleado()
        {
            InitializeComponent();
        }

        private bool editar = false;

        private void RegistroNuevoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
      
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
                    Empleado pEmpleado = new Empleado();
                    pEmpleado.PrimerNombre = txtPrimerNombre.Text.Trim();
                    pEmpleado.SegundoNombre = txtSegundoNombre.Text.Trim();
                    pEmpleado.PrimerApellido = txtPrimerApellido.Text.Trim();
                    pEmpleado.SegundoApellido = txtSegundoApellido.Text.Trim();
                    pEmpleado.RolEmpleado = txtRolEmpleado.Text.Trim();
                    pEmpleado.TipoDocumento = cbxTipoIdentificacion.Text.Trim();
                    pEmpleado.NumDocumento = txtIdentificacion.Text.Trim();
                    pEmpleado.Sexo = cbxSexo.Text.Trim();
                    pEmpleado.Telefono = txtTelefono.Text.Trim();
                    pEmpleado.Direccion = txtDireccion.Text.Trim();
                    pEmpleado.Ciudad = txtCiudad.Text.Trim();
                    pEmpleado.Provincia = txtProvincia.Text.Trim();
                    pEmpleado.Pais = txtPaisNatal.Text.Trim();
                    pEmpleado.Correo = txtCorreo.Text.Trim();
                    pEmpleado.Usuario = txtUsuario.Text.Trim();
                    pEmpleado.Contraseña = txtContra.Text.Trim();

                    int resultado = EmpleadoC.Agregar(pEmpleado);
                    if (resultado > 0)
                    {
                        FrmCorrecto.confirmacionForm("AGREGADO");
                        txtPrimerNombre.Text = "";
                        txtSegundoNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtRolEmpleado.Text = "";
                        cbxTipoIdentificacion.SelectedIndex = -1;
                        txtIdentificacion.Text = "";
                        cbxSexo.SelectedIndex = -1;
                        txtTelefono.Text = "";
                        txtDireccion.Text = "";
                        txtCiudad.Text = "";
                        txtProvincia.Text = "";
                        txtPaisNatal.Text = "";
                        txtCorreo.Text = "";
                        txtUsuario.Text = "";
                        txtContra.Text = "";
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
                    string Query = "update hostal.empleado set PrimerNombre='" + this.txtPrimerNombre.Text + "',SegundoNombre='" + this.txtSegundoNombre.Text + "',PrimerApellido='" + this.txtPrimerApellido.Text + "',SegundoApellido='" + this.txtSegundoApellido.Text + "' where IdEmpleado='" + this.txtIdEmpleado.Text + "';";
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

        public void ObtenerDatos(string IdEmpleado, string PrimerNombre, string SegundoNombre, string PrimerApellido, string RolEmpleado,
            string TipoDocumento, string NumDocumento,
            string Telefono, string Pais, string Correo)
        {
            editar = true;
            txtIdEmpleado.Text = IdEmpleado;
            txtPrimerNombre.Text = PrimerNombre;
            txtSegundoNombre.Text = SegundoNombre;
            txtPrimerApellido.Text = PrimerApellido;
            txtRolEmpleado.Text = RolEmpleado;
            //txtSegundoApellido.Text = SegundoApellido;
            //cbxSexo.Text = Sexo;
            //cbxCompania.Text = Compañia;
            //txtNombreCompania.Text = NombreCompañia;
            txtCorreo.Text = Correo;
            txtIdentificacion.Text = NumDocumento;
            cbxTipoIdentificacion.Text = TipoDocumento;
            txtTelefono.Text = Telefono;
            //txtDireccion.Text = Direccion;
            txtPaisNatal.Text = Pais;
            //txtProvincia.Text = Provincia;
            //txtCiudad.Text = Ciudad;
        }

        private void TxtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e, txtPrimerNombre);
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if( validar.ValidarEmail(txtCorreo.Text) == true)
            {
                errorProviderCorreo.Clear();
            }
          
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (validar.ValidarEmail(txtCorreo.Text) == true)
            {
                errorProviderCorreo.Clear();
            }
            else
            {
                errorProviderCorreo.SetError(this.txtCorreo, "Por favor ingresar un email válido.");
            }
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (cbxTipoIdentificacion.Text == "Pasaporte")
            {
                validar.ValidarPasaporte(e, txtIdentificacion);

            }
        }

        private void TxtIdentificacion_Leave(object sender, EventArgs e)
        {
          
           
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (cbxTipoIdentificacion.Text == "Cédula")
            {
                if (validar.ValidarCedula(txtIdentificacion.Text) == true)
                {
                    errorProviderIdentificacion.Clear();
                }
                else
                {
                    errorProviderIdentificacion.SetError(this.txtIdentificacion, "Por favor ingresar un número de cédula válido.");
                }
            }
        }

        private void TxtPaisNatal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e,txtPaisNatal);
        }
    }
}

