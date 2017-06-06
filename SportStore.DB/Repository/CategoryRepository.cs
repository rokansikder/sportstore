using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.DB.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.DB.Repository
{
    public class CategoryRepository:ICategoryRepository, IDisposable
    {
        private SportStoreContext db = new SportStoreContext();

        public Category Get(int id)
        {
            return db.Categories.Where(c => c.CategoryID == id).SingleOrDefault();
        }

        public IList<Category> GetAll()
        {
            return db.Categories.ToList<Category>();
        }

        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(int id)
        {
            db.Entry(new Category { CategoryID = id}).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Entry(new Category { CategoryID = id }).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }
}
