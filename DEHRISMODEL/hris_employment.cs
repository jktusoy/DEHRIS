//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEHRISMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class hris_employment
    {
        public long hris_employment_id { get; set; }
        public Nullable<System.DateTime> datefrom { get; set; }
        public Nullable<System.DateTime> dateto { get; set; }
        public string positiontitle { get; set; }
        public string departmentagency { get; set; }
        public Nullable<double> monthlysalary { get; set; }
        public string salarygrade { get; set; }
        public string stepincrement { get; set; }
        public string statusofappointment { get; set; }
        public Nullable<bool> isgovservice { get; set; }
        public long hris_personnel_id { get; set; }
    }
}
