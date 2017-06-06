using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.DB.Repository
{
    public interface IProductRepository:IDisposable
    {
        IEnumerable<Product> Products { get; }
        int AddProduct(Product product);
        void Update(Product product);
        Product Remove(int productID);
    }
}
