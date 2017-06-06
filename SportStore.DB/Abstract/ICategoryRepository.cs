using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entities;

namespace SportStore.DB.Abstract
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        IList<Category> GetAll();

        void Add(Category category);
        void Update(int id);
        void Delete(int id);
    }
}
