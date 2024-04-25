﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    static class InchConverter {
        //private const double raito = 0.3048; //定数

        public static readonly double raito = 0.0254; //定数（外部にも公開する場合）

        //メートルからインチを求める
        public static double FromMeter(double meter) {
            return meter / raito;
        }
        //インチからメートルを求める
        public static double ToMeter(double inch) {
            return inch * raito;
        }
    }
}
