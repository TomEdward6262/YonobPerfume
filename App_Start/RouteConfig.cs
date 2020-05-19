using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YonobPerfume
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Category",
                url: "san-pham/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional }
                , namespaces: new[] { "YonobPerfume.Controllers" }
            ); ;

            routes.MapRoute(
                name: "Detail",
                url: "chi-tiet/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional }
                , namespaces: new[] { "YonobPerfume.Controllers" }
            ); ;

            routes.MapRoute(
                name: "Content",
                url: "bai-viet/{metatitle}-{id}",
                defaults: new { controller = "Content", action = "Content_detail", id = UrlParameter.Optional }
                , namespaces: new[] { "YonobPerfume.Controllers" }
            ); ;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , namespaces: new[] { "YonobPerfume.Controllers" }
            ); ;
        }
    }
}
