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
    public partial class ConfigurarImagen : Form
    {
        public ConfigurarImagen()
        {
            InitializeComponent();
        }

        private void BtnBuscarImagen_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    picturebImagen.ImageLocation = imageLocation;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        MainScreen main = MainScreen.Instance;
        private void BtnGuardarImagen_Click(object sender, EventArgs e)
        {
            main.pictureBox15.Image = picturebImagen.Image;
        }
    }
}
