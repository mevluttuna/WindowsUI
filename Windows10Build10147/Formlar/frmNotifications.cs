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
    public partial class frmNotifications : Form
    {
        public frmNotifications()
        {
            InitializeComponent();
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {

            Sınıflar.Bildirimler.BildirimlerVarsayilan();
        }

        private void timerAc_Tick(object sender, EventArgs e)
        {
            Program.bildirimler.Left -= Sınıflar.Bildirimler.speed;
            if (Program.bildirimler.Left <= (Screen.PrimaryScreen.Bounds.Width - Program.bildirimler.Width) + 40) Sınıflar.Bildirimler.speed = 4;
            if (Program.bildirimler.Left <= (Screen.PrimaryScreen.Bounds.Width - Program.bildirimler.Width) + 20) Sınıflar.Bildirimler.speed = 2;
            if (Program.bildirimler.Left <= (Screen.PrimaryScreen.Bounds.Width - Program.bildirimler.Width) + 10) Sınıflar.Bildirimler.speed = 1;
            if (Program.bildirimler.Left <= (Screen.PrimaryScreen.Bounds.Width - Program.bildirimler.Width))
            {
                timerAc.Stop();
                Sınıflar.Bildirimler.speed = 16;
                Sınıflar.Bildirimler.acik = true;
                Program.bildirimler.Left = Screen.PrimaryScreen.Bounds.Width - Program.bildirimler.Width;
            }
        }

        private void timerKapat_Tick(object sender, EventArgs e)
        {
            Program.bildirimler.Left += Sınıflar.Bildirimler.speed;
            if (Program.bildirimler.Left >= Screen.PrimaryScreen.Bounds.Width - 40) Sınıflar.Bildirimler.speed = 4;
            if (Program.bildirimler.Left >= Screen.PrimaryScreen.Bounds.Width - 20) Sınıflar.Bildirimler.speed = 2;
            if (Program.bildirimler.Left >= Screen.PrimaryScreen.Bounds.Width - 10) Sınıflar.Bildirimler.speed = 1;
            if (Program.bildirimler.Left >= Screen.PrimaryScreen.Bounds.Width)
            {
                timerKapat.Stop();
                Sınıflar.Bildirimler.speed = 16;
                Sınıflar.Bildirimler.acik = false;
                Program.bildirimler.Left = Screen.PrimaryScreen.Bounds.Width;
            }
        }

        private void frmNotifications_Deactivate(object sender, EventArgs e)
        {
            Sınıflar.Bildirimler.BildirimleriKapat();
        }

        bool btnAcik = false;
        byte btnSpeed = 8;             
        private void picOpen_Click(object sender, EventArgs e)
        {
            btnSpeed = 8;
            if (!btnAcik)
            {
                picOpen.Image = Image.FromFile(Application.StartupPath + "//asagi.png");
                timerBtnKapat.Stop();
                timerBtnAc.Start();
                btnAcik = true;
            }
            else
            {
                picOpen.Image = Image.FromFile(Application.StartupPath + "//yukari.png");
                timerBtnAc.Stop();
                timerBtnKapat.Start();
                btnAcik = false;
            }
        }

        private void timerBtnAc_Tick(object sender, EventArgs e)
        {
            FlowButtons.Height += btnSpeed;
            if (FlowButtons.Height >= 164) btnSpeed = 2;
            if (FlowButtons.Height >= 184) btnSpeed = 1;
            if (FlowButtons.Height >= 194)
            {
                timerBtnAc.Stop();
                FlowButtons.Height = 194;
            }
        }

        private void timerBtnKapat_Tick(object sender, EventArgs e)
        {
            FlowButtons.Height -= btnSpeed;
            if (FlowButtons.Height <= 96) btnSpeed = 2;
            if (FlowButtons.Height <= 76) btnSpeed = 1;
            if (FlowButtons.Height <= 66)
            {
                timerBtnKapat.Stop();
                FlowButtons.Height = 66;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
