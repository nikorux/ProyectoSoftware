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
    public partial class ListaClientes : UserControl
    {
        //MySqlConnection conex;
        MySqlConnection conex;
        string cadenaconex;
        Huesped obj = new Huesped();
        private static ListaClientes __instante;

       
        public static ListaClientes Instance
        {
            get
            {
                if (__instante == null)
                    __instante = new ListaClientes();
                return __instante;
            }
        }

        public ListaClientes()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server = localhost; database=hostal; Uid=root; pwd=root");
        String Sexo;
        String Compania;


        private void ListaClientes_Load(object sender, EventArgs e)
        {
            dgvHuespedess.DataSource = obj.VistaTabla();

        }

        private void txtFiltroo_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtFiltroo.Text != "")
                {

                    dgvHuespedess.CurrentCell = null;
                    foreach (DataGridViewRow n in dgvHuespedess.Rows)
                    {
                        n.Visible = false;
                    }
                    foreach (DataGridViewRow n in dgvHuespedess.Rows)
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
                    dgvHuespedess.DataSource = obj.VistaTabla();
                }

            }

        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
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

        private void rbtnSexoFemenino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "F";
        }

        private void rbtnSexoMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "M";
        }

        private void rbtnEsCompania_CheckedChanged(object sender, EventArgs e)
        {
            Compania = "Sí";
        }

        private void rbtnNoCompania_CheckedChanged(object sender, EventArgs e)
        {
            Compania = "No";
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                dgvHuespedess.DataSource = null;
                dgvHuespedess.DataSource = obj.VistaTabla();
                Huesped limpiar = new Huesped();
                limpiar.BorrarCampos(this, groupBox1);
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


        private void dgvHuespedess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Enabled = true;
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgvHuespedess.Rows[e.RowIndex];

                txtIdHuesped.Text = row.Cells["IdHuesped"].Value.ToString();
                txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                cbxSexo.Text = row.Cells["Sexo"].Value.ToString();
                cbxCompania.Text = row.Cells["Compañia"].Value.ToString();
                txtNombreCompania.Text = row.Cells["NombreCompañia"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtIdentificacion.Text = row.Cells["NumDocumento"].Value.ToString();
                cbxTipoIdentificacion.Text = row.Cells["TipoDocumento"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtPais.Text = row.Cells["Pais"].Value.ToString();
                txtProvincia.Text = row.Cells["Provincia"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();

            }

        }

        private void dgvHuespedess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHuespedess.Rows[e.RowIndex];

                txtIdHuesped.Text = row.Cells["IdHuesped"].Value.ToString();
                txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                cbxSexo.Text = row.Cells["Sexo"].Value.ToString();
                cbxCompania.Text = row.Cells["Compañia"].Value.ToString();
                txtNombreCompania.Text = row.Cells["NombreCompañia"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtIdentificacion.Text = row.Cells["NumDocumento"].Value.ToString();
                cbxTipoIdentificacion.Text = row.Cells["TipoDocumento"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtPais.Text = row.Cells["Pais"].Value.ToString();
                txtProvincia.Text = row.Cells["Provincia"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    string deleteQuery = "DELETE FROM huesped WHERE IdHuesped = " + txtIdHuesped.Text;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("El cliente ha sido eliminado.");                       
                        dgvHuespedess.DataSource = null;
                        dgvHuespedess.DataSource = obj.VistaTabla();
                        //string query = "UPDATE reservacion SET IsDeleted = 1, DeletedDate=@CurrentDate WHERE IdHuesped = @IdHuesped";
                    }
                    else
                    {
                        MessageBox.Show("El cliente no ha sido eliminado.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();

            }

            txtIdHuesped.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            cbxSexo.Text = "";
            cbxCompania.Text = "";
            txtNombreCompania.Text="";
            txtCorreo.Text = "";
            txtIdentificacion.Text =
            cbxTipoIdentificacion.Text ="";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtProvincia.Text = "";
            txtCiudad.Text = "";
        }

        private void txtSegundoNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
    


  