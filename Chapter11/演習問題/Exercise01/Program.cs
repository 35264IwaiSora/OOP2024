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
            var element = new XElement("sample.xml",
                new XElement("name" ,"サッカー",new XAttribute("kanji","蹴球")),
                new XElement("teammembers","11"),
                new XElement("firstplayed","1863")
                );
            var xdoc = XDocument.Load("sample.xml");
            xdoc.Root.Add(element);
            //確認用
            foreach (var xElement in xdoc.Root.Elements()) {
                var xname = xElement.Element("name");
                var xkanji = xname.Attribute("kanji");
                var xmenber = xElement.Element("teammembers");
                var xyear = xElement.Element("firstplayed");
                Console.WriteLine("{0},{1},{2},{3}", xname.Value,xkanji.Value,xmenber.Value,xyear.Value);
            }
            //保存
            xdoc.Save("sports.xml");
        }
    }
}
