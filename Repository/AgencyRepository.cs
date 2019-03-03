using Common.Model;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AgencyRepository : IAgencyRepository
    {
        public AgencyRegister GetAgencyByCode(string agencyCode)
        {
            return agencyRegisters.Where(x => x.AgencyCode.Equals(agencyCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        List<AgencyRegister> agencyRegisters = new List<AgencyRegister>()
        {
            new AgencyRegister()
            {
                ID=1,
                AgencyCode="AAA",
                ActionRetrieveAllowed=true
            },
             new AgencyRegister()
            {
                ID=2,
                AgencyCode="BBB",
                ActionRetrieveAllowed=true
            }
        };
    }
}
