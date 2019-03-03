using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAgencyRepository
    {
        AgencyRegister GetAgencyByCode(string agencyCode);
    }
}
