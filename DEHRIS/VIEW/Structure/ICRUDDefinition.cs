using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.VIEW.Structure
{
    public interface ICRUDDefinition
    {


       void ViewItem(Object obj);

       void ClearItem();
       void AddItem();
       void UpdateItem(Object obj);
    }
}
