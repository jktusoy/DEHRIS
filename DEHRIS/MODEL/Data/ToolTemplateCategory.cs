using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.MODEL.Data
{
    public class ToolTemplateCategory
    {
        public long type_ImportTemplateCategoryID { get; set; }
        public Nullable<long> parentID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<long> updatedBy { get; set; }
        public Nullable<System.DateTime> dateLastUpdated { get; set; }
        public Nullable<System.DateTime> dateCreated { get; set; }
    }
}
