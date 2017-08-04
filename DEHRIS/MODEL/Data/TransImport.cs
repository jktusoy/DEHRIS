using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class TransImport
    {
        public long TransImportID { get; set; }
        public Nullable<long> TemplateImportID { get; set; }
        public Nullable<System.DateTime> DateImported { get; set; }
        public Nullable<long> ImportBy { get; set; }
        List<TransImportDetails> TransImportDetails { get; set; }
    }
}
