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
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Huesped guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvclie.DataSource = null;
                    //dgvHuespedes.DataSource = obj.VistaTabla();
                    Huesped limpiar = new Huesped();
                    limpiar.BorrarCampos(this, groupBox1);
                    //cbxTipoIdentificacion.Items.Clear();
                    //cbxTipoIdentificacion.SelectedIndex = 0;
                   

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el huesped", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void RegistroNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void RegistroNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

