using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using SportStore.Domain.Entities;
using SportStore.DB.Abstract;

namespace SportStore.WebUI.Controllers
{
    public class CategoryController : ApiController
    {
        ICategoryRepository repo;

        public CategoryController(ICategoryRepository _repo) {
            repo = _repo;
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
