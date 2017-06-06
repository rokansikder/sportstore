using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain.Entities
{
    public class CartLine
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
