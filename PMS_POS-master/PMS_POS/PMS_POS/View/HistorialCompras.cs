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
    public partial class HistorialCompras : UserControl
    {
        private static HistorialCompras _instance;
        public static HistorialCompras Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HistorialCompras();
                return _instance;
            }
        }

        public HistorialCompras()
        {
            InitializeComponent();
        }

        private void HistorialCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
