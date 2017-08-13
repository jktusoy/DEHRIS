
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
       bool AddItem();

       List<object> ListItem();
       bool UpdateItem(Object obj);
       bool EditItem(Object obj);

       bool DeleteItem(Object obj);
       void UpdateTitle(EnumTypes.TransactionType transtype);
       EnumTypes.TransactionType TransactionType
       {
           get;
           set;
       }

       void DelegateAssign(SimpleDelegate basicdel);
       
     

    }
}
