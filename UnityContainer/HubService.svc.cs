using Common.DataContract;
using Interface;
//using Microsoft.Practices.Unity;
using System;
using System.Configuration;
using Unity;


namespace UnityContainer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HubService : IHubService
    {
        
        private readonly IHubBusiness hubBusiness;

        public HubService(IHubBusiness hubBusiness)
        {
            this.hubBusiness = hubBusiness;
        }

        public string RetrieveService(RetrieveRequest request)
        {
            request.TimeStamp = DateTime.Now;
            System.Web.Hosting.HostingEnvironment.QueueBackgroundWorkItem(x => hubBusiness.Process(request));
            return $"{request.FamilyName},{request.DOBOfYear}";
        }

    }
}
