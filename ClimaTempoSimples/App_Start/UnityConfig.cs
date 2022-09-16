using System.Web.Mvc;
using Application.Services;
using DAL.Repository;
using Dominio.Repository;
using Dominio.Services;
using Unity;
using Unity.Mvc5;

namespace ClimaTempoSimples
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEstadoService, EstadoService>();
            container.RegisterType<ICidadeService, CidadeService>();
            container.RegisterType<IPrevisaoClimaService, PrevisaoClimaService>();

            container.RegisterType<IEstadoRepository, EstadoRepository>();
            container.RegisterType<ICidadeRepository, CidadeRepository>();
            container.RegisterType<IPrevisaoClimaRepository, PrevisaoClimaRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}