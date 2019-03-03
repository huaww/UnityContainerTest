using Common.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnityContainer.UnitTest
{
    [TestClass]
    public class HubServiceUnitTest
    {
        [TestMethod]
        public void Threading_test()
        {
            //1.thread is not safe
            //<unity xmlns="http://schemas.microsoft.com/practices/2010/unity">
            //  <container>
            //    <register type="UnityContainer.IHubService,UnityContainer" mapTo="UnityContainer.HubService,UnityContainer">
            //      <lifetime type="ContainerControlledLifetimeManager"/>
            //    </register>
            //    <register type="Interface.IHubBusiness,Interface" mapTo="BLL.HubBusiness,BLL" >
            //      <!--<lifetime type="ContainerControlledLifetimeManager"/>-->
            //    </register>
            //    <register type="Interface.IHubRepository,Interface" mapTo="Repository.HubRepository,Repository" />
            //    <register type="Interface.IAgencyRepository,Interface" mapTo="Repository.AgencyRepository,Repository" />
            //  </container>
            //</unity>

            //2.thread safe
            //<unity xmlns="http://schemas.microsoft.com/practices/2010/unity">
            //  <container>
            //    <register type="UnityContainer.IHubService,UnityContainer" mapTo="UnityContainer.HubService,UnityContainer">
            //      <lifetime type="ContainerControlledLifetimeManager"/>
            //    </register>
            //    <register type="Interface.IHubBusiness,Interface" mapTo="BLL.HubBusiness,BLL" >
            //      <!--<lifetime type="ContainerControlledLifetimeManager"/>-->
            //    </register>
            //    <register type="Interface.IHubRepository,Interface" mapTo="Repository.HubRepository,Repository" />
            //    <register type="Interface.IAgencyRepository,Interface" mapTo="Repository.AgencyRepository,Repository" />
            //  </container>
            //</unity>

            RetrieveRequest request_1 = new RetrieveRequest()
            {
                AgencyCode = "AAA",
                DOBOfYear = 1990,
                FamilyName = "Hello",
                SleepSeconds = 10
            };

            RetrieveRequest request_2 = new RetrieveRequest()
            {
                AgencyCode = "BBB",
                DOBOfYear = 1990,
                FamilyName = "Hello",
                SleepSeconds = 1
            };

            List<RetrieveRequest> retrieveRequestList = new List<RetrieveRequest>();
            retrieveRequestList.Add(request_1);
            retrieveRequestList.Add(request_2);

            foreach (var item in retrieveRequestList)
            {
                using (UnityContainer.HubServiceClient client = new UnityContainer.HubServiceClient())
                {
                    client.RetrieveServiceAsync(item);
                }
            }

            Assert.IsTrue(true);
        }
    }
}
