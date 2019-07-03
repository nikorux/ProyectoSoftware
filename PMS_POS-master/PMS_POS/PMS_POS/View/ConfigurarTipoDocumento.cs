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
using MySql.Data.MySqlClient;


namespace PMS_POS.View
{
    public partial class ConfigurarTipoDocumento : UserControl
    {
        Documento obj = new Documento();

    private static ConfigurarTipoDocumento _instance;
    public static ConfigurarTipoDocumento Instance
    {
        get
        {
            if (_instance == null)
                _instance = new ConfigurarTipoDocumento();
            return _instance;
        }
    }
        public ConfigurarTipoDocumento()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                Documento pDocumento = new Documento();
                pDocumento.NombreDocumento = txtNombreTipoDocumento.Text.Trim();

                int resultado = DocumentoC.Agregar(pDocumento);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de documento", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTipoDocumento.DataSource = null;
                    dgvTipoDocumento.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido crear un nuevo tipo de documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurarTipoDocumento_Load(object sender, EventArgs e)
        {
            dgvTipoDocumento.DataSource = obj.VistaTabla();
        }
    }
}
