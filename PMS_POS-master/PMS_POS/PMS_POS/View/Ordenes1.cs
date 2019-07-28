using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class Ordenes1 : UserControl
    {
        public static Ordenes1 _instance;
        public static Ordenes1 Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Ordenes1();
                return _instance;
            }
        }
        public Ordenes1()
        {
            InitializeComponent();
        }
    }
}
