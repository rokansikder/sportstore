using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using SportStore.DB.Repository;
using PagedList;
using SportStore.Domain.Entities;
using System.Data.Entity.Infrastructure;


namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository _repo)
        {
            repository = _repo;
        }
        // GET: Product
        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMIMEType);
            }
            else
            {
                return null;
            }
        }

        public ActionResult List(string searchString, string category, int? page)
        {
            searchString = searchString ?? "";
            category = category ?? "";
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentFilter = searchString;
            ViewBag.Category = category;
            var products = repository.Products.Where(c=> c.Name.ToLower().Contains(searchString.ToLower())).OrderBy(o=> o.Name);

            return View(products.ToPagedList(pageNumber, pageSize));
        }
    }
}