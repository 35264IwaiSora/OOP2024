namespace DateTimeApp {
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
            dtpBirthday = new DateTimePicker();
            btDateCount = new Button();
            tbDsip = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(31, 65);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(147, 65);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 39);
            dtpBirthday.TabIndex = 1;
            dtpBirthday.Value = new DateTime(2024, 6, 21, 0, 0, 0, 0);
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(148, 123);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(147, 67);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDsip
            // 
            tbDsip.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDsip.Location = new Point(43, 320);
            tbDsip.Name = "tbDsip";
            tbDsip.Size = new Size(304, 39);
            tbDsip.TabIndex = 3;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(43, 230);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 46);
            nudDay.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefore.Location = new Point(200, 196);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(95, 46);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefor_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayAfter.Location = new Point(200, 257);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(95, 46);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 444);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDsip);
            Controls.Add(btDateCount);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button btDateCount;
        private TextBox tbDsip;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button btDayAfter;
    }
}
