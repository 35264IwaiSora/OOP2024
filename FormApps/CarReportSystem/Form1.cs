using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReport = new BindingList<CarReport> ();
        //�R���X�g���N�^
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
