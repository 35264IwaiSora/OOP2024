using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : TextProcessor{
        
        protected override void Initialize(string fname) {
           
        }
        protected override void Execute(string line) {
            string output = new string(line.Select(c=>(c>='０'&&c<='９')?(char)(c-'０'+'0'):c).ToArray());
            Console.WriteLine(output);
        }
        protected override void Terminate() {
            
        }
    }
}
