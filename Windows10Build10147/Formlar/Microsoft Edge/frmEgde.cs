using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Microsoft_Edge
{
    public partial class frmEgde : Form
    {
        public frmEgde()
        {
            InitializeComponent();
        }
        bool surukle = false;
        Point konum;

        private void pnlContainer_MouseDown(object sender, MouseEventArgs e)
        {
            surukle = true;
            konum = e.Location;
        }

        private void pnlContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukle)
            {
                this.Left = e.X + this.Location.X - (konum.X);
                this.Top = e.Y + this.Location.Y - (konum.Y);
            }
        }

        private void pnlContainer_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Sınıflar.FormIslemleri.FormKapat(this, true);
        }

        private void frmEgde_Load(object sender, EventArgs e)
        {
        }

        bool frmFullScreen = false;
        private void btnFull_Click(object sender, EventArgs e)
        {
            if (!frmFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                frmFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                frmFullScreen = false;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void WebKitBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
        }
        
        private void WebKitBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void pnlAdressContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WebKitBrowser_Load(object sender, EventArgs e)
        {

        }

        private void WebKitBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlSekmeler.Controls.Add(Sınıflar.Edge.SekmeEkle());
            pnlSekmeler.Width = (pnlSekmeler.Controls.Count) * 150;
            EdgeMain eMain = new EdgeMain();
            eMain.Dock = DockStyle.Fill;
            eMain.Width = pnlMain.Width;
            eMain.Height = pnlMain.Height;
            pnlMain.Controls.Add(eMain);

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
