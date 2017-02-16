﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Interview_DAL;
using Microsoft.Ajax.Utilities;
using Microsoft.Practices.Unity;

namespace Interview_WebApi
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


            var container = new UnityContainer();
            container.RegisterType<IPatientRepository, PatientRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

        }
    }
}
