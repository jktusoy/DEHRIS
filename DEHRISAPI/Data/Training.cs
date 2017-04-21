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
        public string Title { get; set; }
        public Nullable<int> Duration { get; set; }
        public string ConductedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<DateTime> DateFrom { get; set; }
        public Nullable<DateTime> DateTo { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public string Method { get; set; }
        public bool? IsMandatory { get; set; }
        public string Schedule { get; set; }
        public string TranslatedDuration { get; set; }
    }
}
