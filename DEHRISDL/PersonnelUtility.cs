using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEHRISModel.Data;
using DEHRISModel.Enum;
using DEHRISDB;

namespace DEHRISAPI
{
   public class PersonnelUtility
    {

       public List<Personnel> GetPersonnel()
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {
                  //var query = from pro in dbcontext.hris_personnel
                  //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
                List<Personnel> personnelList = (from item in dbcontext.hris_personnel select new Personnel(){
                 Lastname = item.lastname,
                 Firstname = item.firstname,
                 Middlename = item.middlename,
                 NameExtension = item.nameextension,
                 PersonnelID = item.hris_personnel_id,
                 Bloodtype = item.bloodtype,
                 DateOfBirth = item.dateofbirth == null ? DateTime.Now : (DateTime)item.dateofbirth,
                 Civilstatus = item.civilstatus,
                 BirthPlace = item.placeofbirth,
                 Citizenship = item.citizenship,
                 CellPhone = new Contact(){ ContactDetails = item.cellphoneno, ContacType = DEHRISModel.Enum.ContactType.CellPhone},
                 Height = item.height,
                 Sex = item.sex,
                 Weight = item.weight,
                 EmailAddress = new Contact(){ ContactDetails = item.cellphoneno, ContacType =ContactType.EmailAddress},
                 PermanenetAddress = new Address(){ AddressName = item.permanentaddress, ZipCode= item.permanentzipcode,  AddressType = AddressType.Permanent},
                 ResidentialAddress = new Address(){ AddressName = item.cellphoneno, ZipCode = item.residentialzipcode, AddressType = DEHRISModel.Enum.AddressType.Residential},
                 ProfessionalProfile = new ProfessionalProfile(){ EmployeeNumber = item.agencyemployeeno, GSISNumber = item.gsis_no, PAGIBIGNumber = item.pagibig_no, SSSNumber = item.sss_no, TINNumber = item.tin_no}
                }).ToList();
                return personnelList;
            }
        }


       public  ProfilePicture GetPersonnelProfilePic(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               ProfilePicture image = (from item in dbcontext.profilepictures.Where(a => a.personnel_id == ppersonnel_id)
                                       select new ProfilePicture()
                                                {
                                                      BinaryImage = item.binaryImage,
                                                      FilePath = item.filepath,
                                                      ProfilePictureID = (int)item.profilepicture_id,
                                                      ContentType = item.contentType
                                                }).FirstOrDefault();
               return image;
           }
       }


       public List<CivilService> GetCivilServiceListByPersonnelID(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<CivilService> civilList = (from item in dbcontext.civilservices.Where(a => a.personnel_id == ppersonnel_id)
                                       select new CivilService()
                                       {
                                           Civilservice_number = item.civilservice_number,
                                           CivilServiceID = item.civilservice_id,
                                           CivilServiceName = item.civilservicename,
                                           DateCreated = item.dateCreated,
                                           DistrictID = item.district_id,
                                           ExamDate = item.examdate,
                                           IsInactive = item.isInactive,
                                           PersonnelID = item.personnel_id,
                                           PlaceConducted = item.placeconducted,
                                           Rate = item.rate,
                                           RegionID = item.region_id,
                                           ReleaseDate = item.releasedate
                                       }).ToList();
               return civilList;
           }
       }


       public List<EducationalBackground> GetEducationalBackgroundListByPersonnelID(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<EducationalBackground> educList = (from item in dbcontext.educationalBackgrounds.Where(a => a.personnel_id == ppersonnel_id)
                                                        select new EducationalBackground()
                                               {
                                                   DateFrom= item.dateFrom,
                                                   Datetimestamp = item.datetimestamp,
                                                   DateTo = item.dateTo,
                                                   DegreeEarned = item.degreeEarned,
                                                   EducationalBackgroundID = item.educationalBackground_id,
                                                   HonorsReceived = item.honorsReceived,
                                                   IsInActive = item.isInActive,
                                                   Level = item.level,
                                                   PersonnelID = item.personnel_id,
                                                   RegionID = item.region_id,
                                                   School = item.school,
                                                   SectionID = item.section_id,
                                                   UnitsCompleted = item.unitsCompleted,
                                                   YearGraduated = item.yearGraduated
                                                  
                                               }).ToList();
               return educList;
           }
       }


       public List<SpecialSkills> GetSpecialSkillsListByPersonnelID(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //List<seminar> 
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<SpecialSkills> ssList = (from item in dbcontext.specialSkills.Where(a => a.personnel_id == ppersonnel_id)
                                             select new SpecialSkills()
                                                       {
                                                          DateCreated = item.dateCreated,
                                                          IsInactive = item.isInactive,
                                                          PersonnelID = item.personnel_id,
                                                          RegionID = item.region_id,
                                                          SectionID = item.section_id,
                                                          SpecialSkillDescription = item.specialSkillDescription,
                                                          SpecialSkillID = item.specialSkill_id
                                                       }).ToList();
               return ssList;
           }
       }


       public List<Training> GetSeminarListByPersonnelID(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
              
               //List<seminar> 
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<Training> ssList = (from item in dbcontext.trainings.Where(a => a.personnel_id == ppersonnel_id)
                                             select new Training()
                                             {
                                                 CategoryID = item.category_id,
                                                 ConductedBy = item.conductedBy,
                                                 DateCreated = item.dateCreated,
                                                 DivisionID = item.division_id,
                                                 EndDate = (DateTime)item.dateTo,
                                                 HeaderID = item.header_id,
                                                 IsInactive = item.isInactive,
                                                 IsScholarship = item.isScholarship,
                                                 NoOfHours = item.noOfHours.ToString(),
                                                 PersonnelID = (long)item.personnel_id,
                                                 RegionID = item.region_id,
                                                 StartDate = (DateTime)item.dateFrom,
                                                 Title= item.title,
                                                 TrainingID= item.training_id,
                                                 TrainingModuleID = item.trainingModule_id                                               
                                             }).ToList();
               return ssList;
           }
       }



       public List<WorkExperience> GetWorkExperienceListByPersonnelID(int ppersonnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //List<seminar> 
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<WorkExperience> ssList = (from item in dbcontext.workExperiences.Where(a => a.personnel_id == ppersonnel_id)
                                              select new WorkExperience()
                                             {
                                                 CompanyName = item.companyname,
                                                 DateFrom = item.dateFrom,
                                                 DateTo = item.dateTo,
                                                 IsApproved = item.isApproved,
                                                 IsInactive = item.isInactive,
                                                 PersonnelID = item.personnel_id,
                                                 Position = item.position,
                                                 RdetailID = item.rdetail_id,
                                                 RegionID = item.region_id,
                                                 Remarks = item.remarks,
                                                 Salary = item.salary,
                                                 SectionID = item.section_id,
                                                 SeparationCause = item.separationCause,
                                                 SeparationDate = item.separationDate,
                                                 ServiceLength = item.serviceLength,
                                                 ServiceType = item.serviceType,
                                                 StatusID = (int)item.status_id,
                                                 WorkExperienceID = item.workExperience_id
                                             }).ToList();
               return ssList;
           }
       }


    }
}
