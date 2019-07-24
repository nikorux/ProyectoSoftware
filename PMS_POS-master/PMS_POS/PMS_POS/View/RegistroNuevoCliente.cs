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
                if (this.txtPrimerNombre.Text == string.Empty || this.txtSegundoNombre.Text == string.Empty || this.txtPrimerApellido.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar algunos datos");
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
                        MessageBox.Show("Cliente guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dgvclie.DataSource = null;
                        //dgvHuespedes.DataSource = obj.VistaTabla();
                        Huesped limpiar = new Huesped();
                        //limpiar.BorrarCampos(this, groupBox1);
                        //cbxTipoIdentificacion.Items.Clear();
                        //cbxTipoIdentificacion.SelectedIndex = 0;


                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void ObtenerDatos(string IdHuesped, string PrimerNombre, string SegundoNombre, string PrimerApellido,
            string TipoDocumento, string NumDocumento,
            string Telefono, string Pais, string Correo)
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
            txtCorreo.Text = Correo;
            txtIdentificacion.Text = NumDocumento;
            cbxTipoIdentificacion.Text = TipoDocumento;
            txtTelefono.Text = Telefono;
            //txtDireccion.Text = Direccion;
            txtPaisNatal.Text = Pais;
            //txtProvincia.Text = Provincia;
            //txtCiudad.Text = Ciudad;
        }


    }
}

