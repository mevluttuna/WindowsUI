using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class StartMenu
    {

        public static void StartMenuAc()
        {
            Program.startMenu.speed = 8;
            Program.startMenu.Top = (Screen.PrimaryScreen.Bounds.Height - (Program.startMenu.Height + Program.gorevCubugu.Height)) + 80;
            Program.startMenu.timerMenuKapat.Stop();
            Program.startMenu.timerMenuAc.Start();
            //Program.gorevCubugu.menuAcik = true;
            Program.gorevCubugu.picStart.BackColor = Color.FromArgb(50, 50, 50);   
            Program.gorevCubugu.picStart.Image = Windows10Build10147.Properties.Resources.white; 
            Program.startMenu.Activate();
        }

        public static void StartMenuKapat()
        {
            Program.startMenu.timerMenuAc.Stop();
            Program.startMenu.timerMenuKapat.Start();
            //Program.gorevCubugu.menuAcik = false;
            Program.gorevCubugu.picStart.BackColor = Color.Transparent;
            Program.gorevCubugu.picStart.Image = Windows10Build10147.Properties.Resources.win_10_guncel_start;

        }

        public static void StartMenuOlustur()
        {
            //Menu ilk açılış işlemi
            Sınıflar.BasitFormAc.FormuAc(Program.startMenu, false);
        }

        private static Timer tmrMenuBuyult;
        private static Timer tmrMenuKucult;
        public static void TamEkran()
        {
            tmrMenuBuyult = new Timer();
            tmrMenuBuyult.Tick += tmrMenuBuyult_Tick;
            tmrMenuBuyult.Interval = 1;
            tmrMenuBuyult.Start();
            //StartMenuKapat();
            //Program.startMenu.Width = Screen.PrimaryScreen.Bounds.Width;
            //Program.startMenu.Height = Screen.PrimaryScreen.Bounds.Height - Program.gorevCubugu.Height;
            //Program.startMenu.Left = 0;
            //Program.startMenu.Top = 0;
            //StartMenuAc();
        }

        static void tmrMenuBuyult_Tick(object sender, EventArgs e)
        {
            Program.startMenu.Opacity -= 0.050;
            if (Program.startMenu.Opacity <= 0)
            {
                tmrMenuBuyult.Stop();
                Program.startMenu.Opacity = 0;
                Program.startMenu.Width = Screen.PrimaryScreen.Bounds.Width;
                Program.startMenu.Height = Screen.PrimaryScreen.Bounds.Height - Program.gorevCubugu.Height;
                Program.startMenu.Left = 0;
                Program.startMenu.Top = 0;
                StartMenuAc();
            }
        }
        public static void Normal()
        {
            tmrMenuKucult = new Timer();
            tmrMenuKucult.Tick += tmrMenuKucult_Tick;
            tmrMenuKucult.Interval = 1;
            tmrMenuKucult.Start();
            //StartMenuKapat();
            //Program.startMenu.Width = 600;
            //Program.startMenu.Height = 575;
            //Program.startMenu.Left = 0;
            //Program.startMenu.Top = Screen.PrimaryScreen.Bounds.Height - (Program.startMenu.Height + Program.gorevCubugu.Height);
            //StartMenuAc();
        }

        static void tmrMenuKucult_Tick(object sender, EventArgs e)
        {
            Program.startMenu.Opacity -= 0.050;
            if (Program.startMenu.Opacity <= 0)
            {
                tmrMenuKucult.Stop();
                Program.startMenu.Opacity = 0;
                //Program.startMenu.Width = 600;
                Program.startMenu.Width = 1035;
                Program.startMenu.Height = 575;
                Program.startMenu.Left = 0;
                Program.startMenu.Top = Screen.PrimaryScreen.Bounds.Height - (Program.startMenu.Height + Program.gorevCubugu.Height);
                StartMenuAc();
            }
        }
    }
}
