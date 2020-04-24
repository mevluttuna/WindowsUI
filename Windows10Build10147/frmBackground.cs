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
    public partial class frmBackground : Form
    {
        public frmBackground()
        {
            InitializeComponent();
        }

        private void frmBackground_Load(object sender, EventArgs e)
        {
            _Start();
        }
        public void _Start()
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Left = 0;
            this.Top = 0;
            this.Opacity = 1;
        }
    }
}
