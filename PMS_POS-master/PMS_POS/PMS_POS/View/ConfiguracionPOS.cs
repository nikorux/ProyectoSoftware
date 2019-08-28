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
using MySql.Data.MySqlClient;

namespace PMS_POS.View
{
    public partial class ConfiguracionPOS : Form
    {
        public void loadDGVs()
        {
            dgvCajas.Columns[3].Visible = false;
            dgvCajas.Columns[4].Visible = false;
            dgvCajas.Columns[5].Visible = false;

            dgvMesas.Columns[5].Visible = false;
            dgvMesas.Columns[3].Visible = false;
            dgvMesas.Columns[6].Visible = false;
        }

        static bool editarCategoria = false;
        static bool editarMesa = false;
        static bool editarCaja = false;

        Caja caja = new Caja();
        Categoria categoria = new Categoria();
        Mesa mesa = new Mesa();
        public ConfiguracionPOS()
        {
            InitializeComponent();

            btnMostrarCajasDisponibles.Visible = false;
            btnMostrarCajasNoDisponibles.Visible = true;
            dgvCajas.DataSource = caja.Select("Disponible");
            dgvMesas.DataSource = mesa.Select("Disponible");
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            loadDGVs();
            btnMostrarCajasDisponiblesMesas.Visible = false;
            btnMostrarCajasNoDisponiblesMesas.Visible = true;
            btnGuardarEdicionCategoria.Visible = false;
            btnGuardarEdicionMesas.Visible = false;
            btnGuardarEdicionCajas.Visible = false;
            dgvCategoria.Columns[2].Visible = false;
        }

        public void Clear()
        {
            btnLimpiarCajas.Text = "Limpiar";
            btnLimpiarMesas.Text = "Limpiar";
            button6.Text = "Limpiar";
            txtIdCategorias.Text = categoria.countCategorias().ToString();
            txtIdCajas.Text = caja.countCajas().ToString();
            txtIdMesas.Text = mesa.countMesas().ToString();
            txtNombreCaja.Text = "";
            txtNombreMesa.Text = "";
            textBox2.Text = "";
            txtDescripcionCaja.Text = "";
            txtDescripcionMesa.Text = "";
            chkGuardarCajaNoDisponible.Checked = false;
            chkGuardarMesaNoDisponible.Checked = false;
            chxCategoriaEnMostrador.Checked = false;
            cbxPuntoVentaCategoria.Text = "";
            cbxPuntoVentaMesas.Text = "";
        }

        public void displayComboBox()
        {
            cbxPuntoVentaCategoria.Items.Clear();
            cbxPuntoVentaMesas.Items.Clear();
            try
            {
                //COMBOBOX DISPLAY PUNTOS DE VENTA
                MySqlConnection connectionPV = new MySqlConnection("server=localhost; database=hostal; username=root; password=root");
                string queryPV = "SELECT NombreCaja FROM caja WHERE IsDeleted=0 AND Disponible=1";
                connectionPV.Open();
                MySqlCommand commandPV = new MySqlCommand(queryPV, connectionPV);
                MySqlDataReader readerPV = commandPV.ExecuteReader();
                while (readerPV.Read())
                {
                    cbxPuntoVentaCategoria.Items.Add(readerPV.GetString("NombreCaja"));
                    cbxPuntoVentaMesas.Items.Add(readerPV.GetString("NombreCaja"));
                }
                connectionPV.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardarCajas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtNombreCaja.Text == string.Empty)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    caja.NombreCaja = txtNombreCaja.Text;
                    caja.DescripcionCaja = txtDescripcionCaja.Text;
                    if (chkGuardarCajaNoDisponible.Checked == true)
                    {
                        caja.DisponibleCaja = 0;
                    }
                    else
                    {
                        caja.DisponibleCaja = 1;
                    }
                    if (caja.Insert(caja) == true)
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

            dgvCajas.DataSource = caja.Select("Disponible");
            loadDGVs();
            txtIdCajas.Text = caja.countCajas().ToString();
        }

