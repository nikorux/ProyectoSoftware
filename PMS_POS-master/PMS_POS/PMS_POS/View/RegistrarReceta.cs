using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    _instanceLP = new RegistrarReceta("NombreProducto");
                return _instanceLP;
            }
        }

        Mostrador mostrador = new Mostrador();
        Receta receta = new Receta();

        public static string nombre;

        public RegistrarReceta(string nombreReceta)
        {
            InitializeComponent();
            dgvProductosEnInventario.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            txtNombre.Text = nombreReceta;
            pnlMedidaEnReceta.Visible = false;
        }

        private void BtnAgregarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosEnInventario.SelectedRows.Count > 0)
            {
                pnlMedidaEnReceta.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la lista 'Productos en Inventario'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void BtnMedidaMedida_MouseClick(object sender, MouseEventArgs e)
        {
            nudCantidad.Value = 0;
            cbxUnidadMedida.Text = "";
            chkProductoLiquido.Checked = false;
            pnlMedidaEnReceta.Visible = false;
        }

        private void BtnAceptarMedida_MouseClick(object sender, MouseEventArgs e)
        {
            //insert new recipe
            try
            {
                //tabla 'receta'
                receta.NombreReceta_receta = txtNombre.Text;
                receta.DescripcionReceta_receta = txtDescripcion.Text;
                receta.ComentarioReceta_receta = txtComentario.Text;

                //tabla 'insumo_receta'
                receta.IdReceta_InsumoReceta = receta.SearchIdRECETALastRecord();
                receta.IdInsumo_InsumoReceta = receta.SearchIdINSUMOLastRecord();
                /*
                 * Para cuando se tenga que editar
                  receta.IdInsumo_InsumoReceta = Convert.ToInt32(dgvProductosEnInventario.CurrentRow.Cells[0].Value);
                 */
                receta.CantidadInsumo_InsumoReceta = Convert.ToInt32(nudCantidad.Value);
                receta.UnidadMedida_InsumoReceta = cbxUnidadMedida.Text;

                if (receta.InsertEnTablaReceta(receta) == true && receta.InsertEnTablaInsumoReceta(receta))
                {
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtComentario.Text = "";
                    nudCantidad.Value = 0;
                    cbxUnidadMedida.SelectedIndex = 0;
                    MessageBox.Show("El producto ha sido registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pnlMedidaEnReceta.Visible = false;
            dgvProductosEnReceta.DataSource = receta.SearchProductosEnReceta();
        }

        private void RegistrarReceta_Load(object sender, EventArgs e)
        {
            cbxUnidadMedida.Items.Add("Grano");
            cbxUnidadMedida.Items.Add("Onza");
            cbxUnidadMedida.Items.Add("Libra");
            cbxUnidadMedida.Items.Add("Kilogramo");
            cbxUnidadMedida.Items.Add("Miligramo");
            cbxUnidadMedida.Items.Add("Gramo");
        }

        private void PnlMedidaEnReceta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbxUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMedidaMedida_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarMedida_Click(object sender, EventArgs e)
        {

        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarReceta_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoverDeReceta_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void DgvProductosEnReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvProductosEnInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void ChkProductoLiquido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProductoLiquido.Checked)
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
    }
}
