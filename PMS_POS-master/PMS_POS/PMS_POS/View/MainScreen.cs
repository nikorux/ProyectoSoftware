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
using PMS_POS.Reportes;


namespace PMS_POS
{
    public partial class MainScreen : Form
    {
        static MainScreen _obj;

        public static MainScreen Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainScreen();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return PanelContenedor;  }
            set { PanelContenedor = value; }
        }
        public MainScreen()
        {
            InitializeComponent();

        }


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
        }

        private void BtnListaProductos_Click(object sender, EventArgs e)
        {
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
            else
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
        }

        private void BtnConfigurarTipoCategoria_Click(object sender, EventArgs e)
        {

        }
     

        private void BtnConfigurarImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void BtnPermisosUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnListadoEmpleados_Click(object sender, EventArgs e)
        {
    
        }

        private void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
          
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
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
        }

        private void BtnVentasPorCategoria_Click(object sender, EventArgs e)
        {
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
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            UserControlClientes thisprobando = new UserControlClientes();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void HabitacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            UserControlHabitaciones thisprobando = new UserControlHabitaciones();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }
        private void ReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            NuevaReservacion thisprobando = NuevaReservacion.Instance;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        UserControlClientes este = new UserControlClientes();

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            UserControlClientes thisprobando = new UserControlClientes();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            UserControlInicio thisprobando = new UserControlInicio();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
            /*PanelContenedor.Hide();
            if (!userControlInicio1.Controls.Contains(UserControlInicio.Instance))
            {
                userControlInicio1.Controls.Add(UserControlInicio.Instance);
                UserControlInicio.Instance.Dock = DockStyle.Fill;
                UserControlInicio.Instance.BringToFront();
            }
            else
            {
                UserControlInicio.Instance.BringToFront();
            }*/
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            UserControlEmpleados thisprobando = new UserControlEmpleados();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
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
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            Reservaciones thisprobando = new Reservaciones();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
            /*PanelContenedor.Hide();

            if (!userControlInicio1.Controls.Contains(Reservaciones.Instance))
            {
                userControlInicio1.Controls.Add(Reservaciones.Instance);
                Reservaciones.Instance.Dock = DockStyle.Fill;
                Reservaciones.Instance.BringToFront();
            }
            else
            {
                Reservaciones.Instance.BringToFront();
            }*/
        }


        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            FacturacionCheckOut thisprobando = new FacturacionCheckOut();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();

        }

        private void userControlInicio1_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            CheckedIn thisprobando = new CheckedIn();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _obj = this;

            UserControlInicio uc = new UserControlInicio();
            uc.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(uc);
        }

        private void TipoDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            ConfigurarTipoHabitacion thisprobando = new ConfigurarTipoHabitacion();
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void ModificarLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            ConfigurarImagen thisprobando = new ConfigurarImagen();
            thisprobando.TopLevel = false;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void ReportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            frmReporteHuesped thisprobando = new frmReporteHuesped();
            thisprobando.TopLevel = false;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();

        }

        private void TipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            ConfigurarTipoDocumento thisprobando = new ConfigurarTipoDocumento();
            //thisprobando.TopLevel = false;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void CheckOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void GráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            VentanaGraficos thisprobando = new VentanaGraficos();
            thisprobando.TopLevel = false;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelContenedor.Show();
            userControlInicio1.SendToBack();
            PanelContenedor.Controls.Clear();
            FrmLogincs thisprobando = new FrmLogincs();
            thisprobando.TopLevel = false;
            PanelContenedor.Controls.Add(thisprobando);
            thisprobando.Show();
        }
    }

    }

