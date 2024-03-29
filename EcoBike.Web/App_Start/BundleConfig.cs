﻿using System.Web.Optimization;

namespace Bicimad.Web
{
    public class BundleConfig
    {

        public const string JQuery = "~/bundles/jquery";
        public const string JQueryVal = "~/bundles/jqueryval";

        public const string MdbExtra = "~/bundles/mdbextra";

        public const string Leaflet = "~/bundles/leaflet";
        public const string LeafletAMarker = "~/bundles/leafletmarker";


        public const string BootstrapJs = "~/bundles/bootstrap";

        public const string ModernizerJs = "~/bundles/modernizr";

        //public const string NavbarCss = "~/Content/css/mdsidebarcss";
        public const string NavbarJs = "~/bundles/mdsidebar";

        public const string Mdbootstrap = "~/Content/mdbootstrap";

        public const string Contents = "~/Content/css";
    
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(JQuery).Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle(Leaflet).Include("~/Scripts/leaflet.js"));

            //bundles.Add(new ScriptBundle(NavbarCss).Include("~/Content/mdsidebarcss.css"));
            bundles.Add(new ScriptBundle(NavbarJs).Include("~/Scripts/mdsidebar.js"));


            bundles.Add(new ScriptBundle(LeafletAMarker).Include("~/Scripts/leaflet.extra-markers.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(ModernizerJs).Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                       "~/Scripts/mdb.js"));

            bundles.Add(new StyleBundle(Contents).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/leaflet.css",
                      "~/Content/leaflet.extra-markers.min.css"));

            bundles.Add(new StyleBundle(Mdbootstrap).Include(
                      "~/Content/mdb.css",
                      "~/Content/mdsidebarcss.css"));

        }
    }
}
