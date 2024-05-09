using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class TennisBall : Obj {
        public static int Count { get; set; }

        Random random = new Random(); //乱数インスタンス

        public TennisBall(double xp, double yp)
            : base(xp,yp,@"Pictuer\tennis_ball.png"){
            MoveX = random.Next(-25, 25); //移動量設定
            MoveY = random.Next(-25, 25);
            Count++;
        }

        public override bool Move() {

            if (PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY > 500 || PosY < 0) {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

            return true;
        }
    }
}
