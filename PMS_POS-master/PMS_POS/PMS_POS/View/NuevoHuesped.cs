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
    public partial class NuevoHuesped : UserControl
    {
        Huesped obj = new Huesped();

        private static NuevoHuesped __instante;

        public static NuevoHuesped Instance
        {
            get
            {
                if (__instante == null)
                    __instante = new NuevoHuesped();
                return __instante;
            }
        }
        public NuevoHuesped()
        {
            InitializeComponent();
        }


        private void NuevoHuesped_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
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
                dgvHuespedes.DataSource = null;
                dgvHuespedes.DataSource = obj.VistaTabla();
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

        private void NuevoHuesped_Load_1(object sender, EventArgs e)
        {
            dgvHuespedes.Visible = false;
            txtFiltro.Visible = false;

            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; database = hostal; Uid = root; pwd = root");

                    string selectQuery = "SELECT * FROM documento";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxTipoIdentificacion.Items.Add(reader.GetString("NombreDocumento"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //dgvHuespedes.DataSource = obj.VistaTabla();
            //dgvHuespedes.Columns[0].Visible = false;

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {

                dgvHuespedes.CurrentCell = null;
                foreach (DataGridViewRow n in dgvHuespedes.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvHuespedes.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtFiltro.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvHuespedes.DataSource = obj.VistaTabla();
            }

        }

        private void dgvHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                /*if (e.RowIndex >= 0)
                  {
                      DataGridViewRow row = this.dgvHuespedes.Rows[e.RowIndex];

                      txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                      txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                      txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                      txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                      //numCantCamas.Value = Convert.ToInt32(dgvHab.CurrentRow.Cells[3].Value);
                      //Compania.Value = Convert.ToInt32(dgvHuespedes.CurrentRow.Cells[3].Value);
                      txtNombreCompania.Text = row.Cells["NombreCompañia"].Value.ToString();
                      cbxTipoIdentificacion.Text = row.Cells["TipoDocumento"].Value.ToString();
                      txtIdentificacion.Text = row.Cells["NumDocumento"].Value.ToString();
                      Sexo = row.Cells["Sexo"].Value.ToString();
                      txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                      txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                      txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
                      txtProvincia.Text = row.Cells["Provincia"].Value.ToString();
                      txtPaisNatal.Text = row.Cells["Pais"].Value.ToString();
                      txtCorreo.Text = row.Cells["Correo"].Value.ToString();


                  }*/
            }



        }

        private void dgvHuespedes_DoubleClick(object sender, EventArgs e)
        {

            /*
            if (dgvHuespedes.CurrentRow.Index != -1)
            {
                txtPrimerNombre.Text = dgvHuespedes.CurrentRow.Cells[1].Value.ToString();
                txtSegundoNombre.Text = dgvHuespedes.CurrentRow.Cells[2].Value.ToString();
                txtPrimerApellido.Text = dgvHuespedes.CurrentRow.Cells[3].Value.ToString();
                txtSegundoApellido.Text = dgvHuespedes.CurrentRow.Cells[4].Value.ToString();
                Compania = dgvHuespedes.CurrentRow.Cells[3].ToString();
                txtNombreCompania.Text = dgvHuespedes.CurrentRow.Cells[6].Value.ToString();
                cbxTipoIdentificacion.Text = dgvHuespedes.CurrentRow.Cells[7].Value.ToString();
                txtIdentificacion.Text = dgvHuespedes.CurrentRow.Cells[8].Value.ToString();
                Sexo = dgvHuespedes.CurrentRow.Cells[9].Value.ToString();
                txtTelefono.Text = dgvHuespedes.CurrentRow.Cells[10].Value.ToString();
                txtDireccion.Text = dgvHuespedes.CurrentRow.Cells[11].Value.ToString();
                txtCiudad.Text = dgvHuespedes.CurrentRow.Cells[12].Value.ToString();
                txtProvincia.Text = dgvHuespedes.CurrentRow.Cells[13].Value.ToString();
                txtPaisNatal.Text = dgvHuespedes.CurrentRow.Cells[14].Value.ToString();
                txtCorreo.Text = dgvHuespedes.CurrentRow.Cells[15].Value.ToString();
                btnGuardar.Text = "Update";
            }*/



        }

        private void DgvHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}