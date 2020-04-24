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
    public partial class frmLock : Form
    {
        public static frmLock _start;
        private frmLock()
        {
            InitializeComponent();
        }

        public static frmLock FormVer()
        {
            if (_start == null)
            {
                _start = new frmLock();
            }
            return _start;
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            _Start();
            timerAcilis.Start();
        }
        public void _Start()
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "//Lock Image//back.jpg");
            lblSaat.Text = DateTime.Now.ToShortTimeString();
            lblTarih.Text = DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.ToString("dddd");
        }

        private void timerAcilis_Tick(object sender, EventArgs e)
        {
            this.Opacity += .050;
            if (this.Opacity >= .99)
            {
                timerAcilis.Stop();
                this.Opacity = 1;
                Sınıflar.BasitFormAc.FormuAc(Formlar.frmUsers.FormVer(), true);

            }
        }

        private void frmLock_Click(object sender, EventArgs e)
        {
            speed = 32;
            timerYukari.Start();
        }

        byte speed = 32;
        private void timerYukari_Tick(object sender, EventArgs e)
        {
            //this.Opacity -= .05;
            //if (this.Opacity <= .05)
            //{
            //    timerYukari.Stop();
            //    this.Opacity = 0;
            //    Formlar.frmUsers.FormVer().TopMost = true;
            //}
            this.Top -= speed;
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)) + 160)
            {
                speed = 16;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)) + 80)
            {
                speed = 8;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)) + 40)
            {
                speed = 4;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)) + 20)
            {
                speed = 2;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)) + 10)
            {
                speed = 1;
            }
            if (this.Top <= (Screen.PrimaryScreen.Bounds.Height * (-1)))
            {
                timerYukari.Stop();
                this.Top = (Screen.PrimaryScreen.Bounds.Height * (-1));
                Formlar.frmUsers.FormVer().TopMost = true;
            }


        }

        private void frmLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sınıflar.MainCloser.MainClose();
        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
