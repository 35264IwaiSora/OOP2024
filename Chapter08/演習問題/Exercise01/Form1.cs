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
            var str = now.ToString("ggyy年M月d日(dddd)", culture);

            tbDisp.Text = now.ToString("g") + "\r\n";
            tbDisp.Text += now.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";
            tbDisp.Text += str.ToString();
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var date = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                //来週の日付を取得
                var str1 = string.Format("{0:yy/MM/dd}の次週の{1}:", date, (DayOfWeek)dayofweek);
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
            var str = string.Format("処理時間は{0}ミリ秒でした",duration.TotalMilliseconds);
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
