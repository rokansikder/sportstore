﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using SportStore.API.Models;
using Microsoft.AspNet.Identity;

namespace SportStore.API.Controllers
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        private AuthRepository repo;

        public AccountController()
        {
            repo = new API.AuthRepository();
        }

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            IdentityResult result = await repo.Register(model);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                repo.Dispose();

            base.Dispose(disposing);
        }

    }
}
