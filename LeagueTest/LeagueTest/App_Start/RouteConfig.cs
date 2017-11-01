using System.Web.Mvc;
using System.Web.Routing;

namespace LeagueTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default1", "{controller}",
                new {controller = "Test", action = "Index", id = UrlParameter.Optional});
            routes.MapRoute("Default2", "{controller}/{id}",
                new { controller = "Test", action = "Age", id = UrlParameter.Optional }
            );
        }
    }
}
