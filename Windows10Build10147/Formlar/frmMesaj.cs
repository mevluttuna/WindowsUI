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
    public partial class frmMesaj : Form
    {
        public frmMesaj(string mesaj)
        {
            InitializeComponent();
            lblMesaj.Text = mesaj;
            
        }

        public bool cevap = false;
        private void frmMesaj_Load(object sender, EventArgs e)
        {
            lblMesaj.Top = 30;
            lblMesaj.Left = (this.Width / 2) - (lblMesaj.Width / 2);
            this.Top = -200;
            this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2);
            speed = 16;
            timerAcilis.Start();
        }
        
        private void btnHayır_Click(object sender, EventArgs e)
        {
            speed = 16;
            cevap = false;
            timerAcilis.Stop();
            timerKapanis.Start();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            speed = 16;
            cevap = true;
            timerAcilis.Stop();
            timerKapanis.Start();
        }


        byte speed = 16;

        private void timerAcilis_Tick(object sender, EventArgs e)
        {
            this.Top += speed;
            if (this.Top >= -80)
            {
                speed = 8;
            }
            if (this.Top >= -30)
            {
                speed = 4;
            }
            if (this.Top >= -10)
            {
                speed = 2;
            }
            if (this.Top >= 10)
            {
                speed = 1;
            }
            if (this.Top >= 20)
            {
                timerAcilis.Stop();
                this.Top = 20;
            }
        }

        private void timerKapanis_Tick(object sender, EventArgs e)
        {
            this.Top -= speed;
            if (this.Top <= -50)
            {
                speed = 8;
            }
            if (this.Top <= -130)
            {
                speed = 4;
            }
            if (this.Top <= -170)
            {
                speed = 2;
            }
            if (this.Top <= -190)
            {
                speed = 1;
            }
            if (this.Top <= -200)
            {
                timerKapanis.Stop();
                this.Top = -200;
                this.Dispose();
            }
        }

        private void frmMesaj_CursorChanged(object sender, EventArgs e)
        {

        }

        private void frmMesaj_Deactivate(object sender, EventArgs e)
        {
            speed = 16;
            timerAcilis.Stop();
            timerKapanis.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
