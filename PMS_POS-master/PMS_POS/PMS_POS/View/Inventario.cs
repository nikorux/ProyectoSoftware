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
    public partial class Inventario : UserControl
    {
        private static Inventario _instance;
        public static Inventario Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Inventario();
                return _instance;
            }
        }
        public Inventario()
        {
            InitializeComponent();
        }

        UnidadMedida unidadMedida = new UnidadMedida();
        Producto producto = new Producto();

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (!tabPage1.Controls.Contains(ListadoProducto.InstanceLP))
            {
                tabPage1.Controls.Add(ListadoProducto.InstanceLP);
                ListadoProducto.InstanceLP.Dock = DockStyle.Fill;
                ListadoProducto.InstanceLP.BringToFront();
            }
            else
            {
                ListadoProducto.InstanceLP.BringToFront();
            }

            if (!tabPage4.Controls.Contains(RegistrarNuevaCompra.Instance))
            {
                tabPage4.Controls.Add(RegistrarNuevaCompra.Instance);
                RegistrarNuevaCompra.Instance.Dock = DockStyle.Fill;
                RegistrarNuevaCompra.Instance.BringToFront();
            }
            else
            {
                RegistrarNuevaCompra.Instance.BringToFront();
            }

            if (!tabPage5.Controls.Contains(HistorialCompras.Instance))
            {
                tabPage5.Controls.Add(HistorialCompras.Instance);
                HistorialCompras.Instance.Dock = DockStyle.Fill;
                HistorialCompras.Instance.BringToFront();
            }
            else
            {
                HistorialCompras.Instance.BringToFront();
            }
        }
    }
}
