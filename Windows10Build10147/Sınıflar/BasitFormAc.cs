using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class BasitFormAc
    {
        public static void FormuAc(Form _frm , bool fullScreen)
        {
            if (fullScreen)
            {
                _frm.Width = Screen.PrimaryScreen.Bounds.Width;
                _frm.Height = Screen.PrimaryScreen.Bounds.Height;
                _frm.Left = 0;
                _frm.Top = 0;
            }
            _frm.Show();
            _frm.Activate();
        }
    }
}
