using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class Personnel
    {

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string NameExtension { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Civilstatus { get; set; }
        public string Citizenship { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bloodtype { get; set; }

        public Address ResidentialAddress { get; set; }
        public Address PermanenetAddress { get; set; }

        public Contact EmailAddress { get; set; }
        public Contact CellPhone { get; set; }
        public Contact TelePhone { get; set; }

        public ProfessionalProfile ProfessionalProfile { get; set; }
    
    }
}
