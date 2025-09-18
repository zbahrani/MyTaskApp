using MyTaskApp.Data;
using MyTaskApp.Model;
using MyTaskApp.Services;
using System;

namespace MyTaskApp
{
    class Program
    {
        //متد کمکی برای ساخت سرویس محصول با داده‌های اولیه
        private static IProductService BuildProduct()
        {
            var products = ProductSeedData.GetProducts();
            return new ProductService(products);
        }
        static void Main(string[] args)
        {
            var product = BuildProduct();
            var all = product.GetByCategory(Categories.Category1);
            foreach(var p in all)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
            }

            Console.WriteLine("---------------------------------");

            var maxprice = product.GetProductWithMaxPrice();
            Console.WriteLine($"{maxprice.Id} - " +
                $"{maxprice.Name} - " +
                $"{maxprice.Category} - " +
                $"{maxprice.Price}");

            Console.WriteLine("---------------------------------");

            var totalprice = product.GetTotalPrice();
            Console.WriteLine($"Total price is: {totalprice}");

            Console.WriteLine("---------------------------------");

            var grouped = product.GetProductsGroupedByCategory();
            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key);
                foreach (var pro in group.Value)
                {
                    Console.WriteLine($"  {pro.Name} - {pro.Price}");
                }
            }

            Console.WriteLine("---------------------------------");

            var averageprice = product.GetAveragePrice();
            Console.WriteLine($"Average price is: {averageprice}");
        }
        
    }
}
