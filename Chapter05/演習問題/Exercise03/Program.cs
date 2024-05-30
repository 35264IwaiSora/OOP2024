﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var spaces = text.Count(c => c == ' ');
           Console.WriteLine("空白数：[0]",spaces);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            string[] words = text.Split(' ');
            Console.WriteLine("単語の数："+words.Length);
        }

        private static void Exercise3_4(string text) {
            string[] words = text.Split(' ');
            var a = words.Where(s => s.Length <= 4);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3_5(string text) {
        
        }
    }
}
