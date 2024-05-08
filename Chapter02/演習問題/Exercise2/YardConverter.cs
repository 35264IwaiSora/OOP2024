using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class YardConverter {
        //private const double raito = 0.3048; //定数

        public static readonly double raito = 0.9144; //定数（外部にも公開する場合）

        //メートルからヤードを求める
        public static double FromMeter(double meter) {
            return meter / raito;
        }
        //ヤードからメートルを求める
        public static double ToMeter(double yard) {
            return yard * raito;
        }
    }
}
