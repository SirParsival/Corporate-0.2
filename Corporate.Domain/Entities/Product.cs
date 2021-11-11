using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corporate.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "CategoryId")]
        //[Key]
        //[ForeignKey("Category")]
        public int? CategoryID { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public int CountInStock { get; set; }
        public string Description { get; set; }

        public char Images { get; set; }

        public virtual ICollection<Category> /*Category*/ Categories { get; set; }

        //public virtual Category Category { get; set; }  //определ. как эдиная сущность

        //public byte[] ImageData { get; set; }
        //public string ImageMimeType { get; set; }
    }
}
