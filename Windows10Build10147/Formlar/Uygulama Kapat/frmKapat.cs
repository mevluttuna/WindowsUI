using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Uygulama_Kapat
{
    public partial class frmKapat : Form
    {
        public frmKapat()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmKapat_Load(object sender, EventArgs e)
        {
            _Start();
        }
        private void _Start()
        {
            pnlMainContainer.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (pnlMainContainer.Width / 2);
            pnlMainContainer.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (pnlMainContainer.Height / 2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormKapat(this,true);
        }
    }
}
