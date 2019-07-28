using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Model;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace PMS_POS.View
{
    public partial class ListadoProducto : UserControl
    {
        //instancia que llama al user control ListadoProducto
        private static ListadoProducto _instanceLP;
        public static ListadoProducto InstanceLP
        {
            get
            {
                if (_instanceLP == null)
                    _instanceLP = new ListadoProducto("ListadoProducto");
                return _instanceLP;
            }
        }

        public void Clear()
        {
            cbxCategoriaRP.Text = "";
            cbxUnidadMedida.Text = "";
            txtNombreProducto.Text = "";
            cbxProveedor.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
            chxAplicarITBIS.Checked = false;
            cbxCategoria.Text = "";
            txtPrecioVenta.Text = "";
            nudCantidadActual.Value = 0;
            nudCantidadMinima.Value = 0;
            nudCantidadMaxima.Value = 0;
            cbxUnidadMedida.Text = "";
        }

        //instancia que llama al user control RegistroProducto
        private static ListadoProducto _instanceRP;
        public static ListadoProducto InstanceRP
        {
            get
            {
                if (_instanceRP == null)
                    _instanceRP = new ListadoProducto("NuevoProducto");
                return _instanceRP;
            }
        }

        Producto producto = new Producto();
        UnidadMedida unidadMedida = new UnidadMedida();
        PosForm posForm = new PosForm();

        //Cuando el MainScreen llama a Listado producto, manda una variable string (showUC) con el nombre del UserControl a mostrar
        public ListadoProducto(string showUC)
        {
            InitializeComponent();
            if (showUC == "ListadoProducto")
            {
                splitContainer1.Panel2Collapsed = true;
                btnGoBack.Visible = true;
            }
            if (showUC == "NuevoProducto")
            {
                lblTitulo.Text = "Nuevo Producto";
                btnEditarP.Visible = false;
                btnGuardar.Visible = true;
                splitContainer1.Panel1Collapsed = true;
                btnGoBack.Visible = false;
            }
            dgvProductos.DataSource = producto.Select();
            this.dgvProductos.DefaultCellStyle.Font = new Font("SansSerif", 10);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("SansSerif", 10);
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[13].Visible = false;
            dgvProductos.Columns[14].Visible = false;
            dgvProductos.Columns[15].Visible = false;
            dgvProductos.Columns[16].Visible = false;
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            pnlAjustarStock.Visible = false;
            pnlOpcionesRegistroProducto.Visible = false;
            pnlOpcionesRegistroProducto.BringToFront();

            cbxUnidadMedida.Items.Clear();
            cbxUnidadMedida.Items.Add("Grano");
            cbxUnidadMedida.Items.Add("Onza");
            cbxUnidadMedida.Items.Add("Libra");
            cbxUnidadMedida.Items.Add("Kilogramo");
            cbxUnidadMedida.Items.Add("Miligramo");
            cbxUnidadMedida.Items.Add("Gramo");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            btnEditarP.Visible = true;
            if(producto.CheckSiProductTieneReceta(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString())) == 0)
            {
                btnAgregarReceta.Visible = true;
            }
            else
            {
                btnEditarReceta.Visible = true;
            }
            btnGuardar.Visible = false;

            if (dgvProductos.SelectedRows.Count > 0)
            {
                lblTitulo.Text = "Editar Producto";
                splitContainer1.Panel1Collapsed = true;
                if(float.Parse(dgvProductos.CurrentRow.Cells[7].Value.ToString()) != 1)
                {
                    chxAplicarITBIS.Checked = true;
                }
                if (float.Parse(dgvProductos.CurrentRow.Cells[7].Value.ToString()) == 1)
                {
                    chxAplicarITBIS.Checked = false;
                }
                producto.IdInsumo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                cbxProveedor.Text = producto.SelectNombreCompaniaFROMIdProveedor(Convert.ToInt32(dgvProductos.CurrentRow.Cells[4].Value.ToString()));
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                cbxCategoriaRP.Text = producto.SelectNombreCategoriaFROMIdCategoria(Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value.ToString()));
                txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();
                nudCantidadActual.Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells[9].Value);
                nudCantidadMinima.Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells[10].Value);
                nudCantidadMaxima.Text = dgvProductos.CurrentRow.Cells[11].Value.ToString();
                cbxUnidadMedida.Text = dgvProductos.CurrentRow.Cells[12].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = false;

            if (txtBuscarProducto.Text != "")
            {

                dgvProductos.CurrentCell = null;
                foreach (DataGridViewRow n in dgvProductos.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvProductos.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarProducto.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvProductos.DataSource = producto.Select();
            }
        }

        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProducto.Text = string.Empty;
        }

        private void ListadoProducto_Load(object sender, EventArgs e)
        {            
            try
            {
                //COMBOBOX DISPLAY CATEGORIA
                MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryCategoria = "SELECT NombreCategoria FROM categoria";
                connectionCategoria.Open();
                MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
                MySqlDataReader readerCategoria = command.ExecuteReader();
                while (readerCategoria.Read())
                {
                    cbxCategoria.Items.Add(readerCategoria.GetString("NombreCategoria"));
                    cbxCategoriaRP.Items.Add(readerCategoria.GetString("NombreCategoria"));
                }
                connectionCategoria.Close();

                //COMBOBOX DISPLAY PROVEEDORES
                MySqlConnection connectionProveedores = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryProveedores = "SELECT NombreInsumo FROM insumo";
                connectionProveedores.Open();
                MySqlCommand commandProveedores = new MySqlCommand(queryProveedores, connectionProveedores);
                MySqlDataReader readerP = commandProveedores.ExecuteReader();
                while (readerP.Read())
                {
                    cbxProveedor.Items.Add(readerP.GetString("NombreCompañia"));
                    cbxBuscarProveedor.Items.Add(readerP.GetString("NombreCompañia"));
                }
                connectionProveedores.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Clear();
            splitContainer1.Panel2Collapsed = true;
            dgvProductos.DataSource = producto.Select();            
        }

        public void Guardar(int EnMostrador)
        {
            try
            {
                if (this.txtNombreProducto.Text == string.Empty || this.cbxProveedor.SelectedItem == null ||
                    this.txtDescripcion.Text == string.Empty || this.txtPrecioCompra.Text == string.Empty ||
                    this.txtPrecioVenta.Text == string.Empty || nudCantidadActual.Value == 0 ||
                    this.nudCantidadMinima.Value == 0 || this.nudCantidadMaxima.Value == 0 ||
                    this.cbxUnidadMedida.SelectedItem == null || this.cbxCategoriaRP.SelectedItem == null || 
                    nudCantidadMaxima.Value < nudCantidadMinima.Value)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    producto.NombreInsumo = txtNombreProducto.Text;
                    producto.IdProveedor = producto.SelectIdProveedorFROMnombreCompania(cbxProveedor.SelectedItem.ToString());
                    producto.DescripcionInsumo = txtDescripcion.Text;
                    producto.PrecioCompra = float.Parse(txtPrecioCompra.Text);
                    producto.IdCategoria = producto.SelectIdCategoria(cbxCategoriaRP.SelectedItem.ToString());
                    producto.PrecioVenta = float.Parse(string.Format("{0:0.00}", txtPrecioVenta.Text));
                    producto.CantActual = Convert.ToInt32(nudCantidadActual.Value);
                    producto.CantMinima = Convert.ToInt32(nudCantidadMinima.Value);
                    producto.CantMaxima = Convert.ToInt32(nudCantidadMaxima.Value);
                    producto.UnidadMedida = cbxUnidadMedida.Text;
                    if (chxAplicarITBIS.Checked == true)
                    {
                        producto.Impuesto = float.Parse(txtPrecioVenta.Text) * 0.18f;
                        producto.PorcientoImpuesto = 0.18f;
                    }
                    if (chxAplicarITBIS.Checked == false)
                    {
                        producto.Impuesto = 0;
                        producto.PorcientoImpuesto = 0;
                    }
                    if (producto.Insert(producto, EnMostrador) == true)
                    {
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlOpcionesRegistroProducto.Visible = true;
            pnlOpcionesRegistroProducto.BringToFront();
        }

        public static float precioRegistrado;

        private void BtnEditarP_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                producto.IdInsumo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                producto.NombreInsumo = txtNombreProducto.Text;
                producto.IdProveedor = producto.SelectIdProveedorFROMnombreCompania(cbxProveedor.SelectedItem.ToString());
                producto.DescripcionInsumo = txtDescripcion.Text;
                producto.PrecioCompra = float.Parse(txtPrecioCompra.Text);
                producto.IdCategoria = producto.SelectIdCategoria(cbxCategoriaRP.SelectedItem.ToString());
                producto.PrecioVenta = precioRegistrado = float.Parse(string.Format("{0:0.00}", txtPrecioVenta.Text));
                producto.CantActual = Convert.ToInt32(nudCantidadActual.Value);
                producto.CantMinima = Convert.ToInt32(nudCantidadMinima.Value);
                producto.CantMaxima = Convert.ToInt32(nudCantidadMaxima.Value);
                producto.UnidadMedida = cbxUnidadMedida.Text;
                if (chxAplicarITBIS.Checked == true)
                {
                    producto.Impuesto = (float)nudCantidadActual.Value * 0.18f;
                    producto.PorcientoImpuesto = 0.18f;
                }
                if (chxAplicarITBIS.Checked == false)
                {
                    producto.Impuesto = 1;
                    producto.PorcientoImpuesto = 1;
                }

                if (producto.Update(producto) == true)
                {
                    cbxCategoriaRP.Text = "";
                    cbxUnidadMedida.Text = "";
                    txtNombreProducto.Text = "";
                    cbxProveedor.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecioCompra.Text = "";
                    chxAplicarITBIS.Checked = false;
                    cbxCategoria.SelectedIndex = 0;
                    txtPrecioVenta.Text = "";
                    nudCantidadActual.Value = 0;
                    nudCantidadMinima.Value = 0;
                    nudCantidadMaxima.Value = 0;
                    cbxUnidadMedida.SelectedIndex = 0;
                    MessageBox.Show("El producto ha sido editado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }
        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCategoria.Text == "Todas")
            {
                dgvProductos.DataSource = producto.Select();
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[13].Visible = false;
                dgvProductos.Columns[14].Visible = false;
                dgvProductos.Columns[2].Visible = false;
                dgvProductos.Columns[6].Visible = false;
            }
            else
            {
                dgvProductos.DataSource = producto.FiltrarPORcategoria(cbxCategoria.SelectedItem.ToString());
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[13].Visible = false;
                dgvProductos.Columns[14].Visible = false;
                dgvProductos.Columns[2].Visible = false;
                dgvProductos.Columns[6].Visible = false;

            }
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtPrecioVenta.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 46 && ch != 127 && ch != 08)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (txtPrecioVenta.Text.Length == 0) e.Handled = true;
            }
        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetterOrDigit(ch) && ch != 127 && ch != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecioCompra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtPrecioCompra.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 46 && ch != 127 && ch != 08)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (txtPrecioCompra.Text.Length == 0) e.Handled = true;
            }
        }

        private void BtnCancelarAjuste_Click(object sender, EventArgs e)
        {
            pnlAjustarStock.Visible = false;
        }

        private void BtnAjustarStock_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                pnlAjustarStock.Visible = true;
                lblNombreProductoAjustar.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGuardarAjuste_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.cbxAccionAjuste.Text == string.Empty || this.nudCantidadAjustar.Value == 0 ||
                       this.cbxUnidadMedidaAjustar.Text == string.Empty )
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ajustar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idAjuste = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                    int CantidadAjuste = Convert.ToInt32(nudCantidadAjustar.Value);
                    unidadMedida.Nombre = cbxUnidadMedidaAjustar.Text;
                    float CantidadCalculada = 0;
                    if (cbxAccionAjuste.Text == "Aumentar")
                    {
                        CantidadCalculada = float.Parse(dgvProductos.CurrentRow.Cells[9].Value.ToString()) + unidadMedida.Conversion(dgvProductos.CurrentRow.Cells[12].Value.ToString(), CantidadAjuste);
                    }
                    if (cbxAccionAjuste.Text == "Disminuir")
                    {
                        CantidadCalculada = (float)dgvProductos.CurrentRow.Cells[9].Value - unidadMedida.Conversion(cbxUnidadMedidaAjustar.Text, CantidadAjuste);
                    }

                    if (producto.UpdateAjusteStock(idAjuste, CantidadCalculada) == true)
                    {
                        cbxUnidadMedidaAjustar.Text = "";
                        nudCantidadAjustar.Value = 0;
                        MessageBox.Show("Ajuste de stock exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al ajustar stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pnlAjustarStock.Visible = false;
                    dgvProductos.DataSource = producto.Select();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxBuscarProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscarProveedor.Text == "Todos")
            {
                dgvProductos.DataSource = producto.Select();
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[13].Visible = false;
                dgvProductos.Columns[14].Visible = false;
                dgvProductos.Columns[2].Visible = false;
                dgvProductos.Columns[4].Visible = false;
                dgvProductos.Columns[6].Visible = false;
            }
            else
            {
                dgvProductos.DataSource = producto.FiltrarPORproveedor(cbxBuscarProveedor.SelectedItem.ToString());
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[13].Visible = false;
                dgvProductos.Columns[14].Visible = false;
                dgvProductos.Columns[2].Visible = false;
                dgvProductos.Columns[4].Visible = false;
                dgvProductos.Columns[6].Visible = false;
            }
        }

        private void BtnProductoMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            Guardar(1);

            DialogResult result3 = MessageBox.Show("Este producto requiere receta?","Detalles producto",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                RegistrarReceta receta = new RegistrarReceta(txtNombreProducto.Text, 0);
                receta.Show();
            }

            pnlOpcionesRegistroProducto.Visible = false;
        }

        private void BtnNuevoProducto_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            lblTitulo.Text = "Nuevo Producto";
            btnEditarP.Visible = false;
            btnGuardar.Visible = true;
            btnAgregarReceta.Visible = false;
            btnEditarReceta.Visible = false;
            pnlOpcionesRegistroProducto.Visible = false;
        }

        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlOpcionesRegistroProducto.Visible = false;
        }

        private void BtnProductoAInventario_MouseClick(object sender, MouseEventArgs e)
        {
            Guardar(0);

            DialogResult result3 = MessageBox.Show("Este producto requiere receta?", "Detalles producto",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                RegistrarReceta receta = new RegistrarReceta(producto.NombreInsumo, 0);
                receta.Show();
            }

            pnlOpcionesRegistroProducto.Visible = false;
        }

        private void BtnEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult ans = MessageBox.Show("Desea borrar " + dgvProductos.CurrentRow.Cells[1].Value.ToString() + " del inventario?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ans == DialogResult.Yes)
                {
                    try
                    {
                        producto.IdInsumo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                        if (producto.Delete(producto) == true);
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
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvProductos.DataSource = producto.Select();
        }
        private void BtnAgregarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            RegistrarReceta receta = new RegistrarReceta(txtNombreProducto.Text, 0);
            receta.Show();
        }

        private void ChkProductoLiquido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProductoLiquido.Checked == true)
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

        private void BtnEditarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            RegistrarReceta receta = new RegistrarReceta(txtNombreProducto.Text, Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
            receta.Show();
        }
    }
}