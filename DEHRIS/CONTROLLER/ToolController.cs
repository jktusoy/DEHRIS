using DEHRISDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEHRIS.MODEL.Data;
namespace DEHRIS.CONTROLLER
{
    public class ToolController
    {
        public List<ToolTemplateCategory> GetToolTemplateCategoryList()
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {

                List<ToolTemplateCategory> ssList = (from item in dbcontext.type_ImportTemplateCategory
                                         select new ToolTemplateCategory()
                                         {
                                             createdBy = item.createdBy,
                                             dateCreated = item.dateCreated,
                                             dateLastUpdated = item.dateLastUpdated,
                                             description = item.description,
                                             isActive = item.isActive,
                                             parentID = item.parentID,
                                             title = item.title,
                                             type_ImportTemplateCategoryID = item.type_ImportTemplateCategoryID,
                                             updatedBy = item.updatedBy
                                         }).ToList();
                return ssList;
            }
        }


    }
}
