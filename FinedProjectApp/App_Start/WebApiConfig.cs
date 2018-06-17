﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FinedProjectApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


			config.Routes.MapHttpRoute(
				name: "DirecrRegisterApi",
				routeTemplate: "api/{controller}/{username}/{password}/{e_mail}",
				defaults: new { controller = "ProjectDirectors" }
			);
			config.Routes.MapHttpRoute(
				name: "DirecSignInApi",
				routeTemplate: "api/{controller}/{username}/{password}",
				defaults: new { controller = "ProjectDirectors" }
			);
			config.Routes.MapHttpRoute(
				name: "StudentSignInApi",
				routeTemplate: "api/{controller}/{username}/{password}",
				defaults: new { controller = "students" }
			);
			config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
