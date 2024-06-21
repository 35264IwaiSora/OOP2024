using System;
using System.Collections.Generic;
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
            DayOfWeek dayOfWeek = birthday.DayOfWeek;
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    Console.WriteLine("あなたは日曜日に生まれました");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("あなたは月曜日に生まれました");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("あなたは火曜日に生まれました");
                    break;
                
                case DayOfWeek.Wednesday:
                    Console.WriteLine("あなたは水曜日に生まれました");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("あなたは木曜日に生まれました");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("あなたは金曜日に生まれました");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("あなたは土曜日に生まれました");
                    break;
            }
        }
    }
}
