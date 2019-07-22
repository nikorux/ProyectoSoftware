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
    public partial class PaginaInicio : UserControl
    {
        private static PaginaInicio _instance;
        public static PaginaInicio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaginaInicio();
                return _instance;
            }
        }

        public PaginaInicio()
        {
            InitializeComponent();
        }
    }
}
