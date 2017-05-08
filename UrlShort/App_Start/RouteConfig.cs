﻿using System.Web.Mvc;
using System.Web.Routing;

namespace UrlShort
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Click",
                url: "{segment}",
                defaults: new { controller = "Url", action = "Click" }
            );

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Url", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Url", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}