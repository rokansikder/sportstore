using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entities;
using SportStore.DB.Abstract;

namespace SportStore.DB.Repository
{
    public class ProductRepository:IProductRepository
    {
        SportStoreContext db = new SportStoreContext(); 
        public IEnumerable<Product> Products {
            get { return db.Products; }
            
        }

        public Product GetById(int id) {
            return db.Products.Where(c => c.ProductID == id).SingleOrDefault();
        }
   
        public int AddProduct(Product product)
        {
           
            db.Products.Add(product);
            return db.SaveChanges();
        }

        public Product Remove(int productID)
        {
            Product product = db.Products.Where(p => p.ProductID == productID).SingleOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();

            return product;
        }

        public void Update(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed) {
                if (disposing) {
                    if (db != null)
                        db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
