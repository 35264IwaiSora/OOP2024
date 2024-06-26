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
            var str = now.ToString("ggyy”NMŒd“ú(dddd)", culture);

            tbDisp.Text = now.ToString("g") + "\r\n";
            tbDisp.Text += now.ToString("yyyy”NMMŒdd“ú HHmm•ªss•b") + "\r\n";
            tbDisp.Text += str.ToString();
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var date = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                //—ˆT‚Ì“ú•t‚ğæ“¾
                var str1 = string.Format("{0:yy/MM/dd}‚ÌŸT‚Ì{1}:", date, (DayOfWeek)dayofweek);
                var str2 = string.Format("{0:yy/MM/dd(ddd)}", NextWeek(date, (DayOfWeek)dayofweek));
                tbDisp.Text += str1 + str2 + "\r\n";

            }
        }
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;

            return nextweek.AddDays(day);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Strat();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = string.Format("ˆ—ŠÔ‚Í{0}ƒ~ƒŠ•b‚Å‚µ‚½",duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }
    class TimeWatch {
        private DateTime _time;

        public void Strat() {
            _time = DateTime.Now;
        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }
    }
}
