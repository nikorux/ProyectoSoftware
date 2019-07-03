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
    public partial class ConfigurarRubroProveedor : UserControl
    {
        Documento obj = new Documento();
        private static ConfigurarRubroProveedor _instance;
        public static ConfigurarRubroProveedor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarRubroProveedor();
                return _instance;
            }
        }
        public ConfigurarRubroProveedor()
        {
            InitializeComponent();
        }

        private void TxtRubroProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                Rubro pNombreRubro = new Rubro();
                pNombreRubro.NombreRubro = txtRubroProveedor.Text.Trim();

                int resultado = RubroC.Agregar(pNombreRubro);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de rubro", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRubroProveedor.DataSource = null;
                    dgvRubroProveedor.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido crear un nuevo tipo de rubro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarRubroProveedor_Load(object sender, EventArgs e)
        {
            dgvRubroProveedor.DataSource = obj.VistaTabla();

        }
    }
}