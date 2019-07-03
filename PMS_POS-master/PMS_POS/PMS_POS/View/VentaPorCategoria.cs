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
    public partial class VentaPorCategoria : UserControl
    {
        private static VentaPorCategoria _instance;
        public static VentaPorCategoria Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaPorCategoria();
                return _instance;
            }
        }
        public VentaPorCategoria()
        {
            InitializeComponent();
        }
    }
}
