using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Domain.Entities
{
    public class Product
    {
       
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Range(1, 200)]
        public decimal Price { get; set; }
       
        public byte[] ImageData { get; set; }

        public string ImageMIMEType { get; set; }

      
        public int CategoryID { get; set; }

       
        public int BrandID { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }


    }
}
