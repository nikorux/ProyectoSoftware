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
    public partial class FrmSeguroCerrar : Form
    {
        public FrmSeguroCerrar(string mensaje)
        {
            InitializeComponent();
            lblMensajeD.Text = mensaje;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeguroCerrar_Load(object sender, EventArgs e)
        {
            EsclarecerForm.ShowAsyc(this);
        }
        public static void confirmacionForm(string mensaje)
        {
            FrmSeguroCerrar frm = new FrmSeguroCerrar(mensaje);
            frm.ShowDialog();
        }
    }
}
