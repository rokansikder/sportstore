using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.DB.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.DB.Repository
{
    public class BrandRepository:IBrandRepository
    {
       
       
        public IList<Brand> GetAll()
        {
            using (SportStoreContext db = new DB.SportStoreContext())
            {
                return db.Brands.ToList();
            }
        }
    }
}
