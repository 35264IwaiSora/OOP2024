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
            this.tbfavorite = new System.Windows.Forms.TextBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btregistration = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xvRssBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btGet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGet.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGet.Location = new System.Drawing.Point(588, 13);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 27);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(24, 103);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(250, 628);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // xvRssBrowser
            // 
            this.xvRssBrowser.AllowExternalDrop = true;
            this.xvRssBrowser.CreationProperties = null;
            this.xvRssBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.xvRssBrowser.Location = new System.Drawing.Point(292, 103);
            this.xvRssBrowser.Name = "xvRssBrowser";
            this.xvRssBrowser.Size = new System.Drawing.Size(555, 630);
            this.xvRssBrowser.TabIndex = 3;
            this.xvRssBrowser.ZoomFactor = 1D;
            // 
            // tbfavorite
            // 
            this.tbfavorite.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbfavorite.Location = new System.Drawing.Point(130, 58);
            this.tbfavorite.Name = "tbfavorite";
            this.tbfavorite.Size = new System.Drawing.Size(452, 23);
            this.tbfavorite.TabIndex = 0;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(130, 16);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(452, 24);
            this.cbRssUrl.TabIndex = 4;
            // 
            // btregistration
            // 
            this.btregistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btregistration.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btregistration.Location = new System.Drawing.Point(588, 58);
            this.btregistration.Name = "btregistration";
            this.btregistration.Size = new System.Drawing.Size(75, 27);
            this.btregistration.TabIndex = 5;
            this.btregistration.Text = "登録";
            this.btregistration.UseVisualStyleBackColor = true;
            this.btregistration.Click += new System.EventHandler(this.btregistration_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(90, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "検索";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(46, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "お気に入り";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 745);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btregistration);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.xvRssBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbfavorite);
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
        private System.Windows.Forms.TextBox tbfavorite;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btregistration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

