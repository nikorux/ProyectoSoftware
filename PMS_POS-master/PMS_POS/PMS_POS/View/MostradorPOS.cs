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
        public static int cantItemsDeProducto = 0;
        public static float sumITBIS = 0;
        public static float sumSubTotal = 0;
        public static float sumTotalAPagar = 0;
        public static int IdCajaSeleccionada = 0;

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
            hideProductosColumns();
            panel1.Visible = false;
            panel2.Visible = false;

            txtNombreCliente.Text = "";
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

        private void MostradorPOS_Load(object sender, EventArgs e)
        {
            txtCantidadOrdenesAbiertas.Text = mostrador.SelectOrdenesAbiertas(txtCaja.Text).ToString();
            //FIX 1
            try
            {
                //COMBOBOX DISPLAY CATEGORIA
                MySqlConnection connectionCategoria = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                //string queryCategoria = "SELECT NombreCategoria FROM categoria where EnMostrador=1 AND NombreCaja='" + this.txtCaja.Text + "';";
                string queryCategoria = "SELECT NombreCategoria FROM categoria";
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
                string queryMesasDisponibles = "select Nombre from mesa where Disponible=1";
                connectionMesasDisponibles.Open();
                MySqlCommand command = new MySqlCommand(queryMesasDisponibles, connectionMesasDisponibles);
                MySqlDataReader readerMesasDisponibles = command.ExecuteReader();
                while (readerMesasDisponibles.Read())
                {
                    cbxAsignarMesa.Items.Add(readerMesasDisponibles.GetString("Nombre"));
                }
                connectionMesasDisponibles.Close();

                //COMBOBOX DISPLAY SELEECIONAR MESAS DE PEDIDOS NO DISPONIBLES
                MySqlConnection connectionMesasNODisponibles = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryMesasNODisponibles = "select Nombre from mesa where Disponible=0";
                connectionMesasNODisponibles.Open();
                MySqlCommand commandMesasNODisponibles = new MySqlCommand(queryMesasNODisponibles, connectionMesasNODisponibles);
                MySqlDataReader readerMesasNODisponibles = commandMesasNODisponibles.ExecuteReader();
                while (readerMesasNODisponibles.Read())
                {
                    cbxSeleccionarMesa.Items.Add(readerMesasNODisponibles.GetString("Nombre"));
                }
                readerMesasNODisponibles.Close();
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

        private void CbxSeleccionarMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPedidos.AllowUserToAddRows = false;
            int n = dgvPedidos.Rows.Add();

            if (cbxSeleccionarMesa.Text == "Todas")
            {
                dgvPedidos.DataSource = mostrador.SelectOrdenesAbiertas(txtCaja.Text);//FIX
            }
            else
            {
                DataTable dt = new DataTable();
                dt = mostrador.FiltrarPORmesa(cbxSeleccionarMesa.Text);

                foreach (DataRow row in dt.Rows)
                {
                    dgvPedidos.Rows[n].Cells[0].Value = Convert.ToInt32(row);
                    dgvPedidos.Rows[n].Cells[1].Value = mostrador.SearchNombreClienteFROMIdFactura(Convert.ToInt32(row));
                }
            }
        }

        private void BtnAgregarAFactura_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosMostrador.SelectedRows.Count > 0)
            {
                pnlEligirCantidadDeProducto.Visible = true;
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
                dgvProductosMostrador.DataSource = mostrador.SelectInsumosDisponibleParaMostrador();
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
            int n = dgvFactura.Rows.Add();

            int cantidad = Convert.ToInt32(txtCantidadProducto.Text);
            float precio = float.Parse(dgvProductosMostrador.CurrentRow.Cells[9].Value.ToString());

            dgvFactura.Rows[n].Cells[0].Value = Convert.ToInt32(dgvProductosMostrador.CurrentRow.Cells[0].Value);
            dgvFactura.Rows[n].Cells[1].Value = dgvProductosMostrador.CurrentRow.Cells[1].Value.ToString();
            dgvFactura.Rows[n].Cells[2].Value = cantidad;
            dgvFactura.Rows[n].Cells[3].Value = precio;
            dgvFactura.Rows[n].Cells[4].Value = cantidad * precio;
            dgvFactura.Rows[n].Cells[5].Value = float.Parse(dgvProductosMostrador.CurrentRow.Cells[8].Value.ToString());
            dgvFactura.Rows[n].Cells[6].Value = dgvProductosMostrador.CurrentRow.Cells[13].Value.ToString();

            int cant = Convert.ToInt32(txtCantidadProducto.Text);
            int cantItems = Convert.ToInt32(txtItemsEnFactura.Text);

            sumITBIS += (float.Parse(dgvProductosMostrador.CurrentRow.Cells[7].Value.ToString()) * cant);
            sumSubTotal += (float.Parse(dgvProductosMostrador.CurrentRow.Cells[8].Value.ToString()) * cant);
            sumTotalAPagar = (sumITBIS + sumSubTotal);
            lblITBIS.Text = Convert.ToString(sumITBIS);
            lblSubTotal.Text = Convert.ToString(sumSubTotal);
            lblTotalAPagar.Text = Convert.ToString(sumTotalAPagar);

            txtCantidadProducto.Text = "";
            cantItems += cant;
            txtItemsEnFactura.Text = cantItems.ToString();
            pnlEligirCantidadDeProducto.Visible = false;
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

                try
                {
                    if (this.txtNombreCliente.Text == string.Empty || this.cbxFormaDePago.SelectedItem == null)
                    {
                        MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Nombre Cliente' ó 'Forma de Pago' está vacías?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (mostrador.InsertFactura(txtNombreCliente.Text, cbxFormaDePago.SelectedIndex.ToString(), float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, 1) == true)
                        {
                            if (mostrador.InsertPedido(txtNombreCliente.Text) == true)
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
                                        int cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                        producto.InsertAjuste(IdInsumo, NombreInsumo, "Disminuir", cantActualInsumo - CantidadComprada, UnidadMedida);
                                        producto.UpdateInsumoCantidad(IdInsumo, cantActualInsumo - CantidadComprada);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                                {
                                    /*int cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                    producto.InsertAjuste(IdInsumo, dgvFactura.CurrentRow.Cells[1].Value.ToString(), "Disminuir", cantActualInsumo - CantidadComprada, dgvFactura.CurrentRow.Cells[5].Value.ToString());
                                    producto.UpdateInsumoCantidad(IdInsumo, cantActualInsumo - CantidadComprada);*/
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
            }

            Clear();
            /*if (mostrador.InsertRelacionPedidoFactura(Convert.ToInt32(txtIdPedido.Text), IdFactura, txtNombreCliente.Text) == true)
            {

            }
            else
            {
                MessageBox.Show("Error registrando Relacion pedido-factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            //Clear();
        }


        private void BtnGuardarOrdenAbierta_MouseClick(object sender, MouseEventArgs e)
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

            try
            {
                if (this.txtNombreCliente.Text == string.Empty || this.cbxFormaDePago.SelectedItem == null)
                {
                    MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Nombre Cliente' ó 'Forma de Pago' está vacías?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mostrador.InsertFactura(txtNombreCliente.Text, cbxFormaDePago.SelectedIndex.ToString(), float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, 0) == true)
                    {
                        if (mostrador.InsertPedido(txtNombreCliente.Text) == true)
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
                                    /*int cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                    producto.InsertAjuste(IdInsumo, dgvFactura.CurrentRow.Cells[1].Value.ToString(), "Disminuir", cantActualInsumo - CantidadComprada, dgvFactura.CurrentRow.Cells[5].Value.ToString());
                                    producto.UpdateInsumoCantidad(IdInsumo, cantActualInsumo - CantidadComprada);*/
                                }
                                else
                                {
                                    MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            if (mostrador.InsertRelacionPedidoFactura(IdPedido, IdFactura, txtNombreCliente.Text) == true)
                            {
                                /*int cantActualInsumo = producto.findCantidadActualInsumo(IdInsumo);
                                producto.InsertAjuste(IdInsumo, dgvFactura.CurrentRow.Cells[1].Value.ToString(), "Disminuir", cantActualInsumo - CantidadComprada, dgvFactura.CurrentRow.Cells[5].Value.ToString());
                                producto.UpdateInsumoCantidad(IdInsumo, cantActualInsumo - CantidadComprada);*/
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

                        Clear();
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

            /*if (mostrador.InsertRelacionPedidoFactura(Convert.ToInt32(txtIdPedido.Text), IdFactura, txtNombreCliente.Text) == true)
            {

            }
            else
            {
                MessageBox.Show("Error registrando Relacion pedido-factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            //Clear();
        }

        //============================= F U N C I O N   F A C T U R A R ==================================

        /*public void facturar(int ifCancelada)
        {
            int IdFactura = Convert.ToInt32(txtIdFactura.Text); //REMEMBER TO UNCOMMENT THE TWO CALLINGS
                                                                //OF THIS FUNCTION

            try
            {
                if (this.txtNombreCliente.Text == string.Empty || this.cbxFormaDePago.SelectedItem == null)
                {
                    MessageBox.Show("Campos vacíos o incorrectos. Tal vez, 'Nombre Cliente' ó 'Forma de Pago' está vacías?", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mostrador.InsertFactura(txtNombreCliente.Text, cbxFormaDePago.SelectedIndex.ToString(), float.Parse(lblITBIS.Text), float.Parse(lblSubTotal.Text), float.Parse(lblTotalAPagar.Text), txtCaja.Text, ifCancelada) == true)
                    {
                        foreach (DataGridViewRow row in dgvFactura.Rows)
                        {
                            int IdInsumo = Convert.ToInt32(dgvFactura.CurrentRow.Cells[0].Value);
                            float PrecioVenta = Convert.ToInt32(dgvFactura.CurrentRow.Cells[3].Value);
                            int CantidadComprada = Convert.ToInt32(dgvFactura.CurrentRow.Cells[2].Value);

                            if (mostrador.InsertRelacionFacturaInsumo(IdFactura, IdInsumo, PrecioVenta, CantidadComprada) == true)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Error registrando Items en Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error registrando Factura", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        //========^^^^^^^^^^^^^=========== F U N C I O N   F A C T U R A R ======^^^^^^^^^^^^^^=============

        private void BtnAgregarFacturaAOrden_MouseClick(object sender, MouseEventArgs e)
        {
            //facturar(0);
       }
        private void BtnSeleccionarOrden_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                txtIdFactura.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
                int idPedido = mostrador.SelectIdPedidoCorrespondienteConIdFactura(Convert.ToInt32(txtIdFactura.Text));
                txtIdPedido.Text = idPedido.ToString();
                DataTable dt = mostrador.SelectFacturasEnOrden(idPedido);
                //COMBOBOX DISPLAY FACTURAS EN ESTA MESA
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    MySqlConnection connectionFacturas = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                    string queryFacturas = "select NombreCliente from factura_mostrador where IdFactura=" + Convert.ToInt32(dt.Rows[j]);
                    connectionFacturas.Open();
                    MySqlCommand commandFacturas = new MySqlCommand(queryFacturas, connectionFacturas);
                    MySqlDataReader readerFacturas = commandFacturas.ExecuteReader();
                    while (readerFacturas.Read())
                    {
                        cbxFacturaDeCliente.Items.Add(readerFacturas.GetString("Nombre"));
                    }
                    readerFacturas.Close();
                }

                label19.Visible = true;
                cbxFacturaDeCliente.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxFacturasEnMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PENDIENTE

            /*int idPedido = mostrador.SelectIdPedidoCorrespondienteConIdFactura(Convert.ToInt32(txtIdFactura.Text));
            DataTable dtIdFacturas = mostrador.SelectFacturasEnOrden(idPedido);
            int idFactura = mostrador.encontrarIdFactura(idPedido, cbxFacturasEnMesa.Text);
            DataTable IdInsumosEnFactura = mostrador.ItemsEnFactura(idFactura);

            dgvFactura.AllowUserToAddRows = false;
            int n = dgvFactura.Rows.Add();

            for (int j = 0; j < dtIdFacturas.Rows.Count; j++)
            {
                dgvFactura.Rows[n].Cells[0].Value = Convert.ToInt32(dgvProductosMostrador.CurrentRow.Cells[0].Value);
                dgvFactura.Rows[n].Cells[1].Value = dgvProductosMostrador.CurrentRow.Cells[1].Value.ToString();
                dgvFactura.Rows[n].Cells[2].Value = Convert.ToInt32(txtCantidadProducto.Text);
                dgvFactura.Rows[n].Cells[3].Value = float.Parse(dgvProductosMostrador.CurrentRow.Cells[8].Value.ToString());
                dgvFactura.Rows[n].Cells[4].Value = float.Parse(dgvProductosMostrador.CurrentRow.Cells[7].Value.ToString());
            }*/
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
            //facturar(1);
            dgvFactura.Rows.Clear();
        }
    }
}