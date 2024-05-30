using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line, out num)) {
                string formattedNumber = num.ToString("N0");
                Console.WriteLine(formattedNumber);
            } else {
                Console.WriteLine("変換に失敗しました");
            }
        }
    }
}
