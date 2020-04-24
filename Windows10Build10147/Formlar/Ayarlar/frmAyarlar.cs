using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Ayarlar
{
    public partial class frmAyarlar : Form
    {
        public static frmAyarlar _ayar;
        private frmAyarlar()
        {
            
            InitializeComponent();
        }
        public static frmAyarlar AyarlarıVer()
        {
            _ayar = new frmAyarlar();
            Sınıflar.Ayarlar._ayar = _ayar;
            return Sınıflar.Ayarlar._ayar;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormKapat(this, true);
        }

        bool acik = false;
        private void timerCursorControl_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.Y <= 5 & !acik)
            {
                timerKapat.Stop();
                timerAc.Start();
                acik = true;
            }
            else if (Cursor.Position.Y >= 35 & acik)
            {
                timerAc.Stop();
                timerKapat.Start();
                acik = false;
            }
        }

        private void timerAc_Tick(object sender, EventArgs e)
        {
            pnlKapat.Height += 2;
            if (pnlKapat.Height >= 30)
            {
                timerAc.Stop();
                pnlKapat.Height = 30;
            }
        }

        private void timerKapat_Tick(object sender, EventArgs e)
        {
            pnlKapat.Height -= 2;
            if (pnlKapat.Height <= 0)
            {
                timerKapat.Stop();
                pnlKapat.Height = 0;
            }
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            timerCursorControl.Start();
            _Start();
        }
        public void _Start()
        {
            Main();
        }

        private void pnlAna_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Main()
        {
            UserControl _user = new Formlar.Ayarlar.Ayarlar_Menu_Listesi.AyarlarMain();
            KontrolEkle(_user);
            //pnlAna.Controls.Add(_user);
            //_user.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (_user.Width / 2);
            //_user.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (_user.Height / 2);
        }

        public void KontrolVarsayılan(Control _ctrl)
        {
            _ctrl.Width = Screen.PrimaryScreen.Bounds.Width;
            _ctrl.Height = Screen.PrimaryScreen.Bounds.Height;
            _ctrl.Top = ((Screen.PrimaryScreen.Bounds.Height / 2) - (_ctrl.Height / 2)) + 80;
            _ctrl.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (_ctrl.Width / 2);
        }
        Control ctrlEkle;
        public void KontrolEkle(Control _control)
        {
            pnlAna.Controls.Clear();
            ctrlEkle = new Control();
            ekleHiz = 8;
            _control.Visible = false;
            pnlAna.Controls.Add(_control);
            _control.Width = pnlAna.Width;
            _control.Height = pnlAna.Height;
            KontrolVarsayılan(_control);
            _control.Visible = true;
            ctrlEkle = _control;
            timerKontrolEkle.Start();
        }
        byte ekleHiz = 8;
        private void timerKontrolEkle_Tick(object sender, EventArgs e)
        {
            ctrlEkle.Top -= ekleHiz;
            if ((ctrlEkle.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (ctrlEkle.Height / 2)) + 40))
            {
                ekleHiz = 4;
            }
            if ((ctrlEkle.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (ctrlEkle.Height / 2)) + 20))
            {
                ekleHiz = 2;
            }
            if ((ctrlEkle.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (ctrlEkle.Height / 2)) + 10))
            {
                ekleHiz = 1;
            }
            if ((ctrlEkle.Top <= ((Screen.PrimaryScreen.Bounds.Height / 2) - (ctrlEkle.Height / 2))))
            {
                timerKontrolEkle.Stop();
                ctrlEkle.Top = ((Screen.PrimaryScreen.Bounds.Height / 2) - (ctrlEkle.Height / 2));
                ekleHiz = 8;
            }
        }
    }
}
