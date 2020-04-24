using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147
{
    static class Program
    {

        public static Formlar.frmMainBackStart mainBackStart;
        public static Formlar.frmMasaustu masaustu;
        public static Formlar.frmWelcome welcome;
        public static Formlar.frmGorevCubugu gorevCubugu;
        public static Formlar.frmStartMenu startMenu;
        public static Formlar.frmNotifications bildirimler;
        public static Formlar.frmAraclar araclar;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _Start();
            Application.Run(mainBackStart);
        }
        private static void _Start()
        {
            mainBackStart = new Formlar.frmMainBackStart();
            masaustu = new Formlar.frmMasaustu();
            welcome = new Formlar.frmWelcome();
            gorevCubugu = new Formlar.frmGorevCubugu();
            startMenu = new Formlar.frmStartMenu();
            bildirimler = new Formlar.frmNotifications();
            araclar = new Formlar.frmAraclar();
        }
    }
}
