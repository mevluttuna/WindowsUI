using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar
{
    public partial class frmMainBackStart : Form
    {
        public frmMainBackStart()
        {
            InitializeComponent();
        }

        private void frmMainBackStart_Load(object sender, EventArgs e)
        {
            _Start();
        }

        public void _Start()
        {
            Sınıflar.BasitFormAc.FormuAc(Formlar.frmLock.FormVer(), true);
        }

        private void frmMainBackStart_Click(object sender, EventArgs e)
        {

        }
        public static void TumBilgiler()
        {

        }
    }
}
