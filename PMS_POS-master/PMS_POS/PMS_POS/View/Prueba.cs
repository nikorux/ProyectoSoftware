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
    public partial class Prueba : UserControl
    {
        private static Prueba _instance;
        public static Prueba Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Prueba();
                return _instance;
            }
        }


        Prueba ucPrueba = new Prueba();

        public Prueba()
        {
            InitializeComponent();

        }
    }
}
