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
    public partial class UserControlInicio : UserControl
    {

        private static UserControlInicio _instance;
        public static UserControlInicio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlInicio();
                return _instance;
            }
        }

        public UserControlInicio()
        {
            InitializeComponent();
        }

        private void btnVerDetallesReservadas_Click(object sender, EventArgs e)
        {

        }

        private void UserControlInicio_Load(object sender, EventArgs e)
        {

        }


    }
}
