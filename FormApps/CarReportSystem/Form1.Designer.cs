namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbCarName = new ComboBox();
            label6 = new Label();
            cbAuthor = new ComboBox();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbHonda = new RadioButton();
            tbReport = new TextBox();
            rbSubaru = new RadioButton();
            rbInport = new RadioButton();
            rbAther = new RadioButton();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            label7 = new Label();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label8 = new Label();
            dgvCarReport = new DataGridView();
            btReportOpen = new Button();
            btRepotSave = new Button();
            groupBox1 = new GroupBox();
            ofdPicFileOpen = new OpenFileDialog();
            ssMessageArea = new StatusStrip();
            tslbMessage = new ToolStripStatusLabel();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            btClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            groupBox1.SuspendLayout();
            ssMessageArea.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(93, 21);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(10, 218);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 0;
            label4.Text = "レポート";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(453, 29);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 0;
            label5.Text = "画像";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(93, 164);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(259, 33);
            cbCarName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(18, 127);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 0;
            label6.Text = "メーカー";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(93, 78);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(259, 33);
            cbAuthor.TabIndex = 2;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 9);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(62, 9);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 3;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 9);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 3;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(93, 223);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(346, 105);
            tbReport.TabIndex = 4;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(171, 9);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbInport
            // 
            rbInport.AutoSize = true;
            rbInport.Location = new Point(231, 9);
            rbInport.Name = "rbInport";
            rbInport.Size = new Size(61, 19);
            rbInport.TabIndex = 3;
            rbInport.Text = "輸入車";
            rbInport.UseVisualStyleBackColor = true;
            // 
            // rbAther
            // 
            rbAther.AutoSize = true;
            rbAther.Checked = true;
            rbAther.Location = new Point(298, 9);
            rbAther.Name = "rbAther";
            rbAther.Size = new Size(56, 19);
            rbAther.TabIndex = 3;
            rbAther.TabStop = true;
            rbAther.Text = "その他";
            rbAther.UseVisualStyleBackColor = true;
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(534, 33);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 5;
            btPicOpen.Text = "開く…";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(615, 33);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 5;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.White;
            pbPicture.Location = new Point(453, 62);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(239, 219);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(27, 172);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 0;
            label7.Text = "車名";
            // 
            // btAddReport
            // 
            btAddReport.Location = new Point(453, 287);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(75, 36);
            btAddReport.TabIndex = 5;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.Location = new Point(536, 287);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(75, 36);
            btModifyReport.TabIndex = 5;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Location = new Point(617, 287);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 36);
            btDeleteReport.TabIndex = 5;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.Location = new Point(18, 338);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 0;
            label8.Text = "一覧";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.AllowUserToResizeColumns = false;
            dgvCarReport.AllowUserToResizeRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(93, 338);
            dgvCarReport.MultiSelect = false;
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.RowHeadersVisible = false;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(599, 150);
            dgvCarReport.TabIndex = 7;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // btReportOpen
            // 
            btReportOpen.Location = new Point(12, 395);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(75, 36);
            btReportOpen.TabIndex = 5;
            btReportOpen.Text = "開く…";
            btReportOpen.UseVisualStyleBackColor = true;
            btReportOpen.Click += btReportOpen_Click;
            // 
            // btRepotSave
            // 
            btRepotSave.Location = new Point(12, 452);
            btRepotSave.Name = "btRepotSave";
            btRepotSave.Size = new Size(75, 36);
            btRepotSave.TabIndex = 5;
            btRepotSave.Text = "保存";
            btRepotSave.UseVisualStyleBackColor = true;
            btRepotSave.Click += btRepotSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbInport);
            groupBox1.Controls.Add(rbAther);
            groupBox1.Location = new Point(87, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 28);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tslbMessage });
            ssMessageArea.Location = new Point(0, 532);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(734, 22);
            ssMessageArea.SizingGrip = false;
            ssMessageArea.TabIndex = 9;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tslbMessage
            // 
            tslbMessage.Name = "tslbMessage";
            tslbMessage.Size = new Size(118, 17);
            tslbMessage.Text = "toolStripStatusLabel1";
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // btClear
            // 
            btClear.Location = new Point(318, 21);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 31);
            btClear.TabIndex = 10;
            btClear.Text = "クリア";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 554);
            Controls.Add(btClear);
            Controls.Add(ssMessageArea);
            Controls.Add(groupBox1);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btRepotSave);
            Controls.Add(btReportOpen);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(tbReport);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbCarName;
        private Label label6;
        private ComboBox cbAuthor;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbHonda;
        private TextBox tbReport;
        private RadioButton rbSubaru;
        private RadioButton rbInport;
        private RadioButton rbAther;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Label label7;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label8;
        private DataGridView dgvCarReport;
        private Button btReportOpen;
        private Button btRepotSave;
        private GroupBox groupBox1;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tslbMessage;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFileOpen;
        private Button btClear;
    }
}
