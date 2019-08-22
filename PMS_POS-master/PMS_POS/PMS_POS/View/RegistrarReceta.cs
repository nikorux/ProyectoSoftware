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

        public RegistrarReceta(string nombreReceta, int Editar)
        {
            InitializeComponent();
            dgvProductosEnInventario.DataSource = mostrador.SelectItemsDisponiblesParaMenu();
            txtNombre.Text = nombreReceta;
            pnlMedidaEnReceta.Visible = false;
            idInsumo = Editar;
            int cantRecetas = receta.CountRecetasRegistradas();
            if(cantRecetas == 0)
            {
                idReceta = 1;
            }
            if(Editar != 0)
            {
                idReceta = receta.SearchIdRecetaDelIdInsumo(Editar);
            }

        }

        public void Clear()
        {
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
               unidadMedidaInsumo == "Mililitros" || unidadMedidaInsumo == "Litros" ||
               unidadMedidaInsumo == "Botellas")
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

            dgvProductosEnReceta.Rows[n].Cells[0].Value = dgvProductosEnInventario.CurrentRow.Cells[0].Value.ToString();
            dgvProductosEnReceta.Rows[n].Cells[1].Value = dgvProductosEnInventario.CurrentRow.Cells[1].Value.ToString();
            dgvProductosEnReceta.Rows[n].Cells[2].Value = nudCantidad.Value.ToString();
            dgvProductosEnReceta.Rows[n].Cells[3].Value = cbxUnidadMedida.SelectedItem.ToString();

            Clear();
            pnlMedidaEnReceta.Visible = false;
        }

        private void RegistrarReceta_Load(object sender, EventArgs e)
        {
            if (idInsumo != 0)
            {
                receta.DeleteTablaRelacionalReceta(idReceta);
                receta.Delete(idReceta);
            }
            txtComentario.Text = "";
            txtDescripcion.Text = "";
        }

        private void BtnRemoverDeReceta_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductosEnReceta.SelectedRows.Count > 0)
            {
                int rowIndex = dgvProductosEnReceta.CurrentCell.RowIndex;
                dgvProductosEnReceta.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una fila de 'Productos en Receta'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegistrarReceta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que quiere cerrar la ventana?", "Detalles producto",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnGuardarReceta_MouseClick(object sender, MouseEventArgs e)
        {
            int IdInsumo = 0;
            string NombreInsumo = null;
            float CantidadInsumo = 0;
            string UnidadMedida = null;

            try
            {
                if (this.txtNombre.Text == string.Empty || this.txtDescripcion.Text == string.Empty ||
                    this.txtComentario.Text == string.Empty || dgvProductosEnReceta.Rows.Count == 0 )
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ajustar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int IdReceta = receta.CountRecetasRegistradas() + 1; //ESTO ES PARA CUANDO ES UN PRODUCTO NUEVO Y NO UNA EDICION DE RECETA

                    if (receta.InsertEnTablaReceta(txtNombre.Text, txtDescripcion.Text, txtComentario.Text, receta.CountInsumosRegistrados()) == true)
                    {
                        foreach (DataGridViewRow row in dgvProductosEnReceta.Rows)
                        {
                            foreach (DataGridViewColumn col in dgvProductosEnReceta.Columns)
                            {

                                if (col.Index == 0)
                                {
                                    IdInsumo = Convert.ToInt32(dgvProductosEnReceta.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if(col.Index == 1)
                                {
                                    NombreInsumo = dgvProductosEnReceta.Rows[row.Index].Cells[col.Index].Value.ToString();
                                }
                                if (col.Index == 2)
                                {
                                    CantidadInsumo = float.Parse(dgvProductosEnReceta.Rows[row.Index].Cells[col.Index].Value.ToString());
                                }
                                if (col.Index == 3)
                                {
                                    UnidadMedida = dgvProductosEnReceta.Rows[row.Index].Cells[col.Index].Value.ToString();
                                }
                            }

                            if (receta.InsertEnTablaInsumoReceta(IdReceta, IdInsumo, NombreInsumo, CantidadInsumo, UnidadMedida) == true)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Error registrando Items en Receta", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}