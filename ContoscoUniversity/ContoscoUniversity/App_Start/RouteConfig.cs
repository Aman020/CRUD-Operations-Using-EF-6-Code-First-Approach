using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ContoscoUniversity
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );

            routes.MapRoute(

                name: "WithSearchString",
                url: "{controller}/{action}/{searchString}",
                defaults: new { Controller = "Student", action = "Index", searchString = UrlParameter.Optional }


                );

            routes.MapRoute(
                name: "Myroute",
                url: "{controller}/{action}/{id}",
                defaults: new {Controller="Student", action = "Index", id = UrlParameter.Optional}

                
                
                );
        }
    }
}
