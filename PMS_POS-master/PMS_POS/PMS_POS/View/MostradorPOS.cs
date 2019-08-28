using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class MostradorPOS : Form
    {
        Mostrador mostrador = new Mostrador();
        Producto producto = new Producto();
        UnidadMedida unidadMedida = new UnidadMedida();
        Mesa mesa = new Mesa();
        public static int cantItemsDeProducto = 0;
        public static float sumITBIS = 0;
        public static float sumSubTotal = 0;
        public static float sumTotalAPagar = 0;
        public static int IdCajaSeleccionada = 0;
        public static bool editar;
        public static int Pagada;
        public static List<string> IDarray = new List<string>();
        public MostradorPOS(string caja, int IDcaja)
        {
            InitializeComponent();
            txtCaja.Text = caja;
            IdCajaSeleccionada = IDcaja;
            dgvProductosMostrador.DataSource = mostrador.SelectProductosFROMcaja(txtCaja.Text);
            contarCantidadItems();
            pnlEligirCantidadDeProducto.Visible = false;
            txtItemsEnFactura.Text = "0";
            txtCantidadOrdenesAbiertas.Text = mostrador.SelectOrdenesAbiertas(txtCaja.Text).ToString();
            dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
            pnlNombreClientePedido.Visible = false;
            pnlHuespedes.Visible = false;
            hideProductosColumns();
        }

        public int contarCantidadItems()
        {
            int cant = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                cant += Convert.ToInt32(dgvFactura.SelectedCells[2].Value);
            }
            return cant;
        }

        private void BtnNuevaOrden_MouseClick(object sender, MouseEventArgs e)
        {
            IDarray.Clear();
            pnlNombreClientePedido.Visible = true;
            editar = false;
            Pagada = 1;
        }

        public void loadComboBoxes()
        {
            cbxCategoria.Items.Clear();
            cbxAsignarMesa.Items.Clear();
            try
            {
                //COMBOBOX DISPLAY CATEGORIA
                MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryCategoria = "SELECT NombreCategoria FROM categoria WHERE NombreCaja='" + this.txtCaja.Text + "';";
                connectionCategoria.Open();
                MySqlCommand cmd = new MySqlCommand(queryCategoria, connectionCategoria);
                MySqlDataReader readerCategoria = cmd.ExecuteReader();
                while (readerCategoria.Read())
                {
                    cbxCategoria.Items.Add(readerCategoria.GetString("NombreCategoria"));
                }
                connectionCategoria.Close();

                //COMBOBOX DISPLAY ASIGNAR MESAS DISPONIBLES
                MySqlConnection connectionMesasDisponibles = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryMesasDisponibles = "select Nombre from mesa where Disponible=1 AND NombreCaja='" + this.txtCaja.Text + "';";
                connectionMesasDisponibles.Open();
                MySqlCommand command = new MySqlCommand(queryMesasDisponibles, connectionMesasDisponibles);
                MySqlDataReader readerMesasDisponibles = command.ExecuteReader();
                while (readerMesasDisponibles.Read())
                {
                    cbxAsignarMesa.Items.Add(readerMesasDisponibles.GetString("Nombre"));
                }
                connectionMesasDisponibles.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBorrar_MouseClick(object sender, MouseEventArgs e)
        {
            txtCantidadProducto.Text = "";
        }

        private void BtnCancelarCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txtCantidadProducto.Text = "";
            pnlEligirCantidadDeProducto.Visible = false;
        }
        public void enterCantidad(string num)
        {
            string value = txtCantidadProducto.Text;
            txtCantidadProducto.Text = value + num;
        }

        private void Btn1_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("1");
        }

        private void Btn2_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("2");
        }

        private void Btn3_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("3");
        }

        private void Btn4_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("4");
        }

        private void Btn5_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("5");
        }

        private void Btn6_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("6");
        }

        private void Btn7_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("7");
        }

        private void Btn8_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("8");
        }

        private void Btn9_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("9");
        }

        private void Btn0_MouseClick(object sender, MouseEventArgs e)
        {
            enterCantidad("0");
        }

        private void BtnAgregarAFactura_MouseClick(object sender, MouseEventArgs e)
        {
            bool showCantidadPanel = true;
            if (dgvProductosMostrador.SelectedRows.Count > 0)
            {
                for(int i = 0; i < IDarray.Count; i++)
                {
                    if(dgvProductosMostrador.CurrentRow.Cells[0].Value.ToString() == IDarray[i])
                    {
                        showCantidadPanel = false;
                        i = IDarray.Count;
                        MessageBox.Show("Este producto ya se encuentra en la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if(showCantidadPanel == true)
                {
                    pnlEligirCantidadDeProducto.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void hideProductosColumns()
        {
            dgvProductosMostrador.Columns[2].Visible = false;
            dgvProductosMostrador.Columns[3].Visible = false;
            dgvProductosMostrador.Columns[4].Visible = false;
            dgvProductosMostrador.Columns[5].Visible = false;
            dgvProductosMostrador.Columns[6].Visible = false;
            dgvProductosMostrador.Columns[7].Visible = false;
            dgvProductosMostrador.Columns[8].Visible = false;
            dgvProductosMostrador.Columns[12].Visible = false;
            dgvProductosMostrador.Columns[13].Visible = false;
            dgvProductosMostrador.Columns[14].Visible = false;
            dgvProductosMostrador.Columns[15].Visible = false;
            dgvProductosMostrador.Columns[16].Visible = false;
            dgvProductosMostrador.Columns[17].Visible = false;
        }

        public void Clear()
        {
            txtCambioPara.Text = "";
            txtDevuelta.Text = "";
            txtNombreCliente.Text = "";
            cbxCategoria.Text = "";
            lblITBIS.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblTotalAPagar.Text = "0.00";
            dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
            while (dgvFactura.Rows.Count > 0)
            {
                dgvFactura.Rows.RemoveAt(0);
            }
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Todas")
            {
                dgvProductosMostrador.DataSource = mostrador.SelectInsumosDisponibleParaMostrador(txtCaja.Text);
                hideProductosColumns();
            }
            else
            {
                dgvProductosMostrador.DataSource = mostrador.FiltrarPORcategoria(cbxCategoria.SelectedItem.ToString(), txtCaja.Text);
                hideProductosColumns();
            }
        }

        private void BtnAceptarCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProductosMostrador.AllowUserToAddRows = false;

            if (txtCantidadProducto.Text == "")
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int n = dgvFactura.Rows.Add();
                int cantidad = Convert.ToInt32(txtCantidadProducto.Text);
                float precio = float.Parse(dgvProductosMostrador.CurrentRow.Cells[9].Value.ToString());
                float ITBIS = precio * 0.18f;
                IDarray.Add(dgvProductosMostrador.CurrentRow.Cells[0].Value.ToString());

                dgvFactura.Rows[n].Cells[0].Value = Convert.ToInt32(dgvProductosMostrador.CurrentRow.Cells[0].Value);
                dgvFactura.Rows[n].Cells[1].Value = dgvProductosMostrador.CurrentRow.Cells[1].Value.ToString();
                dgvFactura.Rows[n].Cells[2].Value = cantidad;
                dgvFactura.Rows[n].Cells[3].Value = precio;
                dgvFactura.Rows[n].Cells[4].Value = cantidad * precio;
                dgvFactura.Rows[n].Cells[5].Value = ITBIS;
                dgvFactura.Rows[n].Cells[6].Value = dgvProductosMostrador.CurrentRow.Cells[13].Value.ToString();

                int cant = Convert.ToInt32(txtCantidadProducto.Text);
                int cantItems = Convert.ToInt32(txtItemsEnFactura.Text);

                sumITBIS += ITBIS * cant;
                sumSubTotal += precio * cant;
                sumTotalAPagar = (sumITBIS + sumSubTotal);
                lblITBIS.Text = Convert.ToString(sumITBIS);
                lblSubTotal.Text = Convert.ToString(sumSubTotal);
                lblTotalAPagar.Text = Convert.ToString(sumTotalAPagar);

                txtCantidadProducto.Text = "";
                cantItems += cant;
                txtItemsEnFactura.Text = cantItems.ToString();
                pnlEligirCantidadDeProducto.Visible = false;
            }
            
        }

        private void TxtCambioPara_TextChanged(object sender, EventArgs e)
        {
            float cambio = float.Parse(txtCambioPara.Text);
            float total = float.Parse(lblTotalAPagar.Text);
            float devuelta = cambio - total;
            if (txtCambioPara.Text != "")
            {
                txtDevuelta.Text = Convert.ToString(devuelta);
            }
            else
            {
                txtDevuelta.Text = "0.00";
            }
        }

        private void BtnFacturar_MouseClick(object sender, MouseEventArgs e)
        {
            if (editar == false)
            {
                DialogResult result3 = MessageBox.Show("Desea facturar este pedido?", "Facturación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {
                    int IdFactura = Convert.ToInt32(txtIdFactura.Text);
                    int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                    int IdInsumo = 0;
                    string NombreInsumo = null;
                    float CantidadComprada = 0;
                    float PrecioVenta = 0;
                    float Importe = 0;
                    float ITBIS = 0;
                    string UnidadMedida = null;
                    string Hora = DateTime.Now.ToString("hh:mm ");

                    try
                    {
                        if (this.txtNombreCliente.Text == string.Empty || this.cbxFormaDePago.SelectedItem == null && Pagada == 1)
                        {
                            MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Nombre Cliente' ó 'Forma de Pago' están vacías?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (mostrador.InsertFactura(txtNombreCliente.Text, cbxFormaDePago.SelectedIndex.ToString(), Hora, float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, Pagada) == true)
                            {
                                if (mostrador.InsertPedido(txtNombrePedido.Text, txtCaja.Text, cbxAsignarMesa.Text) == true)
                                {
                                    foreach (DataGridViewRow row in dgvFactura.Rows)
                                    {
                                        foreach (DataGridViewColumn col in dgvFactura.Columns)
                                        {
                                            if (col.Index == 0)
                                            {
                                                IdInsumo = Convert.ToInt32(dgvFactura.Rows[row.Index].Cells[col.Index].Value);
                                            }
                                            if (col.Index == 1)
                                            {
                                                NombreInsumo = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                            }
                                            if (col.Index == 2)
                                            {
                                                CantidadComprada = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 3)
                                            {
                                                PrecioVenta = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 4)
                                            {
                                                ITBIS = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 5)
                                            {
                                                Importe = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 6)
                                            {
                                                UnidadMedida = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                            }
                                        }

                                        if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                        {
                                            //AJUSTANDO INVENTARIO con receta
                                            if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                            {
                                                DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                                foreach (DataRow rw in dt.Rows)
                                                {
                                                    int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                                    float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                                    string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                                    string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                                    string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                                    float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                                    unidadMedida.Nombre = unidadInsumoRECETA;
                                                    float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                                    float cantidadAjustarInventario = cantidadTransformada * CantidadComprada;

                                                    //Insumo de la receta
                                                    producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                                    producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        float cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                        producto.UpdateAjusteStock(IdInsumo, cantActualInsumo - CantidadComprada);

                                    }
                                    if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                                    {

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error registrando Items en RELACION Factura-Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error registrando Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error registrando Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dgvFactura.Rows.Clear();
                    int cantOrdenes = mostrador.CantidadDePedidos();
                    int cantFacturas = mostrador.CantidadDeFacturas();
                    txtIdPedido.Text = (cantOrdenes + 1).ToString();
                    txtIdFactura.Text = (cantFacturas + 1).ToString();
                    txtItemsEnFactura.Text = "0";
                    cbxFacturaDeCliente.Text = "";
                    cbxAsignarMesa.Text = "";
                    txtNombreCliente.Text = "";
                }
            }
            if (editar == true)
            {
                btnGuardarCambios.Visible = true;
                btnGuardarOrdenAbierta.Visible = false;
                DialogResult result3 = MessageBox.Show("Desea facturar este pedido?", "Facturación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {
                    int IdFactura = Convert.ToInt32(txtIdFactura.Text);
                    int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                    int IdInsumo = 0;
                    string NombreInsumo = null;
                    float CantidadComprada = 0;
                    float PrecioVenta = 0;
                    float Importe = 0;
                    float ITBIS = 0;
                    string UnidadMedida = null;
                    string Hora = DateTime.Now.ToString("hh:mm ");


                    try
                    {
                        if (this.txtNombreCliente.Text == string.Empty || this.cbxFormaDePago.Text == string.Empty && Pagada == 1)
                        {
                            MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Nombre Cliente' ó 'Forma de Pago' está vacías?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (mostrador.UpdateFactura(IdFactura, cbxFormaDePago.Text, 1) == true)//FIX!!!
                            {

                                foreach (DataGridViewRow row in dgvFactura.Rows)
                                {
                                    foreach (DataGridViewColumn col in dgvFactura.Columns)
                                    {

                                        if (col.Index == 0)
                                        {
                                            IdInsumo = Convert.ToInt32(dgvFactura.Rows[row.Index].Cells[col.Index].Value);
                                        }
                                        if (col.Index == 1)
                                        {
                                            NombreInsumo = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                        }
                                        if (col.Index == 2)
                                        {
                                            CantidadComprada = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                        }
                                        if (col.Index == 3)
                                        {
                                            PrecioVenta = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                        }
                                        if (col.Index == 4)
                                        {
                                            ITBIS = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                        }
                                        if (col.Index == 5)
                                        {
                                            Importe = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                        }
                                        if (col.Index == 6)
                                        {
                                            UnidadMedida = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                        }
                                    }
                                    int IdFacturaInsumo = mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo);

                                    if (CantidadComprada != mostrador.SearchCantidadCompradaDelInsumo(IdFactura, IdInsumo) && mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo) != 0)
                                    {
                                        if (mostrador.UpdateRelacionFacturaInsumo(IdFacturaInsumo, IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                        {
                                            //AJUSTANDO INVENTARIO con receta
                                            if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                            {
                                                DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                                foreach (DataRow rw in dt.Rows)
                                                {
                                                    int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                                    float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                                    string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                                    string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                                    string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                                    float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                                    unidadMedida.Nombre = unidadInsumoRECETA;
                                                    float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                                    float cantidadAjustarInventario = cantidadTransformada * CantidadComprada;

                                                    //Insumo de la receta
                                                    producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                                    producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                                }
                                            }
                                        }

                                    }

                                }
                                if (mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo) == 0)
                                {
                                    if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                    {
                                        //AJUSTANDO INVENTARIO con receta
                                        if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                        {
                                            DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                            foreach (DataRow rw in dt.Rows)
                                            {
                                                int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                                float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                                string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                                string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                                string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                                float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                                unidadMedida.Nombre = unidadInsumoRECETA;
                                                float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                                float cantidadAjustarInventario = cantidadTransformada * CantidadComprada;

                                                //Insumo de la receta
                                                producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                                producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


                                }
                                if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                                {
                                    MessageBox.Show("19 InsertRelacionPedidoFactura!");
                                }
                                else
                                {
                                    MessageBox.Show("Error registrando Items en RELACION Factura-Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error registrando Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dgvFactura.Rows.Clear();
                    int cantOrdenes = mostrador.CantidadDePedidos();
                    int cantFacturas = mostrador.CantidadDeFacturas();
                    txtIdPedido.Text = (cantOrdenes + 1).ToString();
                    txtIdFactura.Text = (cantFacturas + 1).ToString();
                    txtItemsEnFactura.Text = "0";
                    cbxFacturaDeCliente.Text = "";
                    cbxAsignarMesa.Text = "";
                    txtNombreCliente.Text = "";
                }
            }

            dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
            dgvProductosMostrador.DataSource = mostrador.SelectProductosFROMcaja(txtCaja.Text);
        }

        private void BtnGuardarOrdenAbierta_MouseClick(object sender, MouseEventArgs e)
        {
            editar = false;
            Pagada = 0;
            if (editar == false)
            {
                DialogResult result3 = MessageBox.Show("Desea registrar como cuenta abierta?", "Registro de orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {
                    int IdFactura = Convert.ToInt32(txtIdFactura.Text);
                    int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                    int IdInsumo = 0;
                    string NombreInsumo = null;
                    float CantidadComprada = 0;
                    float PrecioVenta = 0;
                    float Importe = 0;
                    float ITBIS = 0;
                    string UnidadMedida = null;
                    string Hora = DateTime.Now.ToString("hh:mm ");

                    try
                    {
                        if ((this.cbxAsignarMesa.Text == string.Empty || txtNombreCliente.Text == string.Empty) && Pagada == 0)
                        {
                            MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Asignar Mesa' está vacía?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (mostrador.InsertFactura(txtNombreCliente.Text, null, Hora, float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, Pagada) == true)
                            {
                                if (mostrador.InsertPedido(txtNombrePedido.Text, txtCaja.Text, cbxAsignarMesa.Text) == true)
                                {
                                    int IdMesa = mesa.SearchIdMesa(cbxAsignarMesa.Text, txtCaja.Text);
                                    mesa.UpdateHacerMesaNODisponible(IdMesa);

                                    foreach (DataGridViewRow row in dgvFactura.Rows)
                                    {
                                        foreach (DataGridViewColumn col in dgvFactura.Columns)
                                        {
                                            if (col.Index == 0)
                                            {
                                                IdInsumo = Convert.ToInt32(dgvFactura.Rows[row.Index].Cells[col.Index].Value);
                                            }
                                            if (col.Index == 1)
                                            {
                                                NombreInsumo = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                            }
                                            if (col.Index == 2)
                                            {
                                                CantidadComprada = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 3)
                                            {
                                                PrecioVenta = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 4)
                                            {
                                                ITBIS = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 5)
                                            {
                                                Importe = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                            }
                                            if (col.Index == 6)
                                            {
                                                UnidadMedida = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                            }
                                        }

                                        if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                        {
                                            //AJUSTANDO INVENTARIO con receta
                                            if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                            {
                                                DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                                foreach (DataRow rw in dt.Rows)
                                                {
                                                    int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                                    float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                                    string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                                    string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                                    string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                                    float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                                    unidadMedida.Nombre = unidadInsumoRECETA;
                                                    float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                                    float cantidadAjustarInventario = cantidadTransformada * CantidadComprada;

                                                    //Insumo de la receta
                                                    producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                                    producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        float cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                        producto.UpdateAjusteStock(IdInsumo, cantActualInsumo - CantidadComprada);

                                    }
                                    if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                                    {

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error registrando Items en RELACION Factura-Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error registrando Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                dgvFactura.Rows.Clear();
                                txtNombreCliente.Text = "";
                                dgvProductosMostrador.DataSource = mostrador.SelectProductosFROMcaja(txtCaja.Text);
                                dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
                                txtCantidadOrdenesAbiertas.Text = mostrador.CantidadDeOrdenesAbierta(txtCaja.Text);
                                int cantFacturas = mostrador.CantidadDeFacturas();
                                txtIdFactura.Text = (cantFacturas + 1).ToString();
                                cbxAsignarMesa.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Error registrando Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnSeleccionarOrden_MouseClick(object sender, MouseEventArgs e)
        {
            editar = true;
            Pagada = 1;
            dgvFactura.Rows.Clear();
            btnGuardarCambios.Visible = true;
            btnGuardarOrdenAbierta.Visible = false;
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                int IdFactura = Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
                int IdPedido = mostrador.SearchIdPedidoFROMIdFactura(IdFactura, dgvPedidos.CurrentRow.Cells[1].Value.ToString());
                txtIdPedido.Text = IdPedido.ToString();
                DataTable dt = mostrador.SelectFacturasEnOrden(IdPedido);
                cbxFacturaDeCliente.Items.Clear();
                //COMBOBOX DISPLAY FACTURAS EN PEDIDO
                foreach (DataRow row in dt.Rows)
                {
                    cbxFacturaDeCliente.Items.Add(row["NombreClienteFactura"].ToString());
                }

                cbxAsignarMesa.Text = mostrador.searchMesa(IdPedido);
                txtNombreCliente.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
                txtIdFactura.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();

                txtNombrePedido.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
                label19.Visible = true;
                cbxFacturaDeCliente.Visible = true;
                cbxFacturaDeCliente.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una orden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxFacturasEnMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdFactura = mostrador.encontrarIdFactura(Convert.ToInt32(txtIdPedido.Text), cbxFacturaDeCliente.Text);
            DataTable dt = mostrador.ItemsEnFactura(IdFactura);

            dgvFactura.AllowUserToAddRows = false;
            txtItemsEnFactura.Text = "0";
            dgvFactura.Rows.Clear();
            IDarray.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvFactura.Rows.Add(Convert.ToInt32(row["IdInsumo"].ToString()), row["NombreInsumo"].ToString(),
                    Convert.ToInt32(row["CantidadComprada"].ToString()), float.Parse(row["PrecioVenta"].ToString()),
                    float.Parse(row["Importe"].ToString()), float.Parse(row["ITBIS"].ToString()),
                    row["UnidadMedida"].ToString());

                int cant = Convert.ToInt32(row["CantidadComprada"].ToString());
                int cantItems = Convert.ToInt32(txtItemsEnFactura.Text);

                cantItems += cant;
                txtItemsEnFactura.Text = cantItems.ToString();

                IDarray.Add(row["IdInsumo"].ToString());
            }
        }

        private void BtnRemoverDeFactura_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvFactura.SelectedRows.Count > 0)
            {
                int rowIndex = dgvFactura.CurrentCell.RowIndex;
                dgvFactura.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelarFactura_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (editar == true)
                {
                    if (mostrador.UpdateFacturaCancelada(Convert.ToInt32(txtIdFactura.Text)) == true)
                    {

                    }
                }
                else
                {
                    if (mostrador.InsertFacturaCancelada(txtNombreCliente.Text, cbxFormaDePago.SelectedIndex.ToString(), float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, 0) == true)
                    {
                        int IdFactura = Convert.ToInt32(txtIdFactura.Text);
                        int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                        int IdInsumo = 0;
                        string NombreInsumo = null;
                        float CantidadComprada = 0;
                        float PrecioVenta = 0;
                        float Importe = 0;
                        float ITBIS = 0;
                        string UnidadMedida = null;
                        string Hora = DateTime.Now.ToString("hh:mm ");

                        foreach (DataGridViewRow row in dgvFactura.Rows)
                        {
                            foreach (DataGridViewColumn col in dgvFactura.Columns)
                            {
                                if (col.Index == 0)
                                {
                                    IdInsumo = Convert.ToInt32(dgvFactura.Rows[row.Index].Cells[col.Index].Value);
                                }
                                if (col.Index == 1)
                                {
                                    NombreInsumo = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                }
                                if (col.Index == 2)
                                {
                                    CantidadComprada = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if (col.Index == 3)
                                {
                                    PrecioVenta = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if (col.Index == 4)
                                {
                                    ITBIS = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if (col.Index == 5)
                                {
                                    Importe = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if (col.Index == 6)
                                {
                                    UnidadMedida = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                }
                            }

                            if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNombreCliente.Text = "";
            dgvFactura.Rows.Clear();
            txtNombrePedido.Text = "- - -";
            int cantOrdenes = mostrador.CantidadDePedidos();
            int cantFacturas = mostrador.CantidadDeFacturas();
            txtIdPedido.Text = (cantOrdenes + 1).ToString();
            txtIdFactura.Text = (cantFacturas + 1).ToString();
            txtItemsEnFactura.Text = "0";
            dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
        }

        private void BtnContinuar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNombreClientePedido.Text == "")
            {
                MessageBox.Show("Digite un nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtNombreCliente.Text = txtNombreClientePedido.Text;
                txtNombrePedido.Text = txtNombreClientePedido.Text;
                pnlNombreClientePedido.Visible = false;
                txtNombreClientePedido.Text = "";
                cbxFacturaDeCliente.Visible = false;
                label19.Visible = false;
                btnGuardarCambios.Visible = false;
                btnGuardarOrdenAbierta.Visible = true;

                editar = false;
                hideProductosColumns();
                panel1.Visible = false;
                panel2.Visible = false;
                panel6.Visible = false;

                cbxAsignarMesa.Text = "";
                dgvFactura.Rows.Clear();
                dgvFactura.Refresh();

                if (mostrador.CantidadDePedidos() == 0)
                {
                    txtIdPedido.Text = "1";
                    txtIdFactura.Text = "1";
                }
                else
                {
                    int cantOrdenes = mostrador.CantidadDePedidos();
                    int cantFacturas = mostrador.CantidadDeFacturas();
                    txtIdPedido.Text = (cantOrdenes + 1).ToString();
                    txtIdFactura.Text = (cantFacturas + 1).ToString();
                    txtItemsEnFactura.Text = "0";
                }
            }
        }

        private void TxtNombrePedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlNombreClientePedido.Visible = true;
        }

        private void PicBuscarHuespedes_MouseClick(object sender, MouseEventArgs e)
        {
            pnlHuespedes.Visible = true;
        }

        private void PicManejarMesas_MouseClick(object sender, MouseEventArgs e)
        {
            DisponibilidadMesas manejarMesas = new DisponibilidadMesas(txtCaja.Text);
            manejarMesas.Show();
        }

        private void TxtBuscarHuespedes_TextChanged(object sender, EventArgs e)
        {
            dgvHuespedes.AllowUserToAddRows = false;

            if (txtBuscarHuespedes.Text != "" && txtBuscarHuespedes.Text != "Buscar")
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
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarHuespedes.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                // dgvHuespedes.DataSource = mesa.MesasDisponibles();
            }
        }

        private void PicCerrarPnlHuespedes_MouseClick(object sender, MouseEventArgs e)
        {
            pnlHuespedes.Visible = false;
            txtBuscarHuespedes.Text = "";
        }

        private void CbxAsignarMesa_MouseClick(object sender, MouseEventArgs e)
        {
            loadComboBoxes();
        }

        private void TxtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            dgvPedidos.AllowUserToAddRows = false;

            if (txtBuscarCliente.Text != "" && txtBuscarCliente.Text != "Buscar")
            {

                dgvPedidos.CurrentCell = null;
                foreach (DataGridViewRow n in dgvPedidos.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvPedidos.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtBuscarCliente.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);
            }
        }
        private void MostradorPOS_Load(object sender, EventArgs e)
        {
            txtCantidadOrdenesAbiertas.Text = mostrador.CantidadDeOrdenesAbierta(txtCaja.Text);
        }

        private void CbxCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            loadComboBoxes();
        }

        private void PnlBase_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCliente.Text = "Buscar";
        }

        private void Panel8_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarHuespedes.Text = "Buscar";
        }

        private void PicPnlInsertarNombre_MouseClick(object sender, MouseEventArgs e)
        {
            pnlNombreClientePedido.Visible = false;
            txtNombreClientePedido.Text = "";
        }

        private void BtnGuardarCambios_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Desea guardar los cambios?", "Registro de orden",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                int IdFactura = Convert.ToInt32(txtIdFactura.Text);
                int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                int IdInsumo = 0;
                string NombreInsumo = null;
                float CantidadComprada = 0;
                float PrecioVenta = 0;
                float Importe = 0;
                float ITBIS = 0;
                string UnidadMedida = null;
                string Hora = DateTime.Now.ToString("hh:mm ");

                try
                {
                    if ((this.cbxAsignarMesa.Text == string.Empty || txtNombreCliente.Text == string.Empty) && Pagada == 0)
                    {
                        MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Asignar Mesa' está vacía?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (mostrador.UpdateFactura(IdFactura, null, 0) == true)
                        {

                            foreach (DataGridViewRow row in dgvFactura.Rows)
                            {
                                foreach (DataGridViewColumn col in dgvFactura.Columns)
                                {

                                    if (col.Index == 0)
                                    {
                                        IdInsumo = Convert.ToInt32(dgvFactura.Rows[row.Index].Cells[col.Index].Value);
                                    }
                                    if (col.Index == 1)
                                    {
                                        NombreInsumo = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                    }
                                    if (col.Index == 2)
                                    {
                                        CantidadComprada = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                    }
                                    if (col.Index == 3)
                                    {
                                        PrecioVenta = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                    }
                                    if (col.Index == 4)
                                    {
                                        ITBIS = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                    }
                                    if (col.Index == 5)
                                    {
                                        Importe = float.Parse(dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString());
                                    }
                                    if (col.Index == 6)
                                    {
                                        UnidadMedida = dgvFactura.Rows[row.Index].Cells[col.Index].Value.ToString();
                                    }
                                }
                                int IdFacturaInsumo = mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo);
                                float cantidadCompradaAnteriormente = mostrador.SearchCantidadCompradaDelInsumo(IdFactura, IdInsumo);

                                if (CantidadComprada != cantidadCompradaAnteriormente && mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo) != 0)
                                {
                                    float cantidadAajustarAhora = cantidadCompradaAnteriormente - CantidadComprada;
                                    if(CantidadComprada > cantidadCompradaAnteriormente)
                                    {
                                        cantidadAajustarAhora = CantidadComprada - cantidadCompradaAnteriormente;
                                    }

                                    if (mostrador.UpdateRelacionFacturaInsumo(IdFacturaInsumo, IdFactura, IdInsumo, NombreInsumo, cantidadAajustarAhora, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                    {
                                        //AJUSTANDO INVENTARIO con receta
                                        if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                        {
                                            DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                            foreach (DataRow rw in dt.Rows)
                                            {
                                                int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                                float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                                string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                                string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                                string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                                float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                                unidadMedida.Nombre = unidadInsumoRECETA;
                                                float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                                float cantidadAjustarInventario = cantidadTransformada * cantidadAajustarAhora;

                                                //Insumo de la receta
                                                producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                                producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                            }
                                        }
                                    }

                                }

                            }
                            if (mostrador.SearchIdFacturaInsumo(IdFactura, IdInsumo) == 0)
                            {
                                if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, NombreInsumo, CantidadComprada, PrecioVenta, Importe, ITBIS, UnidadMedida) == true)
                                {
                                    //AJUSTANDO INVENTARIO con receta
                                    if (producto.CheckSiProductTieneReceta(IdInsumo) == 1)
                                    {
                                        DataTable dt = mostrador.AjustarCantidadProductoSegunReceta(IdInsumo);
                                        foreach (DataRow rw in dt.Rows)
                                        {
                                            int IdInsumoEnReceta = Convert.ToInt32(rw["IdInsumo"].ToString());
                                            float cantActualInsumoRECETA = producto.findCantidadActualInsumo(IdInsumoEnReceta);

                                            string unidadInsumo = producto.SearchUnidadMedidaInsumo(IdInsumoEnReceta);
                                            string unidadInsumoRECETA = rw["UnidadMedida"].ToString();

                                            string nombreInsumoRECETA = rw["NombreInsumo"].ToString();
                                            float cantidadInsumoRECETA = float.Parse(rw["CantidadInsumo"].ToString());
                                            unidadMedida.Nombre = unidadInsumoRECETA;
                                            float cantidadTransformada = unidadMedida.Conversion(unidadInsumo, cantidadInsumoRECETA);
                                            float cantidadAjustarInventario = cantidadTransformada * CantidadComprada;

                                            //Insumo de la receta
                                            producto.InsertAjuste(IdInsumoEnReceta, nombreInsumoRECETA, "Disminuir", cantActualInsumoRECETA - cantidadAjustarInventario, unidadInsumoRECETA, txtCaja.Text);
                                            producto.UpdateAjusteStock(IdInsumoEnReceta, cantActualInsumoRECETA - cantidadAjustarInventario);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Error registrando Items en RELACION Factura-Pedido", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error registrando Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvFactura.Rows.Clear();
                int cantOrdenes = mostrador.CantidadDePedidos();
                int cantFacturas = mostrador.CantidadDeFacturas();
                txtIdPedido.Text = (cantOrdenes + 1).ToString();
                txtIdFactura.Text = (cantFacturas + 1).ToString();
                txtItemsEnFactura.Text = "0";
                cbxFacturaDeCliente.Text = "";
                cbxAsignarMesa.Text = "";
                txtNombreCliente.Text = "";
            }
        }
    }
}