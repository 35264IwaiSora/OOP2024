using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            //var employeeDict = new Dictionary<int, Employee> {
            //    { 100, new Employee(100, "清水遼久") },
            //    { 112, new Employee(112, "芹沢洋和") },
            //    { 125, new Employee(125, "岩瀬奈央子") },
            //};

            //employeeDict.Add(126, new Employee(126, "庄野和花"));

            //foreach(var item in employeeDict.Keys) {
            //    Console.WriteLine($"{item}");
            //}
            var prefectureOfficeDict = new Dictionary<string, string>();

            String prefecture;
            String prefectural_office;
            Console.WriteLine("県庁所在地の登録");

            for (int i = 0; i < 5; i++) {
                //都道府県の入力
                Console.Write("都道府県：");
                prefecture = Console.ReadLine();
                //県庁所在地の入力
                Console.Write("県庁所在地：");
                prefectural_office = Console.ReadLine();
                
                prefectureOfficeDict.Add(prefecture,prefectural_office);
            }
            while (true) {
                Console.WriteLine("*メニュー*");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                int num = int.Parse(Console.ReadLine());
                if (num == 1) {
                    foreach (var item in prefectureOfficeDict) {
                        Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
                    }
                } else if (num == 2) {
                    Console.Write("都道府県：");
                    prefecture = Console.ReadLine();
                    foreach (var item in prefectureOfficeDict) {
                        if (item.Key == prefecture) {
                            Console.Write("県庁所在地：");
                            Console.WriteLine(item.Value);
                        }
                    }
                } else if (num == 9) {
                    break;
                }
            }



            }
        }
}