        private void BtnEditarCajas_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCajas.SelectedRows.Count > 0)
            {
                btnGuardarEdicionCajas.Visible = true;
                btnEditarCajas.Visible = false;
                txtIdCajas.Text = dgvCajas.CurrentRow.Cells[0].Value.ToString();
                txtNombreCaja.Text = dgvCajas.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionCaja.Text = dgvCajas.CurrentRow.Cells[2].Value.ToString();
                if (Convert.ToInt32(dgvCajas.CurrentRow.Cells[3].Value.ToString()) == 0)
                {
                    chkGuardarCajaNoDisponible.Checked = true;
                }
                if (Convert.ToInt32(dgvCajas.CurrentRow.Cells[3].Value.ToString()) == 1)
                {
                    chkGuardarCajaNoDisponible.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnLimpiarCajas.Text = "Cancelar";
            dgvCajas.DataSource = caja.Select("Disponible");
            loadDGVs();
        }

        private void BtnBorrarCajas_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva mesa",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                if (dgvCajas.SelectedRows.Count > 0)
                {
                    if (float.Parse(dgvCajas.CurrentRow.Cells[3].Value.ToString()) != 1)
                    {
                        chkGuardarCajaNoDisponible.Checked = false;
                    }
                    if (float.Parse(dgvCajas.CurrentRow.Cells[3].Value.ToString()) == 1)
                    {
                        chkGuardarCajaNoDisponible.Checked = true;
                    }
                    caja.IdCaja = Convert.ToInt32(dgvCajas.CurrentRow.Cells[0].Value);
                    txtNombreCaja.Text = dgvCajas.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcionCaja.Text = dgvCajas.CurrentRow.Cells[2].Value.ToString();
                    if (chkGuardarCajaNoDisponible.Checked == true)
                    {
                        caja.DisponibleCaja = 0;
                    }
                    else
                    {
                        caja.DisponibleCaja = 1;
                    }
                    if (caja.Delete(caja) == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error al borrar caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Clear();
            dgvCajas.DataSource = caja.Select("Disponible");
            loadDGVs();
            txtIdCajas.Text = caja.countCajas().ToString();
        }

        private void BtnMostrarCajasNoDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            btnMostrarCajasDisponibles.Visible = true;
            btnMostrarCajasNoDisponibles.Visible = false;
            dgvCajas.DataSource = caja.Select("NO Disponible");
            loadDGVs();
        }

        private void BtnMostrarCajasDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            dgvCajas.DataSource = caja.Select("Disponible");
            btnMostrarCajasDisponibles.Visible = false;
            btnMostrarCajasNoDisponibles.Visible = true;
            loadDGVs();
        }

        private void BtnMostrarCajasDisponiblesMesas_MouseClick(object sender, MouseEventArgs e)
        {
            dgvMesas.DataSource = mesa.Select("Disponible");
            btnMostrarCajasDisponiblesMesas.Visible = false;
            btnMostrarCajasNoDisponiblesMesas.Visible = true;
            loadDGVs();
        }

        private void BtnMostrarCajasNoDisponiblesMesas_MouseClick(object sender, MouseEventArgs e)
        {
            dgvMesas.DataSource = mesa.Select("NO Disponible");
            btnMostrarCajasDisponiblesMesas.Visible = true;
            btnMostrarCajasNoDisponiblesMesas.Visible = false;
            loadDGVs();
        }

