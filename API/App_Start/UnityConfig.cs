using API.Services;
using System.Configuration;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            if(ConfigurationManager.AppSettings["UseMockData"] == "true")
            {
                //TODO: consider lifecycle, e.g. Scoped, Transient, Singleton
                container.RegisterType<IGameRepository, GameRepositoryMock>();
            }
            else
            {
                container.RegisterType<IGameRepository, GameRepository>();
            }

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}