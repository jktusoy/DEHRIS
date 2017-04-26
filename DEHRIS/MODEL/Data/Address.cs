using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEHRIS.MODEL.Enum;
namespace DEHRIS.MODEL.Data
{

  
    public class Address
    {

       public AddressType AddressType { get; set; }
       public string AddressName { get; set; }
       public string ZipCode { get; set; }
        
    }
}
