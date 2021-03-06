﻿using System.Web;
using System.Web.Optimization;

namespace CourseProject.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-datepicker").Include(
                        "~/Scripts/jquery-ui-1.12.1.min.js",
                        "~/Scripts/Custom/datepicker.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/ratings").Include(
                      "~/Scripts/rating.js",
                      "~/Scripts/Custom/initialize-rating.js"));

            bundles.Add(new ScriptBundle("~/bundles/ratings").Include(
                      "~/Scripts/rating.js",
                      "~/Scripts/Custom/initialize-rating.js"));

            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                     "~/Scripts/jquery.signalR-2.2.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chat").Include(
                     "~/Scripts/Custom/chat.js"));

            bundles.Add(new ScriptBundle("~/bundles/search").Include(
                     "~/Scripts/jquery.unobtrusive-ajax.min.js",
                     "~/Scripts/Custom/search-submit.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-paper.min.css",
                      "~/Content/site.css",
                      "~/Content/style.css",
                      "~/Content/checkboxes.css"));
        }
    }
}
