using DEHRISDB;
using DEHRISModel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISAPI
{
    public class PerformanceManagementUtility
    {

        public List<Training> GetSeminarListByPersonnelID(int ppersonnel_id)
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {

                //List<seminar> 
                //var query = from pro in dbcontext.hris_personnel
                //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
                List<Training> ssList = (from item in dbcontext.trainings.Where(a => a.personnelID == ppersonnel_id)
                                         select new Training()
                                         {
                                             ConductedBy = item.conductedBy,
                                             IsActive = item.isActive,
                                             PersonnelID = (long)item.personnelID,
                                             Title = item.title,
                                             DateFrom = item.dateFrom,
                                             DateTo = item.dateTo,
                                             Duration = item.duration,
                                             Method = item.method,
                                             Remarks = item.remarks,
                                             TrainingID = item.trainingID,
                                             Type = item.type
                                         }).ToList();
                return ssList;
            }
        }


        public List<Training> GetSeminarList()
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {

               
                List<Training> ssList = (from item in dbcontext.trainings  select new Training()
                                         {
                                             ConductedBy = item.conductedBy,
                                             IsActive = item.isActive,
                                             IsMandatory = item.isMandatory,
                                             PersonnelID = (long)item.personnelID,
                                             Title = item.title,
                                             DateFrom = item.dateFrom,
                                             DateTo = item.dateTo,
                                             Duration = item.duration,
                                             Method = item.method,
                                             Remarks = item.remarks,
                                             TrainingID = item.trainingID,
                                             Type = item.type,
                                         }).ToList();
                return ssList;
            }
        }




        public bool Add(Training trnItem)
        {
            try
            {
                using (DEHRISEntities dbcontext = new DEHRISEntities())
                {

                    training trn = new training()
                    {
                        conductedBy = trnItem.ConductedBy,
                        dateFrom = trnItem.DateFrom,
                        dateTo = trnItem.DateTo,
                        isActive = trnItem.IsActive,
                        duration = trnItem.Duration,
                        isMandatory = trnItem.IsMandatory,
                        method = trnItem.Method,
                        remarks = trnItem.Remarks,
                        title = trnItem.Title,
                        type = trnItem.Type
                    };
                    dbcontext.trainings.Add(trn);
                    dbcontext.SaveChanges();
                    return true;
                }
               
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Update(Training trnItem)
        {
            try
            {
                using (DEHRISEntities dbcontext = new DEHRISEntities())
                {

                    var result = dbcontext.trainings.SingleOrDefault(b => b.trainingID == trnItem.TrainingID);
                    if (result != null)
                    {
                         result.dateFrom = trnItem.DateFrom;
                         result.dateTo = trnItem.DateTo;
                         result.isActive = trnItem.IsActive;
                         result.duration = trnItem.Duration;
                         result.isMandatory = trnItem.IsMandatory;
                         result.method = trnItem.Method;
                         result.remarks = trnItem.Remarks;
                         result.title = trnItem.Title;
                         result.type = trnItem.Type;
                         result.trainingID = trnItem.TrainingID;
                    }
                   
                    dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
