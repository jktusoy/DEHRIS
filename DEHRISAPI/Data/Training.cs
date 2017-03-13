using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class Training
    {

        public long TrainingID { get; set; }
        public long PersonnelID { get; set; }
        public Nullable<long> HeaderID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NoOfHours { get; set; }
        public string ConductedBy { get; set; }
        public Nullable<bool> IsInactive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsScholarship { get; set; }
        public Nullable<long> RegionID { get; set; }
        public Nullable<long> DivisionID { get; set; }
        public Nullable<long> TrainingModuleID { get; set; }
        public Nullable<long> CategoryID { get; set; }
    }
}
