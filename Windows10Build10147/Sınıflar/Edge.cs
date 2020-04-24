using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class Edge
    {
        static Button btnSekme;
        public static Control[] butonlar = new Control[10];
        public static Button SekmeEkle()
        {
            return btn();
        }
        public static void SekmeSil()
        {

        }
        private static Button btn()
        {
            btnSekme = new Button();
            btnSekme.FlatStyle = FlatStyle.Flat;
            btnSekme.FlatAppearance.BorderSize = 0;
            btnSekme.FlatAppearance.BorderColor = Color.FromArgb(224,244,244);
            btnSekme.Text = "Yeni Sekme";
            btnSekme.Font = new Font("Segoe UI Bold", 10);
            btnSekme.BackColor = Color.Silver;
            btnSekme.Height = 30;
            btnSekme.Width = 150;
            btnSekme.Dock = DockStyle.Left;
            btnSekme.TextAlign = ContentAlignment.MiddleLeft;
            butonlar[0] = btnSekme;
            return btnSekme;
        }
    }
}
