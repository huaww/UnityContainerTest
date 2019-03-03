using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataContract
{
    [DataContract]
    public class RetrieveRequest
    {
        [DataMember]
        public string AgencyCode { get; set; }

        [DataMember]
        public string FamilyName { get; set; }

        [DataMember]
        public int DOBOfYear { get; set; }

        [DataMember]
        public int SleepSeconds { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }
    }
}
