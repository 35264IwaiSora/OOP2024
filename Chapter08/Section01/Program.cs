﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str =birthday.ToString("ggyy年M月d日", culture);
            Console.WriteLine("あなたは{0}{1}に生まれました", str, birthday.ToString("dddd"));

            var today = DateTime.Today;
            TimeSpan diff = today.Date - birthday.Date;
            Console.WriteLine("あなたは生まれてから{0}日目です",diff.Days);
        }
    }
}
