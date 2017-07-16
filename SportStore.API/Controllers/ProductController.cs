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
        [System.Web.Http.Route("api/product/bycategory/{id}")]
        public IList<Product> GetProductByCategory(int id) {
            IEnumerable<Product> productList = repo.Products;

            if (id < 1)
                return productList.ToList();

            return productList.Where(p => p.CategoryID == id).ToList();
        }
    }
}