//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEHRISDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class workExperience
    {
        public long workExperience_id { get; set; }
        public Nullable<long> personnel_id { get; set; }
        public Nullable<System.DateTime> dateFrom { get; set; }
        public string dateTo { get; set; }
        public Nullable<long> region_id { get; set; }
        public Nullable<long> section_id { get; set; }
        public string serviceType { get; set; }
        public string serviceLength { get; set; }
        public string position { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<long> status_id { get; set; }
        public string companyname { get; set; }
        public string separationCause { get; set; }
        public string separationDate { get; set; }
        public string remarks { get; set; }
        public Nullable<bool> isInactive { get; set; }
        public Nullable<bool> isApproved { get; set; }
        public Nullable<long> rdetail_id { get; set; }
    }
}
