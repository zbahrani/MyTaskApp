using MyTaskApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyTaskApp.Services
{
    public abstract class ProductServiceBase : IProductService
    {
        protected readonly List<Product> _products;
        protected ProductServiceBase(List<Product> products)
        {
            _products = products;
        }
        public abstract List<Product> GetByCategory(Categories category);
        public abstract Product GetProductWithMaxPrice();
     
        public virtual decimal GetAveragePrice()
        {
            return _products.Average(p => p.Price);
        }

        public virtual Dictionary<Categories, List<Product>> GetProductsGroupedByCategory()
        {
            return _products.GroupBy(p => p.Category)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public virtual decimal GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }
    }
}
