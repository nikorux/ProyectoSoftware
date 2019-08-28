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
using System.Runtime.InteropServices;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class PosForm : Form
    {
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
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int height
        );

        static public string cajaSeleccionada;
        static public int IDcaja;

        public void showPaginaInicio()
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;

            if (!panelUIseleccionada.Controls.Contains(PaginaInicio.Instance))
            {
                panelUIseleccionada.Controls.Add(PaginaInicio.Instance);
                PaginaInicio.Instance.Dock = DockStyle.Fill;
                PaginaInicio.Instance.BringToFront();
            }
            else
            {
                PaginaInicio.Instance.BringToFront();
            }
        }

        Caja caja = new Caja();

        public PosForm()
        {
            InitializeComponent();
            panelBasePOS.Visible = true;

            //showPaginaInicio();
            pnlCajasDisponibles.Visible = false;
            cajaSeleccionada = txtCajaSeleccionada.Text;

            pnlBotonesProveedores.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonInicio.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonInventario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonMostrador.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonReportes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonTransacciones.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotonVentas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlConfigurar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void hideUIs()
        {
            Ordenes1.Instance.SendToBack();
            RegistroProveedor.Instance.SendToBack();
            PaginaInicio.Instance.SendToBack();
            ListadoProducto.InstanceLP.SendToBack();
            ReporteVentas.Instance.SendToBack();
            Reportes.Instance.SendToBack();
            Inventario.Instance.SendToBack();
        }

        public void showReportes()
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;
            hideUIs();

            if (!panelUIseleccionada.Controls.Contains(Reportes.Instance))
            {
                panelUIseleccionada.Controls.Add(Reportes.Instance);
                Reportes.Instance.Dock = DockStyle.Fill;
                Reportes.Instance.BringToFront();
            }
            else
            {
                Reportes.Instance.BringToFront();
            }
        }

        public void showInventario()
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;
            hideUIs();

            if (!panelUIseleccionada.Controls.Contains(Inventario.Instance))
            {
                panelUIseleccionada.Controls.Add(Inventario.Instance);
                Inventario.Instance.Dock = DockStyle.Fill;
                Inventario.Instance.BringToFront();
            }
            else
            {
                Inventario.Instance.BringToFront();
            }
        }
        public void showProveedores()
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;
            hideUIs();

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
        }

        public void showMostrador()
        {
            panelUIseleccionada.BringToFront();
            panelUIseleccionada.Visible = true;
            hideUIs();
        }

        public void uiColor()
        {
                pnlBotonInicio.BackColor = Color.FromArgb(0, 102, 204);
            
                pnlBotonInventario.BackColor = Color.FromArgb(0, 102, 204);
            
                pnlBotonReportes.BackColor = Color.FromArgb(0, 102, 204);
            
                pnlBotonMenu.BackColor = Color.FromArgb(0, 102, 204);
            
                pnlBotonMostrador.BackColor = Color.FromArgb(0, 102, 204);

                pnlBotonTransacciones.BackColor = Color.FromArgb(0, 102, 204);

                pnlBotonesProveedores.BackColor = Color.FromArgb(0, 102, 204);

                pnlBotonVentas.BackColor = Color.FromArgb(0, 102, 204);
        }

        public void panelSeleccionada(string ui)
        {
            uiColor();

            switch (ui)
            {
                case "Home":
                    pnlBotonInicio.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Inventario":
                    pnlBotonInventario.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Reportes":
                    pnlBotonReportes.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Menu":
                    pnlBotonMenu.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Mostrador":
                    pnlBotonMostrador.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Ordenes":
                    pnlBotonTransacciones.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Proveedores":
                    pnlBotonesProveedores.BackColor = Color.FromArgb(198, 212, 255);
                    break;
                case "Ventas":
                    pnlBotonVentas.BackColor = Color.FromArgb(198, 212, 255);
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int ampmHOUR = Convert.ToInt32(DateTime.Now.ToString("HH"));
            string ampm = null;
            if(ampmHOUR <= 11)
            {
                ampm = "AM";
            }
            else
            {
                ampm = "PM";
            }

            lblHora.Text = DateTime.Now.ToString("hh:mm ");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAMPM.Text = ampm;
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblAMPM.Select();
            lblAMPM.Focus();
        }

        private void PictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                VentasHOY ventas = new VentasHOY(txtCajaSeleccionada.Text);
                ventas.Show();
            }
        }

        private void PnlBotonVentas_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                VentasHOY ventas = new VentasHOY(txtCajaSeleccionada.Text);
                ventas.Show();
            }
        }

        private void LblVentas_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                VentasHOY ventas = new VentasHOY(txtCajaSeleccionada.Text);
                ventas.Show();
            }
        }

        private void PnlBotonVentas_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMG;
            pnlBotonVentas.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonVentas_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMGhover;
            pnlBotonVentas.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void LblVentas_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMG;
            pnlBotonVentas.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void LblVentas_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMGhover;
            pnlBotonVentas.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMG;
            pnlBotonVentas.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = PMS_POS.Properties.Resources.VentasIMGhover;
            pnlBotonVentas.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonReportes_MouseClick(object sender, MouseEventArgs e)
        {
            showReportes();
        }

        private void Lblreporte_MouseClick(object sender, MouseEventArgs e)
        {
            showReportes();
        }

        private void PictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            showReportes();
        }

        private void PnlBotonesProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            showProveedores();
        }

        private void LblProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            showProveedores();
        }

        private void PictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            showProveedores();
        }

        private void PnlBotonMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MenuConfigurar menuConfigurar = new MenuConfigurar(txtCajaSeleccionada.Text);
                menuConfigurar.Show();
            }
        }

        private void Lblmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MenuConfigurar menuConfigurar = new MenuConfigurar(txtCajaSeleccionada.Text);
                menuConfigurar.Show();
            }
        }

        private void PictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MenuConfigurar menuConfigurar = new MenuConfigurar(txtCajaSeleccionada.Text);
                menuConfigurar.Show();
            }
        }

        private void PnlBotonInicio_MouseClick(object sender, MouseEventArgs e)
        {
            //showPaginaInicio();
        }

        private void LblInicio_MouseClick(object sender, MouseEventArgs e)
        {
            //showPaginaInicio();
        }

        private void PictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            //showPaginaInicio();
        }

        private void PnlBotonMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            if(cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MostradorPOS mostradorPOS = new MostradorPOS(cajaSeleccionada, IDcaja);
                mostradorPOS.Show();
            }
            
        }

        private void LblMostrador_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MostradorPOS mostradorPOS = new MostradorPOS(cajaSeleccionada, IDcaja);
                mostradorPOS.Show();
            }
        }

        private void PictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                MostradorPOS mostradorPOS = new MostradorPOS(cajaSeleccionada, IDcaja);
                mostradorPOS.Show();
            }
        }

        private void PnlBotonInventario_MouseClick_1(object sender, MouseEventArgs e)
        {
            showInventario();
        }

        private void Label7_MouseClick(object sender, MouseEventArgs e)
        {
            showInventario();
        }

        private void PictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            showInventario();
        }

        private void PnlBotonTransacciones_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox7.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Ordenes_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Ordenes_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonTransacciones_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox14.Image = PMS_POS.Properties.Resources.OrdenesIMG;
            pnlBotonTransacciones.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonInventario_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMG;
            pnlBotonInventario.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Label7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMG;
            pnlBotonInventario.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMG;
            pnlBotonInventario.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Label7_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMGhover;
            pnlBotonInventario.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMGhover;
            pnlBotonInventario.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonInventario_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = PMS_POS.Properties.Resources.InventarioIMGhover;
            pnlBotonInventario.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonMostrador_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMG;
            pnlBotonMostrador.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void LblMostrador_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMG;
            pnlBotonMostrador.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMG;
            pnlBotonMostrador.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonMostrador_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMGhover;
            pnlBotonMostrador.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void LblMostrador_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMGhover;
            pnlBotonMostrador.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = PMS_POS.Properties.Resources.MostradorIMGhover;
            pnlBotonMostrador.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonInicio_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMG;
            pnlBotonInicio.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void LblInicio_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMG;
            pnlBotonInicio.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMG;
            pnlBotonInicio.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonInicio_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMGhover;
            pnlBotonInicio.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void LblInicio_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMGhover;
            pnlBotonInicio.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = PMS_POS.Properties.Resources.HomeIMGhover;
            pnlBotonInicio.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonesProveedores_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void LblProveedores_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonesProveedores_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGactualhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void LblProveedores_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGactualhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox15_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = PMS_POS.Properties.Resources.ProveedoresIMGactualhover;
            pnlBotonesProveedores.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonReportes_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMG;
            pnlBotonReportes.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Lblreporte_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMG;
            pnlBotonReportes.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMG;
            pnlBotonReportes.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonReportes_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMGhover;
            pnlBotonReportes.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Lblreporte_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMGhover;
            pnlBotonReportes.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = PMS_POS.Properties.Resources.ReportsIMGhover;
            pnlBotonReportes.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonMenu_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMG;
            pnlBotonMenu.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Lblmenu_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMG;
            pnlBotonMenu.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMG;
            pnlBotonMenu.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlBotonMenu_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMGhover;
            pnlBotonMenu.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Lblmenu_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMGhover;
            pnlBotonMenu.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = PMS_POS.Properties.Resources.ConfigurarMenuIMGhover;
            pnlBotonMenu.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlBotonTransacciones_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                OrdenesHOY ordenes = new OrdenesHOY(txtCajaSeleccionada.Text);
                ordenes.Show();
            }
        }

        private void Ordenes_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                OrdenesHOY ordenes = new OrdenesHOY(txtCajaSeleccionada.Text);
                ordenes.Show();
            }
        }

        private void PictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            if (cajaSeleccionada == "Seleccionar")
            {
                MessageBox.Show("Por favor, elige una caja.");
            }
            else
            {
                OrdenesHOY ordenes = new OrdenesHOY(txtCajaSeleccionada.Text);
                ordenes.Show();
            }
        }

        private void Label8_MouseHover(object sender, EventArgs e)
        {
            pnlBotonTransacciones.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Label8_MouseLeave(object sender, EventArgs e)
        {
            pnlBotonTransacciones.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Label9_MouseHover(object sender, EventArgs e)
        {
            pnlBotonVentas.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Label9_MouseLeave(object sender, EventArgs e)
        {
            pnlBotonVentas.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Label10_MouseHover(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void Label10_MouseLeave(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PictureBox17_MouseHover(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlConfigurar_MouseHover(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(198, 212, 255);
        }

        private void PnlConfigurar_MouseLeave(object sender, EventArgs e)
        {
            pnlConfigurar.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void PnlConfigurar_MouseClick(object sender, MouseEventArgs e)
        {
            ConfiguracionPOS configuracion = new ConfiguracionPOS();
            configuracion.Show();
        }

        private void PictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            ConfiguracionPOS configuracion = new ConfiguracionPOS();
            configuracion.Show();
        }

        private void Label10_MouseClick(object sender, MouseEventArgs e)
        {
            ConfiguracionPOS configuracion = new ConfiguracionPOS();
            configuracion.Show();
        }

        private void DgvCajasDisponibles_MouseLeave(object sender, EventArgs e)
        {
            pnlCajasDisponibles.Visible = false;
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            pnlCajasDisponibles.Visible = true;
            pnlCajasDisponibles.BringToFront();
            dgvCajasDisponibles.DataSource = caja.Select("Disponible");
            dgvCajasDisponibles.Columns[2].Visible = false;
            dgvCajasDisponibles.Columns[3].Visible = false;
            dgvCajasDisponibles.Columns[4].Visible = false;
            dgvCajasDisponibles.Columns[5].Visible = false;
        }

        private void DgvCajasDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCajaSeleccionada.Text = dgvCajasDisponibles.CurrentRow.Cells[1].Value.ToString();
            cajaSeleccionada = txtCajaSeleccionada.Text;
            IDcaja = Convert.ToInt32(dgvCajasDisponibles.CurrentRow.Cells[0].Value);
        }
    }
}
