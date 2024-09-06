using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Web.WebView2.Core;
using Microsoft.Toolkit.Forms.UI.Controls;
using Microsoft.Web.WebView2.Wpf;

namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;
        private EventHandler<CoreWebView2InitializationCompletedEventArgs> WebView2_CoreWebView2InitializationCompleted;

        public Form1() {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            xvRssBrowser.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;

            xvRssBrowser.EnsureCoreWebView2Async(null);

        }
        private void Form_Resize(object sender, EventArgs e) {
            xvRssBrowser.Size = this.ClientSize - new System.Drawing.Size(xvRssBrowser.Location);
            btGet.Left = this.ClientSize.Width - btGet.Width;
            tbRssUrl.Width = btGet.Left - tbRssUrl.Left;
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                    .Select(item => new ItemData {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    }).ToList();

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (xvRssBrowser != null && xvRssBrowser.CoreWebView2 != null) {
                xvRssBrowser.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }
        }
    }


    //データ格納用のクラス
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
