using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class Bildirimler
    {
        public static byte speed = 16;
        public static bool acik = false;
        public static void BildirimlerVarsayilan()
        {
            Program.bildirimler.Left = Screen.PrimaryScreen.Bounds.Width;
            Program.bildirimler.Top = 0;
            Program.bildirimler.Width = 350;
            Program.bildirimler.Height = Screen.PrimaryScreen.Bounds.Height - Program.gorevCubugu.Height;
        }
        public static void BildirimSayfasıOlustur()
        {
            Program.bildirimler.Show();
        }
        public static void BildirimleriAc()
        {
            if (!acik)
            {
                
                speed = 16;
                Program.bildirimler.Activate();
                Program.bildirimler.timerKapat.Stop();
                Program.bildirimler.timerAc.Start();
            }
        }
        public static void BildirimleriKapat()
        {
            if (acik)
            {
                speed = 16;
                Program.bildirimler.timerAc.Stop();
                Program.bildirimler.timerKapat.Start();
            }
        }
    }
}
