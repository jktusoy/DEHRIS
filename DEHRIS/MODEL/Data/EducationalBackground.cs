using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class EducationalBackground
    {
        public long EducationalBackgroundID { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string Level { get; set; }
        public string School { get; set; }
        public string DegreeEarned { get; set; }
        public string YearGraduated { get; set; }
        public string UnitsCompleted { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string HonorsReceived { get; set; }
        public Nullable<bool> IsInActive { get; set; }
        public Nullable<System.DateTime> Datetimestamp { get; set; }
        public Nullable<long> RegionID { get; set; }
        public Nullable<long> SectionID { get; set; }
    }
}
