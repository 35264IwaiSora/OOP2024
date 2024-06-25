namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            TimeSpan diff = today - dtpDate.Value;
            tbDsip.Text = diff.Days + 1 + "ì˙ñ⁄";
            //tbDsip.Text = "ÅõÅõì˙ñ⁄";
            //tbDsip.Text = dtpBirthday.Value.ToString("d");
        }

        private void btDayBefor_Click(object sender, EventArgs e) {
            var day = dtpDate.Value;
            var past = day.AddDays(-(double)nudDay.Value);
            tbDsip.Text = past.ToString("D");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var day = dtpDate.Value; ;
            var future = day.AddDays((double)nudDay.Value);
            tbDsip.Text = future.ToString("D");
        }

        private void btAge_Click(object sender, EventArgs e) {
            var tragetday = DateTime.Today;
            var birthday = dtpDate.Value;

            tbDsip.Text = GetAge(birthday, tragetday).ToString();
        }
        public static int GetAge(DateTime birthday,DateTime today) {
            var age = today.Year - birthday.Year;
            if (today < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
