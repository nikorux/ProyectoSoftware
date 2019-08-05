using System;
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
    public partial class ConfigurarTipoDocumento : UserControl
    {
        MySqlConnection conex;
        string cadenaconex;
        Documento obj = new Documento();

    private static ConfigurarTipoDocumento _instance;

    public static ConfigurarTipoDocumento Instance
    {
        get
        {
            if (_instance == null)
                _instance = new ConfigurarTipoDocumento();
            return _instance;
        }
    }
        public ConfigurarTipoDocumento()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost; database=hostal; Uid=root; pwd=root");

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                Documento pDocumento = new Documento();
                pDocumento.NombreDocumento = txtNombreTipoDocumento.Text.Trim();

                int resultado = DocumentoC.Agregar(pDocumento);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de documento", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTipoDocumento.DataSource = null;
                    dgvTipoDocumento.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido crear un nuevo tipo de documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost; database=hostal; Uid=root; pwd=root";
                string Query = "update hostal.documento set NombreDocumento='" + this.txtNombreTipoDocumento.Text + "' where IdTipoDocumento='" + this.txtIdTipoDocumento.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                dgvTipoDocumento.DataSource = null;
                MessageBox.Show("El tipo de documento ha sido modificado.");
                dgvTipoDocumento.DataSource = obj.VistaTabla();
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
                try
                {
                    string deleteQuery = "UPDATE documento SET IsDeleted = 1 WHERE IdTipoDocumento = " + txtIdTipoDocumento.Text;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("El tipo de documento ha sido eliminado.");
                        dgvTipoDocumento.DataSource = null;
                        dgvTipoDocumento.DataSource = obj.VistaTabla();
                        //string query = "UPDATE reservacion SET IsDeleted = 1, DeletedDate=@CurrentDate WHERE IdHuesped = @IdHuesped";
                    }
                    else
                    {
                        MessageBox.Show("El tipo de documento no ha podido ser eliminado.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();

            txtNombreTipoDocumento.Text = "";



        }

        private void TxtNombreTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurarTipoDocumento_Load(object sender, EventArgs e)
        {
            dgvTipoDocumento.DataSource = obj.VistaTabla();
        }

        private void DgvTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreTipoDocumento.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTipoDocumento.Rows[e.RowIndex];

                txtNombreTipoDocumento.Text = row.Cells["NombreDocumento"].Value.ToString();
                txtIdTipoDocumento.Text = row.Cells["IdTipoDocumento"].Value.ToString();

            }
        }

        private void DgvTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreTipoDocumento.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTipoDocumento.Rows[e.RowIndex];

                txtNombreTipoDocumento.Text = row.Cells["NombreDocumento"].Value.ToString();
                txtIdTipoDocumento.Text = row.Cells["IdTipoDocumento"].Value.ToString();

            }
        }
    }
}
