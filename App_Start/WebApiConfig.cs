using System.Web.Http;

namespace BookStore
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable attribute routing
            config.MapHttpAttributeRoutes();

            // Default route (optional)
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}