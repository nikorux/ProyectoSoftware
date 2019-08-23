using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_POS.View
{
    public partial class FrmCorrecto : Form
    {
        public FrmCorrecto(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void FrmCorrecto_Load(object sender, EventArgs e)
        {
            EsclarecerForm.ShowAsyc(this);
        }

        public static void confirmacionForm(string mensaje)
        {
            FrmCorrecto frm = new FrmCorrecto(mensaje);
            frm.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
