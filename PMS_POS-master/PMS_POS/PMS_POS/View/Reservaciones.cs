using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;
namespace PMS_POS.View
{
    public partial class Reservaciones : UserControl
    {
        Reservacion obj = new Reservacion();

        private static Reservaciones _instance;
        public static Reservaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reservaciones();
                return _instance;
            }
        }

        public Reservaciones()
        {
            InitializeComponent();
        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            dgvReservaciones.DataSource = obj.VistaTabla();
        }

        private void DgvReservaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the
            // value.
            if (this.dgvReservaciones.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        string stringValue = e.Value == DBNull.Value ? string.Empty : (string)e.Value;
                        stringValue = stringValue.ToLower();
                        if ((stringValue.IndexOf("sin confirmar") > -1))
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

        }


    }
}

