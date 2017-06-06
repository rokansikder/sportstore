using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Domain.Entities
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ImageMIMEType { get; set; }

        //public virtual IList<Brand> Brands { get; set; }
        //public virtual IList<Product> Products { get; set; }

    }
}
