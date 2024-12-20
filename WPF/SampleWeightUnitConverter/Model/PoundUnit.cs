﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleWeightUnitConverter{
    public class PoundUnit : WeightUnit{
        //グラムを表すクラス
        private static List<PoundUnit> units = new List<PoundUnit>() {
            new PoundUnit { Name = "oz",Coefficient =1 },
            new PoundUnit { Name = "lb", Coefficient = 16 },
        };
        
        public static ICollection<PoundUnit> Units { get { return units; } }
        /// <summary>
        /// ポンドからグラム
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromGramUnit(GramUnit unit ,double value) {
            return (value * unit.Coefficient)/ 28.34/this.Coefficient;
        }
    }
}

