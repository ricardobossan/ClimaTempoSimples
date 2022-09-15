﻿using System.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DAL;
using DAL.Repository;
using Dominio.Repository;

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
            builder.RegisterGeneric(typeof(EstadoRepository)).As(typeof(IEstadoRepository));
            builder.RegisterGeneric(typeof(CidadeRepository)).As(typeof(ICidadeRepository));
            builder.RegisterGeneric(typeof(PrevisaoClimaRepository)).As(typeof(IPrevisaoClimaRepository));

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}