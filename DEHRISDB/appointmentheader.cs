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
    
    public partial class appointmentheader
    {
        public long header_id { get; set; }
        public Nullable<System.DateTime> datesigned { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public Nullable<long> region_id { get; set; }
        public Nullable<long> district_id { get; set; }
        public Nullable<System.DateTime> datecreated { get; set; }
        public string headeridtemp { get; set; }
    }
}
