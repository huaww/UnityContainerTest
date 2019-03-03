using Common.DataContract;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IHubRepository
    {
        void SaveHubRequest(HubRequest request);
    }
}
