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
    public partial class InformacionEstablecimiento : UserControl
    {
        private static InformacionEstablecimiento _instance;
        public static InformacionEstablecimiento Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InformacionEstablecimiento();
                return _instance;
            }
        }

        public InformacionEstablecimiento()
        {
            InitializeComponent();
        }
    }
}
