﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(x => x.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book); 
        }

        private static void Exercise1_3() {
            var query = Library.Books.GroupBy(b => b.PublishedYear)
                .Select(g=>new { PublishedYear = g.Key, Count = g.Count() })
                .OrderBy(y=>y.PublishedYear);
            foreach(var item in query)
                Console.WriteLine("{0}年 {1}冊",item.PublishedYear,item.Count);
        }

        private static void Exercise1_4() {
            var query = Library.Books.
                Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    book.PublishedYear,
                    book.Price,
                    CategoryName = category.Name,
                }).OrderByDescending(b => b.PublishedYear).ThenByDescending(b=>b.Price);
            foreach (var item in query)
            {
                Console.WriteLine("{0}年 {1}円 {2} ({3})", item.PublishedYear, item.Price, item.Title, item.CategoryName);
            }

        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
            throw new NotImplementedException();
        }

        private static void Exercise1_7() {
            throw new NotImplementedException();
        }

        private static void Exercise1_8() {
            throw new NotImplementedException();
        }
    }
}
