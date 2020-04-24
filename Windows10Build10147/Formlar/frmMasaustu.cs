using DevExpress.XtraGauges.Core.Model;
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
    public partial class frmMasaustu : Form
    {
        public frmMasaustu()
        {
            InitializeComponent();
        }


        private void frmMasaustu_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "//Desktop Back//back.jpg");
            Program.araclar.Show();
        }
    }
}
