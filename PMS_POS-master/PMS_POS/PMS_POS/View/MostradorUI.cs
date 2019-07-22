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
    public partial class MostradorUI : UserControl
    {
        private static MostradorUI _instance;
        public static MostradorUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MostradorUI();
                return _instance;
            }
        }

        public MostradorUI()
        {
            InitializeComponent();
        }
    }
}
