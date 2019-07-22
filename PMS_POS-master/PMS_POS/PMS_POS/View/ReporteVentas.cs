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
    public partial class ReporteVentas : UserControl
    {
        private static ReporteVentas _instance;
        public static ReporteVentas Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReporteVentas();
                return _instance;
            }
        }

        public ReporteVentas()
        {
            InitializeComponent();
        }
    }
}
