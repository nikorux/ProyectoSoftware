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
    public partial class RegistrarNuevoEmpleado : UserControl
    {
        private static RegistrarNuevoEmpleado _instance;
        public static RegistrarNuevoEmpleado Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrarNuevoEmpleado();
                return _instance;
            }
        }

        public RegistrarNuevoEmpleado()
        {
            InitializeComponent();
        }
    }
}
