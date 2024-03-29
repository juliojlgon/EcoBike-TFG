// <auto-generated />
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
namespace Bicimad.Web.Areas.Admin.Controllers
{
    public partial class StationsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected StationsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SetBasePrice()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetBasePrice);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SetDiscounts()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetDiscounts);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public StationsController Actions { get { return MVC.Admin.Stations; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Stations";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Stations";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string SetBasePrice = "SetBasePrice";
            public readonly string SetDiscounts = "SetDiscounts";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string SetBasePrice = "SetBasePrice";
            public const string SetDiscounts = "SetDiscounts";
        }


        static readonly ActionParamsClass_SetBasePrice s_params_SetBasePrice = new ActionParamsClass_SetBasePrice();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SetBasePrice SetBasePriceParams { get { return s_params_SetBasePrice; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SetBasePrice
        {
            public readonly string basePrice = "basePrice";
        }
        static readonly ActionParamsClass_SetDiscounts s_params_SetDiscounts = new ActionParamsClass_SetDiscounts();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SetDiscounts SetDiscountsParams { get { return s_params_SetDiscounts; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SetDiscounts
        {
            public readonly string stationIds = "stationIds";
            public readonly string discountType = "discountType";
            public readonly string discConst = "discConst";
            public readonly string discPorc = "discPorc";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
            }
            public readonly string Index = "~/Areas/Admin/Views/Stations/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_StationsController : Bicimad.Web.Areas.Admin.Controllers.StationsController
    {
        public T4MVC_StationsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SetBasePriceOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, double? basePrice);

        [NonAction]
        public override System.Web.Mvc.ActionResult SetBasePrice(double? basePrice)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetBasePrice);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "basePrice", basePrice);
            SetBasePriceOverride(callInfo, basePrice);
            return callInfo;
        }

        [NonAction]
        partial void SetDiscountsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Collections.Generic.List<string> stationIds, Bicimad.Enums.DiscountType discountType, string discConst, string discPorc);

        [NonAction]
        public override System.Web.Mvc.ActionResult SetDiscounts(System.Collections.Generic.List<string> stationIds, Bicimad.Enums.DiscountType discountType, string discConst, string discPorc)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetDiscounts);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "stationIds", stationIds);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "discountType", discountType);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "discConst", discConst);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "discPorc", discPorc);
            SetDiscountsOverride(callInfo, stationIds, discountType, discConst, discPorc);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
