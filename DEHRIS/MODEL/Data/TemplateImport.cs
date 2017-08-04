using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class TemplateImport
    {
        public long TemplateImportID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }

        public List<TemplateImportDetails> TemplateImportDetails { get; set; }
    }
}
