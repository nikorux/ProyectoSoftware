using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class RegistrarReceta : Form
    {
        private static RegistrarReceta _instanceLP;
        public static RegistrarReceta InstanceLP
        {
            get
            {
                if (_instanceLP == null)
                    _instanceLP = new RegistrarReceta("NombreProducto", 0);
                return _instanceLP;
            }
        }

        Mostrador mostrador = new Mostrador();
        Receta receta = new Receta();

        public int idInsumo { get; set; }
        public int idReceta { get; set; }

        public RegistrarReceta(string nombreReceta, int IdInsumo)
        {
            InitializeComponent();
            dgvProductosEnInventario.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            txtNombre.Text = nombreReceta;
            pnlMedidaEnReceta.Visible = false;
            idInsumo = IdInsumo;
            int cantRecetas = receta.CountRecetasRegistradas();
            if(cantRecetas == 0)
            {
                idReceta = 1;
            }
            if(IdInsumo != 0)
            {
                idReceta = receta.SearchIdRecetaDelIdInsumo(IdInsumo);
            }            
        }

        public void Clear()
        {
            txtDescripcion.Text = "";
            txtComentario.Text = "";
            nudCantidad.Value = 0;
            cbxUnidadMedida.SelectedIndex = 0;
        }

        private void BtnAgregarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            string unidadMedidaInsumo = null;
            if (dgvProductosEnInventario.SelectedRows.Count > 0)
            {
                pnlMedidaEnReceta.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la lista 'Productos en Inventario'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            unidadMedidaInsumo = dgvProductosEnInventario.CurrentRow.Cells[2].Value.ToString();
            if (unidadMedidaInsumo == "Cuchara de té" || unidadMedidaInsumo == "Cuchara de madera" ||
               unidadMedidaInsumo == "Onza fluida" || unidadMedidaInsumo == "Taza" ||
               unidadMedidaInsumo == "Medio litro" || unidadMedidaInsumo == "Cuarto de galón" ||
               unidadMedidaInsumo == "Galón" || unidadMedidaInsumo == "Barril" ||
               unidadMedidaInsumo == "Mililitros" || unidadMedidaInsumo == "Litros")
            {
                cbxUnidadMedida.Items.Clear();
                cbxUnidadMedida.Items.Add("Cuchara de té");
                cbxUnidadMedida.Items.Add("Cuchara de madera");
                cbxUnidadMedida.Items.Add("Onza fluida");
                cbxUnidadMedida.Items.Add("Taza");
                cbxUnidadMedida.Items.Add("Medio litro");
                cbxUnidadMedida.Items.Add("Cuarto de galón");
                cbxUnidadMedida.Items.Add("Galón");
                cbxUnidadMedida.Items.Add("Barril");
                cbxUnidadMedida.Items.Add("Mililitros");
                cbxUnidadMedida.Items.Add("Litros");
            }
            else
            {
                cbxUnidadMedida.Items.Clear();
                cbxUnidadMedida.Items.Add("Grano");
                cbxUnidadMedida.Items.Add("Onza");
                cbxUnidadMedida.Items.Add("Libra");
                cbxUnidadMedida.Items.Add("Kilogramo");
                cbxUnidadMedida.Items.Add("Miligramo");
                cbxUnidadMedida.Items.Add("Gramo");
            }
        }

        private void BtnMedidaMedida_MouseClick(object sender, MouseEventArgs e)
        {
            nudCantidad.Value = 0;
            cbxUnidadMedida.Text = "";
            pnlMedidaEnReceta.Visible = false;
        }

        Producto producto = new Producto();
        public static int cont = 0;

        private void BtnAceptarMedida_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProductosEnReceta.AllowUserToAddRows = false;

            int n = dgvProductosEnReceta.Rows.Add();

            /*int IdInsumo = Convert.ToInt32(dgvProductosEnReceta.CurrentRow.Cells[0].Value);
            float PrecioVenta = Convert.ToInt32(dgvProductosEnReceta.CurrentRow.Cells[3].Value);
            string unidadMedida = cbxUnidadMedida.Text;
            int CantidadComprada = Convert.ToInt32(dgvProductosEnReceta.CurrentRow.Cells[2].Value);*/

            dgvProductosEnReceta.Rows[n].Cells[0].Value = dgvProductosEnInventario.CurrentRow.Cells[1].Value.ToString();
            dgvProductosEnReceta.Rows[n].Cells[1].Value = nudCantidad.Value.ToString();
            dgvProductosEnReceta.Rows[n].Cells[2].Value = cbxUnidadMedida.SelectedItem.ToString();
            dgvProductosEnReceta.Rows[n].Cells[3].Value = dgvProductosEnInventario.CurrentRow.Cells[0].Value.ToString();

            Clear();
            pnlMedidaEnReceta.Visible = false;
        }

        private void RegistrarReceta_Load(object sender, EventArgs e)
        {
            if (idInsumo != 0)
            {
                int idReceta = receta.SearchIdRecetaDelIdInsumo(idInsumo);
                txtComentario.Text = receta.getDetallesReceta("Comentario", idReceta);
                txtDescripcion.Text = receta.getDetallesReceta("Descripcion", idReceta);
                if (idInsumo != 0)
                {
                    dgvProductosEnReceta.DataSource = receta.SearchProductosEnReceta(idInsumo);
                }
            }
            else
            {
                txtComentario.Text = "" ;
                txtDescripcion.Text = "";
            }
        }

        private void BtnAceptarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProductosEnReceta.AllowUserToAddRows = false;

            if (idInsumo == 0)
            {
                //insert new recipe
                try
                {
                    //tabla 'receta'
                    receta.NombreReceta_receta = txtNombre.Text;
                    receta.DescripcionReceta_receta = txtDescripcion.Text;
                    receta.ComentarioReceta_receta = txtComentario.Text;
                    receta.IdInsumo_receta = receta.SearchIdINSUMOLastRecord();

                    if (receta.InsertEnTablaReceta(receta) == true)
                    {
                        receta.IdReceta_receta = receta.SearchIdRECETALastRecord();

                        //tabla 'insumo_receta'
                        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hostal;Uid=root;Pwd=root;");
                        for (int i = 0; i < dgvProductosEnReceta.Rows.Count - 1; i++)
                        {
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO insumo_receta (IdReceta, IdInsumo, CantidadInsumo, UnidadMedida) VALUES ('"+ receta.IdReceta_receta +"','" + dgvProductosEnReceta.Rows[i].Cells[3]+"','"+ "','"+dgvProductosEnReceta.Rows[i].Cells[1]+ "','"+dgvProductosEnReceta.Rows[i].Cells[2]+ "'");
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        /*foreach (DataGridViewRow row in dgvProductosEnReceta.Rows)
                        {
                            int n = dgvProductosEnReceta.Rows.Add();
                            receta.CantidadInsumo_InsumoReceta = Convert.ToInt32(dgvProductosEnReceta.Rows[n].Cells[1].Value);
                            receta.UnidadMedida_InsumoReceta = dgvProductosEnReceta.Rows[n].Cells[2].Value.ToString();
                            receta.IdInsumo_InsumoReceta = Convert.ToInt32(dgvProductosEnReceta.Rows[n].Cells[3].Value);
                            receta.InsertEnTablaInsumoReceta(receta);
                        }*/
                        Clear();
                    }
                    producto.UpdateInsumoTieneReceta(idInsumo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                pnlMedidaEnReceta.Visible = false;
                dgvProductosEnReceta.DataSource = receta.SearchProductosEnReceta(receta.IdReceta_InsumoReceta);
            }
            else
            {
                //update recipe
                try
                {
                    if (receta.UpdateEnTablaInsumoReceta(receta, idReceta, idInsumo) == true)
                    {
                        txtDescripcion.Text = "";
                        txtComentario.Text = "";
                        nudCantidad.Value = 0;
                        cbxUnidadMedida.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                pnlMedidaEnReceta.Visible = false;
                //dgvProductosEnReceta.DataSource = receta.SearchProductosEnReceta(receta.IdReceta_InsumoReceta);
            }            
        }

        private void BtnRemoverDeReceta_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosEnReceta.SelectedRows.Count > 0)
            {
                DialogResult ans = MessageBox.Show("Desea remover " + dgvProductosEnReceta.CurrentRow.Cells[1].Value.ToString() + " de la receta?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ans == DialogResult.Yes)
                {
                    try
                    {
                        int ingrediente = Convert.ToInt32(dgvProductosEnReceta.CurrentRow.Cells[0].Value);
                        MessageBox.Show("" + idReceta);
                        if (receta.Delete(idReceta) == true);
                        else
                        {
                            MessageBox.Show("Error al eliminar producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al borrar el producto. (Error: " + ex + ")");
                    }
                }

                dgvProductosEnReceta.DataSource = receta.SearchProductosEnReceta(receta.IdReceta_InsumoReceta);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}