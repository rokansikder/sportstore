using SportStore.DB.Abstract;
using SportStore.DB.Repository;
using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportStore.API.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        ICategoryRepository repo;

        public CategoryController()
        {
            repo = new CategoryRepository();
        }
        public Category Get(int id)
        {
            return repo.Get(id);
        }

        public IList<Category> GetAll()
        {
            return repo.GetAll();
        }
    }
}
