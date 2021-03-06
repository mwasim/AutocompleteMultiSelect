using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using AutCompleteMultiSelect.Entities;
using Unity.WebApi;

namespace AutCompleteMultiSelect
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICountryRepository, CountryRepository>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}