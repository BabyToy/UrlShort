using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using System;
using BusinessLayer;

namespace UrlShort
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUrlHandler, UrlHandler>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        //public static void RegisterComponents()
        //{
        //    var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        //}

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
    }
}