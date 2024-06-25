namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            TimeSpan diff = today - dtpBirthday.Value;
            tbDsip.Text = diff.Days + 1 + "“ú–Ú";
            //tbDsip.Text = "››“ú–Ú";
            //tbDsip.Text = dtpBirthday.Value.ToString("d");
        }

        private void btDayBefor_Click(object sender, EventArgs e) {
            var day = dtpBirthday.Value; ;
            var past = nudDay.Value;
            tbDsip.Text = day.AddDays((double)past*-1).ToString();
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var day = dtpBirthday.Value; ;
            var past = nudDay.Value;
            tbDsip.Text = day.AddDays((double)past).ToString();
        }
    }
}
