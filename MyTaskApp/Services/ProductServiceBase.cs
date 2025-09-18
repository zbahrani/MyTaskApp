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
        //باید توسط کلاس فرزند پیاده‌سازی شود
        public abstract List<Product> GetByCategory(Categories category);
        public abstract Product GetProductWithMaxPrice();

        // محاسبه میانگین قیمت همه محصولات با استفاده از LINQ (Average)
        public virtual decimal GetAveragePrice()
        {
            return _products.Average(p => p.Price);
        }

        // گروه‌بندی محصولات بر اساس دسته‌بندی با استفاده از LINQ (GroupBy + ToDictionary)
        public virtual Dictionary<Categories, List<Product>> GetProductsGroupedByCategory()
        {
            return _products.GroupBy(p => p.Category)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        // محاسبه مجموع قیمت همه محصولات با استفاده از LINQ (Sum)
        public virtual decimal GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }
    }
}
