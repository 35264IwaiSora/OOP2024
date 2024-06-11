using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            
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

                if (prefectureOfficeDict.ContainsKey(prefecture)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    var reWrite = Console.ReadLine();
                    if(reWrite == "N") {
                        continue;
                    }   
                }
                    prefectureOfficeDict.Add(prefecture, prefectural_office);
            }

            Console.WriteLine(); //改行

            Boolean endFlag = false; //終了フラグ
            while (!endFlag) {
                Console.WriteLine("*メニュー*");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                string menuSelect = Console.ReadLine();
                switch (menuSelect) {
                    case "1":
                        foreach (var item in prefectureOfficeDict) {
                            Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
                        }
                        break;

                    case "2":
                        Console.Write("都道府県：");
                        prefecture = Console.ReadLine();
                        Console.WriteLine(prefecture + "の県庁所在地は" + prefectureOfficeDict[prefecture] + "です。");

                        break;

                    case "9":
                        endFlag = true;
                        break;
                }
            }
        }

    }
}