using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Deactivate(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormKapat(this, true);
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
