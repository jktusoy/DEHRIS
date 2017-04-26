using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class Seminar
    {
        public long specialSkill_id { get; set; }
        public Nullable<long> personnel_id { get; set; }
        public string specialSkillDescription { get; set; }
        public Nullable<bool> isInactive { get; set; }
        public Nullable<System.DateTime> dateCreated { get; set; }
        public Nullable<long> region_id { get; set; }
        public Nullable<long> section_id { get; set; }
    }
}
