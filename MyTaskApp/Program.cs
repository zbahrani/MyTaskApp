using MyTaskApp.Data;
using MyTaskApp.Model;
using MyTaskApp.Services;
using System;

namespace MyTaskApp
{
    class Program
    {
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
        }
    }
}
