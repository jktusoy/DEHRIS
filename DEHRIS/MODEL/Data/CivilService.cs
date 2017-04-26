using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class CivilService
    {
        public long CivilServiceID { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string CivilServiceName { get; set; }
        public string Rate { get; set; }
        public string ExamDate { get; set; }
        public string PlaceConducted { get; set; }
        public string Civilservice_number { get; set; }
        public string ReleaseDate { get; set; }
        public Nullable<bool> IsInactive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<long> RegionID { get; set; }
        public Nullable<long> DistrictID { get; set; }
    }
}
