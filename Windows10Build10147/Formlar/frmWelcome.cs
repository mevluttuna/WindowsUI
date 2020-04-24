using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            pnlContainer.Top = ((Screen.PrimaryScreen.Bounds.Height / 2) - (pnlContainer.Height / 2));
            pnlContainer.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (pnlContainer.Width / 2);
            Thread.Sleep(500);
            timerBar.Start();
        }

        private void timerBar_Tick(object sender, EventArgs e)
        {
            if (pnlBar.Left >= -10)
            {
                pnlBar.Left += 1;
            }
            else if (pnlBar.Left >= -100)
            {
                pnlBar.Left += 2;
            }
            else
            {
                pnlBar.Left += 1;
            }
            if (pnlBar.Left >= 0)
            {
                timerBar.Stop();
                pnlBar.Left = 0;
                Program.masaustu.Show();
                timerYukari.Start();
            }
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
            }
        }
    }
}
