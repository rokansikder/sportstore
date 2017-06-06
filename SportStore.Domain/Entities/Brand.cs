using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SportStore.Domain.Entities
{
    public class Brand
    {

        [Required]
        [Key]
        public int BrandID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       
        public int CategoryID { get; set; }
        public string Logo { get; set; }
        public string ImageMIMETYPE { get; set; }

        public virtual Category Category { get; set; }
       
    }
}
