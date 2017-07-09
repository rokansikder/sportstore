using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.DB.Abstract;
using SportStore.DB.Repository;
using SportStore.Domain.Entities;
using System.Web.Http;

namespace SportStore.API.Controllers
{
    public class ProductController : ApiController
    {
        IProductRepository repo;

        public ProductController() {
            repo = new ProductRepository();
        }
       
        // GET: Product
       
        public IEnumerable<Product> GetProducts() {
           return repo.Products;
        }

        public Product GetProductById(int id) {
            return repo.GetById(id);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/product/bycategory/{catid}")]
        public IList<Product> GetProductByCategory(int catid) {
            IEnumerable<Product> productList = repo.Products;

            return productList.Where(p => p.CategoryID == catid).ToList();
        }
    }
}