using Microsoft.AspNet.OData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RESTier608
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //x GlobalConfiguration.Configure(WebApiConfig.Register);
            using (var httpConfiguration = GlobalConfiguration.Configuration)
            {
                httpConfiguration.EnableDependencyInjection();

                WebApiConfig.Register(httpConfiguration);
                httpConfiguration.EnsureInitialized();
            }
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
