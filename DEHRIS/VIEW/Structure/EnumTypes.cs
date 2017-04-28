using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEHRIS.VIEW.Structure
{
    public static class EnumTypes
    {
        public enum TransactionType {Add, Update, Refresh };
        public enum ViewType { ViewOnly, ViewAndManage };

        public enum LayoutType { ViewMainHorizontal, ManageMainHorizontal, ViewMainVertical, ManageMainVertical, FullLoad };
    }
}
