using System.Web.Http;
using UnitOfWorkPatternDemo.Entities;
using UnitOfWorkPatternDemo.Repository;
using UnitOfWorkPatternDemo.Services;
using Unity;
using Unity.WebApi;

namespace UnitOfWorkPatternDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IRepository<Test>, Repository<Test>>();

            container.RegisterType<IDataServices, DataServices>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}