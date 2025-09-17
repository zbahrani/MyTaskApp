using MyTaskApp.Model;
using System.Collections.Generic;

namespace MyTaskApp.Services
{
    public interface IProductService
    {
        List<Product> GetByCategory();
        public Product GetProductWithMaxPrice();
        public decimal GetTotalPrice();
        public decimal GetAveragePrice();
        Dictionary<Categories, List<Product>> GetProductsGroupedByCategory();

    }
}
