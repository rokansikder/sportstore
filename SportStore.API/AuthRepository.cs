using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using System.Threading.Tasks;
using SportStore.API.Models;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SportStore.API
{
    public class AuthRepository : IDisposable
    {
        private AuthContext db;
        private UserManager<IdentityUser> usermanager;

        public AuthRepository()
        {
            db = new API.AuthContext();
            usermanager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(db));
        }

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IdentityResult> Register(UserModel model) {
            IdentityUser user= new IdentityUser
            {
                UserName = model.UserName
            };

            var result = await usermanager.CreateAsync(user, model.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await usermanager.FindAsync(userName, password);
            return user;
        }
        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }
}