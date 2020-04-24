using DevExpress.XtraGauges.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar
{
    public partial class frmAraclar : Form
    {
        public frmAraclar()
        {
            InitializeComponent();
        }

        private void frmAraclar_Load(object sender, EventArgs e)
        {
            Start();
        }
        public void Start()
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
            this.Width = 150;
            this.Height = Screen.PrimaryScreen.Bounds.Height - Program.gorevCubugu.Height;

            BarCpu.EnableAnimation = true;
            BarCpu.EasingMode = EasingMode.EaseInOut;
            BarCpu.EasingFunction = new CircleEase();

            BarRam.EnableAnimation = true;
            BarRam.EasingMode = EasingMode.EaseInOut;
            BarRam.EasingFunction = new CircleEase();

            BarRead.EnableAnimation = true;
            BarRead.EasingMode = EasingMode.EaseInOut;
            BarRead.EasingFunction = new CircleEase();

            BarWrite.EnableAnimation = true;
            BarWrite.EasingMode = EasingMode.EaseInOut;
            BarWrite.EasingFunction = new CircleEase();

            BarCpu.Value = 0;
            BarRam.Value = 0;
            BarRead.Value = 0;
            BarWrite.Value = 0;
        }



        private void timerDenetle_Tick(object sender, EventArgs e)
        {
            double cpu = performanceCounter1.NextValue();
            double ram = performanceCounter2.NextValue();
            double write = performanceCounter3.NextValue();
            double read = performanceCounter4.NextValue();


            BarCpu.Value = Convert.ToInt32(cpu);
            BarRam.Value = Convert.ToInt32(ram);
            BarRead.Value = Convert.ToInt32(read);
            BarWrite.Value = Convert.ToInt32(write);
            
        }

        public byte speed = 16;

        private void timerGoster_Tick(object sender, EventArgs e)
        {
            this.Left -= speed;
            if (this.Left <= (Screen.PrimaryScreen.Bounds.Width - this.Width) + 80) speed = 8;
            if (this.Left <= (Screen.PrimaryScreen.Bounds.Width - this.Width) + 40) speed = 4;
            if (this.Left <= (Screen.PrimaryScreen.Bounds.Width - this.Width) + 20) speed = 2;
            if (this.Left <= (Screen.PrimaryScreen.Bounds.Width - this.Width) + 10) speed = 1;
            if (this.Left <= Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                timerGoster.Stop();
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            }
        }

        private void timerGizle_Tick(object sender, EventArgs e)
        {
            this.Left += speed;
            if (this.Left >= Screen.PrimaryScreen.Bounds.Width - 80) speed = 8;
            if (this.Left >= Screen.PrimaryScreen.Bounds.Width - 40) speed = 4;
            if (this.Left >= Screen.PrimaryScreen.Bounds.Width - 20) speed = 2;
            if (this.Left >= Screen.PrimaryScreen.Bounds.Width - 10) speed = 1;
            if (this.Left >= Screen.PrimaryScreen.Bounds.Width)
            {
                timerGizle.Stop();
                this.Left = Screen.PrimaryScreen.Bounds.Width;

                BarCpu.Value = 0;
                BarRam.Value = 0;
                BarRead.Value = 0;
                BarWrite.Value = 0;
            }
        }

        private void frmAraclar_Deactivate(object sender, EventArgs e)
        {
            Sınıflar.Araclar.AracGizle();
        }

        private void CpuValue_Animating(object sender, EventArgs e)
        {
        }

        private void gaugeControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
