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

namespace PMS_POS.View
{
    public partial class ConfigurarCategoriaProducto : UserControl
    {
        Categoria obj = new Categoria();

        private static ConfigurarCategoriaProducto _instance;
        public static ConfigurarCategoriaProducto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarCategoriaProducto();
                return _instance;
            }
        }

        public ConfigurarCategoriaProducto()
        {
            InitializeComponent();
        }

        CategoriaP categoriaP = new CategoriaP();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.NombreCategoria = txtCategoriaProducto.Text.Trim();
            int EnMostrador = 0;
            if (chxCategoriaEnMostrador.Checked == true)
            {
                EnMostrador = 1;
            }

            bool resultado = categoriaP.Agregar(categoria.NombreCategoria, EnMostrador);
            if (resultado == true)
            {
                MessageBox.Show("Se ha creado un nuevo tipo de categoría de productos.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCategoriaProducto.DataSource = null;
                dgvCategoriaProducto.DataSource = obj.VistaTabla();
            }
            else
            {
                MessageBox.Show("No se ha podido crear un nuevo tipo de documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategoriaProducto.SelectedRows.Count > 0)
            {
                Categoria categoria = new Categoria();
                categoria.NombreCategoria = txtCategoriaProducto.Text.Trim();
                int EnMostrador = 0;
                if (chxCategoriaEnMostrador.Checked == true)
                {
                    EnMostrador = 1;
                }

                bool resultado = categoria.UpdateEnMostrador(categoria.NombreCategoria, EnMostrador);
                if (resultado == true)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de categoría de productos.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCategoriaProducto.DataSource = null;
                    dgvCategoriaProducto.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido editarla categoría", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCategoriaProducto.SelectedRows.Count > 0)
            {
                Categoria categoria = new Categoria();
                bool resultado = categoria.Delete(Convert.ToInt32(dgvCategoriaProducto.CurrentRow.Cells[0].Value));
                if (resultado == true)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de categoría de productos.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCategoriaProducto.DataSource = null;
                    dgvCategoriaProducto.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido editarla categoría", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtCategoriaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurarCategoriaProducto_Load(object sender, EventArgs e)
        {
            dgvCategoriaProducto.DataSource = obj.VistaTabla();
        }

        private void ChxCategoriaEnMostrador_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
