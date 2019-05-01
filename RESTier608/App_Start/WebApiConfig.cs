using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.Restier.AspNet.Batch;
using Microsoft.Restier.EntityFramework;
using RESTier608.Models;

namespace RESTier608
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

            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            config.MapRestierRoute<EntityFrameworkApi<TrippinModel>>("odata", "odata", new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}
