using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace FindMyLibrary.Web
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
     

      routes.MapRoute(
        name: "city",
        url: "{stateAbbreviation}/cities",
        defaults: new { controller = "City", action = "GetCitiesByState", stateAbbreviation = "AL" });

      routes.MapRoute(
        name: "LibraryInACity",
        url: "{stateAbbreviation}/{cityName}/libraries",
        defaults: new { controller = "Library", action = "GetLibrariesByCity", stateAbbreviation = "AL", cityName = "Birmingham"}
        );

      routes.MapRoute(
        name: "LibraryDetails",
        url: "{stateAbbreviation}/{cityName}/{name}/details",
        defaults: new { controller = "Library", action = "Details", stateAbbreviation = "AL", cityName = "Birmingham", name="Birmingham_Public_Library" }
        );
    
      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );

      

    }
  }
}