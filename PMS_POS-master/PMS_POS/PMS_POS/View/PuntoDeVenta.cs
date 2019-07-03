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
    public partial class PuntoDeVenta : UserControl
    {
        private static PuntoDeVenta _instance;
        public static PuntoDeVenta Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PuntoDeVenta();
                return _instance;
            }
        }

        public PuntoDeVenta()
        {
            InitializeComponent();
        }
    }
}
