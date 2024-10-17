using TextNumberSizeChange.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : ITextFileService {

        private int _count;
        //protected override void Initialize(string fname) {

        //}
        //protected override void Execute(string line) {
        //    string output = new string(line.Select(c=>(c>='０'&&c<='９')?(char)(c-'０'+'0'):c).ToArray());
        //    Console.WriteLine(output);
        //}
        //protected override void Terminate() {

        //}
        public void Execute(string line) {
            string output = new string(line.Select(c => (c >= '０' && c <= '９') ? (char)(c - '０' + '0') : c).ToArray());
                Console.WriteLine(output);
            }

        public void Initialize(string fname) {
            _count = 0;
        }

        public void Terminate() {
           
        }
    }  
}

