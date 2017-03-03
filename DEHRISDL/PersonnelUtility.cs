using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEHRISMODEL;
namespace DEHRISDL
{
    class PersonnelUtility
    {

        public List<hris_personnel> GetPersonnel()
        {
            using (DEHRISEntities dbcontext = new DEHRISEntities())
            {
                List<hris_personnel> _personnelList = new List<hris_personnel>();
                _personnelList = dbcontext.hris_personnel.ToList();
                return _personnelList;
            }
        }

    }
}
