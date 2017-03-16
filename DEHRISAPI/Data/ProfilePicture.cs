using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRISModel.Data
{
    public class ProfilePicture
    {

        public int ProfilePictureID { get; set; }
        public int PersonnelID { get; set; }
        public string FilePath { get; set; }
        public string ContentType { get; set; }
        public byte[] BinaryImage { get; set; }


      

    }
}
