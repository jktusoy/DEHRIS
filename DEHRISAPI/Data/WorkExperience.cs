using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class WorkExperience
    {
        public long workExperience_id { get; set; }
        public Nullable<long> region_id { get; set; }
        public Nullable<long> section_id { get; set; }
        public Nullable<long> personnel_id { get; set; }
        public Nullable<int> serviceType { get; set; }
        public Nullable<System.DateTime> dateFrom { get; set; }
        public string dateTo { get; set; }
        public string serviceLength { get; set; }
        public string position { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<int> status_id { get; set; }
        public string companyname { get; set; }
        public string separationCause { get; set; }
        public string separationDate { get; set; }
        public string remarks { get; set; }
        public Nullable<bool> isInactive { get; set; }
        public Nullable<int> isApproved { get; set; }
        public Nullable<long> rdetail_id { get; set; }
    }
}
