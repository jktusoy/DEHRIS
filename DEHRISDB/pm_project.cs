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
    
    public partial class pm_project
    {
        public long pm_projectid { get; set; }
        public string agency { get; set; }
        public string address { get; set; }
        public string projects { get; set; }
        public string location { get; set; }
        public Nullable<decimal> totalcost { get; set; }
        public Nullable<System.DateTime> datestarted { get; set; }
        public Nullable<int> noofextension { get; set; }
        public Nullable<System.DateTime> datetargetcompletion { get; set; }
        public Nullable<int> completion { get; set; }
        public Nullable<decimal> totalcostincurred { get; set; }
        public string remarks { get; set; }
    }
}
