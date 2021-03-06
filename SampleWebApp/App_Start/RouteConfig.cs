﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SampleWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Authorize",
                url: "Authorize",
                defaults: new { controller = "Authorize", action = "Index" }
            );

            routes.MapRoute(
                name: "Students",
                url: "Students/{action}/{studentId}",
                defaults: new { controller = "Students" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}