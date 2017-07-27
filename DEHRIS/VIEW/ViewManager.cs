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
        private EnumTypes.LayoutType layoutType = EnumTypes.LayoutType.FullLoad;


        public string Title { get; set; }

        public EnumTypes.LayoutType LayoutOrientation
        {
            get { return layoutType; }
            set { layoutType = value; }
        }


        public ViewManager()
        {
            InitializeComponent();
            DefaultControl();
            Generator.GenerateColumns(this.objlViewMgr, Type.GetType("DEHRIS.MODEL.Data.Training"), true);
            lblViewMgrlHeader.Text = Title;
            pnlViewMgrContent.Controls.Clear();
            pnlViewMgrContent.Controls.Add((UserControl)mUsercontrol);
            viewType = EnumTypes.ViewType.ViewAndManage;
        }



        public ViewManager(ICRUDDefinition uccont)
        {
            InitializeComponent();
            DefaultControl();
         

            Generator.GenerateColumns(this.objlViewMgr, Type.GetType("DEHRIS.MODEL.Data.Training"), true);
            lblViewMgrlHeader.Text = Title;
            objlViewMgr.SetObjects(uccont.ListItem());
            
            pnlViewMgrContent.Controls.Clear();
 
            mUsercontrol = uccont;
            pnlViewMgrContent.Controls.Add((UserControl)mUsercontrol);
            viewType = EnumTypes.ViewType.ViewAndManage;
        }

        public void UpdateLayout()
        {

            switch (layoutType)
            {
                case EnumTypes.LayoutType.ViewMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Horizontal;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.ViewMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.FullLoad:
                    tbsViewMgr.Collapsed = true;
                    break;
                default:
                    break;
            }
        
        }

        public void UpdateLayout(EnumTypes.LayoutType _layoutType)
        {

            switch (_layoutType)
            {
                case EnumTypes.LayoutType.ViewMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Horizontal;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.ViewMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.FullLoad:
                    tbsViewMgr.Collapsed = true;
                    break;
                default:
                    break;
            }

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

      


        #region COMMON FUNCTION
        public void Edit(bool enabled)
        {

         

            if (viewType == EnumTypes.ViewType.ViewAndManage)
            {
                object objectv = objlViewMgr.SelectedObject;

                if (objectv == null)
                    return;
                mUsercontrol.ViewItem(objectv, enabled);

                if (tbsViewMgr.Collapsed == true)
                {
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.Swapped = false;
                    tbsViewMgr.Collapsed = true;
                }

            }
        }

        public void Add()
        {
            transType = mUsercontrol.TransactionType = EnumTypes.TransactionType.Add;
            mUsercontrol.UpdateTitle(transType);

            briEdit.Enabled = false;
            briAdd.Enabled = false;
            briDelete.Enabled = false;
            briSave.Enabled = true;
            briCancel.Enabled = true;

            if (tbsViewMgr.Collapsed == true)
            {
                tbsViewMgr.Collapsed = false;
                tbsViewMgr.Swapped = false;
                tbsViewMgr.Collapsed = true;
            }

            mUsercontrol.ClearItem();


        
        
        
        }

        public void DefaultControl()
        {

            briEdit.Enabled = true;
            briAdd.Enabled = true;
            briDelete.Enabled = true;
            briSave.Enabled = false;
            briCancel.Enabled = false;
        }


        #endregion 

        #region EVENTS
        private void briAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void objlViewMgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            mUsercontrol.TransactionType = transType = EnumTypes.TransactionType.Refresh;
            mUsercontrol.UpdateTitle(transType);

            Edit(false);
            DefaultControl();
        }
        private void briSave_Click(object sender, EventArgs e)
        {
            
            switch (transType)
            {
                case EnumTypes.TransactionType.Add:
                    mUsercontrol.AddItem();
                    break;
                case EnumTypes.TransactionType.Update:
                    object objectv = objlViewMgr.SelectedObject;
                    mUsercontrol.UpdateItem(objectv);
                    break;

            }

            briEdit.Enabled = true;
            briAdd.Enabled = true;
            briDelete.Enabled = true;
            briSave.Enabled = false;
            briCancel.Enabled = false;

            objlViewMgr.SetObjects(mUsercontrol.ListItem());
        }
      
        private void briDelete_Click(object sender, EventArgs e)
        {
            transType = EnumTypes.TransactionType.Refresh;
        }

        private void briRefresh_Click(object sender, EventArgs e)
        {
            DefaultControl();

            transType = EnumTypes.TransactionType.Refresh;
            objlViewMgr.SetObjects(mUsercontrol.ListItem());
        }


        private void briEdit_Click_1(object sender, EventArgs e)
        {
            transType = mUsercontrol.TransactionType = EnumTypes.TransactionType.Update;
            mUsercontrol.UpdateTitle(transType);


            briEdit.Enabled = false;
            briAdd.Enabled = false;
            briDelete.Enabled = false;
            briSave.Enabled = true;
            briCancel.Enabled = true;

            object objectv = objlViewMgr.SelectedObject;

            if (objectv == null)
                return;
            mUsercontrol.EditItem(objectv);

            Edit(true);
        }

        private void briCancel_Click(object sender, EventArgs e)
        {
            DefaultControl();
        }

#endregion

    }
}
