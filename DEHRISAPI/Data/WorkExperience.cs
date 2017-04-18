using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class WorkExperience
    {
        public long WorkExperienceID { get; set; }
        public Nullable<long> RegionID { get; set; }
        public Nullable<long> SectionID { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string ServiceType { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public string DateTo { get; set; }
        public string ServiceLength { get; set; }
        public string Position { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string CompanyName { get; set; }
        public string SeparationCause { get; set; }
        public string SeparationDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsInactive { get; set; }
        public bool? IsApproved { get; set; }
        public Nullable<long> RdetailID { get; set; }
    }
}
