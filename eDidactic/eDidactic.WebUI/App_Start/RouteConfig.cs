using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using eDidactic.Domain.Entities;

namespace eDidactic.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Courses",
                url: "kurs/{ShortNameCours}/",
                defaults: new {Controller = "Course", action = "Details"}
            );

            routes.MapRoute(
                name: "StaticContent",
                url: "{viewname}",
                defaults: new {controller = "Home", action = "StaticContent"}
            );

            routes.MapRoute(
                name: "CourseList",
                url: "{coursename}",
                defaults: new {controller = "Course", action = "List"},
                constraints: new {coursename = @"[\w ]"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Course", action = "List", id = UrlParameter.Optional }
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
