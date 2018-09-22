using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCPORX
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/Decimal").Include(
                        "~/scripts/Decimal.js"));

            //usando bundles para las hojas de estilo
            bundles.Add(new StyleBundle("~/bundles/css")
            .Include(
            "~/Content/vendors/iconfonts/mdi/css/materialdesignicons.min.css",
            "~/Content/vendors/css/vendor.bundle.base.css",
            "~/Content/vendors/css/vendor.bundle.addons.css",
            "~/Content/css/style.css"));

            //usando bundles para los js
            bundles.Add(new ScriptBundle("~/bundles/js")
            .Include(
            "~/Content/vendors/js/vendor.bundle.base.js",
            "~/Content/vendors/js/vendor.bundle.addons.js",
            "~/Content/js/off-canvas.js",
            "~/Content/js/misc.js",
            "~/Content/js/dashboard.js"));
        }
    }
}