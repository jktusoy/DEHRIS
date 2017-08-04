using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class TemplateImportDetails
    {
        public long TemplateImportDetailsID { get; set; }
        public Nullable<long> TemplateImportID { get; set; }
        public string Columnname { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
