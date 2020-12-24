using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace APIStreamingWithSignalRTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            Global.LogMessage = RequestLog.PostToClient;
           
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));

            var matches = config.Formatters
                           .Where(f => f.SupportedMediaTypes
                                        .Where(m => m.MediaType.ToString() == "application/xml" ||
                                                    m.MediaType.ToString() == "text/xml")
                                        .Count() > 0)
                           .ToList();
            foreach (var match in matches)
                config.Formatters.Remove(match);
        }
    }

    public class Global
    {
        public delegate void DelLogMessage(string data);
        public static DelLogMessage LogMessage;
    }
}
