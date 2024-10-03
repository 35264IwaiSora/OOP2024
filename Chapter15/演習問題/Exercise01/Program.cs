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

            var query = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories, //結合する2番目のシーケンス
                book => book.CategoryId,  //対象シーケンスの結合キー
                category => category.Id,  //2番目のシーケンスの結合キー
                (book, category) => category.Name).Distinct();
            foreach (var name in query) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var query = Library.Books
                .Join(Library.Categories,   //結合する2番目のシーケンス
                    book => book.CategoryId,//対象シーケンスの結合キー
                    category => category.Id,// 2番目のシーケンスの結合キー
                    (book, category) => new {
                        book.Title,
                        CategoryName = category.Name
                    })
                    .GroupBy(b => b.CategoryName)
                    .OrderBy(x => x.Key);
            foreach (var group in query)
            {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("  {0}",item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categorysId = Library.Categories.Single(c=>c.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == categorysId)
                                        .GroupBy(b=>b.PublishedYear)
                                        .OrderBy(b=>b.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine("  {0}", item.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories.GroupJoin(Library.Books,
                                            c => c.Id,
                                            b => b.CategoryId,
                                            (c, books) => new { 
                                            Category = c.Name, 
                                            Count = books.Count() }).
                                            Where(b=> b.Count >= 4);
            foreach (var item in query)
            {
                Console.WriteLine(item.Category);
            }
        }
    }
}
