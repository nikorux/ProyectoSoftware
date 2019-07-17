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
    public partial class Reportes : UserControl
    {
        private static Reportes _instance;
        public static Reportes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reportes();
                return _instance;
            }
        }
        public Reportes()
        {
            InitializeComponent();
        }
    }
}
