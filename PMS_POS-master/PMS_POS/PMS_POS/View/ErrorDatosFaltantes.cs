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
    public partial class ErrorDatosFaltantes : Form
    {
        public ErrorDatosFaltantes(string mensaje)
        {
            InitializeComponent();
            lblMensajeT.Text = mensaje;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void confirmacionForm(string mensaje)
        {
            ErrorDatosFaltantes frm = new ErrorDatosFaltantes(mensaje);
            frm.ShowDialog();
        }

        private void ErrorDatosFaltantes_Load(object sender, EventArgs e)
        {
            EsclarecerForm.ShowAsyc(this);
        }
    }
}
