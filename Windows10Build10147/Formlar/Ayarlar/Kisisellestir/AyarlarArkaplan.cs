using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Ayarlar.Kisisellestir
{
    public partial class AyarlarArkaplan : UserControl
    {
        public AyarlarArkaplan()
        {
            InitializeComponent();
        }

        private void AyarlarArkaplan_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {
            picBackground.Image = Sınıflar.AyarBilgisiTut.DesktopBackgroundGet();
        }
        OpenFileDialog file = new OpenFileDialog();
        private void btnGozat_Click(object sender, EventArgs e)
        {
            file.Filter = "Resim Dosyası |*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                //System.IO.File.Delete(Application.StartupPath + "//Desktop Back//back.jpg");

                //picBackground.Image.Save("back", System.Drawing.Imaging.ImageFormat.Jpeg);
                //Sınıflar.AyarBilgisiTut.DesktopBackgroundRefresh();
                picBackground.Image = Image.FromFile(file.FileName);
                //Sınıflar.MasaustuResimDepola.resim = picDesktopImage.Image;
                //Sınıflar.MasaustuResimDepola.i_layout = i_layout;
                //Program.masaustu.MasaustuArkaPlanYenile();
            }
        }

        bool colorEnable = false;

        private void pnlColor_Click(object sender, EventArgs e)
        {
            if (!colorEnable)
            {
                pnlColor.BackgroundImage = Windows10Build10147.Properties.Resources.Toggle_On_Filled;
                LayoutColor.Visible = true;
                colorEnable = true;
            }
            else
            {
                pnlColor.BackgroundImage = Windows10Build10147.Properties.Resources.Toggle_Off;
                LayoutColor.Visible = false;
                colorEnable = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
