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
    public partial class VerReceta : Form
    {
        static public int IdInsumo = 0;
        static public int IdReceta = 0;
        Receta receta = new Receta();
        public VerReceta(int idInsumo, string NombreInsumo)
        {
            InitializeComponent();
           // this.dgvIngredientes.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            this.dgvIngredientes.RowTemplate.MinimumHeight = 35;
            int IdReceta = receta.SearchIdRecetaDelIdInsumo(idInsumo);
            txtProducto.Text = NombreInsumo;
            txtDescripcion.Text = receta.SearchDescripcionReceta(IdReceta);
            txtComentario.Text = receta.SearchComentarioReceta(IdReceta);
            dgvIngredientes.DataSource = receta.SearchProductosEnReceta(IdReceta);
        }
    }
}
