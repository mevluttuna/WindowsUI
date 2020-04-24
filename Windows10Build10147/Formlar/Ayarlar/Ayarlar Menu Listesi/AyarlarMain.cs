using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Ayarlar.Ayarlar_Menu_Listesi
{
    public partial class AyarlarMain : UserControl
    {
        public AyarlarMain()
        {
            InitializeComponent();
        }

        private void pnlSistem_Click(object sender, EventArgs e)
        {
            //Formlar.Ayarlar.frmAyarlar.AyarlarıVer().KontrolEkle(new Formlar.Ayarlar.Sistem.AyarlarSistem());
            Sınıflar.Ayarlar._ayar.KontrolEkle(new Sistem.AyarlarSistem());
        }

        private void pnlSistem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlKisisellestir_Click(object sender, EventArgs e)
        {
            Sınıflar.Ayarlar._ayar.KontrolEkle(new Formlar.Kisisellestir.AyarlarKisisellestir());
        }
    }
}
