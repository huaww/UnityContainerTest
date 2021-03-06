﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnityContainer.UnitTest.UnityContainer
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "UnityContainer.IHubService")]
    public interface IHubService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/RetrieveService", ReplyAction = "http://tempuri.org/IHubService/RetrieveServiceResponse")]
        string RetrieveService(Common.DataContract.RetrieveRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/RetrieveService", ReplyAction = "http://tempuri.org/IHubService/RetrieveServiceResponse")]
        System.Threading.Tasks.Task<string> RetrieveServiceAsync(Common.DataContract.RetrieveRequest request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHubServiceChannel : UnityContainer.IHubService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HubServiceClient : System.ServiceModel.ClientBase<UnityContainer.IHubService>, UnityContainer.IHubService
    {

        public HubServiceClient()
        {
        }

        public HubServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public HubServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public HubServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public HubServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string RetrieveService(Common.DataContract.RetrieveRequest request)
        {
            return base.Channel.RetrieveService(request);
        }

        public System.Threading.Tasks.Task<string> RetrieveServiceAsync(Common.DataContract.RetrieveRequest request)
        {
            return base.Channel.RetrieveServiceAsync(request);
        }
    }
}
