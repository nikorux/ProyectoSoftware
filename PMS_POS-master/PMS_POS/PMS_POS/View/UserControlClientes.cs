﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class UserControlClientes : UserControl
    {
        //MySqlConnection conex;
        MySqlConnection conex;
        string cadenaconex;
        Huesped obj = new Huesped();
        RegistroNuevoCliente form2 = new RegistroNuevoCliente();

        private static UserControlClientes _instance;
        public static UserControlClientes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlClientes();
                return _instance;
            }
        }


        public UserControlClientes()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            /*Form formulario = new RegistroNuevoCliente();
            formulario.Show();*/

            RegistroNuevoCliente form2 = new RegistroNuevoCliente();
            form2.FormClosed += new FormClosedEventHandler(RegistroNuevoCliente_FormClosed);
            form2.ShowDialog();

        }

        public void RefreshGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = obj.VistaTabla();
        }

        private void UserControlClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = obj.VistaTabla();
        }
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
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

        private void TxtFiltroo_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtFiltroo.Text != "")
                {

                    dgvClientes.CurrentCell = null;
                    foreach (DataGridViewRow n in dgvClientes.Rows)
                    {
                        n.Visible = false;
                    }
                    foreach (DataGridViewRow n in dgvClientes.Rows)
                    {
                        foreach (DataGridViewCell m in n.Cells)
                        {
                            if ((m.Value.ToString().ToUpper().IndexOf(txtFiltroo.Text.ToUpper()) == 0))
                            {
                                n.Visible = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    dgvClientes.DataSource = obj.VistaTabla();
                }

            }

        }

        private void RegistroNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void RegistroNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
