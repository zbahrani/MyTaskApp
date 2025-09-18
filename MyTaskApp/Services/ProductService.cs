using MyTaskApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyTaskApp.Services
{
    public class ProductService : ProductServiceBase
    {
        public ProductService(List<Product> products) : base(products)
        {
        }
        //فیلتر کردن محصولات بر اساس دسته‌بندی مشخص با LINQ (Where)
        public override List<Product> GetByCategory(Categories category)
        {
            return _products
                .Where(p => p.Category == category)
                .ToList();
        }
        //پیدا کردن محصول با بالاترین قیمت با LINQ (OrderByDescending + FirstOrDefault)
        public override Product GetProductWithMaxPrice()
        {
            return _products
                .OrderByDescending(p => p.Price)
                .FirstOrDefault();
        }
    }
}
