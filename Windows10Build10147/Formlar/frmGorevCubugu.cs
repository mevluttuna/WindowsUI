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
    public partial class frmGorevCubugu : Form
    {
        public frmGorevCubugu()
        {
            InitializeComponent();
        }

        private void frmGorevCubugu_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {

            this.Height = 30;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.Left = 0;
            timerAcilis.Start();
            Sınıflar.StartMenu.StartMenuOlustur();
            Sınıflar.Bildirimler.BildirimSayfasıOlustur();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
            timerSaat.Start();
        }

        private void timerAcilis_Tick(object sender, EventArgs e)
        {
            this.Opacity += .050;
            if (this.Opacity >= .95)
            {
                timerAcilis.Stop();
                this.Opacity = .95;
            }
        }

        public bool menuAcik = false;
        private void picStart_Click(object sender, EventArgs e)
        {
            if (!menuAcik)
            {
                Sınıflar.StartMenu.StartMenuAc();
                picStart.BackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                //Sınıflar.StartMenu.StartMenuKapat();
                //picStart.BackColor = Color.Transparent;
            }
        }
        private void FlowMain_Paint(object sender, PaintEventArgs e)
        {
        }
        private void picSearch_Click(object sender, EventArgs e)
        {

        }

        private void timerSearchAc_Tick(object sender, EventArgs e)
        {

        }

        private void timerSearchKapat_Tick(object sender, EventArgs e)
        {

        }

        private void frmGorevCubugu_Deactivate(object sender, EventArgs e)
        {

        }


        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void pictureScreen_Click(object sender, EventArgs e)
        {
        }

        private void picNotifications_Click(object sender, EventArgs e)
        {
            if (!Sınıflar.Bildirimler.acik)
            {
                Sınıflar.Bildirimler.BildirimleriAc();
            }
            else
            {
                Sınıflar.Bildirimler.BildirimleriKapat();
            }
        }

        private void pictureEdge_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormAc(new Formlar.Microsoft_Edge.frmEgde(),false,true);
        }
    }
}
