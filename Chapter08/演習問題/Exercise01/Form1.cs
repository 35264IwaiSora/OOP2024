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
            var str = now.ToString("ggyy�NM��d��dddd", culture);

            tbDisp.Text = now.ToString("G")+"\r\n"
            + now.ToString("yyyy�NMM��dd�� HH��mm��ss�b") + "\r\n"
            + str.ToString();
        }
    }
}
