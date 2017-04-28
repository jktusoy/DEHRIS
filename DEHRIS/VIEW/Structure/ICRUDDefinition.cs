
using DEHRIS.VIEW.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.VIEW.Structure
{
    public interface ICRUDDefinition
    {


       void ViewItem(Object obj, bool enabled);

       void ClearItem();
       void AddItem();

       List<object> ListItem();
       void UpdateItem(Object obj);
       void EditItem(Object obj);
       void UpdateTitle();
       EnumTypes.TransactionType TransactionType
       {
           get;
           set;
       }
     

    }
}
