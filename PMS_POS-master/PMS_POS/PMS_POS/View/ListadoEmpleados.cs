using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_POS.View
{
    public partial class ListadoEmpleados : UserControl
    {
        private static ListadoEmpleados _instance;
        public static ListadoEmpleados Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListadoEmpleados();
                return _instance;
            }
        }

        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        private void BtnReestablecerContrasena_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }
    }
}
