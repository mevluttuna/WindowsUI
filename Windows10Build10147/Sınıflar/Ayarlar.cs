using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public class Ayarlar
    {
        private static Timer tmrControlAdd;
        private static byte speed = 8;
        private static Control Controls;
        public static Formlar.Ayarlar.frmAyarlar _ayar
        {
            get; set;
        }

        public static void ControlAdd(Control _control, Control _addingPanel)
        {
            speed = 8;
            _addingPanel.Controls.Clear();
            _addingPanel.Controls.Add(_control);
            _control.Width = _addingPanel.Width - 25;
            _control.Height = _addingPanel.Height;
            DefaultControl(_control);
            Controls = _control;
            tmrControlAdd = new Timer();
            tmrControlAdd.Interval = 1;
            tmrControlAdd.Tick += TmrControlAdd_Tick;
            tmrControlAdd.Start();
        }

        private static void TmrControlAdd_Tick(object sender, EventArgs e)
        {
            Controls.Top -= speed;
            if (Controls.Top <= 40) speed = 4;
            if (Controls.Top <= 20) speed = 2;
            if (Controls.Top <= 5) speed = 1;
            if (Controls.Top <= 0)
            {
                Controls.Top = 0;
                tmrControlAdd.Stop();
                tmrControlAdd.Dispose();
                speed = 8;
            }
        }

        private static void DefaultControl(Control _ctrl)
        {
            _ctrl.Left = 0;
            _ctrl.Top = 160;
        }
    }
    public class AyarBilgisiTut
    {
        public static Image desktopBackground;
        public static Image DesktopBackgroundGet()
        {
            desktopBackground = Program.masaustu.BackgroundImage;
            return desktopBackground;
        }
        public static void DesktopBackgroundRefresh()
        {
            Program.masaustu.BackgroundImage = Image.FromFile(Application.StartupPath+"Desktop Back//back.jpg");
        }
    }
}
