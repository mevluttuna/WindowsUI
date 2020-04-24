using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar
{
    public partial class frmStartMenu : Form
    {
        public frmStartMenu()
        {
            InitializeComponent();
        }

        private void frmStartMenu_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {
            this.Left = 0;
            this.Top = Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height);
            picUserImage.Image = Image.FromFile(Application.StartupPath + "//User Image//user.jpg");
            lblUserName.Text = Sınıflar.User.UserName();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public byte speed = 8;
        private void timerMenuAc_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < .90)
            {
                this.Opacity += .050;
            }
            else
            {
                this.Opacity = .95;
            }

            this.Top -= speed;
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height)) + 40)
            {
                speed = 4;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height)) + 20)
            {
                speed = 2;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height)) + 10)
            {
                speed = 1;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height)))
            {
                timerMenuAc.Stop();
                this.Top = (Screen.PrimaryScreen.Bounds.Height - (this.Height + Program.gorevCubugu.Height));
                Program.gorevCubugu.menuAcik = true;
            }
        }

        private void timerMenuKapat_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .1;
            this.Top += 5;
            if (this.Opacity <= 0)
            {
                timerMenuKapat.Stop();
                this.Opacity = 0;
                Program.gorevCubugu.menuAcik = false;
            }
        }

        private void frmStartMenu_Deactivate(object sender, EventArgs e)
        {
            Sınıflar.StartMenu.StartMenuKapat();
        }

        private bool fullScreen = false;
        private void picFull_Click(object sender, EventArgs e)
        {
            if (!fullScreen)
            {
                Sınıflar.StartMenu.TamEkran();
                picFull.Image = Windows10Build10147.Properties.Resources.exitFull30;
                fullScreen = true;
            }
            else
            {
                Sınıflar.StartMenu.Normal();
                picFull.Image = Windows10Build10147.Properties.Resources.full30;
                fullScreen = false;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormAc(new Formlar.Uygulama_Kapat.frmKapat(), true, true);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormAc(Formlar.Ayarlar.frmAyarlar.AyarlarıVer(), true, true);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowSolMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComputer_Click(object sender, EventArgs e)
        {

        }

        private void BoxContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picUserImage_Click(object sender, EventArgs e)
        {

        }

        private void ItemAyarlar_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Sınıflar.FormIslemleri.FormAc(Formlar.Ayarlar.frmAyarlar.AyarlarıVer(), true, true);
        }

        private void btnBelgelerim_Click(object sender, EventArgs e)
        {
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            Sınıflar.Araclar.AracGoster();
        }

        private void ItemEdge_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Sınıflar.FormIslemleri.FormAc(new Formlar.Microsoft_Edge.frmEgde(), false, true);
        }
    }
}
