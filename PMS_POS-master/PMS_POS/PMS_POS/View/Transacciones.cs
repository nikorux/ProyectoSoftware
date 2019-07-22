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
    public partial class Transacciones : UserControl
    {
        private static Transacciones _instance;
        public static Transacciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transacciones();
                return _instance;
            }
        }

        public Transacciones()
        {
            InitializeComponent();
        }
    }
}
