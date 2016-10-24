using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCdata
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //       name: "Products",
            //       url: "Products/{category}/{id}",
            //       defaults: new
            //       {
            //           controller = "Products",
            //           action = "Index",
            //           category=UrlParameter.Optional,
            //           id = UrlParameter.Optional
            //       });


            //Route for Home
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //Router Prac
            routes.MapRoute(
                        name: "prac",
                        url: "prac/{action}/{a}",
                        defaults: new { controller = "Prac", action = "Index", a = UrlParameter.Optional }
                    );

        }
    }
}
