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

namespace PMS_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControlInicio1.BringToFront();
            this.WindowState = FormWindowState.Maximized;
        }

        private bool isCollapsedReservaciones;
        //private bool isCollapsedHuesped;
        private bool isCollapsedProveedores;
        private bool isCollapsedProductos;
        private bool isCollapsedReportesFinancieros;
        private bool isCollapsedControlUsuarios;
        private bool isCollapsedConfiguracion;
        private bool isCollapsedClientes;

        UserControlHabitaciones UserControlHabitaciones = new UserControlHabitaciones();


        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            userControlInicio1.BringToFront();           
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = button2.Height;
            SidePanel.Top = ReservacionesDropDown.Top;
            timer1.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = DropDownProductos.Top;
            timer2.Start();            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            {
                SidePanel.Height = button5.Height;
                SidePanel.Top = panelClientes.Top;
                timer6.Start();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = panelProveedores.Top;
            timer7.Start();

            if (!userControlInicio1.Controls.Contains(RegistroProveedor.Instance))
            {
                userControlInicio1.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = panelReportesFinancieros.Top;
            timer3.Start();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
            timer4.Start();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button9.Height;
            SidePanel.Top = button9.Top;
            timer5.Start();
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button10.Height;
            SidePanel.Top = button10.Top;
            SidePanel.BringToFront();

            if (!userControlInicio1.Controls.Contains(UserControlHabitaciones.Instance))
            {
                userControlInicio1.Controls.Add(UserControlHabitaciones.Instance);
                UserControlHabitaciones.Instance.Dock = DockStyle.Fill;
                UserControlHabitaciones.Instance.BringToFront();
            }
            else
            {
                UserControlHabitaciones.Instance.BringToFront();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsedReservaciones)
            {
                ReservacionesDropDown.Height += 10;
                if(ReservacionesDropDown.Size == ReservacionesDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsedReservaciones = false;
                }
            }
            else
            {
                ReservacionesDropDown.Height -= 10;
                if(ReservacionesDropDown.Size == ReservacionesDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsedReservaciones = true;
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListadoReservaciones.Instance))
            {
                userControlInicio1.Controls.Add(ListadoReservaciones.Instance);
                ListadoReservaciones.Instance.Dock = DockStyle.Fill;
                ListadoReservaciones.Instance.BringToFront();
            }
            else
            {
                ListadoReservaciones.Instance.BringToFront();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(NuevaReservacion.Instance))
            {
                userControlInicio1.Controls.Add(NuevaReservacion.Instance);
                NuevaReservacion.Instance.Dock = DockStyle.Fill;
                NuevaReservacion.Instance.BringToFront();
            }
            else
            {
                NuevaReservacion.Instance.BringToFront();
            }
        }

        private void BtnRegistroHuesped_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(NuevoHuesped.Instance))
            {
                userControlInicio1.Controls.Add(NuevoHuesped.Instance);
                NuevoHuesped.Instance.Dock = DockStyle.Fill;
                NuevoHuesped.Instance.BringToFront();
            }
            else
            {
                NuevoHuesped.Instance.BringToFront();
            }

        }

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListaClientes.Instance))
            {
                userControlInicio1.Controls.Add(ListaClientes.Instance);
                ListaClientes.Instance.Dock = DockStyle.Fill;
                ListaClientes.Instance.BringToFront();
            }
            else
            {
                ListaClientes.Instance.BringToFront();
            }
        }

        private void BtnRegistroHabitaciones_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button10.Height;
            SidePanel.Top = button10.Top;
            SidePanel.BringToFront();

            if (!userControlInicio1.Controls.Contains(UserControlHabitaciones.Instance))
            {
                userControlInicio1.Controls.Add(UserControlHabitaciones.Instance);
                UserControlHabitaciones.Instance.Dock = DockStyle.Fill;
                UserControlHabitaciones.Instance.BringToFront();
            }
            else
            {
                UserControlHabitaciones.Instance.BringToFront();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedProductos)
            {
                DropDownProductos.Height += 10;
                if (DropDownProductos.Size == DropDownProductos.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsedProductos = false;
                }
            }
            else
            {
                DropDownProductos.Height -= 10;
                if (DropDownProductos.Size == DropDownProductos.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsedProductos = true;
                }
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedReportesFinancieros)
            {
                panelReportesFinancieros.Height += 10;
                if (panelReportesFinancieros.Size == panelReportesFinancieros.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsedReportesFinancieros = false;
                }
            }
            else
            {
                panelReportesFinancieros.Height -= 10;
                if (panelReportesFinancieros.Size == panelReportesFinancieros.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsedReportesFinancieros = true;
                }
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsedControlUsuarios)
            {
                panelControlUsuarios.Height += 10;
                if (panelControlUsuarios.Size == panelControlUsuarios.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsedControlUsuarios = false;
                }
            }
            else
            {
                panelControlUsuarios.Height -= 10;
                if (panelControlUsuarios.Size == panelControlUsuarios.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsedControlUsuarios = true;
                }
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsedConfiguracion)
            {
                panelConfiguracion.Height += 10;
                if (panelConfiguracion.Size == panelConfiguracion.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsedConfiguracion = false;
                }
            }
            else
            {
                panelConfiguracion.Height -= 10;
                if (panelConfiguracion.Size == panelConfiguracion.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsedConfiguracion = true;
                }
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsedClientes)
            {
                panelClientes.Height += 10;
                if (panelClientes.Size == panelClientes.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsedClientes = false;
                }
            }
            else
            {
                panelClientes.Height -= 10;
                if (panelClientes.Size == panelClientes.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsedClientes = true;
                }
            }
        }

        private void BtnRegistroProducto_Click(object sender, EventArgs e)
        {
            //llama la instancia para el registro de productos
            if (!userControlInicio1.Controls.Contains(ListadoProducto.InstanceRP))
            {
                userControlInicio1.Controls.Add(ListadoProducto.InstanceRP);
                ListadoProducto.InstanceRP.Dock = DockStyle.Fill;
                ListadoProducto.InstanceRP.BringToFront();
            }
            else
            {
                ListadoProducto.InstanceRP.BringToFront();
            }
        }

        private void BtnListaProductos_Click(object sender, EventArgs e)
        {
            //llama la instancia para el listado de productos
            if (!userControlInicio1.Controls.Contains(ListadoProducto.InstanceLP))
            {
                userControlInicio1.Controls.Add(ListadoProducto.InstanceLP);
                ListadoProducto.InstanceLP.Dock = DockStyle.Fill;
                ListadoProducto.InstanceLP.BringToFront();
            }
            else
            {
                ListadoProducto.InstanceLP.BringToFront();
            }
        }

        private void BtnInformacionCompania_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(InformacionEstablecimiento.Instance))
            {
                userControlInicio1.Controls.Add(InformacionEstablecimiento.Instance);
                InformacionEstablecimiento.Instance.Dock = DockStyle.Fill;
                InformacionEstablecimiento.Instance.BringToFront();
            }
            else
            {
                InformacionEstablecimiento.Instance.BringToFront();
            }
        }

        private void BtnTipoDocumento_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ConfigurarTipoDocumento.Instance))
            {
                userControlInicio1.Controls.Add(ConfigurarTipoDocumento.Instance);
                ConfigurarTipoDocumento.Instance.Dock = DockStyle.Fill;
                ConfigurarTipoDocumento.Instance.BringToFront();
            }
            else//flkdsjk
            {
                ConfigurarTipoDocumento.Instance.BringToFront();
            }
        }

        private void BtnTipoHabitaciones_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ConfigurarTipoHabitacion.Instance))
            {
                userControlInicio1.Controls.Add(ConfigurarTipoHabitacion.Instance);
                ConfigurarTipoHabitacion.Instance.Dock = DockStyle.Fill;
                ConfigurarTipoHabitacion.Instance.BringToFront();
            }
            else
            {
                ConfigurarTipoHabitacion.Instance.BringToFront();
            }
        }

        private void BtnTipoRubroProveedores_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ConfigurarRubroProveedor.Instance))
            {
                userControlInicio1.Controls.Add(ConfigurarRubroProveedor.Instance);
                ConfigurarRubroProveedor.Instance.Dock = DockStyle.Fill;
                ConfigurarRubroProveedor.Instance.BringToFront();
            }
            else
            {
                ConfigurarRubroProveedor.Instance.BringToFront();
            }
        }

        private void BtnConfigurarTipoCategoria_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ConfigurarCategoriaProducto.Instance))
            {
                userControlInicio1.Controls.Add(ConfigurarCategoriaProducto.Instance);
                ConfigurarCategoriaProducto.Instance.Dock = DockStyle.Fill;
                ConfigurarCategoriaProducto.Instance.BringToFront();
            }
            else
            {
                ConfigurarCategoriaProducto.Instance.BringToFront();
            }
        }

        private void BtnConfigurarImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void BtnPermisosUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnListadoEmpleados_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListadoEmpleados.Instance))
            {
                userControlInicio1.Controls.Add(ListadoEmpleados.Instance);
                ListadoEmpleados.Instance.Dock = DockStyle.Fill;
                ListadoEmpleados.Instance.BringToFront();
            }
            else
            {
                ListadoEmpleados.Instance.BringToFront();
            }
        }

        private void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(RegistrarNuevoEmpleado.Instance))
            {
                userControlInicio1.Controls.Add(RegistrarNuevoEmpleado.Instance);
                RegistrarNuevoEmpleado.Instance.Dock = DockStyle.Fill;
                RegistrarNuevoEmpleado.Instance.BringToFront();
            }
            else
            {
                RegistrarNuevoEmpleado.Instance.BringToFront();
            }
        }

        private void BtnIngresosDía_Click(object sender, EventArgs e)
        {

        }

        private void BtnEgresosDía_Click(object sender, EventArgs e)
        {

        }

        private void BtnDescuentosRegistradosHoy_Click(object sender, EventArgs e)
        {

        }

        private void BtnResumenDía_Click(object sender, EventArgs e)
        {

        }

        private void BtnReservacionesCanceladas_Click(object sender, EventArgs e)
        {

        }

        private void BtnDescuentosRealizados_Click(object sender, EventArgs e)
        {

        }

        private void BtnImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListadoFacturas.Instance))
            {
                userControlInicio1.Controls.Add(ListadoFacturas.Instance);
                ListadoFacturas.Instance.Dock = DockStyle.Fill;
                ListadoFacturas.Instance.BringToFront();
            }
            else
            {
                ListadoFacturas.Instance.BringToFront();
            }
        }

        private void BtnCuentasPorHospedaje_Click(object sender, EventArgs e)
        {

        }

        private void BtnDetallesIngresosExtras_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistroProveedores_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(RegistroProveedor.Instance))
            {
                userControlInicio1.Controls.Add(RegistroProveedor.Instance);
                RegistroProveedor.Instance.Dock = DockStyle.Fill;
                RegistroProveedor.Instance.BringToFront();
            }
            else
            {
                RegistroProveedor.Instance.BringToFront();
            }
        }

        private void BtnListadoProveedores_Click(object sender, EventArgs e)
        {
            /*if (!userControlInicio1.Controls.Contains(ListadoProveedores.Instance))
            {
                userControlInicio1.Controls.Add(ListadoProveedores.Instance);
                ListadoProveedores.Instance.Dock = DockStyle.Fill;
                ListadoProveedores.Instance.BringToFront();
            }
            else
            {
                ListadoProveedores.Instance.BringToFront();
            }*/
        }

        private void BtnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(PuntoDeVenta.Instance))
            {
                userControlInicio1.Controls.Add(PuntoDeVenta.Instance);
                PuntoDeVenta.Instance.Dock = DockStyle.Fill;
                PuntoDeVenta.Instance.BringToFront();
            }
            else
            {
                PuntoDeVenta.Instance.BringToFront();
            }
        }

        private void BtnHistorialCompra_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(HistorialCompras.Instance))
            {
                userControlInicio1.Controls.Add(HistorialCompras.Instance);
                HistorialCompras.Instance.Dock = DockStyle.Fill;
                HistorialCompras.Instance.BringToFront();
            }
            else
            {
                HistorialCompras.Instance.BringToFront();
            }
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(RegistrarNuevaCompra.Instance))
            {
                userControlInicio1.Controls.Add(RegistrarNuevaCompra.Instance);
                RegistrarNuevaCompra.Instance.Dock = DockStyle.Fill;
                RegistrarNuevaCompra.Instance.BringToFront();
            }
            else
            {
                RegistrarNuevaCompra.Instance.BringToFront();
            }
        }

        private void BtnVentasPorCategoria_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(VentaPorCategoria.Instance))
            {
                userControlInicio1.Controls.Add(VentaPorCategoria.Instance);
                VentaPorCategoria.Instance.Dock = DockStyle.Fill;
                VentaPorCategoria.Instance.BringToFront();
            }
            else
            {
                VentaPorCategoria.Instance.BringToFront();
            }
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
            if (isCollapsedProveedores)
            {
                panelProveedores.Height += 10;
                if (panelProveedores.Size == panelProveedores.MaximumSize)
                {
                    timer7.Stop();
                    isCollapsedProveedores = false;
                }
            }
            else
            {
                panelProveedores.Height -= 10;
                if (panelProveedores.Size == panelProveedores.MinimumSize)
                {
                    timer7.Stop();
                    isCollapsedProveedores = true;
                }
            }
        }

        private void UserControlInicio1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoBack_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
