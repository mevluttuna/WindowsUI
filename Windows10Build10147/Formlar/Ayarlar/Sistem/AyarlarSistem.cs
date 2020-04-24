using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Ayarlar.Sistem
{
    public partial class AyarlarSistem : UserControl
    {
        public AyarlarSistem()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Sınıflar.Ayarlar._ayar.Main();
        }

        private void btnEkran_EnabledChanged(object sender, EventArgs e)
        {
        }
    }
}
