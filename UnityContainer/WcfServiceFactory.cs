using Microsoft.Practices.Unity.Configuration;
using Unity;
using Unity.Wcf;

namespace UnityContainer
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // register all your components with the container here
            // container
            //    .RegisterType<IService1, Service1>()
            //    .RegisterType<DataContext>(new HierarchicalLifetimeManager());

            //container
            //    .RegisterType<IHubService, HubService>(new ContainerControlledLifetimeManager())
            //    .RegisterType<IHubBusiness, HubBusiness>(new ContainerControlledLifetimeManager())
            //    .RegisterType<IHubRepository, HubRepository>(new ContainerControlledLifetimeManager())
            //    .RegisterType<IAgencyRepository, AgencyRepository>(new ContainerControlledLifetimeManager());

            container.LoadConfiguration();
        }
    }    
}