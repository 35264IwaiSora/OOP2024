using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
          
            var books = Library.Books.GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key);
            foreach (var book in books){
                Console.WriteLine(book);
            }
            
            
            
        }
    }
}
