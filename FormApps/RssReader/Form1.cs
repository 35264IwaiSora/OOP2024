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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;
        private EventHandler<CoreWebView2InitializationCompletedEventArgs> WebView2_CoreWebView2InitializationCompleted;

        Dictionary<string, string> topics = new Dictionary<string, string> {
            { "主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            { "国内","https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            { "国際","https://news.yahoo.co.jp/rss/topics/world.xml" },
            { "経済","https://news.yahoo.co.jp/rss/topics/business.xml" },
            { "エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            { "スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml" },
            { "IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            { "科学","https://news.yahoo.co.jp/rss/topics/science.xml" },
            { "地域","https://news.yahoo.co.jp/rss/topics/local.xml" },
        };


        public Form1() {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            xvRssBrowser.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;

            xvRssBrowser.EnsureCoreWebView2Async(null);
            AddCbBox();
            cbRssUrl.SelectedIndex = -1;
        }

        private void AddCbBox() {
            cbRssUrl.DataSource = new BindingSource(topics, null);
            cbRssUrl.DisplayMember = "Key";
            cbRssUrl.ValueMember = "Value";
        }

        private void Form_Resize(object sender, EventArgs e) {
            xvRssBrowser.Size = this.ClientSize - new System.Drawing.Size(xvRssBrowser.Location);
           
        }

        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
            //検索
            string cbBox = cbRssUrl.Text;
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                if (cbRssUrl.Text.Contains("yahoo.co.jp/rss/")) {
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
                } else if (topics.ContainsKey(cbBox)) {
                    var set = (KeyValuePair<string, string>)cbRssUrl.SelectedItem;
                    var topicurl = set.Value;
                    using (var wc = new WebClient()) {
                        var url = topicurl.ToString();
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
                } else {
                    MessageBox.Show("正しいURLを入力してください", "エラー");
                }
            } else {
                MessageBox.Show("ネットワークに接続してください", "エラー");
            }
            
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            
            if (xvRssBrowser != null && xvRssBrowser.CoreWebView2 != null) {
                xvRssBrowser.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }
        }

        private void btregistration_Click(object sender, EventArgs e) {
            //お気に入り登録
            if(tbfavorite != null && cbRssUrl.Text.Contains("yahoo.co.jp/rss/")) {
                topics.Add(tbfavorite.Text, cbRssUrl.Text);
                AddCbBox();
                cbRssUrl.SelectedIndex = -1;
            } else {
                MessageBox.Show("URLと名前を入力してください", "エラー");
            }
            
        }
    }

    //データ格納用のクラス
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
