using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Formlar.Microsoft_Edge
{
    public partial class EdgeMain : UserControl
    {
        public EdgeMain()
        {
            InitializeComponent();
        }
        string address;
        private void btnGo_Click(object sender, EventArgs e)
        {
            address = txtSearch.Text;
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
                Yukleniyor();
            }
            try
            {
                WebKitBR.Navigate(address);
                Yukleniyor();
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        public void Yukleniyor()
        {
            btnGo.SendToBack();
        }
        public void Yuklendi()
        {
            picLoading.SendToBack();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            WebKitBR.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WebKitBR.GoForward();
        }

        private void WebKitBR_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Yuklendi();
            Sınıflar.Edge.butonlar[0].Text = e.Url.Host.ToString();
            txtSearch.Text = e.Url.ToString();
        }

        private void WebKitBR_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Yukleniyor();
        }

        private void WebKitBR_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if ((int)e.CurrentProgress > 0)
            {
                arcScaleComponent1.MaxValue = (int)e.MaximumProgress;
                if (arcScaleComponent1.Value >= (int)e.MaximumProgress)
                    arcScaleComponent1.Value = 0;
                arcScaleComponent1.Value = (int)e.CurrentProgress;
            }
        }

        private void pnlAdressContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
