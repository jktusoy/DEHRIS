using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class SpecialSkills
    {
        public long SpecialSkillID { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string SpecialSkillDescription { get; set; }
        public Nullable<bool> IsInactive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<long> RegionID { get; set; }
        public Nullable<long> SectionID { get; set; }
    }
}
