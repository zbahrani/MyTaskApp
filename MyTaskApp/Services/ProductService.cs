using MyTaskApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskApp.Services
{
    public class ProductService : ProductServiceBase
    {
        public ProductService(List<Product> products) : base(products)
        {
        }

        public override List<Product> GetByCategory(Categories category)
        {
            return _products
                .Where(p => p.Category == category)
                .ToList();
        }

        public override Product GetProductWithMaxPrice()
        {
            return _products
                .OrderByDescending(p => p.Price)
                .FirstOrDefault();
        }
    }
}
