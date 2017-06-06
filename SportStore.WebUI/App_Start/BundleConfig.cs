using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SportStore.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/Content/CSS").Include("~/Content/*.css"));

            bundles.Add(new ScriptBundle("~/Scripts/sobscripts").Include("~/Scripts/bootstrap.js"));
        }
    }
}