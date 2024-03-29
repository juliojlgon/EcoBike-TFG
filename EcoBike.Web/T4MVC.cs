﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly AdminClass s_Admin = new AdminClass();
    public static AdminClass Admin { get { return s_Admin; } }
    static readonly UserClass s_User = new UserClass();
    public static UserClass User { get { return s_User; } }
    public static Bicimad.Web.Controllers.AccountController Account = new Bicimad.Web.Controllers.T4MVC_AccountController();
    public static Bicimad.Web.Controllers.BaseController Base = new Bicimad.Web.Controllers.T4MVC_BaseController();
    public static Bicimad.Web.Controllers.BikeController Bike = new Bicimad.Web.Controllers.T4MVC_BikeController();
    public static Bicimad.Web.Controllers.HomeController Home = new Bicimad.Web.Controllers.T4MVC_HomeController();
    public static Bicimad.Web.Controllers.StationController Station = new Bicimad.Web.Controllers.T4MVC_StationController();
    public static T4MVC.ManageController Manage = new T4MVC.ManageController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminClass
    {
        public readonly string Name = "Admin";
        public Bicimad.Web.Areas.Admin.Controllers.AdminBaseController AdminBase = new Bicimad.Web.Areas.Admin.Controllers.T4MVC_AdminBaseController();
        public Bicimad.Web.Areas.Admin.Controllers.StationsController Stations = new Bicimad.Web.Areas.Admin.Controllers.T4MVC_StationsController();
        public T4MVC.Admin.SharedController Shared = new T4MVC.Admin.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class UserClass
    {
        public readonly string Name = "User";
        public Bicimad.Web.Areas.User.Controllers.HomeController Home = new Bicimad.Web.Areas.User.Controllers.T4MVC_HomeController();
        public Bicimad.Web.Areas.User.Controllers.UserBaseController UserBase = new Bicimad.Web.Areas.User.Controllers.T4MVC_UserBaseController();
        public T4MVC.User.SharedController Shared = new T4MVC.User.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class images {
            private const string URLPATH = "~/Scripts/images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string layers_2x_png = Url("layers-2x.png");
            public static readonly string layers_png = Url("layers.png");
            public static readonly string marker_icon_2x_png = Url("marker-icon-2x.png");
            public static readonly string marker_icon_png = Url("marker-icon.png");
            public static readonly string marker_shadow_png = Url("marker-shadow.png");
        }
    
        public static readonly string jquery_2_2_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.2.0.intellisense.min.js") ? Url("jquery-2.2.0.intellisense.min.js") : Url("jquery-2.2.0.intellisense.js");
        public static readonly string jquery_2_2_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.2.0.min.js") ? Url("jquery-2.2.0.min.js") : Url("jquery-2.2.0.js");
        public static readonly string jquery_2_2_0_min_js = Url("jquery-2.2.0.min.js");
        public static readonly string jquery_2_2_0_min_map = Url("jquery-2.2.0.min.map");
        public static readonly string jquery_min_js = Url("jquery.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string leaflet_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/leaflet-src.min.js") ? Url("leaflet-src.min.js") : Url("leaflet-src.js");
        public static readonly string leaflet_extra_markers_min_js = Url("leaflet.extra-markers.min.js");
        public static readonly string leaflet_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/leaflet.min.js") ? Url("leaflet.min.js") : Url("leaflet.js");
        public static readonly string mdb_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mdb.min.js") ? Url("mdb.min.js") : Url("mdb.js");
        public static readonly string mdb_min_js = Url("mdb.min.js");
        public static readonly string mdsidebar_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mdsidebar.min.js") ? Url("mdsidebar.min.js") : Url("mdsidebar.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class modules__optional_ {
            private const string URLPATH = "~/Scripts/modules (optional)";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string buttons_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/buttons.min.js") ? Url("buttons.min.js") : Url("buttons.js");
            public static readonly string chart_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/chart.min.js") ? Url("chart.min.js") : Url("chart.js");
            public static readonly string collapsible_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/collapsible.min.js") ? Url("collapsible.min.js") : Url("collapsible.js");
            public static readonly string dropdown_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dropdown.min.js") ? Url("dropdown.min.js") : Url("dropdown.js");
            public static readonly string forms_basic_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/forms-basic.min.js") ? Url("forms-basic.min.js") : Url("forms-basic.js");
            public static readonly string global_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/global.min.js") ? Url("global.min.js") : Url("global.js");
            public static readonly string jquery_easing_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-easing.min.js") ? Url("jquery-easing.min.js") : Url("jquery-easing.js");
            public static readonly string mdb_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mdb.min.js") ? Url("mdb.min.js") : Url("mdb.js");
            public static readonly string mdb_min_js = Url("mdb.min.js");
            public static readonly string scrolling_nav_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/scrolling-nav.min.js") ? Url("scrolling-nav.min.js") : Url("scrolling-nav.js");
            public static readonly string velocity_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/velocity.min.js") ? Url("velocity.min.js") : Url("velocity.js");
            public static readonly string video_bg_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/video-bg.min.js") ? Url("video-bg.min.js") : Url("video-bg.js");
            public static readonly string waves_effect_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/waves-effect.min.js") ? Url("waves-effect.min.js") : Url("waves-effect.js");
            public static readonly string wow_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/wow.min.js") ? Url("wow.min.js") : Url("wow.js");
        }
    
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_matchmedia_addListener_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.matchmedia.addListener.min.js") ? Url("respond.matchmedia.addListener.min.js") : Url("respond.matchmedia.addListener.js");
        public static readonly string respond_matchmedia_addListener_min_js = Url("respond.matchmedia.addListener.min.js");
        public static readonly string respond_min_js = Url("respond.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fonts {
            private const string URLPATH = "~/Content/fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
            public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
            public static readonly string Material_Design_Iconic_Font_eot = Url("Material-Design-Iconic-Font.eot");
            public static readonly string Material_Design_Iconic_Font_svg = Url("Material-Design-Iconic-Font.svg");
            public static readonly string Material_Design_Iconic_Font_ttf = Url("Material-Design-Iconic-Font.ttf");
            public static readonly string Material_Design_Iconic_Font_woff = Url("Material-Design-Iconic-Font.woff");
            public static readonly string Material_Design_Iconic_Font_woff2 = Url("Material-Design-Iconic-Font.woff2");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class roboto {
                private const string URLPATH = "~/Content/fonts/roboto";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Roboto_Bold_woff = Url("Roboto-Bold.woff");
                public static readonly string Roboto_Bold_woff2 = Url("Roboto-Bold.woff2");
                public static readonly string Roboto_Light_woff = Url("Roboto-Light.woff");
                public static readonly string Roboto_Light_woff2 = Url("Roboto-Light.woff2");
                public static readonly string Roboto_Medium_woff = Url("Roboto-Medium.woff");
                public static readonly string Roboto_Medium_woff2 = Url("Roboto-Medium.woff2");
                public static readonly string Roboto_Regular_woff = Url("Roboto-Regular.woff");
                public static readonly string Roboto_Regular_woff2 = Url("Roboto-Regular.woff2");
                public static readonly string Roboto_Thin_woff = Url("Roboto-Thin.woff");
                public static readonly string Roboto_Thin_woff2 = Url("Roboto-Thin.woff2");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class img {
            private const string URLPATH = "~/Content/img";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string markers_default_png = Url("markers_default.png");
            public static readonly string markers_default_2x_png = Url("markers_default@2x.png");
            public static readonly string markers_shadow_png = Url("markers_shadow.png");
            public static readonly string markers_shadow_2x_png = Url("markers_shadow@2x.png");
        }
    
        public static readonly string leaflet_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/leaflet.min.css") ? Url("leaflet.min.css") : Url("leaflet.css");
        public static readonly string leaflet_extra_markers_min_css = Url("leaflet.extra-markers.min.css");
        public static readonly string mdb_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mdb.min.css") ? Url("mdb.min.css") : Url("mdb.css");
        public static readonly string mdb_min_css = Url("mdb.min.css");
        public static readonly string mdsidebarcss_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mdsidebarcss.min.css") ? Url("mdsidebarcss.min.css") : Url("mdsidebarcss.css");
        public static readonly string PagedList_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PagedList.min.css") ? Url("PagedList.min.css") : Url("PagedList.css");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class images 
            {
                public static class Assets
                {
                }
            }
            public static partial class modules__optional_ 
            {
                public static class Assets
                {
                    public const string buttons_js = "~/Scripts/modules (optional)/buttons.js"; 
                    public const string chart_js = "~/Scripts/modules (optional)/chart.js"; 
                    public const string collapsible_js = "~/Scripts/modules (optional)/collapsible.js"; 
                    public const string dropdown_js = "~/Scripts/modules (optional)/dropdown.js"; 
                    public const string forms_basic_js = "~/Scripts/modules (optional)/forms-basic.js"; 
                    public const string global_js = "~/Scripts/modules (optional)/global.js"; 
                    public const string jquery_easing_js = "~/Scripts/modules (optional)/jquery-easing.js"; 
                    public const string mdb_js = "~/Scripts/modules (optional)/mdb.js"; 
                    public const string mdb_min_js = "~/Scripts/modules (optional)/mdb.min.js"; 
                    public const string scrolling_nav_js = "~/Scripts/modules (optional)/scrolling-nav.js"; 
                    public const string velocity_js = "~/Scripts/modules (optional)/velocity.js"; 
                    public const string video_bg_js = "~/Scripts/modules (optional)/video-bg.js"; 
                    public const string waves_effect_js = "~/Scripts/modules (optional)/waves-effect.js"; 
                    public const string wow_js = "~/Scripts/modules (optional)/wow.js"; 
                }
            }
            public static class Assets
            {
                public const string _references_js = "~/Scripts/_references.js"; 
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string jquery_2_2_0_intellisense_js = "~/Scripts/jquery-2.2.0.intellisense.js"; 
                public const string jquery_2_2_0_js = "~/Scripts/jquery-2.2.0.js"; 
                public const string jquery_2_2_0_min_js = "~/Scripts/jquery-2.2.0.min.js"; 
                public const string jquery_min_js = "~/Scripts/jquery.min.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_min_js = "~/Scripts/jquery.validate.min.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
                public const string jquery_validate_unobtrusive_min_js = "~/Scripts/jquery.validate.unobtrusive.min.js"; 
                public const string leaflet_src_js = "~/Scripts/leaflet-src.js"; 
                public const string leaflet_extra_markers_min_js = "~/Scripts/leaflet.extra-markers.min.js"; 
                public const string leaflet_js = "~/Scripts/leaflet.js"; 
                public const string mdb_js = "~/Scripts/mdb.js"; 
                public const string mdb_min_js = "~/Scripts/mdb.min.js"; 
                public const string mdsidebar_js = "~/Scripts/mdsidebar.js"; 
                public const string modernizr_2_8_3_js = "~/Scripts/modernizr-2.8.3.js"; 
                public const string respond_js = "~/Scripts/respond.js"; 
                public const string respond_matchmedia_addListener_js = "~/Scripts/respond.matchmedia.addListener.js"; 
                public const string respond_matchmedia_addListener_min_js = "~/Scripts/respond.matchmedia.addListener.min.js"; 
                public const string respond_min_js = "~/Scripts/respond.min.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class fonts 
            {
                public static partial class roboto 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class img 
            {
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string leaflet_css = "~/Content/leaflet.css";
                public const string leaflet_extra_markers_min_css = "~/Content/leaflet.extra-markers.min.css";
                public const string mdb_css = "~/Content/mdb.css";
                public const string mdb_min_css = "~/Content/mdb.min.css";
                public const string mdsidebarcss_css = "~/Content/mdsidebarcss.css";
                public const string PagedList_css = "~/Content/PagedList.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


