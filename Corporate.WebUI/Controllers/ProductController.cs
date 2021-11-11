using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Corporate.Domain.Abstract;
using Corporate.Domain.Concrete;
using Corporate.Domain.Entities;
using Corporate.WebUI.Models;

namespace Corporate.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductRepository repository;
        public int pageSize = 5;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(/*int category,*/ int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                    //.Where(p => category == null || p.CategoryId == category)
                    .OrderBy(product => product.ProductId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Products.Count()
                },
                //CurrentCategory = category
            };
            return View(model);
        }

        void AddOrUpdateProduct(EFDbContext context, int CategoryID)
        {
            var crs = context.Categories.SingleOrDefault(c => c.CategoryID == CategoryID);
            //var inst = crs.Instructors.SingleOrDefault(i => i.LastName == instructorName);
            //if (inst == null)
            //    crs.Instructors.Add(context.Instructors.Single(i => i.LastName == instructorName));
        }
        static void Main(string [] args)
        {
            using (var context = new EFDbContext())
            {
                var category = new Category { };
                var products = new List<Product> { };
                context.Products.AddRange(products);
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}