using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall : Obj {
        public static int Count { get; set; }

        Random random = new Random();//乱数インスタンス

        public SoccerBall(double xp, double yp)
            : base(xp,yp,@"Pictuer\soccer_ball.png"){
            MoveX = random.Next(-25,25); //移動量設定
            MoveY = random.Next(-25,25); 
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

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
