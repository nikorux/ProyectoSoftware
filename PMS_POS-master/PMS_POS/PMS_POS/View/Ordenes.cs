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
    public partial class Ordenes : UserControl
    {
        private static Ordenes _instance;
        public static Ordenes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ordenes();
                return _instance;
            }
        }

        public Ordenes()
        {
            InitializeComponent();
        }
    }
}
