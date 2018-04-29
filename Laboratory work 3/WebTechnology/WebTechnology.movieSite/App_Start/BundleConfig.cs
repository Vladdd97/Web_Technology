using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebTechnology.movieSite
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/tether.min.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/myScript").Include(
                "~/Scripts/scripts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/font-awesome.min.css",
                "~/Content/bootstrap.css",
                "~/Content/site.css"));
        }
    }
}