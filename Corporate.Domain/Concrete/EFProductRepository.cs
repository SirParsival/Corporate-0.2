using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corporate.Domain.Entities;
using Corporate.Domain.Abstract;

namespace Corporate.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get {
                //products = context.Products.ToList;
                //foreach (Product p in products)
                //{
                //    context.Entry(p).Collection(x => x.Categories).Load();
                //    //foreach (Category c in p.Categories)
                //    //{
                //    //    Category.Add(c.Title);
                //    //}
                //}
                return context.Products; 
                }
        }
    }
}
