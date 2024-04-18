using SampleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123,"かりんとう",180);
            Product daihuku = new Product(230, "大福", 150);
            Product dorayaki = new Product(98, "どら焼き", 210);

            int price = karinto.Price;
            int taxIncluded = karinto.GetPriceIncludingTax();

            int daihukuPrice = daihuku.Price;
            int daihukuTaxIncluded = daihuku.GetPriceIncludingTax();

            int dorayakiTax = dorayaki.GetTax();

            Console.WriteLine(karinto.Name + "の税込み金額" + taxIncluded + "円【税抜き" + price + "円】");
            Console.WriteLine(daihuku.Name + "の税込み金額" + taxIncluded + "円【税抜き" + price + "円】");
            Console.WriteLine($"{dorayakiTax}円");
        }
    }
}
