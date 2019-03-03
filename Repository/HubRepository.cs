using Common.DataContract;
using Common.Model;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class HubRepository : IHubRepository
    {
        public void SaveHubRequest(HubRequest request)
        {
            using (UnityContainerEntities context = new UnityContainerEntities())
            {
                context.HubRequests.Add(request);
                request.CreatedDateTime = DateTime.Now;
                context.SaveChanges();
            }
        }

        
    }
}
