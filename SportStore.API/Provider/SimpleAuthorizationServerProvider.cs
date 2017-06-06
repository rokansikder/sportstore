using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.Provider;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

namespace SportStore.API.Provider
{
    public class SimpleAuthorizationServerProvider:OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Acess-Control-Allow-Origin", new[] { "*" });

            using (AuthRepository repo = new AuthRepository()) {
                IdentityUser user =await repo.FindUser(context.UserName, context.Password);

                if (user == null) {
                    context.SetError("invalid_grant", "the username or password incorrect");
                    return;
                }

            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("Role", "user"));

            context.Validated(identity);
            
        }
    }
}