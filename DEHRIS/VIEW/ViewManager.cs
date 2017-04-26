using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Syncfusion.Windows.Forms.Tools;
using DEHRIS.CONTROLLER.Structure;
using BrightIdeasSoftware;
using DEHRIS.MODEL.Data;
using DEHRIS.VIEW.Structure;
 
namespace DEHRIS.VIEW
{
    public partial class ViewManager : UserControl
    {
        private ICRUDDefinition mUsercontrol;




        private EnumTypes.ViewType viewType = EnumTypes.ViewType.ViewOnly;
        private EnumTypes.TransactionType transType = EnumTypes.TransactionType.Refresh;
        private IController<object> instanceController;
        private List<Object> objList;
    

        public string Title { get; set; }


        //Type myType = Type.GetType("MyNamespace.MyType");
   


        public ViewManager(List<object> objl, ICRUDDefinition uccont)
        {
            
           
            InitializeComponent();

   
           
            Generator.GenerateColumns(this.objlViewMgr, Type.GetType("DEHRIS.MODEL.Data.Training"), true);
            lblViewMgrlHeader.Text = Title;
            objlViewMgr.SetObjects(objl);

            pnlViewMgrContent.Controls.Clear();
 
            mUsercontrol = uccont;
            pnlViewMgrContent.Controls.Add((UserControl)mUsercontrol);

            viewType = EnumTypes.ViewType.ViewAndManage;
           

          // //   instanceController = controller;
        }


        public void ImplementViewType()
        {
            if (viewType == EnumTypes.ViewType.ViewOnly)
            {
                foreach (TabSplitterPage item in tbsViewMgr.SecondaryPages)
                {
                    item.Hide = true;
                }
            }

        }




        private void xpTaskBarBox2_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {

        }

        private void briAdd_Click(object sender, EventArgs e)
        {
            transType = EnumTypes.TransactionType.Add;
            if (tbsViewMgr.Collapsed == true)
            {
                tbsViewMgr.Collapsed = false;
                tbsViewMgr.Swapped = false;
                tbsViewMgr.Collapsed = true;
            }

            mUsercontrol.ClearItem();


        }

        private void objlViewMgr_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (viewType == EnumTypes.ViewType.ViewAndManage)
            {
                object objectv = objlViewMgr.SelectedObject;

                if (objectv == null)
                    return;
                mUsercontrol.ViewItem(objectv);

                if (tbsViewMgr.Collapsed == true)
                {
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.Swapped = false;
                    tbsViewMgr.Collapsed = true;
                }

            }

        }

        private void briSave_Click(object sender, EventArgs e)
        {
            switch (transType){
                case EnumTypes.TransactionType.Add:
                     mUsercontrol.AddItem();
                     break;
                case EnumTypes.TransactionType.Update:
                     object objectv = objlViewMgr.SelectedObject;
                     mUsercontrol.UpdateItem(objectv);
                     break;

            }

            transType = EnumTypes.TransactionType.Refresh;
        }

        private void briEdit_Click(object sender, EventArgs e)
        {
            transType = EnumTypes.TransactionType.Update;
        }

        private void briDelete_Click(object sender, EventArgs e)
        {
            transType = EnumTypes.TransactionType.Refresh;
        }

        private void briRefresh_Click(object sender, EventArgs e)
        {
            transType = EnumTypes.TransactionType.Refresh;
        }



    }
}
