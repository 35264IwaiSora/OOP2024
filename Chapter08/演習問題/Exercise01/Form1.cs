using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("ggyy年M月d日dddd", culture);

            tbDisp.Text = now.ToString("G") + "\r\n";
            tbDisp.Text += now.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";
            tbDisp.Text += str.ToString();
        }

        private void btEx8_2_Click(object sender, EventArgs e) {

        }
    }
}
