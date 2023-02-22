using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace baberShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            //home page
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeBaberShop", action = "Index", id = UrlParameter.Optional }
            );

            //login
            routes.MapRoute(
                name: "Auth",
                url: "auth/{action}",
                new { controller = "Auth", action = "Login", id = UrlParameter.Optional }
            );
            
        }
    }
}
