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
    public partial class ConfigurarTipoHabitacion : UserControl
    {
        TipoHabitacion obj = new TipoHabitacion();
        private static ConfigurarTipoHabitacion _instance;
        public static ConfigurarTipoHabitacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurarTipoHabitacion();
                return _instance;
            }
        }

        public ConfigurarTipoHabitacion()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                TipoHabitacion pNombreTipoHab = new TipoHabitacion();
                pNombreTipoHab.NombreTipoHab = txtTipoHabitacion.Text.Trim();

                int resultado = TipoHabitacionC.Agregar(pNombreTipoHab);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha creado un nuevo tipo de habitación", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTipoHabitacion.DataSource = null;
                    dgvTipoHabitacion.DataSource = obj.VistaTabla();
                }
                else
                {
                    MessageBox.Show("No se ha podido crear un nuevo tipo de habitación", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void TxtTipoHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarTipoHabitacion_Load(object sender, EventArgs e)
        {
            dgvTipoHabitacion.DataSource = obj.VistaTabla();

        }
    }
}
