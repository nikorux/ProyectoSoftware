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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            userControlInicio1.BringToFront();
            this.WindowState = FormWindowState.Maximized;
        }


        UserControlHabitaciones UserControlHabitaciones = new UserControlHabitaciones();


        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           //No va
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          //No va
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //No va
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //No va
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private void Button6_Click(object sender, EventArgs e)
        {
          //No va
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           //No va
        }

        private void Button8_Click(object sender, EventArgs e)
        {
          //No va
        }

        private void Button9_Click(object sender, EventArgs e)
        {
           //No va
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            //No va
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

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
            //No va
        }

        
        private void Timer3_Tick(object sender, EventArgs e)
        {
          //No va
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
          //No va
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
           //No va
        }
       

        private void BtnRegistroProducto_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(RegistroNuevoProducto.Instance))
            {
                userControlInicio1.Controls.Add(RegistroNuevoProducto.Instance);
                RegistroNuevoProducto.Instance.Dock = DockStyle.Fill;
                RegistroNuevoProducto.Instance.BringToFront();
            }
            else
            {
                RegistroNuevoProducto.Instance.BringToFront();
            }
        }

        private void BtnListaProductos_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListadoProducto.Instance))
            {
                userControlInicio1.Controls.Add(ListadoProducto.Instance);
                ListadoProducto.Instance.Dock = DockStyle.Fill;
                ListadoProducto.Instance.BringToFront();
            }
            else
            {
                ListadoProducto.Instance.BringToFront();
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
            if (!userControlInicio1.Controls.Contains(UserControlClientes.Instance))
            {
                userControlInicio1.Controls.Add(UserControlClientes.Instance);
                UserControlClientes.Instance.Dock = DockStyle.Fill;
                UserControlClientes.Instance.BringToFront();
            }
            else
            {
                UserControlClientes.Instance.BringToFront();
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
            if (!userControlInicio1.Controls.Contains(ListadoProveedores.Instance))
            {
                userControlInicio1.Controls.Add(ListadoProveedores.Instance);
                ListadoProveedores.Instance.Dock = DockStyle.Fill;
                ListadoProveedores.Instance.BringToFront();
            }
            else
            {
                ListadoProveedores.Instance.BringToFront();
            }
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
            //No va
        }

        private void UserControlInicio1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoBack_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás segur@ que deseas cerrar la aplicación?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //No va
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //No va
        }

        private void NuevaReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //No va
        }

        private void InsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
          //No va
        }

        private void ClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(UserControlClientes.Instance))
            {
                userControlInicio1.Controls.Add(UserControlClientes.Instance);
                UserControlClientes.Instance.Dock = DockStyle.Fill;
                UserControlClientes.Instance.BringToFront();
            }
            else
            {
                UserControlClientes.Instance.BringToFront();
            }
        }

        private void HabitacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
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
        private void ReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(ListadoProveedores.Instance))
            {
                userControlInicio1.Controls.Add(ListadoProveedores.Instance);
                ListadoProveedores.Instance.Dock = DockStyle.Fill;
                ListadoProveedores.Instance.BringToFront();
            }
            else
            {
                ListadoProveedores.Instance.BringToFront();
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(UserControlClientes.Instance))
            {
                userControlInicio1.Controls.Add(UserControlClientes.Instance);
                UserControlClientes.Instance.Dock = DockStyle.Fill;
                UserControlClientes.Instance.BringToFront();
            }
            else
            {
                UserControlClientes.Instance.BringToFront();
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (!userControlInicio1.Controls.Contains(UserControlInicio.Instance))
            {
                userControlInicio1.Controls.Add(UserControlInicio.Instance);
                UserControlInicio.Instance.Dock = DockStyle.Fill;
                UserControlInicio.Instance.BringToFront();
            }
            else
            {
                UserControlInicio.Instance.BringToFront();
            }
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Segur@ que desea cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {

            if (!userControlInicio1.Controls.Contains(ListadoReservaciones.Instance))
            {
                
                ListadoReservaciones.Instance.Controls.Remove(NuevaReservacion.Instance);
                userControlInicio1.Controls.Add(ListadoReservaciones.Instance);
                ListadoReservaciones.Instance.Dock = DockStyle.Fill;
                ListadoReservaciones.Instance.BringToFront();

            }
            else

              //  ListadoReservaciones.Instance.Refresh();
            ListadoReservaciones.Instance.Controls.Remove(NuevaReservacion.Instance);
                ListadoReservaciones.Instance.BringToFront();
            }
        }

    }
}
