using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportStore.DB.Repository;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Controllers
{
    public class FirstController : ApiController
    {

        IProductRepository repo;

        public FirstController(IProductRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<Product> Get()
        {
            return repo.Products;
        }

        
        [AcceptVerbs("Get")]
        public Product ProductDetails(int id)
        {
            return repo.Products.Where(p => p.ProductID == id).SingleOrDefault();
        }

        public void Post(Product product) {

            if (ModelState.IsValid)
            {

            }
            else {
                var errors = ModelState.Where(e => e.Value.Errors.Count > 0)
                    .Select(e => new
                    {
                        Name = e.Key,
                        Message = e.Value.Errors.First().ErrorMessage
                    });
            }
        }
    }
}
