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
            container.RegisterType<IUnitOfWork2<>, UnitOfWork2>();
            container.RegisterType<IRepository<Test>, Repository<Test>>();
            container.RegisterType<IRepository<Test>, Repository<Test>>();

            container.RegisterType<IDataServices, DataServices>();
            container.RegisterType<ITestServices, TestServices>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}