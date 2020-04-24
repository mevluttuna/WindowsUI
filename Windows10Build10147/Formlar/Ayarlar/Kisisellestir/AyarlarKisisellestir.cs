using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Kisisellestir
{
    public partial class AyarlarKisisellestir : UserControl
    {
        public AyarlarKisisellestir()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Sınıflar.Ayarlar._ayar.Main();
        }
        public void BtnSelect(Button btn)
        {
            btnArkaplan.BackColor = Color.Transparent;
            btnRenkler.BackColor = Color.Transparent;
            btnKilit.BackColor = Color.Transparent;
            btnTemalar.BackColor = Color.Transparent;
            btnBaslangic.BackColor = Color.Transparent;
            btn.BackColor = Color.Silver;
        }
        private void AyarlarKisisellestir_Load(object sender, EventArgs e)
        {
            //BtnSelect(btnArkaplan);
            //Sınıflar.Ayarlar.ControlAdd(new Formlar.Ayarlar.Kisisellestir.AyarlarArkaplan(),pnlMain);
            Sınıflar.Ayarlar.ControlAdd(new Formlar.Ayarlar.AyarlarVarsayılan(),pnlMain);
        }

        private void btnArkaplan_Click(object sender, EventArgs e)
        {
            BtnSelect(btnArkaplan);
            Sınıflar.Ayarlar.ControlAdd(new Formlar.Ayarlar.Kisisellestir.AyarlarArkaplan(), pnlMain);
        }

        private void btnRenkler_Click(object sender, EventArgs e)
        {
            BtnSelect(btnRenkler);
            Sınıflar.Ayarlar.ControlAdd(new Formlar.Ayarlar.Kisisellestir.AyarlarRenkler(), pnlMain);
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            BtnSelect(btnKilit);
        }

        private void btnTemalar_Click(object sender, EventArgs e)
        {
            BtnSelect(btnTemalar);
        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            BtnSelect(btnBaslangic);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
