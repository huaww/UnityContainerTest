using Common.DataContract;
using Common.Model;
using Interface;

namespace BLL
{
    public class HubBusiness : IHubBusiness
    {
        private readonly IHubRepository hubRepository;
        private readonly IAgencyRepository agencyRepository;
        private AgencyRegister agencyRegister;

        public HubBusiness(
            IHubRepository hubRepository,
            IAgencyRepository agencyRepository)
        {
            this.hubRepository = hubRepository;
            this.agencyRepository = agencyRepository;
        }

        public void Process(RetrieveRequest request)
        {
            this.agencyRegister = this.agencyRepository.GetAgencyByCode(request.AgencyCode);
            //AgencyRegister agencyRegister = this.agencyRepository.GetAgencyByCode(request.AgencyCode);
            System.Threading.Thread.Sleep(request.SleepSeconds * 1000);
            HubRequest hubRequest = this.MapToHubRequest(request, agencyRegister.ID);
            this.hubRepository.SaveHubRequest(hubRequest);
        }

        private HubRequest MapToHubRequest(RetrieveRequest request, int? agencyID = null)
        {
            HubRequest hubRequest = new HubRequest()
            {
                AgencyCode = request.AgencyCode,
                DOBOfYear = request.DOBOfYear,
                FamilyName = request.FamilyName,
                TimeStamp = request.TimeStamp,
                SleepSeconds = request.SleepSeconds,
                //AgencyID = agencyID
                AgencyID = this.agencyRegister.ID
            };
            return hubRequest;
        }
    }
}