        private void BtnGuardarMesas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtNombreMesa.Text == string.Empty || this.cbxPuntoVentaMesas.Text == string.Empty)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mesa.NombreMesa = txtNombreMesa.Text;
                    mesa.DescripcionMesa = txtDescripcionMesa.Text;
                    mesa.NombreCaja = cbxPuntoVentaMesas.Text;
                    if (chkGuardarMesaNoDisponible.Checked == true)
                    {
                        mesa.DisponibleMesa = 0;
                    }
                    if (chkGuardarMesaNoDisponible.Checked == false)
                    {
                        mesa.DisponibleMesa = 1;
                    }
                    if (mesa.Insert(mesa) == true)
                    {

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

            Clear();
            dgvMesas.DataSource = mesa.Select("Disponible");
            loadDGVs();
            txtIdMesas.Text = mesa.countMesas().ToString();
        }

        private void BtnEditarMesas_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvMesas.SelectedRows.Count > 0)
            {
                btnGuardarEdicionMesas.Visible = true;
                btnEditarMesas.Visible = false;
                txtIdMesas.Text = dgvMesas.CurrentRow.Cells[0].Value.ToString();
                txtNombreMesa.Text = dgvMesas.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionMesa.Text = dgvMesas.CurrentRow.Cells[2].Value.ToString();
                if (Convert.ToInt32(dgvMesas.CurrentRow.Cells[3].Value.ToString()) == 0)
                {
                    chkGuardarMesaNoDisponible.Checked = true;
                }
                if (Convert.ToInt32(dgvMesas.CurrentRow.Cells[3].Value.ToString()) == 1)
                {
                    chkGuardarMesaNoDisponible.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnLimpiarMesas.Text = "Cancelar";
            dgvMesas.DataSource = mesa.Select("Disponible");
            loadDGVs();
        }

        private void BtnBorrarMesas_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva mesa",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                if (dgvMesas.SelectedRows.Count > 0)
                {
                    if (float.Parse(dgvMesas.CurrentRow.Cells[3].Value.ToString()) != 1)
                    {
                        chkGuardarMesaNoDisponible.Checked = false;
                    }
                    if (float.Parse(dgvMesas.CurrentRow.Cells[3].Value.ToString()) == 1)
                    {
                        chkGuardarMesaNoDisponible.Checked = true;
                    }
                    mesa.IdMesa = Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value);
                    txtNombreMesa.Text = dgvMesas.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcionMesa.Text = dgvMesas.CurrentRow.Cells[2].Value.ToString();
                    if (chkGuardarMesaNoDisponible.Checked == true)
                    {
                        mesa.DisponibleMesa = 0;
                    }
                    else
                    {
                        mesa.DisponibleMesa = 1;
                    }
                    if (mesa.Delete(mesa) == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error al editar caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Clear();
            dgvMesas.DataSource = mesa.Select("Disponible");
            loadDGVs();
            txtIdMesas.Text = mesa.countMesas().ToString();
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (editarCategoria == true)
                {
                    MessageBox.Show("Campos ya existentes.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.textBox2.Text == string.Empty || cbxPuntoVentaCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    categoria.NombreCategoria = textBox2.Text;
                    categoria.NombreCaja = cbxPuntoVentaCategoria.Text;
                    if (chxCategoriaEnMostrador.Checked == true)
                    {
                        categoria.EnMostrador = 0;
                    }
                    else
                    {
                        categoria.EnMostrador = 1;
                    }
                    if (categoria.Insert(categoria) == true)
                    {

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

            Clear();
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            loadDGVs();
            txtIdCategorias.Text = categoria.countCategorias().ToString();
        }

        private void Button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                btnGuardarEdicionCategoria.Visible = true;
                button4.Visible = false;
                txtIdCategorias.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                cbxPuntoVentaCategoria.Text = dgvCategoria.CurrentRow.Cells[3].Value.ToString();

                int checkIfEnMostrador = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[2].Value.ToString());
                if (checkIfEnMostrador == 1)
                {
                    chxCategoriaEnMostrador.Checked = false;
                }
                if (checkIfEnMostrador == 0)
                {
                    chxCategoriaEnMostrador.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            button6.Text = "Cancelar";
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            loadDGVs();
        }

        private void Button6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
            chxCategoriaEnMostrador.Checked = false;
            editarCategoria = false;
            btnGuardarEdicionCategoria.Visible = false;
            button4.Visible = true;
        }

        private void BtnMostrarCategoriasEnMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            btnMostrarCategoriasEnMostrador.Visible = false;
            btnMostrarCategoriasEnInventario.Visible = true;
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            dgvCategoria.Columns[2].Visible = false;
        }

        private void BtnMostrarCategoriasEnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            btnMostrarCategoriasEnMostrador.Visible = true;
            btnMostrarCategoriasEnInventario.Visible = false;
            dgvCategoria.DataSource = categoria.SelectCategoriasEnInventario();
            dgvCategoria.Columns[2].Visible = false;
        }

        private void Button5_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva mesa",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                if (dgvCategoria.SelectedRows.Count > 0)
                {
                    categoria.IdCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                    categoria.NombreCategoria = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                    if (chxCategoriaEnMostrador.Checked == true)
                    {
                        categoria.EnMostrador = 1;
                    }
                    else
                    {
                        categoria.EnMostrador = 0;
                    }
                    if (categoria.Delete(categoria) == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Clear();
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            loadDGVs();
            txtIdCategorias.Text = categoria.countCategorias().ToString();
        }

        private void BtnGuardarEdicionCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva categoría",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                try
                {
                    categoria.IdCategoria = Convert.ToInt32(txtIdCategorias.Text);
                    categoria.NombreCategoria = textBox2.Text;
                    categoria.NombreCaja = cbxPuntoVentaCategoria.Text;
                    if (chxCategoriaEnMostrador.Checked == true)
                    {
                        categoria.EnMostrador = 0;
                    }
                    else
                    {
                        categoria.EnMostrador = 1;
                    }

                    if (categoria.Update(categoria) == true)
                    {
                        txtIdCategorias.Text = "";
                        chxCategoriaEnMostrador.Checked = false;
                    }

                    dgvCategoria.Columns[2].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnGuardarEdicionCategoria.Visible = false;
                button4.Visible = true;
            }
            if (result3 == DialogResult.No)
            {
                btnGuardarEdicionCategoria.Visible = false;
                button4.Visible = true;
            }

            txtIdCategorias.Text = categoria.countCategorias().ToString();
            dgvCategoria.DataSource = categoria.SelectCategoriasEnMostrador();
            Clear();
        }

        private void BtnGuardarEdicionCajas_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva caja",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                try
                {
                    caja.IdCaja = Convert.ToInt32(txtIdCajas.Text);
                    caja.NombreCaja = txtNombreCaja.Text;
                    caja.DescripcionCaja = txtDescripcionCaja.Text;

                    if (chkGuardarCajaNoDisponible.Checked == false)
                    {
                        caja.DisponibleCaja = 1;
                    }
                    if (chkGuardarCajaNoDisponible.Checked == true)
                    {
                        caja.DisponibleCaja = 0;
                    }

                    if (caja.Update(caja) == true)
                    {
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnEditarCajas.Visible = true;
                btnGuardarEdicionCajas.Visible = false;
            }
            if (result3 == DialogResult.No)
            {
                btnEditarCajas.Visible = true;
                btnGuardarEdicionCajas.Visible = false;
                Clear();
            }

            dgvCajas.DataSource = caja.Select("Disponible");
            txtIdCajas.Text = caja.countCajas().ToString();
        }

        private void BtnGuardarEdicionMesas_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Seguro que desea guardar?", "Nueva mesa",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                try
                {
                    mesa.IdMesa = Convert.ToInt32(txtIdMesas.Text);
                    mesa.NombreMesa = txtNombreMesa.Text;
                    mesa.DescripcionMesa = txtDescripcionMesa.Text;
                    mesa.NombreCaja = cbxPuntoVentaMesas.Text;
                    if (chkGuardarMesaNoDisponible.Checked == false)
                    {
                        mesa.DisponibleMesa = 1;
                    }
                    if (chkGuardarMesaNoDisponible.Checked == true)
                    {
                        mesa.DisponibleMesa = 0;
                    }

                    if (mesa.Update(mesa) == true)
                    {
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (result3 == DialogResult.No)
            {
                Clear();
            }

            btnEditarMesas.Visible = true;
            btnGuardarEdicionMesas.Visible = false;
            dgvMesas.DataSource = mesa.Select("Disponible");
            txtIdMesas.Text = mesa.countMesas().ToString();
        }

        private void ConfiguracionPOS_Load(object sender, EventArgs e)
        {
            txtIdCategorias.Text = categoria.countCategorias().ToString();
            txtIdCajas.Text = caja.countCajas().ToString();
            txtIdMesas.Text = mesa.countMesas().ToString();
        }

        private void BtnLimpiarMesas_MouseClick(object sender, MouseEventArgs e)
        {
            Clear();
        }

        private void CbxPuntoVentaCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
        }

        private void CbxPuntoVentaMesas_MouseClick(object sender, MouseEventArgs e)
        {
            displayComboBox();
        }
    }
}
