using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Ayarlar
{
    public partial class AyarlarVarsayılan : UserControl
    {
        public AyarlarVarsayılan()
        {
            InitializeComponent();
        }

        private void AyarlarVarsayılan_Load(object sender, EventArgs e)
        {
            pnlContainer.Left = ((Screen.PrimaryScreen.Bounds.Width / 2) - (pnlContainer.Width / 2)) - 132;
            pnlContainer.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (pnlContainer.Height / 2) - 100;
        }

        private void AyarlarVarsayılan_Resize(object sender, EventArgs e)
        {

        }
    }
}
