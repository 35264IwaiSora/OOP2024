using System.Security.Permissions;

namespace BallApp {
    public partial class Form1 : Form {
        Obj ball;   
        PictureBox pb;
       
        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            //this.BackColor = Color.Green;
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            
            ball.Move();
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();
            
            if (e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X-25, e.Y-25);

            }else if(e.Button == MouseButtons.Right){
                pb.Size = new Size(25,25);
                ball = new TennisBall(e.X - 12, e.Y - 12);
            }

            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();
        }
    }
}