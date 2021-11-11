using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Corporate.Domain.Entities;

namespace Corporate.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentCategory { get; set; }
    }
}