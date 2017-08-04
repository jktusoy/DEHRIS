using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class TransImportDetails
    {
        public long TransImportDetailsID { get; set; }
        public Nullable<long> TransImportID { get; set; }
        public Nullable<long> TemplateImportID { get; set; }
        public Nullable<long> TemplateImportDetailsID { get; set; }
        public string ColumnAddress { get; set; }
        public string Value { get; set; }
    }
}
