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
    public partial class FacturacionCheckIn : UserControl
    {
        private static FacturacionCheckIn _instance;
        public static FacturacionCheckIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FacturacionCheckIn();
                return _instance;
            }
        }

        public FacturacionCheckIn()
        {
            InitializeComponent();

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
