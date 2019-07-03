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
    public partial class RegistroProveedor : UserControl
    {
        private static RegistroProveedor _instance;
        public static RegistroProveedor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistroProveedor();
                return _instance;
            }
        }
        public RegistroProveedor()
        {
            InitializeComponent();
        }
    }
}
