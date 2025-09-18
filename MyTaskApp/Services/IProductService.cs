using MyTaskApp.Model;
using System.Collections.Generic;

namespace MyTaskApp.Services
{
    public interface IProductService
    {
        List<Product> GetByCategory(Categories category);
        public Product GetProductWithMaxPrice();
        public decimal GetTotalPrice();
        public decimal GetAveragePrice();
        Dictionary<Categories, List<Product>> GetProductsGroupedByCategory();

    }
}
