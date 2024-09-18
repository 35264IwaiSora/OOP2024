using SampleEntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramwork {
    internal class Program {
        static void Main(string[] args) {

            //InsertBooks();
            //AddBooks();
            //AddAuthors();
            //foreach (var item in GetBooks()){
            //    Console.WriteLine("{0}",item.Title);
            //}
            DisplayAllBooks3();
            Console.WriteLine();
            Console.WriteLine("#1.4");
            Exercice1_4();
            Console.WriteLine();
            Console.WriteLine("#1.5");
            Exercice1_5();
        }

       

        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges(); //データベースを更新
            }
        }
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.//Where(book => book.Author.Name.StartsWith("夏目")).
                                ToList();
            }
        }
        //著者の追加
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authers.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authers.Add(author2);
                db.SaveChanges();
            }
        }
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authers.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authers.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);
                var author3 = db.Authers.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book3);
                var author4 = db.Authers.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }
        //データの変更
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.Books.Add(book);
            }
        }
        private static void DeleteBooks() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        static void DisplayAllBooks2() {
            using (var db = new BooksDbContext()) {
                foreach (var item in db.Books.ToList()) {
                    Console.WriteLine("{0},{1},{2},({3:yyyy/MM/dd})", item.Title, item.PublishedYear, item.Author.Name, item.Author.Birthday);

                }
            }
        }
        static void DisplayAllBooks3() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(s => s.Title.Length == db.Books.Max(x => x.Title.Length)).ToList();
                foreach (var item in books) {
                    Console.WriteLine(item.Title);
                }

            }
        }
        private static void Exercice1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(s => s.PublishedYear).ToList();
                for (var i = 0; i < 3; i++) {
                    Console.WriteLine("{0},{1}",books[i].Title, books[i].Author.Name);
                }
            }

        }

        private static void Exercice1_5() {
            
        }
    }
}