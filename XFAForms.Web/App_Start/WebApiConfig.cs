using System.Web.Http;
using WebApiContrib.Formatting;

namespace XFAForms.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });

            //config.Formatters.Remove(config.Formatters.JsonFormatter);
            //config.Formatters.Remove(config.Formatters.XmlFormatter);

            //https://damienbod.wordpress.com/2014/01/11/using-protobuf-net-media-formatter-with-web-api-2/

            config.Formatters.Add(new ProtoBufFormatter());

        }
    }
}
