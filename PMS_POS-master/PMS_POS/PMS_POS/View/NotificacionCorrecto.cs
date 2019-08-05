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
    public partial class NotificacionCorrecto : Form
    {
        public NotificacionCorrecto(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void NotificacionCorrecto_Load(object sender, EventArgs e)
        {
            esclarecerForm.ShowAsyc(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void confirmacionForm(string mensaje)
        {
            NotificacionCorrecto frm = new NotificacionCorrecto(mensaje);
            frm.ShowDialog();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
