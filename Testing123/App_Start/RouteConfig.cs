using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Testing123
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Register",
              url: "Register/",
              defaults: new { controller = "Register", action = "Index" }
          );
            routes.MapRoute(
             name: "Login",
             url: "Login/",
             defaults: new { controller = "LogIn", action = "Index" }
         );
            routes.MapRoute(
          name: "Message",
          url: "Message/",
          defaults: new { controller = "Message", action = "Index" }
      );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );
        
        }
    }
}
