//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HubRequest
    {
        public int ID { get; set; }
        public string AgencyCode { get; set; }
        public Nullable<int> AgencyID { get; set; }
        public string FamilyName { get; set; }
        public Nullable<int> DOBOfYear { get; set; }
        public Nullable<int> SleepSeconds { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
    }
}
