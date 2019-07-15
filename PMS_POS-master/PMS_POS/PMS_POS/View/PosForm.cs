using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.View;

namespace PMS_POS.View
{
    public partial class PosForm : Form
    {
        public string estadoUI { get; set; }

        private static PosForm _instance;
        public static PosForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PosForm();
                return _instance;
            }
        }

        public PosForm()
        {
            InitializeComponent();
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new System.Drawing.Size(width, height);
            panelUIseleccionada.Visible = false;
            panelBasePOS.Visible = true;
            lblestadoUI.Text = estadoUI;
        }

        private void BtnProductos_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            if (!panelUIseleccionada.Controls.Contains(ListadoProducto.InstanceLP))
            {
                panelUIseleccionada.Controls.Add(ListadoProducto.InstanceLP);
                ListadoProducto.InstanceLP.Dock = DockStyle.Fill;
                ListadoProducto.InstanceLP.BringToFront();
            }
            else
            {
                ListadoProducto.InstanceLP.BringToFront();
            }

            estadoUI = "Productos";
        }

        private void BtnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            MenuConfigurar menu = new MenuConfigurar();
            menu.Show();

            estadoUI = "Menu";
        }

        private void BtnReportes_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            /*if (!panelUIseleccionada.Controls.Contains(RegistroProveedor.Instance))
            {
                panelUIseleccionada.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }*/

            estadoUI = "Reportes";
        }

        private void BtnOrdenes_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            /*if (!panelUIseleccionada.Controls.Contains(RegistroProveedor.Instance))
            {
                panelUIseleccionada.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }*/

            estadoUI = "Ordenes";
        }

        private void BtnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            /*if (!panelUIseleccionada.Controls.Contains(RegistroProveedor.Instance))
            {
                panelUIseleccionada.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }*/

            estadoUI = "Inventario";
        }

        private void BtnProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            if (!panelUIseleccionada.Controls.Contains(RegistroProveedor.Instance))
            {
                panelUIseleccionada.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }

            estadoUI = "Proveedores";
        }

        private void BtnMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            /*if (!panelUIseleccionada.Controls.Contains(ListadoProducto.InstanceLP))
            {
                panelUIseleccionada.Controls.Add(ListadoProducto.InstanceLP);
                ListadoProducto.InstanceLP.Dock = DockStyle.Fill;
                ListadoProducto.InstanceLP.BringToFront();
            }
            else
            {
                ListadoProducto.InstanceLP.BringToFront();
            }*/

            estadoUI = "Mostrador";
        }

        private void BtnRegresar_MouseClick(object sender, MouseEventArgs e)
        {
            if (estadoUI == "Productos" || estadoUI == "Menu" || estadoUI == "Reportes" ||
                estadoUI == "Ordenes" || estadoUI == "Inventario" || estadoUI == "Proveedores" ||
                estadoUI == "Mostrador")
            {
                panelUIseleccionada.SendToBack();
                panelUIseleccionada.Visible = false;
                panelBasePOS.BringToFront();
                panelBasePOS.Visible = true;
            }
            if (lblestadoUI.Text == "RegistroProducto")
            {
                if (!panelUIseleccionada.Controls.Contains(ListadoProducto.InstanceRP))
                {
                    panelUIseleccionada.Controls.Add(ListadoProducto.InstanceRP);
                    ListadoProducto.InstanceRP.Dock = DockStyle.Fill;
                    ListadoProducto.InstanceRP.BringToFront();
                }
                else
                {
                    ListadoProducto.InstanceRP.BringToFront();
                }
            }
        }

        private void LblestadoUI_TextChanged(object sender, EventArgs e)
        {
            if (estadoUI == "NuevoProducto")
            {
                panelUIseleccionada.SendToBack();
                panelUIseleccionada.Visible = false;
                panelBasePOS.Visible = true;
            }
        }
    }
}
