using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DAL;

namespace ClimaTempoSimples.App_Start
{
    public class AutofacRegistration
    {
        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers
            builder.RegisterControllers(typeof(WebApiApplication).Assembly);

            // Now grab your connection string and wire up your db context
            var conn = ConfigurationManager.ConnectionStrings["Connection_String"];
            builder.Register(c => new Context());

            // You can register any other dependencies here

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}