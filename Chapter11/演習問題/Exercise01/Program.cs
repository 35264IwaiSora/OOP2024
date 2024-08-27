using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements();
            foreach (var x in xelements) {
                var xname = x.Element("name");
                var xmenber = x.Element("teammembers");
                Console.WriteLine( "{0},{1}",xname.Value,xmenber.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements().OrderBy(x => (int)x.Element("firstplayed"));
            foreach (var x in xelements)
            {
                var xkanji = x.Element("name").Attribute("kanji");
                var xyear = x.Element("firstplayed");
                Console.WriteLine("{0},{1}",xkanji.Value,xyear.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements().OrderByDescending(x => x.Element("teammembers").Value).First();
            Console.WriteLine(xelements.Element("name").Value);
            
        }   

        private static void Exercise1_4(string file, string newfile) {
            int nextFlag;
            string name, kanji, origin, member;
            List<XElement> xElements = new List<XElement>();
            var xdoc = XDocument.Load(file);
            while(true) {
                //入力処理
                Console.Write("名称：");
                name = Console.ReadLine();
                Console.Write("漢字：");
                kanji = Console.ReadLine();
                Console.Write("人数：");
                member = Console.ReadLine();
                Console.Write("起源：");
                origin = Console.ReadLine();
                //1件分の要素作成
                var element = new XElement("ballsport",
                    new XElement("name", name, new XAttribute("kanji", kanji)),
                    new XElement("teammembers", member),
                    new XElement("firstplayed", origin)
                    );
                xElements.Add(element); //リストに追加

                Console.WriteLine();
                Console.WriteLine("追加（1）、保存（2）");
                nextFlag = int.Parse(Console.ReadLine());
                //無限ループを抜ける
                if(nextFlag == 2) {
                    break;
                }
                Console.WriteLine();
            }
            xdoc = XDocument.Load(file);
            //保存
            xdoc.Save(newfile);


        }
    }
}
