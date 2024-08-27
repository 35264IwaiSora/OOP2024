using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employees = new Employee {
                Id = 123,
                Name = "山田太郎",
                HireDate = DateTime.Now,
            };

            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using(var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(writer,employees);
            }
        }

        private static void Exercise1_2(string outfile) {
            
        }

        private static void Exercise1_3(string file) {
            
        }

        private static void Exercise1_4(string file) {
            
        }
    }
}
