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
                 Bloodtype = item.bloodtype,
                 DateOfBirth = item.dateofbirth == null ? DateTime.Now : (DateTime)item.dateofbirth,
                 Civilstatus = item.civilstatus,
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


       public List<Personnel> GetPersonnelProfilePic(int personnel_id)
       {
           using (DEHRISEntities dbcontext = new DEHRISEntities())
           {
               //var query = from pro in dbcontext.hris_personnel
               //  select new ProjectInfo(){ Name = pro.ProjectName, Id = pro.ProjectId };
               List<Personnel> personnelList = (from item in dbcontext.hris_personnel
                                                select new Personnel()
                                                {
                                                    Lastname = item.lastname,
                                                    Firstname = item.firstname,
                                                    Middlename = item.middlename,
                                                    NameExtension = item.nameextension,
                                                    Bloodtype = item.bloodtype,
                                                    DateOfBirth = item.dateofbirth == null ? DateTime.Now : (DateTime)item.dateofbirth,
                                                    Civilstatus = item.civilstatus,
                                                    Citizenship = item.citizenship,
                                                    CellPhone = new Contact() { ContactDetails = item.cellphoneno, ContacType = DEHRISModel.Enum.ContactType.CellPhone },
                                                    Height = item.height,
                                                    Sex = item.sex,
                                                    Weight = item.weight,
                                                    EmailAddress = new Contact() { ContactDetails = item.cellphoneno, ContacType = ContactType.EmailAddress },
                                                    PermanenetAddress = new Address() { AddressName = item.permanentaddress, ZipCode = item.permanentzipcode, AddressType = AddressType.Permanent },
                                                    ResidentialAddress = new Address() { AddressName = item.cellphoneno, ZipCode = item.residentialzipcode, AddressType = DEHRISModel.Enum.AddressType.Residential },
                                                    ProfessionalProfile = new ProfessionalProfile() { EmployeeNumber = item.agencyemployeeno, GSISNumber = item.gsis_no, PAGIBIGNumber = item.pagibig_no, SSSNumber = item.sss_no, TINNumber = item.tin_no }
                                                }).ToList();
               return personnelList;
           }
       }

    }
}
