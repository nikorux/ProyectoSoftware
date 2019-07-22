using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_POS.View
{
    public partial class Probando : Form
    {
        private static Probando _instance;
        public static Probando Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Probando();
                return _instance;
            }
        }
        public Probando()
        {
            InitializeComponent();
        }
    }
}
