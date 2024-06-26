using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport> ();
        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport { 
                Date = dtpDate.Value,
            
            
            };
            listCarReport.Add(carReport);



        }
    }
}
