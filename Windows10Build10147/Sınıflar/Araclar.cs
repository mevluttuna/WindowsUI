using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows10Build10147.Sınıflar
{
    public static class Araclar
    {
        public static bool araclarAcik = false;
        
        public static void AracGoster()
        {
            Program.araclar.speed = 16;
            if (!araclarAcik)
            {
                Program.araclar.timerGizle.Stop();
                Program.araclar.timerGoster.Start();
                Program.araclar.Activate();
                Program.araclar.timerDenetle.Start();
                araclarAcik = true;
            }

        }
        public static void AracGizle()
        {
            Program.araclar.speed = 16;

            if (araclarAcik)
            {
                Program.araclar.timerGoster.Stop();
                Program.araclar.timerGizle.Start();
                Program.araclar.timerDenetle.Stop();

                araclarAcik = false;
            }
        }
    }
}
