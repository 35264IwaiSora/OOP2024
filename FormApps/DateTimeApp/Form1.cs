namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            TimeSpan diff = today - dtpDate.Value;
            tbDsip.Text = diff.Days + 1 + "“ú–Ú";
            //tbDsip.Text = "››“ú–Ú";
            //tbDsip.Text = dtpBirthday.Value.ToString("d");
        }

        private void btDayBefor_Click(object sender, EventArgs e) {
            var day = dtpDate.Value; 
            var past = day.AddDays(-(double)nudDay.Value);
            tbDsip.Text = past.ToString();
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var day = dtpDate.Value; ;
            var future = day.AddDays((double)nudDay.Value);
            tbDsip.Text = future.ToString();
        }
    }
}
