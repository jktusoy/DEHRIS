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
    
    public partial class ais_cdtransaction
    {
        public long ais_cdtransaction_id { get; set; }
        public Nullable<System.DateTime> dateofcheck { get; set; }
        public Nullable<decimal> cashadvanceamount { get; set; }
        public Nullable<long> financialyear_id { get; set; }
        public string sourceoffunds { get; set; }
        public string particulars { get; set; }
        public Nullable<decimal> totalamount { get; set; }
        public Nullable<decimal> balanceunliquidated { get; set; }
    }
}