using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class FormIslemleri
    {
        private static Timer tmrGorevEkle;
        private static Timer tmrFormAc;
        private static Timer tmrFormKapat;
        private static Timer tmrFormGizle;
        private static Timer tmrFormGoster;
        private static Form gelenForm = null;
        private static byte speed = 16;
        private static bool FormAcilisEffect = false;
        private static bool FormKapanisEffect = false;
        private static int FormKapanisBaslangic = 0;
        private static bool FormAcFullScreen;


        private static Form FormFullScreen(Form frm)
        {

            return frm;
        }
        private static Form FormFullScreenKonum(Form frm)
        {

            return frm;
        }
        public static void FormAc(Form frm, bool FullScreen, bool Effect)
        {
            if (FullScreen)
            {
                frm.Width = Screen.PrimaryScreen.Bounds.Width;
                frm.Height = Screen.PrimaryScreen.Bounds.Height;
            }
            if (Effect)
            {
                frm.Left = 0;
                frm.Top = 160;
            }
            FormAcilisEffect = Effect;
            FormAcFullScreen = FullScreen;
            frm.Opacity = 0;
            frm.TopMost = true;
            frm.Activate();
            gelenForm = null;
            gelenForm = frm;
            gelenForm.Show();
            speed = 16;
            //GorevCubugunaEkle(frm);
            tmrFormAc = new Timer();
            tmrFormAc.Tick += tmrFormAc_Tick;
            tmrFormAc.Interval = 1;
            tmrFormAc.Start();
        }
        //static Button btn;
        //private static void GorevCubugunaEkle(Form frm)
        //{
        //    btn = new Button();
        //    btn.Width = 150;
        //    btn.Height = 30;
        //    btn.Margin = new Padding(2,10,0,0);
        //    btn.BackColor = Color.FromArgb(64,64,64);
        //    btn.ForeColor = Color.FromArgb(240,240,240);
        //    btn.Text = frm.Text;
        //    btn.FlatStyle = FlatStyle.Flat;
        //    btn.FlatAppearance.BorderColor = Color.FromArgb(64,64,64);
        //    btn.FlatAppearance.BorderSize = 0;
        //    btn.Font = new Font("Segoe UI Light",9);
        //    btn.TextAlign = ContentAlignment.MiddleLeft;
        //    tmrGorevEkle = new Timer();
        //    tmrGorevEkle.Interval = 1;
        //    tmrGorevEkle.Tick += TmrGorevEkle_Tick;
        //    tmrGorevEkle.Start();
        //    Program.gorevCubugu.FlowMain.Controls.Add(btn);
        //    btn.Click += Btn_Click;
        //}

        private static void TmrGorevEkle_Tick(object sender, EventArgs e)
        {
            //btn.Margin -= new Padding(0,1,0,0);
            //if (btn.Margin.Top <= 1)
            //{
            //    tmrGorevEkle.Stop();
            //    btn.Margin = new Padding(2,0,0,0);
            //}
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            if (gelenForm.WindowState == FormWindowState.Minimized)
            {
                gelenForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                gelenForm.WindowState = FormWindowState.Minimized;
            }
        }

        private static bool ilk = true;
        static void tmrFormAc_Tick(object sender, EventArgs e)
        {
            if (ilk)
            {
                if (FormAcFullScreen)
                {
                    gelenForm.Top = 160;
                    gelenForm.Left = 0;
                    ilk = false;
                }
                else
                {
                    gelenForm.Top = ((Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2)) + 100;
                    gelenForm.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (gelenForm.Width / 2);
                    ilk = false;
                }
            }
            if (FormAcilisEffect)
            {
                if (FormAcFullScreen)
                {
                    gelenForm.Top -= speed;
                    gelenForm.Opacity += .1;
                    if (gelenForm.Top <= 80)speed = 8;
                    if (gelenForm.Top <= 40)speed = 4;
                    if (gelenForm.Top <= 20)speed = 2;
                    if (gelenForm.Top <= 10)speed = 1;
                    if (gelenForm.Top <= 0)
                    {
                        tmrFormAc.Stop();
                        tmrFormAc.Dispose();
                        gelenForm.Top = 0;
                        gelenForm.Opacity = 1;
                        gelenForm.Activate();
                        ilk = true;
                    }
                    
                }
                else
                {
                    gelenForm.Top -= speed;
                    gelenForm.Opacity += .1;
                    if (gelenForm.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2)) + 80)speed = 8;
                    if (gelenForm.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2)) + 40)speed = 4;
                    if (gelenForm.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2)) + 20)speed = 2;
                    if (gelenForm.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2)) + 10)speed = 1;
                    if (gelenForm.Top <= (Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2))
                    {
                        tmrFormAc.Stop();
                        tmrFormAc.Dispose();
                        gelenForm.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (gelenForm.Height / 2);
                        gelenForm.Opacity = 1;
                        gelenForm.Activate();
                        ilk = true;
                    }
                }

            }
            else
            {
                gelenForm.Top = 0;
                gelenForm.Left = 0;
                gelenForm.Opacity += 0.050;
                if (gelenForm.Opacity >= 1)
                {
                    tmrFormAc.Stop();
                    tmrFormAc.Dispose();
                    gelenForm.Opacity = 1;
                }
            }
        }
        public static void FormKapat(Form frm, bool Effect)
        {
            FormKapanisBaslangic = frm.Top;
            FormKapanisEffect = Effect;
            frm.Opacity = 1;
            gelenForm = null;
            gelenForm = frm;
            speed = 16;
            tmrFormKapat = new Timer();
            tmrFormKapat.Tick += tmrFormKapat_Tick;
            tmrFormKapat.Interval = 1;
            tmrFormKapat.Start();
        }

        static void tmrFormKapat_Tick(object sender, EventArgs e)
        {
            if (FormKapanisEffect)
            {
                gelenForm.Top += 2;
                gelenForm.Opacity -= .1;
                if (gelenForm.Opacity <= 0)
                {
                    tmrFormKapat.Stop();
                    tmrFormKapat.Dispose();
                    gelenForm.Opacity = 0;
                    gelenForm.Dispose();
                }

            }
            else
            {
                gelenForm.Opacity -= .050;
                if (gelenForm.Opacity <= 0)
                {
                    tmrFormKapat.Stop();
                    tmrFormKapat.Dispose();
                    gelenForm.Opacity = 0;
                    gelenForm.Dispose();
                }
            }
        }
        public static void FormGizle()
        {

        }
    }
}