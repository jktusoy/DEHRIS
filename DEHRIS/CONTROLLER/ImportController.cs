using DEHRIS.CONTROLLER.Structure;
using DEHRISDB;
using DEHRIS.MODEL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DEHRIS.CONTROLLER
{
    public class ImportController : IController<TemplateImport>
    {


        public TemplateImport GetTemplateImport(int tempateID)
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {

                List<TemplateImportDetails> details = (from itemdet in dbcontext.templateImportDetails.Where(a=>a.templateImportID == tempateID)
                                         select new TemplateImportDetails()
                                         {
                                             Address = itemdet.Address,
                                             Columnname = itemdet.columnname,
                                             TemplateImportDetailsID = itemdet.templateImportDetailsID,
                                             TemplateImportID = itemdet.templateImportID
                                         }).ToList();


               
                  TemplateImport  ssList = (from item in dbcontext.templateImports.Where(x=>x.templateImportID == tempateID)
                                         select new TemplateImport()
                                         {
                                            Description = item.description,
                                            Title  = item.title,
                                            TemplateImportID = item.templateImportID
                                         }).FirstOrDefault();
                  ssList.TemplateImportDetails = details;
             
                return ssList;
            }
        }

        public List<TemplateImport>  GetList()
        {
            return new List<TemplateImport>();
            
        }

        public bool Add(TemplateImport template)
        {
            return false;
        }

        public bool Update(TemplateImport trnItem)
        {
            return true;
        }

        public bool Delete(TemplateImport trnItem)
        {
            return true;
        }


    }
}
