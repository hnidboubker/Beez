﻿using System.Web.Http;

namespace Beez.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           
            // Routes Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
