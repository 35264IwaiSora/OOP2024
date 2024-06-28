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
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReport.Add(carReport);

        }
        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if(rbToyota.Checked) {
                return CarReport.MakerGroup.�g���^;
            }else if(rbNissan.Checked) {
                return CarReport.MakerGroup.���Y;
            }else if(rbHonda.Checked) {
                return CarReport.MakerGroup.�z���_;
            }else if(rbSubaru.Checked) {
                return CarReport.MakerGroup.�X�o��;
            }else if(rbInport.Checked){
                return CarReport.MakerGroup.�A����;
            }else {
                return CarReport.MakerGroup.���̑�;
            }
        }
    }
}
