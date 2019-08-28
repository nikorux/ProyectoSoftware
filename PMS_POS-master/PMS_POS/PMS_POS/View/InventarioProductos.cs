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
    public partial class InventarioProductos : Form
    {
        public void Clear()
        {
            cbxCategoriaRP.Text = "";
            cbxUnidadMedida.Text = "";
            txtNombreProducto.Text = "";
            cbxProveedor.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
            chxAplicarITBIS.Checked = false;
            chkProductoLiquido.Checked = false;
            cbxCategoria.Text = "";
            txtPrecioVenta.Text = "";
            nudCantidadActual.Value = 0;
            nudCantidadMinima.Value = 0;
            nudCantidadMaxima.Value = 0;
            cbxPuntosDeVentas.Text = "";
        }

        Caja caja = new Caja();
        Categoria categoria = new Categoria();
        Producto producto = new Producto();
        UnidadMedida unidadMedida = new UnidadMedida();
        PosForm posForm = new PosForm();
        static public string CajaN = null;

        public InventarioProductos(/*string showUC*/string NombreCaja)
        {
            InitializeComponent();
            
            // ------ INVENTARIO --------

            CajaN = NombreCaja;
            txtCaja.Text = CajaN;
            /*
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
            }*/
            dgvProductos.DataSource = producto.Select(CajaN);
            colorProductos();
            this.dgvProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.dgvProductos.RowTemplate.MinimumHeight = 35;

            displaydgvProductos();

            pnlAjustarStock.Visible = false;
            pnlOpcionesRegistroProducto.Visible = false;
            pnlOpcionesRegistroProducto.BringToFront();
            chkProductoEnMostrador.Visible = false;

            cbxUnidadMedida.Items.Clear();
            cbxUnidadMedida.Items.Add("Unidad");
            cbxUnidadMedida.Items.Add("Grano");
            cbxUnidadMedida.Items.Add("Onza");
            cbxUnidadMedida.Items.Add("Libra");
            cbxUnidadMedida.Items.Add("Kilogramo");
            cbxUnidadMedida.Items.Add("Miligramo");
            cbxUnidadMedida.Items.Add("Gramo");

            cbxUnidadMedidaAjustar.SelectedIndex = 0;
            nudCantidadAjustar.Value = 0;
            cbxAccionAjuste.SelectedIndex = 0;

            // ----- REGISTRO COMPRAS --------
            this.dgvProductosRegistrados.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.dgvProductosRegistrados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.dgvProductosRegistrados.RowTemplate.MinimumHeight = 35;
            LoadPrdCompra();
            LoadHistorial();
            dgvProductosRegistrados.Columns[2].Visible = false;
            dgvProductosRegistrados.Columns[3].Visible = false;
            dgvProductosRegistrados.Columns[4].Visible = false;
            dgvProductosRegistrados.Columns[5].Visible = false;
            dgvProductosRegistrados.Columns[6].Visible = false;
            dgvProductosRegistrados.Columns[7].Visible = false;
            dgvProductosRegistrados.Columns[8].Visible = false;
            dgvProductosRegistrados.Columns[9].Visible = false;
            dgvProductosRegistrados.Columns[10].Visible = false;
            dgvProductosRegistrados.Columns[11].Visible = false;
            dgvProductosRegistrados.Columns[12].Visible = false;
            dgvProductosRegistrados.Columns[13].Visible = false;
            dgvProductosRegistrados.Columns[14].Visible = false;
            dgvProductosRegistrados.Columns[15].Visible = false;
            dgvProductosRegistrados.Columns[16].Visible = false;
            dgvProductosRegistrados.Columns[17].Visible = false;

            // ---------- HISTORIAL COMPRAS ----------------
            LoadHistorialCompras();
        }

        // ------ INVENTARIO ------------

        public void colorProductos()
        {
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                float cantActual = float.Parse(dgvProductos.Rows[i].Cells[10].Value.ToString());
                float cantMinima = float.Parse(dgvProductos.Rows[i].Cells[11].Value.ToString());
                if (cantActual == 0)
                {
                    dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvProductos.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                if (cantActual == cantMinima)
                {
                    dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvProductos.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        public void displaydgvProductos()
        {
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            dgvProductos.Columns[7].Visible = false;
            dgvProductos.Columns[8].Visible = false;
            dgvProductos.Columns[14].Visible = false;
            dgvProductos.Columns[15].Visible = false;
            dgvProductos.Columns[16].Visible = false;
            dgvProductos.Columns[17].Visible = false;
        }

        private void BtnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
            btnEditarP.Visible = true;
            btnGuardar.Visible = false;
            chkProductoEnMostrador.Visible = true;

            if (dgvProductos.SelectedRows.Count > 0)
            {
                if (producto.CheckSiProductTieneReceta(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString())) == 0)
                {
                    btnAgregarReceta.Visible = true;
                }
                else
                {
                    btnEditarReceta.Visible = true;
                }

                if (Convert.ToInt32(dgvProductos.CurrentRow.Cells[15].Value.ToString()) == 0)
                {
                    chkProductoEnMostrador.Checked = false;
                }
                else
                {
                    chkProductoEnMostrador.Checked = true;
                }
                lblTitulo.Text = "Editar Producto";
                splitContainer1.Panel1Collapsed = true;
                if (float.Parse(dgvProductos.CurrentRow.Cells[7].Value.ToString()) == 0.18f)
                {
                    chxAplicarITBIS.Checked = true;
                }
                if (float.Parse(dgvProductos.CurrentRow.Cells[7].Value.ToString()) == 0)
                {
                    chxAplicarITBIS.Checked = false;
                }
                producto.IdInsumo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                cbxCategoriaRP.Text = producto.SelectNombreCategoriaFROMIdCategoria(Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value.ToString()));
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                cbxProveedor.Text = producto.SelectNombreCompaniaFROMIdProveedor(Convert.ToInt32(dgvProductos.CurrentRow.Cells[4].Value.ToString()));
                cbxPuntosDeVentas.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();

                txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells[9].Value.ToString();
                nudCantidadActual.Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells[10].Value);
                nudCantidadMinima.Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells[11].Value);
                nudCantidadMaxima.Text = dgvProductos.CurrentRow.Cells[12].Value.ToString();
                cbxUnidadMedida.Text = dgvProductos.CurrentRow.Cells[13].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = false;

            if (txtBuscarProducto.Text != "" && txtBuscarProducto.Text != "Buscar")
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
                dgvProductos.DataSource = producto.Select(CajaN);
            }
        }

        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            cbxBuscarProveedor.Text = "";
            cbxCategoria.Text = "";
            txtBuscarProducto.Text = string.Empty;
        }

        public void displayComboBox()
        {
            cbxPuntosDeVentas.Items.Clear();

            cbxCategoriaRP.Items.Clear();

            cbxProveedor.Items.Clear();

            try
            {
                if(cbxPuntosDeVentas.Text != "")
                {
                    //COMBOBOX DISPLAY CATEGORIA
                    MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                    string queryCategoria = "SELECT NombreCategoria FROM categoria WHERE NombreCaja='" + this.cbxPuntosDeVentas.Text+ " AND IsDeleted='" + 0 + "';";
                    connectionCategoria.Open();
                    MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
                    MySqlDataReader readerCategoria = command.ExecuteReader();
                    while (readerCategoria.Read())
                    {
                        cbxCategoriaRP.Items.Add(readerCategoria.GetString("NombreCategoria"));
                    }
                    connectionCategoria.Close();
                }
                

                //COMBOBOX DISPLAY PROVEEDORES
                MySqlConnection connectionProveedores = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryProveedores = "SELECT NombreCompañia FROM proveedor";
                connectionProveedores.Open();
                MySqlCommand commandProveedores = new MySqlCommand(queryProveedores, connectionProveedores);
                MySqlDataReader readerP = commandProveedores.ExecuteReader();
                while (readerP.Read())
                {
                    cbxProveedor.Items.Add(readerP.GetString("NombreCompañia"));
                }
                connectionProveedores.Close();

                //COMBOBOX DISPLAY PUNTOS DE VENTA
                MySqlConnection connectionPV = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryPV = "SELECT NombreCaja FROM caja WHERE IsDeleted=0 AND Disponible=1";
                connectionPV.Open();
                MySqlCommand commandPV = new MySqlCommand(queryPV, connectionPV);
                MySqlDataReader readerPV = commandPV.ExecuteReader();
                while (readerPV.Read())
                {
                    cbxPuntosDeVentas.Items.Add(readerPV.GetString("NombreCaja"));
                }
                connectionPV.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGoBack_MouseClick(object sender, MouseEventArgs e)
        {
            Clear();
            splitContainer1.Panel2Collapsed = true;
            dgvProductos.DataSource = producto.Select(CajaN);
        }

        public void Guardar(int EnMostrador, int TieneReceta)
        {
            if (txtNombreProducto.Text == string.Empty || cbxProveedor.Text == string.Empty ||
                txtPrecioVenta.Text == string.Empty || nudCantidadActual.Value == 0 ||
                nudCantidadMinima.Value == 0 || nudCantidadMaxima.Value == 0 ||
                cbxUnidadMedida.Text == string.Empty || cbxCategoriaRP.Text == string.Empty ||
                (nudCantidadMaxima.Value < nudCantidadMinima.Value) || cbxPuntosDeVentas.Text == string.Empty)
            {
                MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                producto.NombreInsumo = txtNombreProducto.Text;
                producto.IdProveedor = producto.SelectIdProveedorFROMnombreCompania(cbxProveedor.Text);
                producto.DescripcionInsumo = txtDescripcion.Text;
                producto.NombreCaja = cbxPuntosDeVentas.Text;
                producto.PrecioCompra = float.Parse(txtPrecioCompra.Text);
                producto.IdCategoria = producto.SelectIdCategoria(cbxCategoriaRP.Text);
                producto.PrecioVenta = float.Parse(string.Format("{0:0.00}", txtPrecioVenta.Text));
                producto.CantActual = Convert.ToInt32(nudCantidadActual.Value);
                producto.CantMinima = Convert.ToInt32(nudCantidadMinima.Value);
                producto.CantMaxima = Convert.ToInt32(nudCantidadMaxima.Value);
                producto.EnMostrador = EnMostrador;
                producto.TieneReceta = TieneReceta;
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
                if (producto.Insert(producto) == true)
                {
                    producto.IdInsumo = producto.CantidadDeInsumos();
                    if (producto.InsertHistorialInsumo(producto) == true)
                    {
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    producto.Impuesto = 0;
                    producto.PorcientoImpuesto = 0;
                }

                if (producto.Update(producto) == true)
                {
                    if(producto.InsertHistorialInsumo(producto) == true)
                    {
                        Clear();
                    }
                    
                    MessageBox.Show("El producto ha sido editado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    splitContainer1.Panel2Collapsed = true;
                    dgvProductos.DataSource = producto.Select(CajaN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtPrecioVenta.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetterOrDigit(ch) && ch != 127 && ch != 08 && ch != 32)
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnCancelarAjuste_MouseClick(object sender, MouseEventArgs e)
        {
            pnlAjustarStock.Visible = false;
            cbxUnidadMedidaAjustar.SelectedIndex = 0;
            nudCantidadAjustar.Value = 0;
            cbxAccionAjuste.SelectedIndex = 0;
        }

        private void BtnAjustarStock_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                pnlAjustarStock.Visible = true;
                lblNombreProductoAjustar.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();

                string unidadMedidaProductoSeleccionado = dgvProductos.CurrentRow.Cells[13].Value.ToString();

                if (unidadMedidaProductoSeleccionado == "Grano" || unidadMedidaProductoSeleccionado == "Onza" ||
                    unidadMedidaProductoSeleccionado == "Libra" || unidadMedidaProductoSeleccionado == "Kilogramo" ||
                    unidadMedidaProductoSeleccionado == "Miligramo" || unidadMedidaProductoSeleccionado == "Gramo"
                    )
                {
                    cbxUnidadMedidaAjustar.Items.Clear();
                    cbxUnidadMedidaAjustar.Items.Add("Grano");
                    cbxUnidadMedidaAjustar.Items.Add("Onza");
                    cbxUnidadMedidaAjustar.Items.Add("Libra");
                    cbxUnidadMedidaAjustar.Items.Add("Kilogramo");
                    cbxUnidadMedidaAjustar.Items.Add("Miligramo");
                    cbxUnidadMedidaAjustar.Items.Add("Gramo");
                }
                else if (unidadMedidaProductoSeleccionado == "Unidad")
                {
                    cbxUnidadMedidaAjustar.Text = "Unidad";
                }
                else
                {
                    cbxUnidadMedidaAjustar.Items.Clear();
                    cbxUnidadMedidaAjustar.Items.Add("Botellas");//============================================
                    cbxUnidadMedidaAjustar.Items.Add("Cuchara de té");
                    cbxUnidadMedidaAjustar.Items.Add("Cuchara de madera");
                    cbxUnidadMedidaAjustar.Items.Add("Onza fluida");
                    cbxUnidadMedidaAjustar.Items.Add("Taza");
                    cbxUnidadMedidaAjustar.Items.Add("Medio litro");
                    cbxUnidadMedidaAjustar.Items.Add("Cuarto de galón");
                    cbxUnidadMedidaAjustar.Items.Add("Galón");
                    cbxUnidadMedidaAjustar.Items.Add("Barril");
                    cbxUnidadMedidaAjustar.Items.Add("Mililitros");
                    cbxUnidadMedidaAjustar.Items.Add("Litros");
                }
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
                       this.cbxUnidadMedidaAjustar.Text == string.Empty)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ajustar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idAjuste = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                    float CantidadAjuste = Convert.ToInt32(nudCantidadAjustar.Value);
                    unidadMedida.Nombre = cbxUnidadMedidaAjustar.Text;
                    float CantidadCalculada = 0;
                    if (cbxAccionAjuste.Text == "Aumentar")
                    {
                        if (dgvProductos.CurrentRow.Cells[13].Value.ToString() == "Unidad" || dgvProductos.CurrentRow.Cells[13].Value.ToString() == "Botellas")
                        {
                            CantidadCalculada = float.Parse(dgvProductos.CurrentRow.Cells[10].Value.ToString()) + CantidadAjuste;
                            cbxUnidadMedidaAjustar.Enabled = false;
                            cbxUnidadMedidaAjustar.Text = dgvProductos.CurrentRow.Cells[13].Value.ToString();
                        }
                        else
                        {
                            CantidadCalculada = float.Parse(dgvProductos.CurrentRow.Cells[10].Value.ToString()) + unidadMedida.Conversion(dgvProductos.CurrentRow.Cells[13].Value.ToString(), CantidadAjuste);
                        }
                    }
                    if (cbxAccionAjuste.Text == "Disminuir")
                    {
                        if (dgvProductos.CurrentRow.Cells[13].Value.ToString() == "Unidad" || dgvProductos.CurrentRow.Cells[13].Value.ToString() == "Botellas")
                        {
                            CantidadCalculada = float.Parse(dgvProductos.CurrentRow.Cells[10].Value.ToString()) - CantidadAjuste;
                            cbxUnidadMedidaAjustar.Enabled = false;
                            cbxUnidadMedidaAjustar.Text = dgvProductos.CurrentRow.Cells[13].Value.ToString();
                        }
                        else
                        {
                            CantidadCalculada = (float)dgvProductos.CurrentRow.Cells[10].Value - unidadMedida.Conversion(cbxUnidadMedidaAjustar.Text, CantidadAjuste);
                        }
                    }

                    if (producto.UpdateAjusteStock(idAjuste, CantidadCalculada) == true)
                    {
                        nudCantidadAjustar.Value = 0;
                        MessageBox.Show("Ajuste de stock exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al ajustar stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cbxUnidadMedidaAjustar.Text = "";
                    cbxUnidadMedidaAjustar.Enabled = true;
                    pnlAjustarStock.Visible = false;
                    dgvProductos.DataSource = producto.Select(CajaN);
                    cbxUnidadMedidaAjustar.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbxUnidadMedidaAjustar.SelectedIndex = 0;
            nudCantidadAjustar.Value = 0;
            cbxAccionAjuste.SelectedIndex = 0;
        }

        private void CbxBuscarProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscarProveedor.Text == "Todos")
            {
                dgvProductos.DataSource = producto.Select(CajaN);
                displaydgvProductos();
            }
            else
            {
                dgvProductos.DataSource = producto.FiltrarPORproveedor(cbxBuscarProveedor.SelectedItem.ToString(), CajaN);
                displaydgvProductos();
            }
        }

        private void BtnProductoMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Guardar(1, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (producto.UnidadMedida == "Botellas")
            {

            }
            else
            {
                DialogResult result3 = MessageBox.Show("Este producto requiere receta?", "Detalles producto",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {
                    //Guardar(1, 1);
                    RegistrarReceta receta = new RegistrarReceta(producto.CantidadDeInsumos(), txtNombreProducto.Text, 0, cbxPuntosDeVentas.Text);
                    receta.Show();
                }
                if (result3 == DialogResult.No)
                {
                }
            }

            Clear();
            pnlOpcionesRegistroProducto.Visible = false;
        }

        private void BtnNuevoProducto_MouseClick(object sender, MouseEventArgs e)
        {
            chkProductoEnMostrador.Visible = false;
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
            try
            {
                Guardar(0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (producto.UnidadMedida == "Botellas")
            {

            }
            else
            {
                DialogResult result3 = MessageBox.Show("Este producto requiere receta?", "Detalles producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {
                    RegistrarReceta receta = new RegistrarReceta(producto.IdInsumo, producto.NombreInsumo, 0, cbxPuntosDeVentas.Text);
                    receta.Show();
                }
                if (result3 == DialogResult.No)
                {
                }
            }

            Clear();

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
                        if (producto.Delete(producto) == true) ;
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

            dgvProductos.DataSource = producto.Select(CajaN);
        }

        private void BtnAgregarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            RegistrarReceta receta = new RegistrarReceta(0, txtNombreProducto.Text, 0, cbxPuntosDeVentas.Text);
            receta.Show();
        }

        private void ChkProductoLiquido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProductoLiquido.Checked == true)
            {
                cbxUnidadMedida.Items.Clear();
                cbxUnidadMedida.Items.Add("Botellas");
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
                cbxUnidadMedida.Items.Add("Unidad");
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
            DialogResult result3 = MessageBox.Show("Seguro que desea editar la receta? Se eliminará la anterior para crear la actual.", "Detalles producto",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                RegistrarReceta receta = new RegistrarReceta(0, txtNombreProducto.Text, Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value), cbxPuntosDeVentas.Text);
                receta.Show();
            }
        }

        private void BtnVerReceta_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                if (producto.CheckSiProductTieneReceta(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString())) == 1)
                {
                    VerReceta verReceta = new VerReceta(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString()), dgvProductos.CurrentRow.Cells[1].Value.ToString());
                    verReceta.Show();
                }
                else
                {
                    MessageBox.Show("Este producto no tiene receta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxCategoriaRP_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
        }

        private void CbxProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
        }

        private void CbxPuntosDeVentas_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
        }

        private void SplitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProducto.Text = "Buscar";
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Todas")
            {
                dgvProductos.DataSource = producto.Select(CajaN);
                displaydgvProductos();
            }
            else
            {
                dgvProductos.DataSource = producto.FiltrarPORcategoria(cbxCategoria.SelectedItem.ToString(), CajaN);
                displaydgvProductos();
            }
        }

        private void CbxBuscarProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            cbxCategoria.Text = "";
            cbxBuscarProveedor.Items.Clear();
            cbxBuscarProveedor.Items.Add("Todos");
            //COMBOBOX DISPLAY PROVEEDORES
            MySqlConnection connectionProveedores = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
            string queryProveedores = "SELECT NombreCompañia FROM proveedor";
            connectionProveedores.Open();
            MySqlCommand commandProveedores = new MySqlCommand(queryProveedores, connectionProveedores);
            MySqlDataReader readerP = commandProveedores.ExecuteReader();
            while (readerP.Read())
            {
                cbxBuscarProveedor.Items.Add(readerP.GetString("NombreCompañia"));
            }
            connectionProveedores.Close();
        }

        private void CbxCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            cbxBuscarProveedor.Text = "";
            cbxCategoria.Items.Clear();
            cbxCategoria.Items.Add("Todas");
            //COMBOBOX DISPLAY CATEGORIA
            MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
            string queryCategoria = "SELECT NombreCategoria FROM categoria WHERE NombreCaja='" + CajaN + "';";
            connectionCategoria.Open();
            MySqlCommand command = new MySqlCommand(queryCategoria, connectionCategoria);
            MySqlDataReader readerCategoria = command.ExecuteReader();
            while (readerCategoria.Read())
            {
                cbxCategoria.Items.Add(readerCategoria.GetString("NombreCategoria"));
            }
            connectionCategoria.Close();
        }

        // ----- REGISTRO COMPRAS

        public void LoadPrdCompra()//para listar
        {
            dgvProductosRegistrados.DataSource = GetProvList();
        }

        private DataTable GetProvList()//listar 
        {
            DataTable dtProveedores = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM INSUMO", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtProveedores.Load(reader);
                    dtProveedores.Columns["IdInsumo"].ColumnName = "##";
                    dtProveedores.Columns["NombreInsumo"].ColumnName = "Nombre Producto";
                }
            }

            return dtProveedores;

        }

        public void LoadHistorial()//para listar historial
        {
            dgvProductosComprados.DataSource = GetProvList2();
        }

        private DataTable GetProvList2()//listar historial

        {
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM historial_compra_insumo", con))
                {
                    con.Open();


                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    dt.Columns["Id"].ColumnName = "##";
                    dt.Columns["FechaCompra"].ColumnName = "Fecha compra";
                    dt.Columns["IdInsumo"].ColumnName = "ID producto";
                    dt.Columns["CantidadComprada"].ColumnName = "Cantidad comprada";
                    dt.Columns["IdProveedor"].ColumnName = "ID proveedor";
                    dt.Columns["NombreProducto"].ColumnName = "Nombre Producto";
                }
            }

            return dt;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProductosRegistrados.AllowUserToAddRows = false;

            if (txtBuscar.Text != "" && txtBuscar.Text != "Buscar")
            {
                dgvProductosRegistrados.CurrentCell = null;
                foreach (DataGridViewRow n in dgvProductosRegistrados.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvProductosRegistrados.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvProductosRegistrados.DataSource = GetProvList();
            }
        }

        private void DgvProductosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductosRegistrados.Rows[e.RowIndex];
                txtNombreProd.Text = row.Cells["NombreInsumo"].Value.ToString();
                txtPrecioProd.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtId.Text = row.Cells["IdInsumo"].Value.ToString();
                txtCantDisp.Text = row.Cells["CantActual"].Value.ToString();
                txtIdProveedor.Text = row.Cells["Proveedor"].Value.ToString();
                txtIdInsumo.Text = row.Cells["IdInsumo"].Value.ToString();


            }
        }

        private void BtnAgregar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int cant = Convert.ToInt32(txtCantDisp.Text);
                int cant2 = Convert.ToInt32(spnCantComprada.Text);
                int cantTotal = cant + cant2;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update hostal.insumo set CantActual='" + cantTotal + "' where IdInsumo='" + this.txtId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Registrados");
                LoadPrdCompra();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //insertar en historial
            try
            {
                DateTime today = DateTime.Today;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
                // This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into hostal.historial_compra_insumo(FechaCompra,IdInsumo,CantidadComprada,IdProveedor, NombreProducto) values('" + DateTime.Now.ToString("dd-MM-yyyy hh:mm") + "','" + Convert.ToInt32(txtIdInsumo.Text) + "','" + Convert.ToInt32(spnCantComprada.Text) + "','" + this.txtIdProveedor.Text + "','" + txtNombreProd.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Historial Actualizado");
                clearDatos();
                LoadHistorial();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //fin insertar en historial

        }
        public void clearDatos()
        {
            txtNombreProd.Text = "";
            txtPrecioProd.Text = "";
            txtId.Text = "";
            txtCantDisp.Text = "";
            spnCantComprada.Text = "1";
        }

        // ------------- HISTORIAL COMPRAS ------------------

        public void LoadHistorialCompras()//para listar historial
        {
            dgvCompras.DataSource = GetProvList2Compras();
        }

        private DataTable GetProvList2Compras()//listar historial

        {
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM historial_compra_insumo", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;

        }
    }
}
