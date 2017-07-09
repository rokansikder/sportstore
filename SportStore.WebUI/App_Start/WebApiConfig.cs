using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http;

namespace SportStore.WebUI
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration) {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
            new { id = RouteParameter.Optional });

            configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            
        }
    }
}