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
    public partial class ListadoFacturas : UserControl
    {
        private static ListadoFacturas _instance;
        public static ListadoFacturas Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListadoFacturas();
                return _instance;
            }
        }
        public ListadoFacturas()
        {
            InitializeComponent();
        }
    }
}
