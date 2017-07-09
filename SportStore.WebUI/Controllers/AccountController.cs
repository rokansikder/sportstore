using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.WebUI.Models;
using SportStore.WebUI.Abstract;

namespace SportStore.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthProvider authProvider;


        
        public AccountController(IAuthProvider provider)
        {
            authProvider = provider;
        }

        
        // GET: Account
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnURL) {

            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password))
                {
                    return Redirect(returnURL ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password!");
                    return View();
                }
            }
            else
                return View();
        }
    }
}