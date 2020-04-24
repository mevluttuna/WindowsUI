using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar
{
    public partial class frmUsers : Form
    {
        public static frmUsers _users;
        private frmUsers()
        {
            InitializeComponent();
        }

        public static frmUsers FormVer()
        {
            if (_users == null)
            {
                _users = new frmUsers();
            }
            return _users;
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(Application.StartupPath + "//User Back//back.jpg");
            pnlUserContainer.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (pnlUserContainer.Width / 2);
            pnlUserContainer.Top = ((Screen.PrimaryScreen.Bounds.Height / 2) - (pnlUserContainer.Height / 2));

            pnlImageContainer.Left = (pnlUserContainer.Width / 2) - (pnlImageContainer.Width / 2);
            timerRefresh.Start();
        }

        private void frmUsers_Paint(object sender, PaintEventArgs e)
        {

            Pen myPen = new Pen(Color.FromArgb(40, 40, 40), 1);
            Graphics gr = null;
            gr = pnlImageContainer.CreateGraphics();
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.AssumeLinear;
            Image myImage = Image.FromFile(Application.StartupPath + "//User Image//user.jpg");
            TextureBrush myTextureBrush = new TextureBrush(myImage);
            gr.FillEllipse(myTextureBrush, 0, 0, 200, 200);
            gr.DrawEllipse(myPen, 0, 0, 200, 200);
            gr.Dispose();

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClose_Click(object sender, EventArgs e)
        {
            //mesaj genel kullanımı
            if (Sınıflar.Mesaj.MesajVer("Uygulamayı kapatmak istediğinize emin misiniz ?"))
            {
                MessageBox.Show("Evet");
            }
            else
            {
                MessageBox.Show("Hayır");
            }
        }

        private void pnlSleep_Click(object sender, EventArgs e)
        {
            Sınıflar.Mesaj.MesajVer("Uyku moduna geçmek istediğinize emin misiniz ?");

        }

        private void pnlRestart_Click(object sender, EventArgs e)
        {
            Sınıflar.Mesaj.MesajVer("Uygulamayı yeniden başlatmak istediğinize emin misiniz ?");

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == Sınıflar.User.UserPassword())
            {
                picLoad.Visible = true;
                btnGo.Visible = false;
                Program.masaustu.Show();
                timerLoad.Start();
                //Program.welcome.Show();
                //_SifreDogru();
            }
            else
            {
                txtPassword.Clear();
                lblYanlis.Visible = true;
            }
        }
        public void _SifreDogru()
        {
            speed = 32;
            timerYukari.Start();
            Program.gorevCubugu.Show();
        }

        int speed = 32;
        private void timerYukari_Tick(object sender, EventArgs e)
        {
            this.Top -= speed;
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)) + 160)
            {
                speed = 16;
            }
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)) + 80)
            {
                speed = 8;
            }
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)) + 40)
            {
                speed = 4;
            }
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)) + 20)
            {
                speed = 2;
            }
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)) + 10)
            {
                speed = 1;
            }
            if (this.Top <= ((Screen.PrimaryScreen.Bounds.Height) * (-1)))
            {
                timerYukari.Stop();
                this.Top = ((Screen.PrimaryScreen.Bounds.Height) * (-1));
                this.Enabled = false;
                this.Visible = false;
                //Program.welcome.TopMost = true;
            }
        }

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sınıflar.MainCloser.MainClose();
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            this.Refresh();
            timerRefresh.Stop();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
            _SifreDogru();
        }
    }
}
