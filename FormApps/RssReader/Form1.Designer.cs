namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.xvRssBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.xvRssBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(588, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(23, 115);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(448, 100);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // xvRssBrowser
            // 
            this.xvRssBrowser.AllowExternalDrop = true;
            this.xvRssBrowser.CreationProperties = null;
            this.xvRssBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.xvRssBrowser.Location = new System.Drawing.Point(23, 227);
            this.xvRssBrowser.Name = "xvRssBrowser";
            this.xvRssBrowser.Size = new System.Drawing.Size(705, 506);
            this.xvRssBrowser.TabIndex = 3;
            this.xvRssBrowser.ZoomFactor = 1D;
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Location = new System.Drawing.Point(23, 66);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(186, 19);
            this.tbRssUrl.TabIndex = 0;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(23, 17);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(559, 20);
            this.cbRssUrl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 745);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.xvRssBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbRssUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xvRssBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 xvRssBrowser;
        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.ComboBox cbRssUrl;
    }
}

