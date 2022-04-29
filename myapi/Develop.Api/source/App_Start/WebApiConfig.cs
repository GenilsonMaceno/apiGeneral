using source.App_Config;
using source.App_Start;
using source.Interfarce.Services;
using source.Models;
using source.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Hosting;
using System.Web.Http.Metadata;
using System.Web.Http.Metadata.Providers;
using System.Web.Http.ModelBinding;
using System.Web.Http.Tracing;
using System.Web.Http.WebHost;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;

namespace source
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}"
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            container.RegisterType<IGoogleServices, GoogleServices>(new HierarchicalLifetimeManager());


            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
