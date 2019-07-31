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
    public partial class ConfigurarTipoHabitacion : UserControl
    {
        TipoHabitacion obj = new TipoHabitacion();
        private static ConfigurarTipoHabitacion _instance;
        TipoHabitacion tipohab = new TipoHabitacion();
        public static ConfigurarTipoHabitacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarTipoHabitacion();
                return _instance;
            }
        }

        public ConfigurarTipoHabitacion()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost; database=hostal; Uid=root; pwd=root");

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "UPDATE tipo_habitacion SET IsDeleted = 1 WHERE IdTipoHab = " + txtIdTipoHab.Text;
                connection.Open();
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("El tipo de habitación ha sido eliminado.");
                    dgvTipoHabitacion.DataSource = null;
                    dgvTipoHabitacion.DataSource = obj.VistaTabla();
                    //string query = "UPDATE reservacion SET IsDeleted = 1, DeletedDate=@CurrentDate WHERE IdHuesped = @IdHuesped";
                }
                else
                {
                    MessageBox.Show("El tipo de habitación no ha podido ser eliminado.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            txtTipoHabitacion.Text = "";

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                TipoHabitacion pNombreTipoHab = new TipoHabitacion();
                pNombreTipoHab.NombreTipoHab = txtTipoHabitacion.Text.Trim();

                int resultado = TipoHabitacionC.Agregar(pNombreTipoHab);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de habitación", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTipoHabitacion.DataSource = null;
                    dgvTipoHabitacion.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido crear un nuevo tipo de habitación", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost; database=hostal; Uid=root; pwd=root";
                string Query = "update hostal.tipo_habitacion set NombreTipoHab='" + this.txtTipoHabitacion.Text + "' where IdTipoHab='" + this.txtIdTipoHab.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                dgvTipoHabitacion.DataSource = null;
                MessageBox.Show("El tipo de habitación ha sido modificado.");
                dgvTipoHabitacion.DataSource = obj.VistaTabla();
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

        private void TxtTipoHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarTipoHabitacion_Load(object sender, EventArgs e)
        {
            dgvTipoHabitacion.DataSource = obj.VistaTabla();

        }

        private void DgvTipoHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoHabitacion.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTipoHabitacion.Rows[e.RowIndex];

                txtTipoHabitacion.Text = row.Cells["NombreTipoHab"].Value.ToString();
                txtIdTipoHab.Text = row.Cells["IdTipoHab"].Value.ToString();

            }

        }

        private void DgvTipoHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoHabitacion.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTipoHabitacion.Rows[e.RowIndex];

                txtTipoHabitacion.Text = row.Cells["NombreTipoHab"].Value.ToString();
                txtIdTipoHab.Text = row.Cells["IdTipoHab"].Value.ToString();

            }
        }
    }
}
