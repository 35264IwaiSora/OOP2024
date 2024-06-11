using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    internal class Program {
        static Dictionary<string, string> prefectureOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {

            String prefecture,prefectural_office;
            Console.WriteLine("県庁所在地の登録");

            while(true) {
                //都道府県の入力
                Console.Write("都道府県：");
                prefecture = Console.ReadLine();

                if (prefecture == null) {
                    break;
                }

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
                
                switch (menuDisp()) {
                    case "1":
                        listDisplay();
                        break;

                    case "2":
                        prefecture = serachPrefectural_office();
                        break;

                    case "9":
                        endFlag = true;
                        break;
                }
            }
        }

        private static string serachPrefectural_office() {
            string prefecture;
            Console.Write("都道府県：");
            prefecture = Console.ReadLine();
            Console.WriteLine(prefecture + "の県庁所在地は" + prefectureOfficeDict[prefecture] + "です。");
            return prefecture;
        }
        //一覧表示
        private static void listDisplay() {
            foreach (var item in prefectureOfficeDict) {
                Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
            }
        }
        //メニュー表示
        private static string menuDisp() {
            Console.WriteLine("*メニュー*");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            string menuSelect = Console.ReadLine();
            return menuSelect;
        }
    }
}