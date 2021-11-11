using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate.Domain.Entities
{
    public class Category
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Key]
        //[ForeignKey("Product")]
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }

        public virtual /*ICollection<Product>*/ Product Product { get; set; }

    }
}
