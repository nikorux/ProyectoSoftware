﻿using System;
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
                    MessageBox.Show("Falta ingresar algunos datos");
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

                    int resultado = EmpleadoC.Agregar(pEmpleado);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Empleado guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
