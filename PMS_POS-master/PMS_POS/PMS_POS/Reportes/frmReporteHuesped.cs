using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace PMS_POS.Reportes
{
    public partial class frmReporteHuesped : Form
    {
        private static frmReporteHuesped _instance;
        public static frmReporteHuesped Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmReporteHuesped();
                return _instance;
            }
        }

        string instruccion;
        MySqlConnection conex;
        string cadenaconex;
        public frmReporteHuesped()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }

        private void FrmReporteHuesped_Load(object sender, EventArgs e)
        {

            this.rptHuesped.RefreshReport();

            instruccion = "Select IdHuesped, PrimerNombre, SegundoNombre, PrimerApellido, NumDocumento, TipoDocumento, Sexo, Telefono, Pais FROM huesped WHERE IsDeleted = 0";
            MySqlDataAdapter da = new MySqlDataAdapter(instruccion, conexion());
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("huesped", ds.Tables[0]);

            rptHuesped.LocalReport.DataSources.Clear();
            rptHuesped.LocalReport.DataSources.Add(fuente);
            rptHuesped.LocalReport.ReportEmbeddedResource = "PMS_POS.Reportes.reportehuespedes.rdlc";

            rptHuesped.LocalReport.Refresh();
            rptHuesped.Refresh();
            rptHuesped.RefreshReport();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            instruccion = "Select IdHuesped, PrimerNombre, SegundoNombre, PrimerApellido, NumDocumento, TipoDocumento, Sexo, Telefono, Pais FROM huesped WHERE IsDeleted = 0";
            MySqlDataAdapter da = new MySqlDataAdapter(instruccion, conexion());
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("huesped", ds.Tables[0]);

            rptHuesped.LocalReport.DataSources.Clear();
            rptHuesped.LocalReport.DataSources.Add(fuente);
            rptHuesped.LocalReport.ReportEmbeddedResource = "PMS_POS.Reportes.reportehuespedes.rdlc";

            rptHuesped.LocalReport.Refresh();
            rptHuesped.Refresh();
            rptHuesped.RefreshReport();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            instruccion = "Select IdEmpleado, PrimerNombre, SegundoNombre, PrimerApellido, Rol, NumDocumento, TipoDocumento, Telefono, Correo, Pais FROM empleado WHERE IsDeleted = 0";
            MySqlDataAdapter da = new MySqlDataAdapter(instruccion, conexion());
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("empleado", ds.Tables[0]);

            rptHuesped.LocalReport.DataSources.Clear();
            rptHuesped.LocalReport.DataSources.Add(fuente);
            rptHuesped.LocalReport.ReportEmbeddedResource = "PMS_POS.Reportes.reporteEmpleados.rdlc";

            rptHuesped.LocalReport.Refresh();
            rptHuesped.Refresh();
            rptHuesped.RefreshReport();
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            instruccion = "Select IdHuesped, PrimerNombre, SegundoNombre, PrimerApellido, NumDocumento, TipoDocumento, Sexo, Telefono, Pais FROM huesped WHERE IsDeleted = 0";
            MySqlDataAdapter da = new MySqlDataAdapter(instruccion, conexion());
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("huesped", ds.Tables[0]);

            rptHuesped.LocalReport.DataSources.Clear();
            rptHuesped.LocalReport.DataSources.Add(fuente);
            rptHuesped.LocalReport.ReportEmbeddedResource = "PMS_POS.Reportes.WizardPrueba.rdlc";

            rptHuesped.LocalReport.Refresh();
            rptHuesped.Refresh();
            rptHuesped.RefreshReport();
        }

        private void FrmReporteHuesped_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
    
}
