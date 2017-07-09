using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.DB.Repository;
using SportStore.DB.Abstract;

namespace SportStore.WebUI.Controllers
{
    public class NavController : Controller
    {

        private IProductRepository repo;

        public NavController(IProductRepository _repo)
        {
            repo = _repo;
        }
        // GET: Nav
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            //IList<string> categories = new IList<string>() {"", "", }; (repo.Products
            //                                .Select(x=> category == category)
            //                                .Distinct()
            //                                .OrderBy(x => x)).ToList<string>();

            return PartialView("");
        }
    }
}