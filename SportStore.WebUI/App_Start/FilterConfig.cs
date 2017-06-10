using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.WebUI.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilter(GlobalFilterCollection filter) {
            filter.Add(new HandleErrorAttribute());
            filter.Add(new AuthorizeAttribute());
        }
    }
}