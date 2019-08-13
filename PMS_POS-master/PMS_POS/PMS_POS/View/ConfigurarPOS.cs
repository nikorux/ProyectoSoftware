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

namespace PMS_POS.View
{
    public partial class ConfigurarPOS : UserControl
    {
        private static ConfigurarPOS _instance;
        public static ConfigurarPOS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarPOS();
                return _instance;
            }
        }

        static bool editar = false;

        Caja caja = new Caja();
        Categoria categoria = new Categoria();
        Mesa mesa = new Mesa();
        public ConfigurarPOS()
        {
            InitializeComponent();
            btnMostrarCajasDisponibles.Visible = false;
            btnMostrarCajasNoDisponibles.Visible = true;
            dgvCajas.DataSource = caja.Select("Disponible");
            dgvMesas.DataSource = mesa.Select("Disponible");
        }

        private void ConfigurarPOS_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregarCaja_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtNombreCaja.Text == string.Empty || this.txtDescripcionCaja.Text == string.Empty)
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

        private void BtnEditarCaja_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCajas.SelectedRows.Count > 0)
            {
                if (float.Parse(dgvCajas.CurrentRow.Cells[3].Value.ToString()) == 0)
                {
                    chkGuardarCajaNoDisponible.Checked = true;
                }
                if (float.Parse(dgvCajas.CurrentRow.Cells[3].Value.ToString()) == 1)
                {
                    chkGuardarCajaNoDisponible.Checked = false;
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
                if (caja.Update(caja) == true)
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

        private void BtnBorrarCaja_MouseClick(object sender, MouseEventArgs e)
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

        private void BtnMostrarCajasNoDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            dgvCajas.DataSource = caja.Select("No Disponible");
            btnMostrarCajasDisponibles.Visible = true;
            btnMostrarCajasNoDisponibles.Visible = false;
        }

        private void BtnMostrarCajasDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            dgvCajas.DataSource = caja.Select("Disponible");
            btnMostrarCajasDisponibles.Visible = false;
            btnMostrarCajasNoDisponibles.Visible = true;
        }

        private void BtnMostrarCajasDisponiblesMesas_MouseClick(object sender, MouseEventArgs e)
        {
            dgvMesas.DataSource = mesa.Select("Disponible");
            btnMostrarCajasDisponiblesMesas.Visible = false;
            btnMostrarCajasNoDisponiblesMesas.Visible = true;
        }

        private void BtnMostrarCajasNoDisponiblesMesas_MouseClick(object sender, MouseEventArgs e)
        {
            dgvMesas.DataSource = caja.Select("No Disponible");
            btnMostrarCajasDisponiblesMesas.Visible = true;
            btnMostrarCajasNoDisponiblesMesas.Visible = false;
        }

        private void BtnAgregarMesa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtNombreMesa.Text == string.Empty || this.txtDescripcionMesa.Text == string.Empty)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mesa.NombreMesa = txtNombreMesa.Text;
                    mesa.DescripcionMesa = txtDescripcionMesa.Text;
                    if (chkGuardarMesaNoDisponible.Checked == true)
                    {
                        mesa.DisponibleMesa = 0;
                    }
                    else
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
        }

        private void BtnEditarMesa_MouseClick(object sender, MouseEventArgs e)
        {
            if (editar == true) 
            {         
                if (chkGuardarMesaNoDisponible.Checked == true)
                {
                    mesa.DisponibleMesa = 0;
                }
                else
                {
                    mesa.DisponibleMesa = 1;
                }
                mesa.NombreMesa = txtNombreMesa.Text;
                mesa.DescripcionMesa = txtDescripcionMesa.Text;
                if (mesa.Update(mesa) == true)
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

        private void BtnBorrarMesa_MouseClick(object sender, MouseEventArgs e)
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

        private void BtnAgregarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtCategoriaProducto.Text == string.Empty)
                {
                    MessageBox.Show("Campos vacíos o incorrectos.", "Error al ingresar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    categoria.NombreCategoria = txtCategoriaProducto.Text;
                    if (chxCategoriaEnMostrador.Checked == true)
                    {
                        categoria.EnMostrador = 1;
                    }
                    else
                    {
                        categoria.EnMostrador = 0;
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
        }

        private void BtnEditarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                if (float.Parse(dgvCategoria.CurrentRow.Cells[2].Value.ToString()) != 1)
                {
                    chkGuardarMesaNoDisponible.Checked = false;
                }
                if (float.Parse(dgvCategoria.CurrentRow.Cells[2].Value.ToString()) == 1)
                {
                    chkGuardarMesaNoDisponible.Checked = true;
                }
                categoria.IdCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                txtCategoriaProducto.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();

                if (chxCategoriaEnMostrador.Checked == true)
                {
                    categoria.EnMostrador = 1;
                }
                else
                {
                    categoria.EnMostrador = 0;
                }
                if (categoria.Update(categoria) == true)
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

        private void DgvMesas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void BtnLimpiarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            txtCategoriaProducto.Text = "";
            chxCategoriaEnMostrador.Checked = false;
        }
    }
}